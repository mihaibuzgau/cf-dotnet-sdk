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
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class EnvironmentVariableGroupsTest
    {

        [TestMethod]
        public void TestUpdateContentsOfRunningEnvironmentVariableGroupRequest()
        {
            string json = @"{
  ""abc"": 123,
  ""do-re-me"": ""far-so-la-tee""
}";

            UpdateContentsOfRunningEnvironmentVariableGroupRequest request = new UpdateContentsOfRunningEnvironmentVariableGroupRequest();

            request.Abc = 123;
            request.Doreme = "far-so-la-tee";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestUpdateContentsOfStagingEnvironmentVariableGroupRequest()
        {
            string json = @"{
  ""abc"": 123,
  ""do-re-me"": ""far-so-la-tee""
}";

            UpdateContentsOfStagingEnvironmentVariableGroupRequest request = new UpdateContentsOfStagingEnvironmentVariableGroupRequest();

            request.Abc = 123;
            request.Doreme = "far-so-la-tee";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
