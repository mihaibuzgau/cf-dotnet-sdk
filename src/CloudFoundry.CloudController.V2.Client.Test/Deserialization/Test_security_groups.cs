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
    public class SecurityGroupsTest
    {


        [TestMethod]
        public void TestUpdateSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""1930582f-3797-4e14-be2a-a134384a86c9"",
    ""url"": ""/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9"",
    ""created_at"": ""2016-02-09T10:21:53Z"",
    ""updated_at"": ""2016-02-09T10:21:57Z""
  },
  ""entity"": {
    ""name"": ""new_name"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9/spaces""
  }
}";

            UpdateSecurityGroupResponse obj = Utilities.DeserializeJson<UpdateSecurityGroupResponse>(json);

            Assert.AreEqual("1930582f-3797-4e14-be2a-a134384a86c9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:53Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-09T10:21:57Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("new_name", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestListAllSecurityGroupsResponse()
        {
            string json = @"{
  ""total_results"": 5,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""1930582f-3797-4e14-be2a-a134384a86c9"",
        ""url"": ""/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9"",
        ""created_at"": ""2016-02-09T10:21:53Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy1"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""c01b657f-b2cc-4e87-9329-1e84511f3b20"",
        ""url"": ""/v2/security_groups/c01b657f-b2cc-4e87-9329-1e84511f3b20"",
        ""created_at"": ""2016-02-09T10:21:53Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy2"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/c01b657f-b2cc-4e87-9329-1e84511f3b20/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""df1bc2f3-c7d7-4128-9fc7-6b90b86c674f"",
        ""url"": ""/v2/security_groups/df1bc2f3-c7d7-4128-9fc7-6b90b86c674f"",
        ""created_at"": ""2016-02-09T10:21:57Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2098"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/df1bc2f3-c7d7-4128-9fc7-6b90b86c674f/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""f2114d11-d106-45a1-a882-406293d2237c"",
        ""url"": ""/v2/security_groups/f2114d11-d106-45a1-a882-406293d2237c"",
        ""created_at"": ""2016-02-09T10:21:57Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2099"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/f2114d11-d106-45a1-a882-406293d2237c/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""9669acd1-37d5-4ff3-a3ec-e825558e4f13"",
        ""url"": ""/v2/security_groups/9669acd1-37d5-4ff3-a3ec-e825558e4f13"",
        ""created_at"": ""2016-02-09T10:21:57Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2100"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/9669acd1-37d5-4ff3-a3ec-e825558e4f13/spaces""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSecurityGroupsResponse> page = Utilities.DeserializePage<ListAllSecurityGroupsResponse>(json, null);

            Assert.AreEqual("5", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("1930582f-3797-4e14-be2a-a134384a86c9", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:53Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9/spaces", TestUtil.ToTestableString(page[0].SpacesUrl), true);
            Assert.AreEqual("c01b657f-b2cc-4e87-9329-1e84511f3b20", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/c01b657f-b2cc-4e87-9329-1e84511f3b20", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:53Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy2", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[1].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[1].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/c01b657f-b2cc-4e87-9329-1e84511f3b20/spaces", TestUtil.ToTestableString(page[1].SpacesUrl), true);
            Assert.AreEqual("df1bc2f3-c7d7-4128-9fc7-6b90b86c674f", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/df1bc2f3-c7d7-4128-9fc7-6b90b86c674f", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:57Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2098", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[2].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[2].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/df1bc2f3-c7d7-4128-9fc7-6b90b86c674f/spaces", TestUtil.ToTestableString(page[2].SpacesUrl), true);
            Assert.AreEqual("f2114d11-d106-45a1-a882-406293d2237c", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/f2114d11-d106-45a1-a882-406293d2237c", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:57Z", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2099", TestUtil.ToTestableString(page[3].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[3].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[3].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/f2114d11-d106-45a1-a882-406293d2237c/spaces", TestUtil.ToTestableString(page[3].SpacesUrl), true);
            Assert.AreEqual("9669acd1-37d5-4ff3-a3ec-e825558e4f13", TestUtil.ToTestableString(page[4].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/9669acd1-37d5-4ff3-a3ec-e825558e4f13", TestUtil.ToTestableString(page[4].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:57Z", TestUtil.ToTestableString(page[4].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[4].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2100", TestUtil.ToTestableString(page[4].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[4].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[4].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/9669acd1-37d5-4ff3-a3ec-e825558e4f13/spaces", TestUtil.ToTestableString(page[4].SpacesUrl), true);
        }

        [TestMethod]
        public void TestRemoveSpaceFromSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""1930582f-3797-4e14-be2a-a134384a86c9"",
    ""url"": ""/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9"",
    ""created_at"": ""2016-02-09T10:21:53Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9/spaces""
  }
}";

            RemoveSpaceFromSecurityGroupResponse obj = Utilities.DeserializeJson<RemoveSpaceFromSecurityGroupResponse>(json);

            Assert.AreEqual("1930582f-3797-4e14-be2a-a134384a86c9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:53Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestAssociateSpaceWithSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""1930582f-3797-4e14-be2a-a134384a86c9"",
    ""url"": ""/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9"",
    ""created_at"": ""2016-02-09T10:21:53Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9/spaces""
  }
}";

            AssociateSpaceWithSecurityGroupResponse obj = Utilities.DeserializeJson<AssociateSpaceWithSecurityGroupResponse>(json);

            Assert.AreEqual("1930582f-3797-4e14-be2a-a134384a86c9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:53Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestCreateSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""8b30c621-401c-4d4a-9d98-f12ebff95d33"",
    ""url"": ""/v2/security_groups/8b30c621-401c-4d4a-9d98-f12ebff95d33"",
    ""created_at"": ""2016-02-09T10:21:57Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my_super_sec_group"",
    ""rules"": [
      {
        ""protocol"": ""icmp"",
        ""destination"": ""0.0.0.0/0"",
        ""type"": 0,
        ""code"": 1
      },
      {
        ""protocol"": ""tcp"",
        ""destination"": ""0.0.0.0/0"",
        ""ports"": ""2048-3000"",
        ""log"": true
      },
      {
        ""protocol"": ""udp"",
        ""destination"": ""0.0.0.0/0"",
        ""ports"": ""53, 5353""
      },
      {
        ""protocol"": ""all"",
        ""destination"": ""0.0.0.0/0""
      }
    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/8b30c621-401c-4d4a-9d98-f12ebff95d33/spaces""
  }
}";

            CreateSecurityGroupResponse obj = Utilities.DeserializeJson<CreateSecurityGroupResponse>(json);

            Assert.AreEqual("8b30c621-401c-4d4a-9d98-f12ebff95d33", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/8b30c621-401c-4d4a-9d98-f12ebff95d33", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:57Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my_super_sec_group", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/8b30c621-401c-4d4a-9d98-f12ebff95d33/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestRetrieveSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""1930582f-3797-4e14-be2a-a134384a86c9"",
    ""url"": ""/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9"",
    ""created_at"": ""2016-02-09T10:21:53Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9/spaces""
  }
}";

            RetrieveSecurityGroupResponse obj = Utilities.DeserializeJson<RetrieveSecurityGroupResponse>(json);

            Assert.AreEqual("1930582f-3797-4e14-be2a-a134384a86c9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:53Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/1930582f-3797-4e14-be2a-a134384a86c9/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestListAllSpacesForSecurityGroupResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""c9e62e71-1e5c-4288-9765-17a8d91da284"",
        ""url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284"",
        ""created_at"": ""2016-02-09T10:21:57Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2092"",
        ""organization_guid"": ""cad81127-e01a-44b3-9c55-fbde2f0acaea"",
        ""space_quota_definition_guid"": null,
        ""organization_url"": ""/v2/organizations/cad81127-e01a-44b3-9c55-fbde2f0acaea"",
        ""developers_url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/developers"",
        ""managers_url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/managers"",
        ""auditors_url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/auditors"",
        ""apps_url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/apps"",
        ""routes_url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/routes"",
        ""domains_url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/domains"",
        ""service_instances_url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/service_instances"",
        ""app_events_url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/app_events"",
        ""events_url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/events"",
        ""security_groups_url"": ""/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/security_groups""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSpacesForSecurityGroupResponse> page = Utilities.DeserializePage<ListAllSpacesForSecurityGroupResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("c9e62e71-1e5c-4288-9765-17a8d91da284", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:57Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2092", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("cad81127-e01a-44b3-9c55-fbde2f0acaea", TestUtil.ToTestableString(page[0].OrganizationGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionGuid), true);
            Assert.AreEqual("/v2/organizations/cad81127-e01a-44b3-9c55-fbde2f0acaea", TestUtil.ToTestableString(page[0].OrganizationUrl), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/developers", TestUtil.ToTestableString(page[0].DevelopersUrl), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/managers", TestUtil.ToTestableString(page[0].ManagersUrl), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/auditors", TestUtil.ToTestableString(page[0].AuditorsUrl), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/domains", TestUtil.ToTestableString(page[0].DomainsUrl), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/app_events", TestUtil.ToTestableString(page[0].AppEventsUrl), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
            Assert.AreEqual("/v2/spaces/c9e62e71-1e5c-4288-9765-17a8d91da284/security_groups", TestUtil.ToTestableString(page[0].SecurityGroupsUrl), true);
        }
    }
}
