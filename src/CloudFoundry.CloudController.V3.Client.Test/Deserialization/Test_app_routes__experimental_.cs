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

using CloudFoundry.CloudController.V3.Client;
using CloudFoundry.CloudController.V3.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V3.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class AppRoutesExperimentalTest
    {


        [TestMethod]
        public void TestListRoutesResponse()
        {
            string json = @"{
  ""pagination"": {
    ""total_results"": 2,
    ""first"": {
      ""href"": ""/v3/apps/09381e34-521c-4d95-a3b6-c5b1a4a5e0f6/routes?page=1=50""
    },
    ""last"": {
      ""href"": ""/v3/apps/09381e34-521c-4d95-a3b6-c5b1a4a5e0f6/routes?page=1=50""
    },
    ""next"": null,
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""cc3cffe0-c750-4e49-8a9f-dc8d4708662b"",
      ""host"": ""host-6"",
      ""path"": """",
      ""created_at"": ""2016-02-11T13:20:32Z"",
      ""updated_at"": null,
      ""links"": {
        ""space"": {
          ""href"": ""/v2/spaces/9920bee5-ab70-4a63-8799-ee11a570bb4d""
        },
        ""domain"": {
          ""href"": ""/v2/domains/3f07f69d-9f3c-4893-b097-dc8634d5feb7""
        }
      }
    },
    {
      ""guid"": ""cc3cffe0-c750-4e49-8a9f-dc8d4708662b"",
      ""host"": ""host-7"",
      ""path"": ""/foo/bar"",
      ""created_at"": ""2016-02-11T13:20:32Z"",
      ""updated_at"": null,
      ""links"": {
        ""space"": {
          ""href"": ""/v2/spaces/9920bee5-ab70-4a63-8799-ee11a570bb4d""
        },
        ""domain"": {
          ""href"": ""/v2/domains/113857b5-715c-4511-b308-c3811aacbf83""
        }
      }
    }
  ]
}";

            PagedResponseCollection<ListRoutesResponse> page = Utilities.DeserializePage<ListRoutesResponse>(json, null);

            Assert.AreEqual("cc3cffe0-c750-4e49-8a9f-dc8d4708662b", TestUtil.ToTestableString(page[0].Guid), true);
            Assert.AreEqual("host-6", TestUtil.ToTestableString(page[0].Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Path), true);
            Assert.AreEqual("2016-02-11T13:20:32Z", TestUtil.ToTestableString(page[0].CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].UpdatedAt), true);
            Assert.AreEqual("cc3cffe0-c750-4e49-8a9f-dc8d4708662b", TestUtil.ToTestableString(page[1].Guid), true);
            Assert.AreEqual("host-7", TestUtil.ToTestableString(page[1].Host), true);
            Assert.AreEqual("/foo/bar", TestUtil.ToTestableString(page[1].Path), true);
            Assert.AreEqual("2016-02-11T13:20:32Z", TestUtil.ToTestableString(page[1].CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].UpdatedAt), true);
        }
    }
}