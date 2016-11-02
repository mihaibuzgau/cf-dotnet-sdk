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
    public class ServicePlanVisibilitiesTest
    {

        [TestMethod]
        public void TestUpdateServicePlanVisibilityRequest()
        {
            string json = @"{
  ""service_plan_guid"": ""39a10e2e-0e0b-4fac-9242-2d7f79a0fe5f"",
  ""organization_guid"": ""39a10e2e-0e0b-4fac-9242-2d7f79a0fe5f""
}";

            UpdateServicePlanVisibilityRequest request = new UpdateServicePlanVisibilityRequest();

            request.ServicePlanGuid = new Guid("39a10e2e-0e0b-4fac-9242-2d7f79a0fe5f");
            request.OrganizationGuid = new Guid("39a10e2e-0e0b-4fac-9242-2d7f79a0fe5f");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateServicePlanVisibilityRequest()
        {
            string json = @"{
  ""service_plan_guid"": ""5b96a822-8390-46f3-9cf9-bce50f5ea88c"",
  ""organization_guid"": ""5b96a822-8390-46f3-9cf9-bce50f5ea88c""
}";

            CreateServicePlanVisibilityRequest request = new CreateServicePlanVisibilityRequest();

            request.ServicePlanGuid = new Guid("5b96a822-8390-46f3-9cf9-bce50f5ea88c");
            request.OrganizationGuid = new Guid("5b96a822-8390-46f3-9cf9-bce50f5ea88c");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
