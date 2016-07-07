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
    public class AppUsageEventsTest
    {


        [TestMethod]
        public void TestListAllAppUsageEventsResponse()
        {
            string json = @"{
  ""total_results"": 2,
  ""total_pages"": 2,
  ""prev_url"": null,
  ""next_url"": ""/v2/app_usage_events?after_guid=05ebb6c2-d18c-472a-a482-f1cc16df85dc=asc=2=1"",
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""cec0287e-272d-4248-bd2d-30b82c9dfed9"",
        ""url"": ""/v2/app_usage_events/ca7e06c6-d642-429b-9977-d43852836a2d"",
        ""created_at"": ""2016-07-07T09:17:18Z""
      },
      ""entity"": {
        ""state"": ""STARTED"",
        ""memory_in_mb_per_instance"": 564,
        ""instance_count"": 1,
        ""app_guid"": ""cec0287e-272d-4248-bd2d-30b82c9dfed9"",
        ""app_name"": ""name-2497"",
        ""space_guid"": ""cec0287e-272d-4248-bd2d-30b82c9dfed9"",
        ""space_name"": ""name-2498"",
        ""org_guid"": ""cec0287e-272d-4248-bd2d-30b82c9dfed9"",
        ""buildpack_guid"": ""cec0287e-272d-4248-bd2d-30b82c9dfed9"",
        ""buildpack_name"": ""name-2499"",
        ""package_state"": ""STAGED"",
        ""parent_app_guid"": null,
        ""parent_app_name"": null,
        ""process_type"": ""web""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllAppUsageEventsResponse> page = Utilities.DeserializePage<ListAllAppUsageEventsResponse>(json, null);

            Assert.AreEqual("2", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("2", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("/v2/app_usage_events?after_guid=05ebb6c2-d18c-472a-a482-f1cc16df85dc=asc=2=1", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("cec0287e-272d-4248-bd2d-30b82c9dfed9", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/app_usage_events/ca7e06c6-d642-429b-9977-d43852836a2d", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:17:18Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("STARTED", TestUtil.ToTestableString(page[0].State), true);
            Assert.AreEqual("564", TestUtil.ToTestableString(page[0].MemoryInMbPerInstance), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page[0].InstanceCount), true);
            Assert.AreEqual("cec0287e-272d-4248-bd2d-30b82c9dfed9", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("name-2497", TestUtil.ToTestableString(page[0].AppName), true);
            Assert.AreEqual("cec0287e-272d-4248-bd2d-30b82c9dfed9", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("name-2498", TestUtil.ToTestableString(page[0].SpaceName), true);
            Assert.AreEqual("cec0287e-272d-4248-bd2d-30b82c9dfed9", TestUtil.ToTestableString(page[0].OrgGuid), true);
            Assert.AreEqual("cec0287e-272d-4248-bd2d-30b82c9dfed9", TestUtil.ToTestableString(page[0].BuildpackGuid), true);
            Assert.AreEqual("name-2499", TestUtil.ToTestableString(page[0].BuildpackName), true);
            Assert.AreEqual("STAGED", TestUtil.ToTestableString(page[0].PackageState), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].ParentAppGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].ParentAppName), true);
            Assert.AreEqual("web", TestUtil.ToTestableString(page[0].ProcessType), true);
        }

        [TestMethod]
        public void TestRetrieveAppUsageEventResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""b969f296-eb3d-4e17-b2f9-93983babf28b"",
    ""url"": ""/v2/app_usage_events/aa177097-ed40-44c6-846b-5e662b157009"",
    ""created_at"": ""2016-07-07T09:17:18Z""
  },
  ""entity"": {
    ""state"": ""STARTED"",
    ""memory_in_mb_per_instance"": 564,
    ""instance_count"": 1,
    ""app_guid"": ""b969f296-eb3d-4e17-b2f9-93983babf28b"",
    ""app_name"": ""name-2503"",
    ""space_guid"": ""b969f296-eb3d-4e17-b2f9-93983babf28b"",
    ""space_name"": ""name-2504"",
    ""org_guid"": ""b969f296-eb3d-4e17-b2f9-93983babf28b"",
    ""buildpack_guid"": ""b969f296-eb3d-4e17-b2f9-93983babf28b"",
    ""buildpack_name"": ""name-2505"",
    ""package_state"": ""STAGED"",
    ""parent_app_guid"": null,
    ""parent_app_name"": null,
    ""process_type"": ""web""
  }
}";

            RetrieveAppUsageEventResponse obj = Utilities.DeserializeJson<RetrieveAppUsageEventResponse>(json);

            Assert.AreEqual("b969f296-eb3d-4e17-b2f9-93983babf28b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/app_usage_events/aa177097-ed40-44c6-846b-5e662b157009", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:17:18Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("STARTED", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("564", TestUtil.ToTestableString(obj.MemoryInMbPerInstance), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.InstanceCount), true);
            Assert.AreEqual("b969f296-eb3d-4e17-b2f9-93983babf28b", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("name-2503", TestUtil.ToTestableString(obj.AppName), true);
            Assert.AreEqual("b969f296-eb3d-4e17-b2f9-93983babf28b", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("name-2504", TestUtil.ToTestableString(obj.SpaceName), true);
            Assert.AreEqual("b969f296-eb3d-4e17-b2f9-93983babf28b", TestUtil.ToTestableString(obj.OrgGuid), true);
            Assert.AreEqual("b969f296-eb3d-4e17-b2f9-93983babf28b", TestUtil.ToTestableString(obj.BuildpackGuid), true);
            Assert.AreEqual("name-2505", TestUtil.ToTestableString(obj.BuildpackName), true);
            Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj.PackageState), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ParentAppGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ParentAppName), true);
            Assert.AreEqual("web", TestUtil.ToTestableString(obj.ProcessType), true);
        }
    }
}
