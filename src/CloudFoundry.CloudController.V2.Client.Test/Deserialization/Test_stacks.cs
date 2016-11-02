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
    ""guid"": ""49e4d681-65f4-48ee-ac05-bff30b7aa1cc"",
    ""url"": ""/v2/stacks/f1f3e79b-3f4f-401c-a64a-84eac6188b18"",
    ""created_at"": ""2016-10-12T12:29:19Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""cflinuxfs2"",
    ""description"": ""cflinuxfs2""
  }
}";

            RetrieveStackResponse obj = Utilities.DeserializeJson<RetrieveStackResponse>(json);

            Assert.AreEqual("49e4d681-65f4-48ee-ac05-bff30b7aa1cc", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/f1f3e79b-3f4f-401c-a64a-84eac6188b18", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:19Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj.Description), true);
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
        ""guid"": ""33f8a512-2099-4107-9b22-0f860c4437a2"",
        ""url"": ""/v2/stacks/f1f3e79b-3f4f-401c-a64a-84eac6188b18"",
        ""created_at"": ""2016-10-12T12:29:19Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cflinuxfs2"",
        ""description"": ""cflinuxfs2""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""33f8a512-2099-4107-9b22-0f860c4437a2"",
        ""url"": ""/v2/stacks/41f7c466-57d1-4c13-81a8-880e8441afed"",
        ""created_at"": ""2016-10-12T12:29:19Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default-stack-name"",
        ""description"": ""default-stack-description""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""33f8a512-2099-4107-9b22-0f860c4437a2"",
        ""url"": ""/v2/stacks/e7c58ec9-cef4-4bec-a901-ee007ebc432c"",
        ""created_at"": ""2016-10-12T12:29:19Z"",
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
            Assert.AreEqual("33f8a512-2099-4107-9b22-0f860c4437a2", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/f1f3e79b-3f4f-401c-a64a-84eac6188b18", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:19Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("33f8a512-2099-4107-9b22-0f860c4437a2", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/41f7c466-57d1-4c13-81a8-880e8441afed", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:19Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("default-stack-name", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("default-stack-description", TestUtil.ToTestableString(page[1].Description), true);
            Assert.AreEqual("33f8a512-2099-4107-9b22-0f860c4437a2", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/e7c58ec9-cef4-4bec-a901-ee007ebc432c", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:19Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("cider", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("cider-description", TestUtil.ToTestableString(page[2].Description), true);
        }

        [TestMethod]
        public void TestCreateStackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""365c5254-91f1-44e5-b361-6c3190438e68"",
    ""url"": ""/v2/stacks/de3b6853-2640-41fd-827c-ff8e3f0e1761"",
    ""created_at"": ""2016-10-12T12:29:38Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example_stack"",
    ""description"": ""Description for the example stack""
  }
}";

            CreateStackResponse obj = Utilities.DeserializeJson<CreateStackResponse>(json);

            Assert.AreEqual("365c5254-91f1-44e5-b361-6c3190438e68", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/de3b6853-2640-41fd-827c-ff8e3f0e1761", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-10-12T12:29:38Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("example_stack", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("Description for the example stack", TestUtil.ToTestableString(obj.Description), true);
        }
    }
}
