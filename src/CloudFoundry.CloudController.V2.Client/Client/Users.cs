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
    /// Users Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UsersEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractUsersEndpoint
    {
        internal UsersEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }    
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{

    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUsersEndpoint : BaseEndpoint
    {

        /// <summary>
        /// Get User summary
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/get_user_summary.html"</para>
        /// </summary>
        public async Task<GetUserSummaryResponse> GetUserSummary(Guid? guid)
        {
            string route = string.Format("/v2/users/{0}/summary", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetUserSummaryResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Audited Space with the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/associate_audited_space_with_the_user.html"</para>
        /// </summary>
        public async Task<AssociateAuditedSpaceWithUserResponse> AssociateAuditedSpaceWithUser(Guid? guid, Guid? audited_space_guid)
        {
            string route = string.Format("/v2/users/{0}/audited_spaces/{1}", guid, audited_space_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateAuditedSpaceWithUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Managed Spaces for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_managed_spaces_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagedSpacesForUserResponse>> ListAllManagedSpacesForUser(Guid? guid)
        {
            return await ListAllManagedSpacesForUser(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Managed Spaces for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_managed_spaces_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagedSpacesForUserResponse>> ListAllManagedSpacesForUser(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/users/{0}/managed_spaces", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllManagedSpacesForUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Managed Organizations for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_managed_organizations_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagedOrganizationsForUserResponse>> ListAllManagedOrganizationsForUser(Guid? guid)
        {
            return await ListAllManagedOrganizationsForUser(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Managed Organizations for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_managed_organizations_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagedOrganizationsForUserResponse>> ListAllManagedOrganizationsForUser(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/users/{0}/managed_organizations", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllManagedOrganizationsForUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Organizations for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_organizations_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllOrganizationsForUserResponse>> ListAllOrganizationsForUser(Guid? guid)
        {
            return await ListAllOrganizationsForUser(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Organizations for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_organizations_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllOrganizationsForUserResponse>> ListAllOrganizationsForUser(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/users/{0}/organizations", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllOrganizationsForUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Updating a User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/updating_a_user.html"</para>
        /// </summary>
        public async Task<UpdateUserResponse> UpdateUser(Guid? guid, UpdateUserRequest value)
        {
            string route = string.Format("/v2/users/{0}", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Space from the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/remove_space_from_the_user.html"</para>
        /// </summary>
        public async Task<RemoveSpaceFromUserResponse> RemoveSpaceFromUser(Guid? guid, Guid? space_guid)
        {
            string route = string.Format("/v2/users/{0}/spaces/{1}", guid, space_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveSpaceFromUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Space with the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/associate_space_with_the_user.html"</para>
        /// </summary>
        public async Task<AssociateSpaceWithUserResponse> AssociateSpaceWithUser(Guid? guid, Guid? space_guid)
        {
            string route = string.Format("/v2/users/{0}/spaces/{1}", guid, space_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateSpaceWithUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/retrieve_a_particular_user.html"</para>
        /// </summary>
        public async Task<RetrieveUserResponse> RetrieveUser(Guid? guid)
        {
            string route = string.Format("/v2/users/{0}", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Billing Managed Organization from the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/remove_billing_managed_organization_from_the_user.html"</para>
        /// </summary>
        public async Task<RemoveBillingManagedOrganizationFromUserResponse> RemoveBillingManagedOrganizationFromUser(Guid? guid, Guid? billing_managed_organization_guid)
        {
            string route = string.Format("/v2/users/{0}/billing_managed_organizations/{1}", guid, billing_managed_organization_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveBillingManagedOrganizationFromUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Billing Managed Organizations for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_billing_managed_organizations_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllBillingManagedOrganizationsForUserResponse>> ListAllBillingManagedOrganizationsForUser(Guid? guid)
        {
            return await ListAllBillingManagedOrganizationsForUser(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Billing Managed Organizations for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_billing_managed_organizations_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllBillingManagedOrganizationsForUserResponse>> ListAllBillingManagedOrganizationsForUser(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/users/{0}/billing_managed_organizations", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllBillingManagedOrganizationsForUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Audited Space from the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/remove_audited_space_from_the_user.html"</para>
        /// </summary>
        public async Task<RemoveAuditedSpaceFromUserResponse> RemoveAuditedSpaceFromUser(Guid? guid, Guid? audited_space_guid)
        {
            string route = string.Format("/v2/users/{0}/audited_spaces/{1}", guid, audited_space_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveAuditedSpaceFromUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Managed Space with the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/associate_managed_space_with_the_user.html"</para>
        /// </summary>
        public async Task<AssociateManagedSpaceWithUserResponse> AssociateManagedSpaceWithUser(Guid? guid, Guid? managed_space_guid)
        {
            string route = string.Format("/v2/users/{0}/managed_spaces/{1}", guid, managed_space_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateManagedSpaceWithUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Billing Managed Organization with the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/associate_billing_managed_organization_with_the_user.html"</para>
        /// </summary>
        public async Task<AssociateBillingManagedOrganizationWithUserResponse> AssociateBillingManagedOrganizationWithUser(Guid? guid, Guid? billing_managed_organization_guid)
        {
            string route = string.Format("/v2/users/{0}/billing_managed_organizations/{1}", guid, billing_managed_organization_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateBillingManagedOrganizationWithUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Users
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_users.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllUsersResponse>> ListAllUsers()
        {
            return await ListAllUsers(new RequestOptions());
        }

        /// <summary>
        /// List all Users
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_users.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllUsersResponse>> ListAllUsers(RequestOptions options)
        {
            string route = "/v2/users";
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllUsersResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Audited Spaces for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_audited_spaces_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditedSpacesForUserResponse>> ListAllAuditedSpacesForUser(Guid? guid)
        {
            return await ListAllAuditedSpacesForUser(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Audited Spaces for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_audited_spaces_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditedSpacesForUserResponse>> ListAllAuditedSpacesForUser(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/users/{0}/audited_spaces", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAuditedSpacesForUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Audited Organization from the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/remove_audited_organization_from_the_user.html"</para>
        /// </summary>
        public async Task<RemoveAuditedOrganizationFromUserResponse> RemoveAuditedOrganizationFromUser(Guid? guid, Guid? audited_organization_guid)
        {
            string route = string.Format("/v2/users/{0}/audited_organizations/{1}", guid, audited_organization_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveAuditedOrganizationFromUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Managed Space from the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/remove_managed_space_from_the_user.html"</para>
        /// </summary>
        public async Task<RemoveManagedSpaceFromUserResponse> RemoveManagedSpaceFromUser(Guid? guid, Guid? managed_space_guid)
        {
            string route = string.Format("/v2/users/{0}/managed_spaces/{1}", guid, managed_space_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveManagedSpaceFromUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating a User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/creating_a_user.html"</para>
        /// </summary>
        public async Task<CreateUserResponse> CreateUser(CreateUserRequest value)
        {
            string route = "/v2/users";
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Post;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Managed Organization with the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/associate_managed_organization_with_the_user.html"</para>
        /// </summary>
        public async Task<AssociateManagedOrganizationWithUserResponse> AssociateManagedOrganizationWithUser(Guid? guid, Guid? managed_organization_guid)
        {
            string route = string.Format("/v2/users/{0}/managed_organizations/{1}", guid, managed_organization_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateManagedOrganizationWithUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Spaces for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_spaces_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForUserResponse>> ListAllSpacesForUser(Guid? guid)
        {
            return await ListAllSpacesForUser(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Spaces for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_spaces_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForUserResponse>> ListAllSpacesForUser(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/users/{0}/spaces", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpacesForUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/delete_a_particular_user.html"</para>
        /// </summary>
        public async Task DeleteUser(Guid? guid)
        {
            string route = string.Format("/v2/users/{0}", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Remove Organization from the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/remove_organization_from_the_user.html"</para>
        /// </summary>
        public async Task<RemoveOrganizationFromUserResponse> RemoveOrganizationFromUser(Guid? guid, Guid? organization_guid)
        {
            string route = string.Format("/v2/users/{0}/organizations/{1}", guid, organization_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveOrganizationFromUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Managed Organization from the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/remove_managed_organization_from_the_user.html"</para>
        /// </summary>
        public async Task<RemoveManagedOrganizationFromUserResponse> RemoveManagedOrganizationFromUser(Guid? guid, Guid? managed_organization_guid)
        {
            string route = string.Format("/v2/users/{0}/managed_organizations/{1}", guid, managed_organization_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveManagedOrganizationFromUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Audited Organizations for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_audited_organizations_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditedOrganizationsForUserResponse>> ListAllAuditedOrganizationsForUser(Guid? guid)
        {
            return await ListAllAuditedOrganizationsForUser(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Audited Organizations for the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/list_all_audited_organizations_for_the_user.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditedOrganizationsForUserResponse>> ListAllAuditedOrganizationsForUser(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/users/{0}/audited_organizations", guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAuditedOrganizationsForUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Audited Organization with the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/associate_audited_organization_with_the_user.html"</para>
        /// </summary>
        public async Task<AssociateAuditedOrganizationWithUserResponse> AssociateAuditedOrganizationWithUser(Guid? guid, Guid? audited_organization_guid)
        {
            string route = string.Format("/v2/users/{0}/audited_organizations/{1}", guid, audited_organization_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateAuditedOrganizationWithUserResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Organization with the User
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/users/associate_organization_with_the_user.html"</para>
        /// </summary>
        public async Task<AssociateOrganizationWithUserResponse> AssociateOrganizationWithUser(Guid? guid, Guid? organization_guid)
        {
            string route = string.Format("/v2/users/{0}/organizations/{1}", guid, organization_guid);
            string endpoint = this.Client.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateOrganizationWithUserResponse>(await response.ReadContentAsStringAsync());
        }
    }
}