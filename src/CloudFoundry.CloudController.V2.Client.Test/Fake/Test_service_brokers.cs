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
    public class ServiceBrokersEndpoint
{
        [TestMethod]
        public void CreateServiceBrokerTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""385267b3-277d-4e16-ba7e-659e6a93041e"",
    ""created_at"": ""2016-07-07T09:17:13Z"",
    ""updated_at"": null,
    ""url"": ""/v2/service_brokers/176f6dfd-738b-4a08-b0ea-c72a40b4ba5f""
  },
  ""entity"": {
    ""name"": ""service-broker-name"",
    ""broker_url"": ""https://broker.example.com"",
    ""auth_username"": ""admin"",
    ""space_guid"": null
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServiceBrokerRequest value = new CreateServiceBrokerRequest();


                var obj = cfClient.ServiceBrokers.CreateServiceBroker(value).Result;


                Assert.AreEqual("385267b3-277d-4e16-ba7e-659e6a93041e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-07-07T09:17:13Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("/v2/service_brokers/176f6dfd-738b-4a08-b0ea-c72a40b4ba5f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("service-broker-name", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("https://broker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
                Assert.AreEqual("admin", TestUtil.ToTestableString(obj.AuthUsername), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.SpaceGuid), true);

            }
        }

        [TestMethod]
        public void DeleteServiceBrokerTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceBrokers.DeleteServiceBroker(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllServiceBrokersTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""3dfa9ffb-925b-4265-9dd7-2cb032820b07"",
        ""url"": ""/v2/service_brokers/fb5051ea-d3cc-4a1c-b7d3-a8857d3009a0"",
        ""created_at"": ""2016-07-07T09:17:13Z"",
        ""updated_at"": ""2016-07-07T09:17:13Z""
      },
      ""entity"": {
        ""name"": ""name-2229"",
        ""broker_url"": ""https://foo.com/url-98"",
        ""auth_username"": ""auth_username-73"",
        ""space_guid"": ""3dfa9ffb-925b-4265-9dd7-2cb032820b07""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""3dfa9ffb-925b-4265-9dd7-2cb032820b07"",
        ""url"": ""/v2/service_brokers/9fd08b6f-a836-4f9a-82e8-3a05b0fa8c5b"",
        ""created_at"": ""2016-07-07T09:17:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2230"",
        ""broker_url"": ""https://foo.com/url-99"",
        ""auth_username"": ""auth_username-74"",
        ""space_guid"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""3dfa9ffb-925b-4265-9dd7-2cb032820b07"",
        ""url"": ""/v2/service_brokers/cbc91c6c-b9f6-4eed-832b-c96c6d8252f6"",
        ""created_at"": ""2016-07-07T09:17:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2231"",
        ""broker_url"": ""https://foo.com/url-100"",
        ""auth_username"": ""auth_username-75"",
        ""space_guid"": null
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceBrokers.ListAllServiceBrokers().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("3dfa9ffb-925b-4265-9dd7-2cb032820b07", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_brokers/fb5051ea-d3cc-4a1c-b7d3-a8857d3009a0", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-07T09:17:13Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-07-07T09:17:13Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2229", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("https://foo.com/url-98", TestUtil.ToTestableString(obj[0].BrokerUrl), true);
                Assert.AreEqual("auth_username-73", TestUtil.ToTestableString(obj[0].AuthUsername), true);
                Assert.AreEqual("3dfa9ffb-925b-4265-9dd7-2cb032820b07", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("3dfa9ffb-925b-4265-9dd7-2cb032820b07", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_brokers/9fd08b6f-a836-4f9a-82e8-3a05b0fa8c5b", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-07T09:17:13Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2230", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("https://foo.com/url-99", TestUtil.ToTestableString(obj[1].BrokerUrl), true);
                Assert.AreEqual("auth_username-74", TestUtil.ToTestableString(obj[1].AuthUsername), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].SpaceGuid), true);
                Assert.AreEqual("3dfa9ffb-925b-4265-9dd7-2cb032820b07", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_brokers/cbc91c6c-b9f6-4eed-832b-c96c6d8252f6", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-07T09:17:13Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2231", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("https://foo.com/url-100", TestUtil.ToTestableString(obj[2].BrokerUrl), true);
                Assert.AreEqual("auth_username-75", TestUtil.ToTestableString(obj[2].AuthUsername), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].SpaceGuid), true);

            }
        }

        [TestMethod]
        public void RetrieveServiceBrokerTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""99ee500c-f89c-43bc-bcf8-ba2cb31fd16e"",
    ""url"": ""/v2/service_brokers/f4aa9598-01dc-4193-af8e-b944ea50c148"",
    ""created_at"": ""2016-07-07T09:17:13Z"",
    ""updated_at"": ""2016-07-07T09:17:13Z""
  },
  ""entity"": {
    ""name"": ""name-2211"",
    ""broker_url"": ""https://foo.com/url-89"",
    ""auth_username"": ""auth_username-64"",
    ""space_guid"": ""99ee500c-f89c-43bc-bcf8-ba2cb31fd16e""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceBrokers.RetrieveServiceBroker(guid).Result;


                Assert.AreEqual("99ee500c-f89c-43bc-bcf8-ba2cb31fd16e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_brokers/f4aa9598-01dc-4193-af8e-b944ea50c148", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-07T09:17:13Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-07-07T09:17:13Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2211", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("https://foo.com/url-89", TestUtil.ToTestableString(obj.BrokerUrl), true);
                Assert.AreEqual("auth_username-64", TestUtil.ToTestableString(obj.AuthUsername), true);
                Assert.AreEqual("99ee500c-f89c-43bc-bcf8-ba2cb31fd16e", TestUtil.ToTestableString(obj.SpaceGuid), true);

            }
        }

        [TestMethod]
        public void UpdateServiceBrokerTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""c1569450-4a7f-442c-8507-2cefec35108d"",
    ""created_at"": ""2016-07-07T09:17:13Z"",
    ""updated_at"": ""2016-07-07T09:17:13Z"",
    ""url"": ""/v2/service_brokers/c564be40-e030-4aca-a83f-3b384872d837""
  },
  ""entity"": {
    ""name"": ""name-2223"",
    ""broker_url"": ""https://mybroker.example.com"",
    ""auth_username"": ""admin-user"",
    ""space_guid"": ""c1569450-4a7f-442c-8507-2cefec35108d""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateServiceBrokerRequest value = new UpdateServiceBrokerRequest();


                var obj = cfClient.ServiceBrokers.UpdateServiceBroker(guid, value).Result;


                Assert.AreEqual("c1569450-4a7f-442c-8507-2cefec35108d", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-07-07T09:17:13Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-07-07T09:17:13Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("/v2/service_brokers/c564be40-e030-4aca-a83f-3b384872d837", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("name-2223", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("https://mybroker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
                Assert.AreEqual("admin-user", TestUtil.ToTestableString(obj.AuthUsername), true);
                Assert.AreEqual("c1569450-4a7f-442c-8507-2cefec35108d", TestUtil.ToTestableString(obj.SpaceGuid), true);

            }
        }

    }
}