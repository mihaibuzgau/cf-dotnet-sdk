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

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class UserProvidedServiceInstancesEndpoint
{
        [TestMethod]
        public void RetrieveUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""40ac5366-a19f-40c6-936d-01bb36532f7a"",
    ""url"": ""/v2/user_provided_service_instances/42e0ff44-b2ee-40f4-9cde-048f94bfff90"",
    ""created_at"": ""2016-10-12T12:29:10Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-160"",
    ""credentials"": {
      ""creds-key-16"": ""creds-val-16""
    },
    ""space_guid"": ""40ac5366-a19f-40c6-936d-01bb36532f7a"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-16"",
    ""route_service_url"": null,
    ""space_url"": ""/v2/spaces/0fb7a62a-1f4e-4fe2-bc48-ba80c97b35d0"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/42e0ff44-b2ee-40f4-9cde-048f94bfff90/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/42e0ff44-b2ee-40f4-9cde-048f94bfff90/routes""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.RetrieveUserProvidedServiceInstance(guid).Result;


                Assert.AreEqual("40ac5366-a19f-40c6-936d-01bb36532f7a", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/42e0ff44-b2ee-40f4-9cde-048f94bfff90", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-160", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("40ac5366-a19f-40c6-936d-01bb36532f7a", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("https://foo.com/url-16", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
                Assert.AreEqual("/v2/spaces/0fb7a62a-1f4e-4fe2-bc48-ba80c97b35d0", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/42e0ff44-b2ee-40f4-9cde-048f94bfff90/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/42e0ff44-b2ee-40f4-9cde-048f94bfff90/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);

            }
        }

        [TestMethod]
        public void UpdateUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""e1f7d01b-b6fc-4132-8234-717e16fa2a7b"",
    ""url"": ""/v2/user_provided_service_instances/3abad881-fc89-4e44-955f-746bc7b4180b"",
    ""created_at"": ""2016-10-12T12:29:10Z"",
    ""updated_at"": ""2016-10-12T12:29:10Z""
  },
  ""entity"": {
    ""name"": ""name-168"",
    ""credentials"": {
      ""somekey"": ""somenewvalue""
    },
    ""space_guid"": ""e1f7d01b-b6fc-4132-8234-717e16fa2a7b"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-18"",
    ""route_service_url"": null,
    ""space_url"": ""/v2/spaces/8939200c-09cf-400e-9a33-f4ee64280acd"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/3abad881-fc89-4e44-955f-746bc7b4180b/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/3abad881-fc89-4e44-955f-746bc7b4180b/routes""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateUserProvidedServiceInstanceRequest value = new UpdateUserProvidedServiceInstanceRequest();


                var obj = cfClient.UserProvidedServiceInstances.UpdateUserProvidedServiceInstance(guid, value).Result;


                Assert.AreEqual("e1f7d01b-b6fc-4132-8234-717e16fa2a7b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/3abad881-fc89-4e44-955f-746bc7b4180b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-168", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("e1f7d01b-b6fc-4132-8234-717e16fa2a7b", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("https://foo.com/url-18", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
                Assert.AreEqual("/v2/spaces/8939200c-09cf-400e-9a33-f4ee64280acd", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/3abad881-fc89-4e44-955f-746bc7b4180b/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/3abad881-fc89-4e44-955f-746bc7b4180b/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);

            }
        }

        [TestMethod]
        public void DeleteUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.UserProvidedServiceInstances.DeleteUserProvidedServiceInstance(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllRoutesForUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""f72cb470-5c55-4534-a734-d22aeb175e46"",
        ""url"": ""/v2/routes/724252f5-9b56-4a29-842e-e19f1de04afb"",
        ""created_at"": ""2016-10-12T12:29:11Z"",
        ""updated_at"": ""2016-10-12T12:29:11Z""
      },
      ""entity"": {
        ""host"": ""host-4"",
        ""path"": """",
        ""domain_guid"": ""f72cb470-5c55-4534-a734-d22aeb175e46"",
        ""space_guid"": ""f72cb470-5c55-4534-a734-d22aeb175e46"",
        ""service_instance_guid"": ""f72cb470-5c55-4534-a734-d22aeb175e46"",
        ""port"": null,
        ""domain_url"": ""/v2/private_domains/4b1348ea-5ae3-4a86-9e95-28882d38fed3"",
        ""space_url"": ""/v2/spaces/71364aef-ecd7-4baa-8f99-13a34c2731b9"",
        ""service_instance_url"": ""/v2/user_provided_service_instances/ebfda19f-a361-461b-a6d6-a4a924606fd1"",
        ""apps_url"": ""/v2/routes/724252f5-9b56-4a29-842e-e19f1de04afb/apps"",
        ""route_mappings_url"": ""/v2/routes/724252f5-9b56-4a29-842e-e19f1de04afb/route_mappings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.ListAllRoutesForUserProvidedServiceInstance(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("f72cb470-5c55-4534-a734-d22aeb175e46", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/724252f5-9b56-4a29-842e-e19f1de04afb", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:11Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-10-12T12:29:11Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-4", TestUtil.ToTestableString(obj[0].Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Path), true);
                Assert.AreEqual("f72cb470-5c55-4534-a734-d22aeb175e46", TestUtil.ToTestableString(obj[0].DomainGuid), true);
                Assert.AreEqual("f72cb470-5c55-4534-a734-d22aeb175e46", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("f72cb470-5c55-4534-a734-d22aeb175e46", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Port), true);
                Assert.AreEqual("/v2/private_domains/4b1348ea-5ae3-4a86-9e95-28882d38fed3", TestUtil.ToTestableString(obj[0].DomainUrl), true);
                Assert.AreEqual("/v2/spaces/71364aef-ecd7-4baa-8f99-13a34c2731b9", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/ebfda19f-a361-461b-a6d6-a4a924606fd1", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);
                Assert.AreEqual("/v2/routes/724252f5-9b56-4a29-842e-e19f1de04afb/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/routes/724252f5-9b56-4a29-842e-e19f1de04afb/route_mappings", TestUtil.ToTestableString(obj[0].RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllUserProvidedServiceInstancesTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""0520d683-bfc6-404e-8b65-94d98fa99e61"",
        ""url"": ""/v2/user_provided_service_instances/89f51651-e729-4280-9c73-4f9138b8ba95"",
        ""created_at"": ""2016-10-12T12:29:10Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-164"",
        ""credentials"": {
          ""creds-key-17"": ""creds-val-17""
        },
        ""space_guid"": ""0520d683-bfc6-404e-8b65-94d98fa99e61"",
        ""type"": ""user_provided_service_instance"",
        ""syslog_drain_url"": ""https://foo.com/url-17"",
        ""route_service_url"": null,
        ""space_url"": ""/v2/spaces/be690915-8d4d-4622-9fea-667fb7f7a327"",
        ""service_bindings_url"": ""/v2/user_provided_service_instances/89f51651-e729-4280-9c73-4f9138b8ba95/service_bindings"",
        ""routes_url"": ""/v2/user_provided_service_instances/89f51651-e729-4280-9c73-4f9138b8ba95/routes""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.UserProvidedServiceInstances.ListAllUserProvidedServiceInstances().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("0520d683-bfc6-404e-8b65-94d98fa99e61", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/89f51651-e729-4280-9c73-4f9138b8ba95", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-164", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("0520d683-bfc6-404e-8b65-94d98fa99e61", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("https://foo.com/url-17", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].RouteServiceUrl), true);
                Assert.AreEqual("/v2/spaces/be690915-8d4d-4622-9fea-667fb7f7a327", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/89f51651-e729-4280-9c73-4f9138b8ba95/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/89f51651-e729-4280-9c73-4f9138b8ba95/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);

            }
        }

        [TestMethod]
        public void RemoveRouteFromUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? route_guid = Guid.NewGuid();


                cfClient.UserProvidedServiceInstances.RemoveRouteFromUserProvidedServiceInstance(guid, route_guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllServiceBindingsForUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""9507caec-622a-4f63-87f7-b2f29e804e8c"",
        ""url"": ""/v2/service_bindings/e2455d8d-0528-49ff-9d36-392f3ce88ac2"",
        ""created_at"": ""2016-10-12T12:29:11Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""9507caec-622a-4f63-87f7-b2f29e804e8c"",
        ""service_instance_guid"": ""9507caec-622a-4f63-87f7-b2f29e804e8c"",
        ""credentials"": {
          ""creds-key-23"": ""creds-val-23""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""volume_mounts"": [

        ],
        ""service_instance_url"": ""/v2/user_provided_service_instances/4b7968de-0a4a-4707-af12-2720fff4c944""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.ListAllServiceBindingsForUserProvidedServiceInstance(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("9507caec-622a-4f63-87f7-b2f29e804e8c", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/e2455d8d-0528-49ff-9d36-392f3ce88ac2", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:11Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("9507caec-622a-4f63-87f7-b2f29e804e8c", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("9507caec-622a-4f63-87f7-b2f29e804e8c", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/4b7968de-0a4a-4707-af12-2720fff4c944", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void AssociateRouteWithUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""89314390-48b2-49c2-b0e5-d0d90bb3e9d4"",
    ""url"": ""/v2/user_provided_service_instances/03b0ade4-84c9-4476-926f-83bc82872432"",
    ""created_at"": ""2016-10-12T12:29:10Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-172"",
    ""credentials"": {
      ""creds-key-19"": ""creds-val-19""
    },
    ""space_guid"": ""89314390-48b2-49c2-b0e5-d0d90bb3e9d4"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-20"",
    ""route_service_url"": ""https://foo.com/url-19"",
    ""space_url"": ""/v2/spaces/e9ded3dc-cbf8-4bf7-b8c9-90b144a42a3b"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/03b0ade4-84c9-4476-926f-83bc82872432/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/03b0ade4-84c9-4476-926f-83bc82872432/routes""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? route_guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.AssociateRouteWithUserProvidedServiceInstance(guid, route_guid).Result;


                Assert.AreEqual("89314390-48b2-49c2-b0e5-d0d90bb3e9d4", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/03b0ade4-84c9-4476-926f-83bc82872432", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-172", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("89314390-48b2-49c2-b0e5-d0d90bb3e9d4", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("https://foo.com/url-20", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("https://foo.com/url-19", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
                Assert.AreEqual("/v2/spaces/e9ded3dc-cbf8-4bf7-b8c9-90b144a42a3b", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/03b0ade4-84c9-4476-926f-83bc82872432/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/03b0ade4-84c9-4476-926f-83bc82872432/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);

            }
        }

        [TestMethod]
        public void CreateUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""55a28336-4ef8-4743-8cb2-7b2786b82d12"",
    ""url"": ""/v2/user_provided_service_instances/96f38e60-7f95-4ff2-9fe1-2e5ef9482b34"",
    ""created_at"": ""2016-10-12T12:29:10Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-user-provided-instance"",
    ""credentials"": {
      ""somekey"": ""somevalue""
    },
    ""space_guid"": ""55a28336-4ef8-4743-8cb2-7b2786b82d12"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""syslog://example.com"",
    ""route_service_url"": ""https://logger.example.com"",
    ""space_url"": ""/v2/spaces/43486658-c90d-4591-85bc-3cddd4e4db58"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/96f38e60-7f95-4ff2-9fe1-2e5ef9482b34/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/96f38e60-7f95-4ff2-9fe1-2e5ef9482b34/routes""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateUserProvidedServiceInstanceRequest value = new CreateUserProvidedServiceInstanceRequest();


                var obj = cfClient.UserProvidedServiceInstances.CreateUserProvidedServiceInstance(value).Result;


                Assert.AreEqual("55a28336-4ef8-4743-8cb2-7b2786b82d12", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/96f38e60-7f95-4ff2-9fe1-2e5ef9482b34", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-10-12T12:29:10Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my-user-provided-instance", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("55a28336-4ef8-4743-8cb2-7b2786b82d12", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("syslog://example.com", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("https://logger.example.com", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
                Assert.AreEqual("/v2/spaces/43486658-c90d-4591-85bc-3cddd4e4db58", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/96f38e60-7f95-4ff2-9fe1-2e5ef9482b34/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/96f38e60-7f95-4ff2-9fe1-2e5ef9482b34/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);

            }
        }

    }
}