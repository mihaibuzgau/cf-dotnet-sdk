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
    public class SecurityGroupStagingDefaultsTest
    {


        [TestMethod]
        public void TestSetSecurityGroupAsDefaultForStagingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""4fe45b13-ad01-42ff-92c9-83b3b4f64055"",
    ""url"": ""/v2/config/staging_security_groups/4fe45b13-ad01-42ff-92c9-83b3b4f64055"",
    ""created_at"": ""2015-04-16T12:04:13+00:00"",
    ""updated_at"": ""2015-04-16T12:04:13+00:00""
  },
  ""entity"": {
    ""name"": ""name-1"",
    ""rules"": [
      {
        ""protocol"": ""udp"",
        ""ports"": ""8080"",
        ""destination"": ""198.41.191.47/1""
      }
    ],
    ""running_default"": false,
    ""staging_default"": true
  }
}";

            SetSecurityGroupAsDefaultForStagingResponse obj = Utilities.DeserializeJson<SetSecurityGroupAsDefaultForStagingResponse>(json);

            Assert.AreEqual("4fe45b13-ad01-42ff-92c9-83b3b4f64055", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/staging_security_groups/4fe45b13-ad01-42ff-92c9-83b3b4f64055", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:13+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-04-16T12:04:13+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.StagingDefault), true);
        }

        [TestMethod]
        public void TestReturnSecurityGroupsUsedForStagingResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""865d9002-320a-4270-b278-2812e00a4a5a"",
        ""url"": ""/v2/config/staging_security_groups/865d9002-320a-4270-b278-2812e00a4a5a"",
        ""created_at"": ""2015-04-16T12:04:13+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-4"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": true
      }
    }
  ]
}";

            PagedResponseCollection<ReturnSecurityGroupsUsedForStagingResponse> page = Utilities.DeserializePage<ReturnSecurityGroupsUsedForStagingResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("865d9002-320a-4270-b278-2812e00a4a5a", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/staging_security_groups/865d9002-320a-4270-b278-2812e00a4a5a", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:13+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-4", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].StagingDefault), true);
        }
    }
}
