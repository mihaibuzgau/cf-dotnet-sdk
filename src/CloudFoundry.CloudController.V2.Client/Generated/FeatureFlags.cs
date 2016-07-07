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
    /// FeatureFlags Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class FeatureFlagsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractFeatureFlagsEndpoint
    {
        internal FeatureFlagsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for FeatureFlags Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractFeatureFlagsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractFeatureFlagsEndpoint()
        {
        }

        /// <summary>
        /// Get all feature flags
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/get_all_feature_flags.html"</para>
        /// </summary>
        public async Task<GetAllFeatureFlagsResponse[]> GetAllFeatureFlags()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/feature_flags";
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
            return Utilities.DeserializeJsonArray<GetAllFeatureFlagsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the App Bits Upload feature flag
        /// <para>When enabled, space developers can upload app bits. When disabled, only admin users can upload app bits</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/get_the_app_bits_upload_feature_flag.html"</para>
        /// </summary>
        public async Task<GetAppBitsUploadFeatureFlagResponse> GetAppBitsUploadFeatureFlag()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/feature_flags/app_bits_upload";
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
            return Utilities.DeserializeJson<GetAppBitsUploadFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the App Scaling feature flag
        /// <para>When enabled, space developers can perform scaling operations (i.e. change memory, disk or instances). When disabled, only admins can perform scaling operations.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/get_the_app_scaling_feature_flag.html"</para>
        /// </summary>
        public async Task<GetAppScalingFeatureFlagResponse> GetAppScalingFeatureFlag()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/feature_flags/app_scaling";
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
            return Utilities.DeserializeJson<GetAppScalingFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the Diego Docker feature flag
        /// <para>When enabled, Docker applications are supported by Diego. When disabled, Docker applications will stop running.</para>
        /// <para>It will still be possible to stop and delete them and update their configurations.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/get_the_diego_docker_feature_flag.html"</para>
        /// </summary>
        public async Task<GetDiegoDockerFeatureFlagResponse> GetDiegoDockerFeatureFlag()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/feature_flags/diego_docker";
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
            return Utilities.DeserializeJson<GetDiegoDockerFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the Private Domain Creation feature flag
        /// <para>When enabled, an organization manager can create private domains for that organization. When disabled, only admin users can create private domains.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/get_the_private_domain_creation_feature_flag.html"</para>
        /// </summary>
        public async Task<GetPrivateDomainCreationFeatureFlagResponse> GetPrivateDomainCreationFeatureFlag()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/feature_flags/private_domain_creation";
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
            return Utilities.DeserializeJson<GetPrivateDomainCreationFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the Route Creation feature flag
        /// <para>When enabled, a space developer can create routes in a space. When disabled, only admin users can create routes.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/get_the_route_creation_feature_flag.html"</para>
        /// </summary>
        public async Task<GetRouteCreationFeatureFlagResponse> GetRouteCreationFeatureFlag()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/feature_flags/route_creation";
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
            return Utilities.DeserializeJson<GetRouteCreationFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the Service Instance Creation feature flag
        /// <para>When enabled, a space developer can create service instances in a space. When disabled, only admin users can create service instances.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/get_the_service_instance_creation_feature_flag.html"</para>
        /// </summary>
        public async Task<GetServiceInstanceCreationFeatureFlagResponse> GetServiceInstanceCreationFeatureFlag()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/feature_flags/service_instance_creation";
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
            return Utilities.DeserializeJson<GetServiceInstanceCreationFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the Set User Roles feature flag
        /// <para>When enabled, Org Managers or Space Managers can add access roles by username.</para>
        /// <para>In order for this feature to be enabled the CF operator must:</para>
        /// <para>1) Enable the `/ids/users/` endpoint for UAA</para>
        /// <para>2) Create a UAA `cloud_controller_username_lookup` client with the `scim.userids`</para>
        /// <para>authority</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/get_the_set_user_roles_feature_flag.html"</para>
        /// </summary>
        public async Task<GetSetUserRolesFeatureFlagResponse> GetSetUserRolesFeatureFlag()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/feature_flags/set_roles_by_username";
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
            return Utilities.DeserializeJson<GetSetUserRolesFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the Unset User Roles feature flag
        /// <para>When enabled, Org Managers or Space Managers can remove access roles by username.</para>
        /// <para>In order for this feature to be enabled the CF operator must:</para>
        /// <para>1) Enable the `/ids/users/` endpoint for UAA</para>
        /// <para>2) Create a UAA `cloud_controller_username_lookup` client with the `scim.userids`</para>
        /// <para>authority</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/get_the_unset_user_roles_feature_flag.html"</para>
        /// </summary>
        public async Task<GetUnsetUserRolesFeatureFlagResponse> GetUnsetUserRolesFeatureFlag()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/feature_flags/unset_roles_by_username";
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
            return Utilities.DeserializeJson<GetUnsetUserRolesFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the User Org Creation feature flag
        /// <para>When enabled, any user can create an organization via the API. When disabled, only admin users can create organizations via the API.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/get_the_user_org_creation_feature_flag.html"</para>
        /// </summary>
        public async Task<GetUserOrgCreationFeatureFlagResponse> GetUserOrgCreationFeatureFlag()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/feature_flags/user_org_creation";
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
            return Utilities.DeserializeJson<GetUserOrgCreationFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Set a feature flag
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/feature_flags/set_a_feature_flag.html"</para>
        /// </summary>
        public async Task<SetFeatureFlagResponse> SetFeatureFlag(dynamic name, SetFeatureFlagRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/config/feature_flags/{0}", name);
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
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<SetFeatureFlagResponse>(await response.ReadContentAsStringAsync());
        }
    }
}
