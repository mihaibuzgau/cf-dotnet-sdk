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
    public class SpacesTest
    {

        [TestMethod]
        public void TestAssociateAuditorWithSpaceByUsernameRequest()
        {
            string json = @"{
  ""username"": ""user@example.com""
}";

            AssociateAuditorWithSpaceByUsernameRequest request = new AssociateAuditorWithSpaceByUsernameRequest();

            request.Username = "user@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestAssociateDeveloperWithSpaceByUsernameRequest()
        {
            string json = @"{
  ""username"": ""user@example.com""
}";

            AssociateDeveloperWithSpaceByUsernameRequest request = new AssociateDeveloperWithSpaceByUsernameRequest();

            request.Username = "user@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestAssociateManagerWithSpaceByUsernameRequest()
        {
            string json = @"{
  ""username"": ""user@example.com""
}";

            AssociateManagerWithSpaceByUsernameRequest request = new AssociateManagerWithSpaceByUsernameRequest();

            request.Username = "user@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateSpaceRequest()
        {
            string json = @"{
  ""name"": ""development"",
  ""organization_guid"": ""a30f61da-cd2a-4f15-8f01-08a9a6b128c1""
}";

            CreateSpaceRequest request = new CreateSpaceRequest();

            request.Name = "development";
            request.OrganizationGuid = new Guid("a30f61da-cd2a-4f15-8f01-08a9a6b128c1");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestDisassociateAuditorWithSpaceByUsernameRequest()
        {
            string json = @"{
  ""username"": ""auditor@example.com""
}";

            DisassociateAuditorWithSpaceByUsernameRequest request = new DisassociateAuditorWithSpaceByUsernameRequest();

            request.Username = "auditor@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestDisassociateDeveloperWithSpaceByUsernameRequest()
        {
            string json = @"{
  ""username"": ""developer@example.com""
}";

            DisassociateDeveloperWithSpaceByUsernameRequest request = new DisassociateDeveloperWithSpaceByUsernameRequest();

            request.Username = "developer@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestDisassociateManagerWithSpaceByUsernameRequest()
        {
            string json = @"{
  ""username"": ""manager@example.com""
}";

            DisassociateManagerWithSpaceByUsernameRequest request = new DisassociateManagerWithSpaceByUsernameRequest();

            request.Username = "manager@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestUpdateSpaceRequest()
        {
            string json = @"{
  ""name"": ""New Space Name""
}";

            UpdateSpaceRequest request = new UpdateSpaceRequest();

            request.Name = "New Space Name";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
