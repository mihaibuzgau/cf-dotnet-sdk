﻿using CloudFoundry.CloudController.Common.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace CloudFoundry.Common.Http
{
    public class HttpAbstractionClient : IDisposable, IHttpAbstractionClient
    {
        private readonly HttpClientHandler handler = null;
        private readonly HttpClient client = null;
        private bool disposed = false;
        private CancellationToken cancellationToken = CancellationToken.None;
        private static readonly TimeSpan defaultTimeout = new TimeSpan(0, 0, 30);

        internal HttpAbstractionClient(TimeSpan timeout, CancellationToken cancellationToken)
        {
            try
            {
                this.handler = new HttpClientHandler();
                this.client = new HttpClient(this.handler);
                this.client.Timeout = timeout;

                this.cancellationToken = cancellationToken;
                this.Method = HttpMethod.Get;
                this.Headers = new Dictionary<string, string>();
                this.ContentType = string.Empty;
            }
            catch
            {
                if (this.handler != null)
                {
                    this.handler.Dispose();
                }

                if (this.client != null)
                {
                    this.client.Dispose();
                }

                throw;
            }
        }

        public static IHttpAbstractionClient Create()
        {
            return new HttpAbstractionClient(defaultTimeout, CancellationToken.None);
        }

        public static IHttpAbstractionClient Create(TimeSpan timeout)
        {
            return new HttpAbstractionClient(timeout, CancellationToken.None);
        }

        public static IHttpAbstractionClient Create(CancellationToken cancellationToken)
        {
            return new HttpAbstractionClient(defaultTimeout, cancellationToken);
        }

        public static IHttpAbstractionClient Create(CancellationToken cancellationToken, TimeSpan timeout)
        {
            return new HttpAbstractionClient(timeout, cancellationToken);
        }

        public HttpMethod Method { get; set; }

        public Uri Uri { get; set; }

        public Stream Content { get; set; }

        public IDictionary<string, string> Headers { get; private set; }

        public string ContentType { get; set; }

        public TimeSpan Timeout { get; set; }

        public async Task<IHttpResponseAbstraction> SendAsync()
        {
            HttpContent httpContent = null;
            if (this.Content != null)
            {
                httpContent = new StreamContent(this.Content);
            }
            return await this.SendAsync(httpContent);
        }

        public async Task<IHttpResponseAbstraction> SendAsync(IEnumerable<IHttpMultipartFormDataAbstraction> multipartData)
        {
            var httpContent = new MultipartFormDataContent();
            foreach (var field in multipartData)
            {
                var content = new StreamContent(field.Content);
                if (!string.IsNullOrEmpty(field.ContentType))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue(field.ContentType);
                }

                if (string.IsNullOrEmpty(field.FileName))
                {
                    httpContent.Add(content, field.Name);
                }
                else
                {
                    httpContent.Add(content, field.Name, field.FileName);
                }
            }

            return await this.SendAsync(httpContent);
        }

        internal async Task<IHttpResponseAbstraction> SendAsync(HttpContent requestContent)
        {
            var requestMessage = new HttpRequestMessage { Method = this.Method, RequestUri = this.Uri };

            if (this.Method == HttpMethod.Post || this.Method == HttpMethod.Put)
            {
                if (requestContent != null)
                {
                    requestMessage.Content = requestContent;
                }
            }

            requestMessage.Headers.Clear();
            foreach (var header in this.Headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            var startTime = DateTime.Now;

            try
            {
                var result = await this.client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead, this.cancellationToken).ConfigureAwait(false);

                var headers = new HttpHeadersCollection(result.Headers);

                HttpContent content = null;
                if (result.Content != null)
                {
                    headers.AddRange(result.Content.Headers);

                    content = result.Content;
                }

                var retval = new HttpResponseAbstraction(content, headers, result.StatusCode);

                return retval;
            }
            catch (Exception ex)
            {
                var tcex = ex as TaskCanceledException;
                if (tcex == null)
                {
                    throw;
                }

                if (this.cancellationToken.IsCancellationRequested)
                {
                    throw new OperationCanceledException("The operation was canceled by user request.", tcex, this.cancellationToken);
                }

                if (DateTime.Now - startTime > this.Timeout)
                {
                    throw new TimeoutException(string.Format(CultureInfo.InvariantCulture, "The task failed to complete in the given timeout period ({0}).", this.Timeout));
                }

                throw;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~HttpAbstractionClient()
        {
            this.Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            this.handler.Dispose();
            this.client.Dispose();

            this.disposed = true;
        }
    }
}