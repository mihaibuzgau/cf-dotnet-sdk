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
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    /// <summary>
    /// Organizations Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class OrganizationsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractOrganizationsEndpoint
    {
        internal OrganizationsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Organizations Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractOrganizationsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractOrganizationsEndpoint()
        {
        }

        /// <summary>
        /// Get Organization summary
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/get_organization_summary.html"</para>
        /// </summary>
        public async Task<GetOrganizationSummaryResponse> GetOrganizationSummary(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/summary", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetOrganizationSummaryResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Private Domains for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_private_domains_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPrivateDomainsForOrganizationResponse>> ListAllPrivateDomainsForOrganization(Guid? guid)
        {
            return await ListAllPrivateDomainsForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Private Domains for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_private_domains_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPrivateDomainsForOrganizationResponse>> ListAllPrivateDomainsForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/private_domains", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllPrivateDomainsForOrganizationResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Billing Managers for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_billing_managers_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllBillingManagersForOrganizationResponse>> ListAllBillingManagersForOrganization(Guid? guid)
        {
            return await ListAllBillingManagersForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Billing Managers for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_billing_managers_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllBillingManagersForOrganizationResponse>> ListAllBillingManagersForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/billing_managers", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllBillingManagersForOrganizationResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Update an Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/update_an_organization.html"</para>
        /// </summary>
        public async Task<UpdateOrganizationResponse> UpdateOrganization(Guid? guid, UpdateOrganizationRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove User from the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/remove_user_from_the_organization.html"</para>
        /// </summary>
        public async Task<RemoveUserFromOrganizationResponse> RemoveUserFromOrganization(Guid? guid, Guid? user_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/users/{1}", guid, user_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveUserFromOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Domains for the Organization (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_domains_for_the_organization_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDomainsForOrganizationDeprecatedResponse>> ListAllDomainsForOrganizationDeprecated(Guid? guid)
        {
            return await ListAllDomainsForOrganizationDeprecated(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Domains for the Organization (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_domains_for_the_organization_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDomainsForOrganizationDeprecatedResponse>> ListAllDomainsForOrganizationDeprecated(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/domains", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllDomainsForOrganizationDeprecatedResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieving organization memory usage
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/retrieving_organization_memory_usage.html"</para>
        /// </summary>
        public async Task<RetrievingOrganizationMemoryUsageResponse> RetrievingOrganizationMemoryUsage(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/memory_usage", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrievingOrganizationMemoryUsageResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Space Quota Definitions for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_space_quota_definitions_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpaceQuotaDefinitionsForOrganizationResponse>> ListAllSpaceQuotaDefinitionsForOrganization(Guid? guid)
        {
            return await ListAllSpaceQuotaDefinitionsForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Space Quota Definitions for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_space_quota_definitions_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpaceQuotaDefinitionsForOrganizationResponse>> ListAllSpaceQuotaDefinitionsForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/space_quota_definitions", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpaceQuotaDefinitionsForOrganizationResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Remove Private Domain from the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/remove_private_domain_from_the_organization.html"</para>
        /// </summary>
        public async Task<RemovePrivateDomainFromOrganizationResponse> RemovePrivateDomainFromOrganization(Guid? guid, Guid? private_domain_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/private_domains/{1}", guid, private_domain_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemovePrivateDomainFromOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Billing Manager from the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/remove_billing_manager_from_the_organization.html"</para>
        /// </summary>
        public async Task<RemoveBillingManagerFromOrganizationResponse> RemoveBillingManagerFromOrganization(Guid? guid, Guid? billing_manager_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/billing_managers/{1}", guid, billing_manager_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveBillingManagerFromOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/delete_a_particular_organization.html"</para>
        /// </summary>
        public async Task DeleteOrganization(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Associate User with the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/associate_user_with_the_organization.html"</para>
        /// </summary>
        public async Task<AssociateUserWithOrganizationResponse> AssociateUserWithOrganization(Guid? guid, Guid? user_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/users/{1}", guid, user_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateUserWithOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Spaces for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_spaces_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForOrganizationResponse>> ListAllSpacesForOrganization(Guid? guid)
        {
            return await ListAllSpacesForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Spaces for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_spaces_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForOrganizationResponse>> ListAllSpacesForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/spaces", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpacesForOrganizationResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Services for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_services_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicesForOrganizationResponse>> ListAllServicesForOrganization(Guid? guid)
        {
            return await ListAllServicesForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Services for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_services_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicesForOrganizationResponse>> ListAllServicesForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/services", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServicesForOrganizationResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Organizations
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_organizations.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllOrganizationsResponse>> ListAllOrganizations()
        {
            return await ListAllOrganizations(new RequestOptions());
        }

        /// <summary>
        /// List all Organizations
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_organizations.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllOrganizationsResponse>> ListAllOrganizations(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/organizations";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllOrganizationsResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Auditors for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_auditors_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditorsForOrganizationResponse>> ListAllAuditorsForOrganization(Guid? guid)
        {
            return await ListAllAuditorsForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Auditors for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_auditors_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditorsForOrganizationResponse>> ListAllAuditorsForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/auditors", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAuditorsForOrganizationResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Users for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_users_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllUsersForOrganizationResponse>> ListAllUsersForOrganization(Guid? guid)
        {
            return await ListAllUsersForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Users for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_users_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllUsersForOrganizationResponse>> ListAllUsersForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/users", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllUsersForOrganizationResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Remove Manager from the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/remove_manager_from_the_organization.html"</para>
        /// </summary>
        public async Task<RemoveManagerFromOrganizationResponse> RemoveManagerFromOrganization(Guid? guid, Guid? manager_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/managers/{1}", guid, manager_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveManagerFromOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Managers for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_managers_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagersForOrganizationResponse>> ListAllManagersForOrganization(Guid? guid)
        {
            return await ListAllManagersForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Managers for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/list_all_managers_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagersForOrganizationResponse>> ListAllManagersForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/managers", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllManagersForOrganizationResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Creating an Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/creating_an_organization.html"</para>
        /// </summary>
        public async Task<CreateOrganizationResponse> CreateOrganization(CreateOrganizationRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/organizations";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Billing Manager with the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/associate_billing_manager_with_the_organization.html"</para>
        /// </summary>
        public async Task<AssociateBillingManagerWithOrganizationResponse> AssociateBillingManagerWithOrganization(Guid? guid, Guid? billing_manager_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/billing_managers/{1}", guid, billing_manager_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateBillingManagerWithOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/retrieve_a_particular_organization.html"</para>
        /// </summary>
        public async Task<RetrieveOrganizationResponse> RetrieveOrganization(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Auditor with the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/associate_auditor_with_the_organization.html"</para>
        /// </summary>
        public async Task<AssociateAuditorWithOrganizationResponse> AssociateAuditorWithOrganization(Guid? guid, Guid? auditor_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/auditors/{1}", guid, auditor_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateAuditorWithOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Private Domain with the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/associate_private_domain_with_the_organization.html"</para>
        /// </summary>
        public async Task<AssociatePrivateDomainWithOrganizationResponse> AssociatePrivateDomainWithOrganization(Guid? guid, Guid? private_domain_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/private_domains/{1}", guid, private_domain_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociatePrivateDomainWithOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Auditor from the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/remove_auditor_from_the_organization.html"</para>
        /// </summary>
        public async Task<RemoveAuditorFromOrganizationResponse> RemoveAuditorFromOrganization(Guid? guid, Guid? auditor_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/auditors/{1}", guid, auditor_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveAuditorFromOrganizationResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Manager with the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/205/organizations/associate_manager_with_the_organization.html"</para>
        /// </summary>
        public async Task<AssociateManagerWithOrganizationResponse> AssociateManagerWithOrganization(Guid? guid, Guid? manager_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/managers/{1}", guid, manager_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateManagerWithOrganizationResponse>(await response.ReadContentAsStringAsync());
        }
    }
}
