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
    public class StacksTest
    {


        [TestMethod]
        public void TestRetrieveStackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""51bd9f3b-b57e-466f-9e93-5c3064a44bdd"",
    ""url"": ""/v2/stacks/51bd9f3b-b57e-466f-9e93-5c3064a44bdd"",
    ""created_at"": ""2015-04-16T12:04:14+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""lucid64"",
    ""description"": ""Ubuntu 10.04 on x86-64""
  }
}";

            RetrieveStackResponse obj = Utilities.DeserializeJson<RetrieveStackResponse>(json);

            Assert.AreEqual("51bd9f3b-b57e-466f-9e93-5c3064a44bdd", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/51bd9f3b-b57e-466f-9e93-5c3064a44bdd", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("lucid64", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("Ubuntu 10.04 on x86-64", TestUtil.ToTestableString(obj.Description), true);
        }

        [TestMethod]
        public void TestListAllStacksResponse()
        {
            string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""51bd9f3b-b57e-466f-9e93-5c3064a44bdd"",
        ""url"": ""/v2/stacks/51bd9f3b-b57e-466f-9e93-5c3064a44bdd"",
        ""created_at"": ""2015-04-16T12:04:14+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""lucid64"",
        ""description"": ""Ubuntu 10.04 on x86-64""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""ae5f9659-37ed-4857-9152-ac98fb8076d9"",
        ""url"": ""/v2/stacks/ae5f9659-37ed-4857-9152-ac98fb8076d9"",
        ""created_at"": ""2015-04-16T12:04:14+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default-stack-name"",
        ""description"": ""default-stack-description""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""e0e2d13f-fabd-461e-bd6b-7c0c2328e189"",
        ""url"": ""/v2/stacks/e0e2d13f-fabd-461e-bd6b-7c0c2328e189"",
        ""created_at"": ""2015-04-16T12:04:14+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cider"",
        ""description"": ""cider-description""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllStacksResponse> page = Utilities.DeserializePage<ListAllStacksResponse>(json, null);

            Assert.AreEqual("3", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("51bd9f3b-b57e-466f-9e93-5c3064a44bdd", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/51bd9f3b-b57e-466f-9e93-5c3064a44bdd", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("lucid64", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("Ubuntu 10.04 on x86-64", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("ae5f9659-37ed-4857-9152-ac98fb8076d9", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/ae5f9659-37ed-4857-9152-ac98fb8076d9", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("default-stack-name", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("default-stack-description", TestUtil.ToTestableString(page[1].Description), true);
            Assert.AreEqual("e0e2d13f-fabd-461e-bd6b-7c0c2328e189", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/e0e2d13f-fabd-461e-bd6b-7c0c2328e189", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("cider", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("cider-description", TestUtil.ToTestableString(page[2].Description), true);
        }
    }
}
