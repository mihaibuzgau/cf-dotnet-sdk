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
    public class OrganizationsEndpoint : BaseEndpoint
    {
        public OrganizationsEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }

        /// <summary>
        /// List all Users for the Organization
        /// </summary>
        public async Task<PagedResponseCollection<ListAllUsersForOrganizationResponse>> ListAllUsersForOrganization(Guid? guid)
        {
            return await ListAllUsersForOrganization(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllUsersForOrganizationResponse>> ListAllUsersForOrganization(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/organizations/{0}/users", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllUsersForOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Spaces for the Organization
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForOrganizationResponse>> ListAllSpacesForOrganization(Guid? guid)
        {
            return await ListAllSpacesForOrganization(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllSpacesForOrganizationResponse>> ListAllSpacesForOrganization(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/organizations/{0}/spaces", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpacesForOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate User with the Organization
        /// </summary>
        public async Task<AssociateUserWithOrganizationResponse> AssociateUserWithOrganization(Guid? guid, Guid? user_guid)
        {
            string route = string.Format("/v2/organizations/{0}/users/{1}", guid, user_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateUserWithOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Manager from the Organization
        /// </summary>
        public async Task<RemoveManagerFromOrganizationResponse> RemoveManagerFromOrganization(Guid? guid, Guid? manager_guid)
        {
            string route = string.Format("/v2/organizations/{0}/managers/{1}", guid, manager_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveManagerFromOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Auditor from the Organization
        /// </summary>
        public async Task<RemoveAuditorFromOrganizationResponse> RemoveAuditorFromOrganization(Guid? guid, Guid? auditor_guid)
        {
            string route = string.Format("/v2/organizations/{0}/auditors/{1}", guid, auditor_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveAuditorFromOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Manager with the Organization
        /// </summary>
        public async Task<AssociateManagerWithOrganizationResponse> AssociateManagerWithOrganization(Guid? guid, Guid? manager_guid)
        {
            string route = string.Format("/v2/organizations/{0}/managers/{1}", guid, manager_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateManagerWithOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Billing Managers for the Organization
        /// </summary>
        public async Task<PagedResponseCollection<ListAllBillingManagersForOrganizationResponse>> ListAllBillingManagersForOrganization(Guid? guid)
        {
            return await ListAllBillingManagersForOrganization(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllBillingManagersForOrganizationResponse>> ListAllBillingManagersForOrganization(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/organizations/{0}/billing_managers", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllBillingManagersForOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Auditors for the Organization
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditorsForOrganizationResponse>> ListAllAuditorsForOrganization(Guid? guid)
        {
            return await ListAllAuditorsForOrganization(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllAuditorsForOrganizationResponse>> ListAllAuditorsForOrganization(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/organizations/{0}/auditors", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAuditorsForOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Services for the Organization
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicesForOrganizationResponse>> ListAllServicesForOrganization(Guid? guid)
        {
            return await ListAllServicesForOrganization(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllServicesForOrganizationResponse>> ListAllServicesForOrganization(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/organizations/{0}/services", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServicesForOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Private Domains for the Organization
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPrivateDomainsForOrganizationResponse>> ListAllPrivateDomainsForOrganization(Guid? guid)
        {
            return await ListAllPrivateDomainsForOrganization(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllPrivateDomainsForOrganizationResponse>> ListAllPrivateDomainsForOrganization(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/organizations/{0}/private_domains", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllPrivateDomainsForOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating an Organization
        /// </summary>
        public async Task<CreateOrganizationResponse> CreateOrganization(CreateOrganizationRequest value)
        {
            string route = "/v2/organizations";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Domains for the Organization (deprecated)
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDomainsForOrganizationDeprecatedResponse>> ListAllDomainsForOrganizationDeprecated(Guid? guid)
        {
            return await ListAllDomainsForOrganizationDeprecated(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllDomainsForOrganizationDeprecatedResponse>> ListAllDomainsForOrganizationDeprecated(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/organizations/{0}/domains", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllDomainsForOrganizationDeprecatedResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Auditor with the Organization
        /// </summary>
        public async Task<AssociateAuditorWithOrganizationResponse> AssociateAuditorWithOrganization(Guid? guid, Guid? auditor_guid)
        {
            string route = string.Format("/v2/organizations/{0}/auditors/{1}", guid, auditor_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateAuditorWithOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get Organization summary
        /// </summary>
        public async Task<GetOrganizationSummaryResponse> GetOrganizationSummary(Guid? guid)
        {
            string route = string.Format("/v2/organizations/{0}/summary", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetOrganizationSummaryResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Space Quota Definitions for the Organization
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpaceQuotaDefinitionsForOrganizationResponse>> ListAllSpaceQuotaDefinitionsForOrganization(Guid? guid)
        {
            return await ListAllSpaceQuotaDefinitionsForOrganization(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllSpaceQuotaDefinitionsForOrganizationResponse>> ListAllSpaceQuotaDefinitionsForOrganization(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/organizations/{0}/space_quota_definitions", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpaceQuotaDefinitionsForOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Billing Manager from the Organization
        /// </summary>
        public async Task<RemoveBillingManagerFromOrganizationResponse> RemoveBillingManagerFromOrganization(Guid? guid, Guid? billing_manager_guid)
        {
            string route = string.Format("/v2/organizations/{0}/billing_managers/{1}", guid, billing_manager_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveBillingManagerFromOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Organization
        /// </summary>
        public async Task<RetrieveOrganizationResponse> RetrieveOrganization(Guid? guid)
        {
            string route = string.Format("/v2/organizations/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove User from the Organization
        /// </summary>
        public async Task<RemoveUserFromOrganizationResponse> RemoveUserFromOrganization(Guid? guid, Guid? user_guid)
        {
            string route = string.Format("/v2/organizations/{0}/users/{1}", guid, user_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveUserFromOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Organization
        /// </summary>
        public async Task DeleteOrganization(Guid? guid)
        {
            string route = string.Format("/v2/organizations/{0}", guid);
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
        /// List all Managers for the Organization
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagersForOrganizationResponse>> ListAllManagersForOrganization(Guid? guid)
        {
            return await ListAllManagersForOrganization(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllManagersForOrganizationResponse>> ListAllManagersForOrganization(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/organizations/{0}/managers", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllManagersForOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieving organization memory usage
        /// </summary>
        public async Task<RetrievingOrganizationMemoryUsageResponse> RetrievingOrganizationMemoryUsage(Guid? guid)
        {
            string route = string.Format("/v2/organizations/{0}/memory_usage", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrievingOrganizationMemoryUsageResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Organizations
        /// </summary>
        public async Task<PagedResponseCollection<ListAllOrganizationsResponse>> ListAllOrganizations()
        {
            return await ListAllOrganizations(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllOrganizationsResponse>> ListAllOrganizations(RequestOptions options)
        {
            string route = "/v2/organizations";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllOrganizationsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Update an Organization
        /// </summary>
        public async Task<UpdateOrganizationResponse> UpdateOrganization(Guid? guid, UpdateOrganizationRequest value)
        {
            string route = string.Format("/v2/organizations/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Billing Manager with the Organization
        /// </summary>
        public async Task<AssociateBillingManagerWithOrganizationResponse> AssociateBillingManagerWithOrganization(Guid? guid, Guid? billing_manager_guid)
        {
            string route = string.Format("/v2/organizations/{0}/billing_managers/{1}", guid, billing_manager_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateBillingManagerWithOrganizationResponse>(await response.ReadContentAsStringAsync());
        }
    }
}