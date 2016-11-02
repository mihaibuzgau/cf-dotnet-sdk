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
    public class SharedDomainsEndpoint
{
        [TestMethod]
        public void ListAllSharedDomainsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 6,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""b3384999-559c-44e2-8422-7d464a4e21c4"",
        ""url"": ""/v2/shared_domains/a3be3c42-326d-483e-8bb2-bd498a9d1a8e"",
        ""created_at"": ""2016-10-12T12:29:07Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain1.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b3384999-559c-44e2-8422-7d464a4e21c4"",
        ""url"": ""/v2/shared_domains/e9086ebb-0598-438c-804d-31c04f53b252"",
        ""created_at"": ""2016-10-12T12:29:07Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain2.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b3384999-559c-44e2-8422-7d464a4e21c4"",
        ""url"": ""/v2/shared_domains/8a0c9e0a-a434-4f92-862b-7a260ce1bec2"",
        ""created_at"": ""2016-10-12T12:29:15Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-36.example.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b3384999-559c-44e2-8422-7d464a4e21c4"",
        ""url"": ""/v2/shared_domains/7418712e-d327-4a30-893c-5c881d6adcc6"",
        ""created_at"": ""2016-10-12T12:29:15Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-37.example.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b3384999-559c-44e2-8422-7d464a4e21c4"",
        ""url"": ""/v2/shared_domains/00936a7d-18f3-4666-b764-ed205e1f2c99"",
        ""created_at"": ""2016-10-12T12:29:15Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-38.example.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b3384999-559c-44e2-8422-7d464a4e21c4"",
        ""url"": ""/v2/shared_domains/3f3200f9-e2fe-4be6-9db3-7b0fc2f2babd"",
        ""created_at"": ""2016-10-12T12:29:15Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-39.example.com"",
        ""router_group_guid"": ""b3384999-559c-44e2-8422-7d464a4e21c4"",
        ""router_group_type"": ""tcp""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SharedDomains.ListAllSharedDomains().Result;

                Assert.AreEqual("6", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("b3384999-559c-44e2-8422-7d464a4e21c4", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/a3be3c42-326d-483e-8bb2-bd498a9d1a8e", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:07Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].RouterGroupType), true);
                Assert.AreEqual("b3384999-559c-44e2-8422-7d464a4e21c4", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/e9086ebb-0598-438c-804d-31c04f53b252", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:07Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain2.com", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].RouterGroupType), true);
                Assert.AreEqual("b3384999-559c-44e2-8422-7d464a4e21c4", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/8a0c9e0a-a434-4f92-862b-7a260ce1bec2", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:15Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-36.example.com", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].RouterGroupType), true);
                Assert.AreEqual("b3384999-559c-44e2-8422-7d464a4e21c4", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/7418712e-d327-4a30-893c-5c881d6adcc6", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:15Z", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-37.example.com", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].RouterGroupType), true);
                Assert.AreEqual("b3384999-559c-44e2-8422-7d464a4e21c4", TestUtil.ToTestableString(obj[4].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/00936a7d-18f3-4666-b764-ed205e1f2c99", TestUtil.ToTestableString(obj[4].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:15Z", TestUtil.ToTestableString(obj[4].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-38.example.com", TestUtil.ToTestableString(obj[4].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].RouterGroupType), true);
                Assert.AreEqual("b3384999-559c-44e2-8422-7d464a4e21c4", TestUtil.ToTestableString(obj[5].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/3f3200f9-e2fe-4be6-9db3-7b0fc2f2babd", TestUtil.ToTestableString(obj[5].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:15Z", TestUtil.ToTestableString(obj[5].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[5].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-39.example.com", TestUtil.ToTestableString(obj[5].Name), true);
                Assert.AreEqual("b3384999-559c-44e2-8422-7d464a4e21c4", TestUtil.ToTestableString(obj[5].RouterGroupGuid), true);
                Assert.AreEqual("tcp", TestUtil.ToTestableString(obj[5].RouterGroupType), true);

            }
        }

        [TestMethod]
        public void RetrieveSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""c3467d56-4cec-45a1-a493-d91a43c3566b"",
    ""url"": ""/v2/shared_domains/a3be3c42-326d-483e-8bb2-bd498a9d1a8e"",
    ""created_at"": ""2016-10-12T12:29:07Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""customer-app-domain1.com"",
    ""router_group_guid"": null,
    ""router_group_type"": null
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SharedDomains.RetrieveSharedDomain(guid).Result;


                Assert.AreEqual("c3467d56-4cec-45a1-a493-d91a43c3566b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/a3be3c42-326d-483e-8bb2-bd498a9d1a8e", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:07Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouterGroupType), true);

            }
        }

        [TestMethod]
        public void CreateSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""e6b3a8fb-8fbc-43fc-9979-1c9aa5ce0d46"",
    ""url"": ""/v2/shared_domains/b700f2f7-dc88-42ee-9017-5129a854405b"",
    ""created_at"": ""2016-10-12T12:29:16Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example.com"",
    ""router_group_guid"": ""e6b3a8fb-8fbc-43fc-9979-1c9aa5ce0d46"",
    ""router_group_type"": ""tcp""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSharedDomainRequest value = new CreateSharedDomainRequest();


                var obj = cfClient.SharedDomains.CreateSharedDomain(value).Result;


                Assert.AreEqual("e6b3a8fb-8fbc-43fc-9979-1c9aa5ce0d46", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/b700f2f7-dc88-42ee-9017-5129a854405b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("example.com", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("e6b3a8fb-8fbc-43fc-9979-1c9aa5ce0d46", TestUtil.ToTestableString(obj.RouterGroupGuid), true);
                Assert.AreEqual("tcp", TestUtil.ToTestableString(obj.RouterGroupType), true);

            }
        }

        [TestMethod]
        public void FilterSharedDomainsByNameTest()
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
        ""guid"": ""88d5b506-0f66-420f-8445-dd2bb3c9a755"",
        ""url"": ""/v2/shared_domains/ff4a75ce-bc59-47f7-b061-85cca41ec2cf"",
        ""created_at"": ""2016-10-12T12:29:16Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""shared-domain.com"",
        ""router_group_guid"": ""88d5b506-0f66-420f-8445-dd2bb3c9a755"",
        ""router_group_type"": ""tcp""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SharedDomains.FilterSharedDomainsByName().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("88d5b506-0f66-420f-8445-dd2bb3c9a755", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/ff4a75ce-bc59-47f7-b061-85cca41ec2cf", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:16Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("shared-domain.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("88d5b506-0f66-420f-8445-dd2bb3c9a755", TestUtil.ToTestableString(obj[0].RouterGroupGuid), true);
                Assert.AreEqual("tcp", TestUtil.ToTestableString(obj[0].RouterGroupType), true);

            }
        }

        [TestMethod]
        public void DeleteSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SharedDomains.DeleteSharedDomain(guid).Wait();

            }
        }

    }
}