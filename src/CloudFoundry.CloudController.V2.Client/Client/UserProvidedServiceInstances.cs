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
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class UserProvidedServiceInstancesEndpoint : BaseEndpoint
    {
        public UserProvidedServiceInstancesEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }

        /// <summary>
        /// Creating a User Provided Service Instance
        /// </summary>
        public async Task<CreateUserProvidedServiceInstanceResponse> CreateUserProvidedServiceInstance(CreateUserProvidedServiceInstanceRequest value)
        {
            string route = "/v2/user_provided_service_instances";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateUserProvidedServiceInstanceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular User Provided Service Instance
        /// </summary>
        public async Task DeleteUserProvidedServiceInstance(Guid? guid)
        {
            string route = string.Format("/v2/user_provided_service_instances/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List all Service Bindings for the User Provided Service Instance
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsForUserProvidedServiceInstanceResponse>> ListAllServiceBindingsForUserProvidedServiceInstance(Guid? guid)
        {
            return await ListAllServiceBindingsForUserProvidedServiceInstance(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllServiceBindingsForUserProvidedServiceInstanceResponse>> ListAllServiceBindingsForUserProvidedServiceInstance(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/user_provided_service_instances/{0}/service_bindings", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceBindingsForUserProvidedServiceInstanceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular User Provided Service Instance
        /// </summary>
        public async Task<RetrieveUserProvidedServiceInstanceResponse> RetrieveUserProvidedServiceInstance(Guid? guid)
        {
            string route = string.Format("/v2/user_provided_service_instances/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveUserProvidedServiceInstanceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Updating a User Provided Service Instance
        /// </summary>
        public async Task<UpdateUserProvidedServiceInstanceResponse> UpdateUserProvidedServiceInstance(Guid? guid, UpdateUserProvidedServiceInstanceRequest value)
        {
            string route = string.Format("/v2/user_provided_service_instances/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateUserProvidedServiceInstanceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all User Provided Service Instances
        /// </summary>
        public async Task<PagedResponseCollection<ListAllUserProvidedServiceInstancesResponse>> ListAllUserProvidedServiceInstances()
        {
            return await ListAllUserProvidedServiceInstances(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllUserProvidedServiceInstancesResponse>> ListAllUserProvidedServiceInstances(RequestOptions options)
        {
            string route = "/v2/user_provided_service_instances";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllUserProvidedServiceInstancesResponse>(await response.ReadContentAsStringAsync());
        }
    }
}