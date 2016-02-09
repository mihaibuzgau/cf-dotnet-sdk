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
    public class ServicesTest
    {

        [TestMethod]
        public void TestUpdateServiceDeprecatedRequest()
        {
            string json = @"{
  ""label"": ""SomeMysqlService"",
  ""description"": ""Mysql stores things for you"",
  ""provider"": ""MySql Provider"",
  ""version"": ""2.0"",
  ""url"": ""http://myql.provider.com""
}";

            UpdateServiceDeprecatedRequest request = new UpdateServiceDeprecatedRequest();

            request.Label = "SomeMysqlService";
            request.Description = "Mysql stores things for you";
            request.Provider = "MySql Provider";
            request.Version = "2.0";
            request.Url = "http://myql.provider.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateServiceDeprecatedRequest()
        {
            string json = @"{
  ""label"": ""SomeMysqlService"",
  ""description"": ""Mysql stores things for you"",
  ""provider"": ""MySql Provider"",
  ""version"": ""2.0"",
  ""url"": ""http://myql.provider.com""
}";

            CreateServiceDeprecatedRequest request = new CreateServiceDeprecatedRequest();

            request.Label = "SomeMysqlService";
            request.Description = "Mysql stores things for you";
            request.Provider = "MySql Provider";
            request.Version = "2.0";
            request.Url = "http://myql.provider.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
