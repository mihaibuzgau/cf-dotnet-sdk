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
    public class ServicesEndpoint
{
        [TestMethod]
        public void RetrieveServiceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""f32db991-7c11-451b-8be8-b0aae4bb26c8"",
    ""url"": ""/v2/services/5d8fb3a7-22e4-410e-b014-d9e964869b4b"",
    ""created_at"": ""2016-10-12T12:29:39Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""label-75"",
    ""provider"": null,
    ""url"": null,
    ""description"": ""desc-274"",
    ""long_description"": null,
    ""version"": null,
    ""info_url"": null,
    ""active"": true,
    ""bindable"": true,
    ""unique_id"": ""edc3667b-46d0-47c0-8781-a3af1315dd57"",
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": ""f32db991-7c11-451b-8be8-b0aae4bb26c8"",
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/5d8fb3a7-22e4-410e-b014-d9e964869b4b/service_plans""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Services.RetrieveService(guid).Result;


                Assert.AreEqual("f32db991-7c11-451b-8be8-b0aae4bb26c8", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/services/5d8fb3a7-22e4-410e-b014-d9e964869b4b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:39Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-75", TestUtil.ToTestableString(obj.Label), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Provider), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Url), true);
                Assert.AreEqual("desc-274", TestUtil.ToTestableString(obj.Description), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Version), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
                Assert.AreEqual("edc3667b-46d0-47c0-8781-a3af1315dd57", TestUtil.ToTestableString(obj.UniqueId), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
                Assert.AreEqual("f32db991-7c11-451b-8be8-b0aae4bb26c8", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
                Assert.AreEqual("/v2/services/5d8fb3a7-22e4-410e-b014-d9e964869b4b/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServicesTest()
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
        ""guid"": ""4fa84a4f-ab31-427b-bbde-e86ffec1232d"",
        ""url"": ""/v2/services/6b508ed4-54ec-4eb6-80b7-e55f24af2b01"",
        ""created_at"": ""2016-10-12T12:29:39Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-76"",
        ""provider"": null,
        ""url"": null,
        ""description"": ""desc-275"",
        ""long_description"": null,
        ""version"": null,
        ""info_url"": null,
        ""active"": true,
        ""bindable"": true,
        ""unique_id"": ""24f0004d-cc74-4d6f-aafb-dfec21726755"",
        ""extra"": null,
        ""tags"": [

        ],
        ""requires"": [

        ],
        ""documentation_url"": null,
        ""service_broker_guid"": ""4fa84a4f-ab31-427b-bbde-e86ffec1232d"",
        ""plan_updateable"": false,
        ""service_plans_url"": ""/v2/services/6b508ed4-54ec-4eb6-80b7-e55f24af2b01/service_plans""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Services.ListAllServices().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("4fa84a4f-ab31-427b-bbde-e86ffec1232d", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/services/6b508ed4-54ec-4eb6-80b7-e55f24af2b01", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:39Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-76", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Provider), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Url), true);
                Assert.AreEqual("desc-275", TestUtil.ToTestableString(obj[0].Description), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].LongDescription), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Version), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].InfoUrl), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Active), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Bindable), true);
                Assert.AreEqual("24f0004d-cc74-4d6f-aafb-dfec21726755", TestUtil.ToTestableString(obj[0].UniqueId), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Extra), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DocumentationUrl), true);
                Assert.AreEqual("4fa84a4f-ab31-427b-bbde-e86ffec1232d", TestUtil.ToTestableString(obj[0].ServiceBrokerGuid), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].PlanUpdateable), true);
                Assert.AreEqual("/v2/services/6b508ed4-54ec-4eb6-80b7-e55f24af2b01/service_plans", TestUtil.ToTestableString(obj[0].ServicePlansUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServicePlansForServiceTest()
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
        ""guid"": ""086c537f-fae5-4283-a6de-5592dce56f4c"",
        ""url"": ""/v2/service_plans/3b2f36c3-6382-4cac-957f-2090feca3ce5"",
        ""created_at"": ""2016-10-12T12:29:39Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2473"",
        ""free"": false,
        ""description"": ""desc-277"",
        ""service_guid"": ""086c537f-fae5-4283-a6de-5592dce56f4c"",
        ""extra"": null,
        ""unique_id"": ""c5c3d419-a63d-4091-9044-6b04b6c19b22"",
        ""public"": true,
        ""active"": true,
        ""service_url"": ""/v2/services/b531d4dd-e164-4b81-9932-d60908ce6b94"",
        ""service_instances_url"": ""/v2/service_plans/3b2f36c3-6382-4cac-957f-2090feca3ce5/service_instances""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Services.ListAllServicePlansForService(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("086c537f-fae5-4283-a6de-5592dce56f4c", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plans/3b2f36c3-6382-4cac-957f-2090feca3ce5", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:39Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2473", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Free), true);
                Assert.AreEqual("desc-277", TestUtil.ToTestableString(obj[0].Description), true);
                Assert.AreEqual("086c537f-fae5-4283-a6de-5592dce56f4c", TestUtil.ToTestableString(obj[0].ServiceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Extra), true);
                Assert.AreEqual("c5c3d419-a63d-4091-9044-6b04b6c19b22", TestUtil.ToTestableString(obj[0].UniqueId), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Public), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Active), true);
                Assert.AreEqual("/v2/services/b531d4dd-e164-4b81-9932-d60908ce6b94", TestUtil.ToTestableString(obj[0].ServiceUrl), true);
                Assert.AreEqual("/v2/service_plans/3b2f36c3-6382-4cac-957f-2090feca3ce5/service_instances", TestUtil.ToTestableString(obj[0].ServiceInstancesUrl), true);

            }
        }

        [TestMethod]
        public void DeleteServiceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""c84ec9ba-69dc-4b8d-9a75-11c0f15138f2"",
    ""created_at"": ""2016-10-12T12:29:39Z"",
    ""url"": ""/v2/jobs/dec083b2-4755-4725-9a3f-f0cc44cd711b""
  },
  ""entity"": {
    ""guid"": ""c84ec9ba-69dc-4b8d-9a75-11c0f15138f2"",
    ""status"": ""queued""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)202;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Services.DeleteService(guid).Result;


                Assert.AreEqual("c84ec9ba-69dc-4b8d-9a75-11c0f15138f2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-10-12T12:29:39Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/dec083b2-4755-4725-9a3f-f0cc44cd711b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("c84ec9ba-69dc-4b8d-9a75-11c0f15138f2", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);

            }
        }

    }
}