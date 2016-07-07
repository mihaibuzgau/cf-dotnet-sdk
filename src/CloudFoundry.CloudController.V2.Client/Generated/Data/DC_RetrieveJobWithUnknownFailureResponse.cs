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

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.JobsEndpoint.RetrieveJobWithUnknownFailure()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/jobs/retrieve_job_with_unknown_failure.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrieveJobWithUnknownFailureResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrieveJobWithUnknownFailureResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.JobsEndpoint.RetrieveJobWithUnknownFailure()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/jobs/retrieve_job_with_unknown_failure.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrieveJobWithUnknownFailureResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Guid</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Status</para>
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Error</para>
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Error Details</para>
        /// </summary>
        [JsonProperty("error_details", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> ErrorDetails
        {
            get;
            set;
        }
    }
}