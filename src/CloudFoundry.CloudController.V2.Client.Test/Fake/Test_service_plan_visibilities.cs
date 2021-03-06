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
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServicePlanVisibilitiesEndpoint
{
        [TestMethod]
        public void ListAllServicePlanVisibilitiesTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""558b4cc0-ea70-4ee9-8c87-0fe6349971cc"",
        ""url"": ""/v2/service_plan_visibilities/558b4cc0-ea70-4ee9-8c87-0fe6349971cc"",
        ""created_at"": ""2015-04-16T12:04:22+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""service_plan_guid"": ""f858895a-a3f4-429d-b61b-9a0078c2e389"",
        ""organization_guid"": ""0e44d306-3415-4842-a22f-232d51db33e9"",
        ""service_plan_url"": ""/v2/service_plans/f858895a-a3f4-429d-b61b-9a0078c2e389"",
        ""organization_url"": ""/v2/organizations/0e44d306-3415-4842-a22f-232d51db33e9""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServicePlanVisibilities.ListAllServicePlanVisibilities().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("558b4cc0-ea70-4ee9-8c87-0fe6349971cc", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plan_visibilities/558b4cc0-ea70-4ee9-8c87-0fe6349971cc", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-16T12:04:22+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("f858895a-a3f4-429d-b61b-9a0078c2e389", TestUtil.ToTestableString(obj[0].ServicePlanGuid), true);
                Assert.AreEqual("0e44d306-3415-4842-a22f-232d51db33e9", TestUtil.ToTestableString(obj[0].OrganizationGuid), true);
                Assert.AreEqual("/v2/service_plans/f858895a-a3f4-429d-b61b-9a0078c2e389", TestUtil.ToTestableString(obj[0].ServicePlanUrl), true);
                Assert.AreEqual("/v2/organizations/0e44d306-3415-4842-a22f-232d51db33e9", TestUtil.ToTestableString(obj[0].OrganizationUrl), true);

            }
        }

        [TestMethod]
        public void CreateServicePlanVisibilityTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""efa536a8-334b-4750-ba75-91958b2c469c"",
    ""url"": ""/v2/service_plan_visibilities/efa536a8-334b-4750-ba75-91958b2c469c"",
    ""created_at"": ""2015-04-16T12:04:22+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""service_plan_guid"": ""bdc11465-2a7b-49da-94b9-867ffdeecf02"",
    ""organization_guid"": ""cef3c47c-8cfe-4e34-8463-de01ad657e43"",
    ""service_plan_url"": ""/v2/service_plans/bdc11465-2a7b-49da-94b9-867ffdeecf02"",
    ""organization_url"": ""/v2/organizations/cef3c47c-8cfe-4e34-8463-de01ad657e43""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServicePlanVisibilityRequest value = new CreateServicePlanVisibilityRequest();


                var obj = cfClient.ServicePlanVisibilities.CreateServicePlanVisibility(value).Result;


                Assert.AreEqual("efa536a8-334b-4750-ba75-91958b2c469c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plan_visibilities/efa536a8-334b-4750-ba75-91958b2c469c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-16T12:04:22+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("bdc11465-2a7b-49da-94b9-867ffdeecf02", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("cef3c47c-8cfe-4e34-8463-de01ad657e43", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("/v2/service_plans/bdc11465-2a7b-49da-94b9-867ffdeecf02", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
                Assert.AreEqual("/v2/organizations/cef3c47c-8cfe-4e34-8463-de01ad657e43", TestUtil.ToTestableString(obj.OrganizationUrl), true);

            }
        }

        [TestMethod]
        public void DeleteServicePlanVisibilitiesTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServicePlanVisibilities.DeleteServicePlanVisibilities(guid).Wait();

            }
        }

        [TestMethod]
        public void UpdateServicePlanVisibilityTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""430b831a-6fb4-4ce0-b03e-1841c035e7e1"",
    ""url"": ""/v2/service_plan_visibilities/430b831a-6fb4-4ce0-b03e-1841c035e7e1"",
    ""created_at"": ""2015-04-16T12:04:22+00:00"",
    ""updated_at"": ""2015-04-16T12:04:22+00:00""
  },
  ""entity"": {
    ""service_plan_guid"": ""e5eb2915-7697-4b3e-95da-4726894fec38"",
    ""organization_guid"": ""627520e1-2a6d-4aa6-a9d2-cf799c238604"",
    ""service_plan_url"": ""/v2/service_plans/e5eb2915-7697-4b3e-95da-4726894fec38"",
    ""organization_url"": ""/v2/organizations/627520e1-2a6d-4aa6-a9d2-cf799c238604""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateServicePlanVisibilityRequest value = new UpdateServicePlanVisibilityRequest();


                var obj = cfClient.ServicePlanVisibilities.UpdateServicePlanVisibility(guid, value).Result;


                Assert.AreEqual("430b831a-6fb4-4ce0-b03e-1841c035e7e1", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plan_visibilities/430b831a-6fb4-4ce0-b03e-1841c035e7e1", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-16T12:04:22+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-04-16T12:04:22+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("e5eb2915-7697-4b3e-95da-4726894fec38", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("627520e1-2a6d-4aa6-a9d2-cf799c238604", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("/v2/service_plans/e5eb2915-7697-4b3e-95da-4726894fec38", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
                Assert.AreEqual("/v2/organizations/627520e1-2a6d-4aa6-a9d2-cf799c238604", TestUtil.ToTestableString(obj.OrganizationUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveServicePlanVisibilityTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""94008955-73c1-4266-963a-31b1c8fa8f33"",
    ""url"": ""/v2/service_plan_visibilities/94008955-73c1-4266-963a-31b1c8fa8f33"",
    ""created_at"": ""2015-04-16T12:04:22+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""service_plan_guid"": ""8bf8aca3-93fb-4b8c-bc11-2160db19ea19"",
    ""organization_guid"": ""d4d63a84-8633-436a-a0f5-3091e0a23347"",
    ""service_plan_url"": ""/v2/service_plans/8bf8aca3-93fb-4b8c-bc11-2160db19ea19"",
    ""organization_url"": ""/v2/organizations/d4d63a84-8633-436a-a0f5-3091e0a23347""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServicePlanVisibilities.RetrieveServicePlanVisibility(guid).Result;


                Assert.AreEqual("94008955-73c1-4266-963a-31b1c8fa8f33", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plan_visibilities/94008955-73c1-4266-963a-31b1c8fa8f33", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-16T12:04:22+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("8bf8aca3-93fb-4b8c-bc11-2160db19ea19", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("d4d63a84-8633-436a-a0f5-3091e0a23347", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("/v2/service_plans/8bf8aca3-93fb-4b8c-bc11-2160db19ea19", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
                Assert.AreEqual("/v2/organizations/d4d63a84-8633-436a-a0f5-3091e0a23347", TestUtil.ToTestableString(obj.OrganizationUrl), true);

            }
        }

    }
}