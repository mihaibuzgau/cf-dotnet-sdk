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

using CloudFoundry.CloudController.V2.Client.Data;
using CloudFoundry.CloudController.V2.Interfaces;
using CloudFoundry.Common;
using CloudFoundry.Common.ServiceLocation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    public class ServicePlanVisibilitiesEndpoint: BaseEndpoint
    {
        public ServicePlanVisibilitiesEndpoint(CloudfoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }
    
        /// <summary>
        /// Creating a Service Plan Visibility
        /// </summary>
    

    
        public async Task<CreateServicePlanVisibilityResponse> CreateServicePlanVisibility(CreateServicePlanVisibilityRequest value)
    
        {
            string route = "/v2/service_plan_visibilities";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
        
            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<CreateServicePlanVisibilityResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Retrieve a Particular Service Plan Visibility
        /// </summary>
    
        
    

    
        public async Task<RetrieveServicePlanVisibilityResponse> RetrieveServicePlanVisibility(Guid? guid)
    
        {
            string route = string.Format("/v2/service_plan_visibilities/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<RetrieveServicePlanVisibilityResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Updating a Service Plan Visibility
        /// </summary>
    

    
        public async Task<UpdateServicePlanVisibilityResponse> UpdateServicePlanVisibility(Guid? guid, UpdateServicePlanVisibilityRequest value)
    
        {
            string route = string.Format("/v2/service_plan_visibilities/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
        
            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<UpdateServicePlanVisibilityResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Service Plan Visibilities
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllServicePlanVisibilitiesResponse>> ListAllServicePlanVisibilities()
        {
            return await ListAllServicePlanVisibilities(new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllServicePlanVisibilitiesResponse>> ListAllServicePlanVisibilities(RequestOptions options)
    
        {
            string route = "/v2/service_plan_visibilities";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllServicePlanVisibilitiesResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Delete a Particular Service Plan Visibilities
        /// </summary>
    

    
        public async Task DeleteServicePlanVisibilities(Guid? guid)
    
        {
            string route = string.Format("/v2/service_plan_visibilities/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            var response = await client.SendAsync();
        
        }
    
    }
}