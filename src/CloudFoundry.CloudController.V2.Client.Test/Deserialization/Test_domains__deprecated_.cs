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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class DomainsDeprecatedTest
    {


        [TestMethod]
        public void TestListAllSpacesForDomainDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""aba0e54a-87d3-4e8c-a26b-0cdf040ecf34"",
        ""url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34"",
        ""created_at"": ""2015-04-16T12:04:24+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-495"",
        ""organization_guid"": ""42619a4e-4a56-4776-a5d3-2ec762ac6b20"",
        ""space_quota_definition_guid"": null,
        ""organization_url"": ""/v2/organizations/42619a4e-4a56-4776-a5d3-2ec762ac6b20"",
        ""developers_url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/developers"",
        ""managers_url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/managers"",
        ""auditors_url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/auditors"",
        ""apps_url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/apps"",
        ""routes_url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/routes"",
        ""domains_url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/domains"",
        ""service_instances_url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/service_instances"",
        ""app_events_url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/app_events"",
        ""events_url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/events"",
        ""security_groups_url"": ""/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/security_groups""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSpacesForDomainDeprecatedResponse> page = Utilities.DeserializePage<ListAllSpacesForDomainDeprecatedResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("aba0e54a-87d3-4e8c-a26b-0cdf040ecf34", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:24+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-495", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("42619a4e-4a56-4776-a5d3-2ec762ac6b20", TestUtil.ToTestableString(page[0].OrganizationGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionGuid), true);
            Assert.AreEqual("/v2/organizations/42619a4e-4a56-4776-a5d3-2ec762ac6b20", TestUtil.ToTestableString(page[0].OrganizationUrl), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/developers", TestUtil.ToTestableString(page[0].DevelopersUrl), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/managers", TestUtil.ToTestableString(page[0].ManagersUrl), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/auditors", TestUtil.ToTestableString(page[0].AuditorsUrl), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/domains", TestUtil.ToTestableString(page[0].DomainsUrl), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/app_events", TestUtil.ToTestableString(page[0].AppEventsUrl), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
            Assert.AreEqual("/v2/spaces/aba0e54a-87d3-4e8c-a26b-0cdf040ecf34/security_groups", TestUtil.ToTestableString(page[0].SecurityGroupsUrl), true);
        }

        [TestMethod]
        public void TestListAllDomainsDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""0210f9ef-64f7-48c4-b37e-5cd5e4080da5"",
        ""url"": ""/v2/domains/0210f9ef-64f7-48c4-b37e-5cd5e4080da5"",
        ""created_at"": ""2015-04-16T12:04:14+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain1.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""0359e25a-338d-42e0-ac6c-f7fc3dd3032d"",
        ""url"": ""/v2/domains/0359e25a-338d-42e0-ac6c-f7fc3dd3032d"",
        ""created_at"": ""2015-04-16T12:04:14+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain2.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""face0158-42ca-4003-8a48-d1c56a793ac8"",
        ""url"": ""/v2/domains/face0158-42ca-4003-8a48-d1c56a793ac8"",
        ""created_at"": ""2015-04-16T12:04:14+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""68378f1b-b6b1-4b89-8614-ff80330b6ae0"",
        ""owning_organization_url"": ""/v2/organizations/68378f1b-b6b1-4b89-8614-ff80330b6ae0"",
        ""spaces_url"": ""/v2/domains/face0158-42ca-4003-8a48-d1c56a793ac8/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""2696bbe0-2fea-46ff-8d8b-bd49846eb93f"",
        ""url"": ""/v2/domains/2696bbe0-2fea-46ff-8d8b-bd49846eb93f"",
        ""created_at"": ""2015-04-16T12:04:24+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-27.example.com""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllDomainsDeprecatedResponse> page = Utilities.DeserializePage<ListAllDomainsDeprecatedResponse>(json, null);

            Assert.AreEqual("4", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("0210f9ef-64f7-48c4-b37e-5cd5e4080da5", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/0210f9ef-64f7-48c4-b37e-5cd5e4080da5", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("0359e25a-338d-42e0-ac6c-f7fc3dd3032d", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/0359e25a-338d-42e0-ac6c-f7fc3dd3032d", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("customer-app-domain2.com", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("face0158-42ca-4003-8a48-d1c56a793ac8", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/face0158-42ca-4003-8a48-d1c56a793ac8", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("68378f1b-b6b1-4b89-8614-ff80330b6ae0", TestUtil.ToTestableString(page[2].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/68378f1b-b6b1-4b89-8614-ff80330b6ae0", TestUtil.ToTestableString(page[2].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/domains/face0158-42ca-4003-8a48-d1c56a793ac8/spaces", TestUtil.ToTestableString(page[2].SpacesUrl), true);
            Assert.AreEqual("2696bbe0-2fea-46ff-8d8b-bd49846eb93f", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/2696bbe0-2fea-46ff-8d8b-bd49846eb93f", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:24+00:00", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-27.example.com", TestUtil.ToTestableString(page[3].Name), true);
        }

        [TestMethod]
        public void TestCreatesDomainOwnedByGivenOrganizationDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ec4741e3-3288-4046-810d-d8f72144e558"",
    ""url"": ""/v2/domains/ec4741e3-3288-4046-810d-d8f72144e558"",
    ""created_at"": ""2015-04-16T12:04:24+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""04638947-e98f-413d-b6a9-64259b0c43b0"",
    ""owning_organization_url"": ""/v2/organizations/04638947-e98f-413d-b6a9-64259b0c43b0"",
    ""spaces_url"": ""/v2/domains/ec4741e3-3288-4046-810d-d8f72144e558/spaces""
  }
}";

            CreatesDomainOwnedByGivenOrganizationDeprecatedResponse obj = Utilities.DeserializeJson<CreatesDomainOwnedByGivenOrganizationDeprecatedResponse>(json);

            Assert.AreEqual("ec4741e3-3288-4046-810d-d8f72144e558", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/ec4741e3-3288-4046-810d-d8f72144e558", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:24+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("04638947-e98f-413d-b6a9-64259b0c43b0", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/04638947-e98f-413d-b6a9-64259b0c43b0", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/domains/ec4741e3-3288-4046-810d-d8f72144e558/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestRetrieveDomainDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""391b3c51-cc5a-49b2-8594-deb08899ceaa"",
    ""url"": ""/v2/domains/391b3c51-cc5a-49b2-8594-deb08899ceaa"",
    ""created_at"": ""2015-04-16T12:04:24+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""domain-29.example.com""
  }
}";

            RetrieveDomainDeprecatedResponse obj = Utilities.DeserializeJson<RetrieveDomainDeprecatedResponse>(json);

            Assert.AreEqual("391b3c51-cc5a-49b2-8594-deb08899ceaa", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/391b3c51-cc5a-49b2-8594-deb08899ceaa", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:24+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-29.example.com", TestUtil.ToTestableString(obj.Name), true);
        }

        [TestMethod]
        public void TestCreatesSharedDomainDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""31523876-ceec-436d-9c09-81a40a468668"",
    ""url"": ""/v2/domains/31523876-ceec-436d-9c09-81a40a468668"",
    ""created_at"": ""2015-04-16T12:04:24+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example.com"",
    ""owning_organization_guid"": null
  }
}";

            CreatesSharedDomainDeprecatedResponse obj = Utilities.DeserializeJson<CreatesSharedDomainDeprecatedResponse>(json);

            Assert.AreEqual("31523876-ceec-436d-9c09-81a40a468668", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/31523876-ceec-436d-9c09-81a40a468668", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:24+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("example.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
        }
    }
}
