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
    public class JobsTest
    {


        [TestMethod]
        public void TestRetrieveJobThatWasSuccessfulResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""0"",
    ""created_at"": ""1970-01-01T00:00:00+00:00"",
    ""url"": ""/v2/jobs/0""
  },
  ""entity"": {
    ""guid"": ""0"",
    ""status"": ""finished""
  }
}";

            RetrieveJobThatWasSuccessfulResponse obj = Utilities.DeserializeJson<RetrieveJobThatWasSuccessfulResponse>(json);

            Assert.AreEqual("0", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("1970-01-01T00:00:00+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("0", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("finished", TestUtil.ToTestableString(obj.Status), true);
        }

        [TestMethod]
        public void TestRetrieveJobWithKnownFailureResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""46f09aaa-0c76-47d4-a98b-732ea2b2e6f3"",
    ""created_at"": ""2015-04-16T12:04:14+00:00"",
    ""url"": ""/v2/jobs/46f09aaa-0c76-47d4-a98b-732ea2b2e6f3""
  },
  ""entity"": {
    ""guid"": ""46f09aaa-0c76-47d4-a98b-732ea2b2e6f3"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""code"": 1001,
      ""description"": ""Request invalid due to parse error: arbitrary string"",
      ""error_code"": ""CF-MessageParseError""
    }
  }
}";

            RetrieveJobWithKnownFailureResponse obj = Utilities.DeserializeJson<RetrieveJobWithKnownFailureResponse>(json);

            Assert.AreEqual("46f09aaa-0c76-47d4-a98b-732ea2b2e6f3", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/46f09aaa-0c76-47d4-a98b-732ea2b2e6f3", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("46f09aaa-0c76-47d4-a98b-732ea2b2e6f3", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
            Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);
        }

        [TestMethod]
        public void TestRetrieveJobThatIsQueuedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""1bb1e9cf-f093-48f0-98b5-013eafa8cf0f"",
    ""created_at"": ""2015-04-16T12:04:14+00:00"",
    ""url"": ""/v2/jobs/1bb1e9cf-f093-48f0-98b5-013eafa8cf0f""
  },
  ""entity"": {
    ""guid"": ""1bb1e9cf-f093-48f0-98b5-013eafa8cf0f"",
    ""status"": ""queued""
  }
}";

            RetrieveJobThatIsQueuedResponse obj = Utilities.DeserializeJson<RetrieveJobThatIsQueuedResponse>(json);

            Assert.AreEqual("1bb1e9cf-f093-48f0-98b5-013eafa8cf0f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/1bb1e9cf-f093-48f0-98b5-013eafa8cf0f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("1bb1e9cf-f093-48f0-98b5-013eafa8cf0f", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);
        }

        [TestMethod]
        public void TestRetrieveJobWithUnknownFailureResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ee38d37d-ac91-4278-9e54-688ed4f61d07"",
    ""created_at"": ""2015-04-16T12:04:14+00:00"",
    ""url"": ""/v2/jobs/ee38d37d-ac91-4278-9e54-688ed4f61d07""
  },
  ""entity"": {
    ""guid"": ""ee38d37d-ac91-4278-9e54-688ed4f61d07"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""error_code"": ""UnknownError"",
      ""description"": ""An unknown error occurred."",
      ""code"": 10001
    }
  }
}";

            RetrieveJobWithUnknownFailureResponse obj = Utilities.DeserializeJson<RetrieveJobWithUnknownFailureResponse>(json);

            Assert.AreEqual("ee38d37d-ac91-4278-9e54-688ed4f61d07", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/ee38d37d-ac91-4278-9e54-688ed4f61d07", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("ee38d37d-ac91-4278-9e54-688ed4f61d07", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
            Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);
        }
    }
}
