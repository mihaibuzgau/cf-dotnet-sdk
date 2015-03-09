//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace CloudFoundry.CloudController.V2.Client
{
    /// <summary>
    /// Files Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class FilesEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractFilesEndpoint
    {
        internal FilesEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }    
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{

    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractFilesEndpoint : BaseEndpoint
    {

        /// <summary>
        /// Retrieve File
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/files/retrieve_file.html"</para>
        /// </summary>
        public async Task RetrieveFile(Guid? app_guid, int? instance_index, dynamic file_path)
        {
            string route = string.Format("/v2/apps/{0}/instances/{1}/files/{2}", app_guid, instance_index, file_path);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 302;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }
    }
}