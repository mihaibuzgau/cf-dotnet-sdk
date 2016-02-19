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
    public class PackagesExperimentalTest
    {


        [TestMethod]
        public void TestCreatePackageResponse()
        {
            string json = @"{
  ""guid"": ""2c7e7f59-f4dd-4f20-84dc-38367cf05f0e"",
  ""type"": ""docker"",
  ""data"": {
    ""hash"": {
      ""type"": ""sha1"",
      ""value"": null
    },
    ""error"": null,
    ""image"": ""registry/image:latest"",
    ""credentials"": {
      ""user"": ""user name"",
      ""email"": ""root@admin.example.com"",
      ""password"": ""very secret password"",
      ""login_server"": ""https://index.docker.io/v1""
    },
    ""store_image"": true
  },
  ""state"": ""READY"",
  ""created_at"": ""2016-02-11T13:20:51Z"",
  ""updated_at"": null,
  ""links"": {
    ""self"": {
      ""href"": ""/v3/packages/bfd883e8-95fc-401e-a134-e81d1b6c01ab""
    },
    ""app"": {
      ""href"": ""/v3/apps/a224642b-2080-4ce0-9b1d-5c27169f39c9""
    }
  }
}";

            CreatePackageResponse obj = Utilities.DeserializeJson<CreatePackageResponse>(json);

            Assert.AreEqual("2c7e7f59-f4dd-4f20-84dc-38367cf05f0e", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("docker", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("READY", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("2016-02-11T13:20:51Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }

        [TestMethod]
        public void TestGetPackageResponse()
        {
            string json = @"{
  ""guid"": ""f1811782-a7a8-47ad-a49f-de15802b9123"",
  ""type"": ""bits"",
  ""data"": {
    ""hash"": {
      ""type"": ""sha1"",
      ""value"": null
    },
    ""error"": null
  },
  ""state"": ""AWAITING_UPLOAD"",
  ""created_at"": ""2016-02-11T13:20:51Z"",
  ""updated_at"": null,
  ""links"": {
    ""self"": {
      ""href"": ""/v3/packages/33cbdd87-9175-4e0e-b458-2019a6f70baa""
    },
    ""upload"": {
      ""href"": ""/v3/packages/33cbdd87-9175-4e0e-b458-2019a6f70baa/upload"",
      ""method"": ""POST""
    },
    ""download"": {
      ""href"": ""/v3/packages/33cbdd87-9175-4e0e-b458-2019a6f70baa/download"",
      ""method"": ""GET""
    },
    ""stage"": {
      ""href"": ""/v3/packages/33cbdd87-9175-4e0e-b458-2019a6f70baa/droplets"",
      ""method"": ""POST""
    },
    ""app"": {
      ""href"": ""/v3/apps/ab8c80f4-9c8c-4227-8945-e7c46e4e079f""
    }
  }
}";

            GetPackageResponse obj = Utilities.DeserializeJson<GetPackageResponse>(json);

            Assert.AreEqual("f1811782-a7a8-47ad-a49f-de15802b9123", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("bits", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("AWAITING_UPLOAD", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("2016-02-11T13:20:51Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }

        [TestMethod]
        public void TestCopyPackageResponse()
        {
            string json = @"{
  ""guid"": ""21b91418-397a-44dd-a86d-08ea21e32bbe"",
  ""type"": ""docker"",
  ""data"": {
    ""hash"": {
      ""type"": ""sha1"",
      ""value"": null
    },
    ""error"": null,
    ""image"": ""http://awesome-sauce.com"",
    ""credentials"": {

    },
    ""store_image"": false
  },
  ""state"": ""READY"",
  ""created_at"": ""2016-02-11T13:20:51Z"",
  ""updated_at"": null,
  ""links"": {
    ""self"": {
      ""href"": ""/v3/packages/9b00f439-048a-4dd8-b702-47d325fd8b2c""
    },
    ""app"": {
      ""href"": ""/v3/apps/abcf74a5-82dd-4e5d-8995-9fd80c7a2ad5""
    }
  }
}";

            CopyPackageResponse obj = Utilities.DeserializeJson<CopyPackageResponse>(json);

            Assert.AreEqual("21b91418-397a-44dd-a86d-08ea21e32bbe", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("docker", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("READY", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("2016-02-11T13:20:51Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }

        [TestMethod]
        public void TestDownloadBitsForPackageResponse()
        {
            string json = @"{
  ""guid"": ""cb2497ad-c011-4ada-b0dd-d08ab8160e64"",
  ""type"": ""bits"",
  ""data"": {
    ""hash"": {
      ""type"": ""sha1"",
      ""value"": null
    },
    ""error"": null
  },
  ""state"": ""PROCESSING_UPLOAD"",
  ""created_at"": ""2016-02-11T13:20:51Z"",
  ""updated_at"": ""2016-02-11T13:20:51Z"",
  ""links"": {
    ""self"": {
      ""href"": ""/v3/packages/967ca660-fccf-42a4-8d53-b6f0aa62b6fa""
    },
    ""upload"": {
      ""href"": ""/v3/packages/967ca660-fccf-42a4-8d53-b6f0aa62b6fa/upload"",
      ""method"": ""POST""
    },
    ""download"": {
      ""href"": ""/v3/packages/967ca660-fccf-42a4-8d53-b6f0aa62b6fa/download"",
      ""method"": ""GET""
    },
    ""stage"": {
      ""href"": ""/v3/packages/967ca660-fccf-42a4-8d53-b6f0aa62b6fa/droplets"",
      ""method"": ""POST""
    },
    ""app"": {
      ""href"": ""/v3/apps/bfe94bcf-f2da-497c-a6cf-49dbaed748d0""
    }
  }
}";

            DownloadBitsForPackageResponse obj = Utilities.DeserializeJson<DownloadBitsForPackageResponse>(json);

            Assert.AreEqual("cb2497ad-c011-4ada-b0dd-d08ab8160e64", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("bits", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("PROCESSING_UPLOAD", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("2016-02-11T13:20:51Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:51Z", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }

        [TestMethod]
        public void TestListAllPackagesResponse()
        {
            string json = @"{
  ""pagination"": {
    ""total_results"": 3,
    ""first"": {
      ""href"": ""/v3/packages?page=1=2""
    },
    ""last"": {
      ""href"": ""/v3/packages?page=2=2""
    },
    ""next"": {
      ""href"": ""/v3/packages?page=2=2""
    },
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""f4ab43d0-d7c5-448b-af1e-45ef301955fb"",
      ""type"": ""bits"",
      ""data"": {
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": null
        },
        ""error"": null
      },
      ""state"": ""AWAITING_UPLOAD"",
      ""created_at"": ""2016-02-11T13:20:51Z"",
      ""updated_at"": null,
      ""links"": {
        ""self"": {
          ""href"": ""/v3/packages/66ed7f6e-d4dd-422d-b83c-7699de081f95""
        },
        ""upload"": {
          ""href"": ""/v3/packages/66ed7f6e-d4dd-422d-b83c-7699de081f95/upload"",
          ""method"": ""POST""
        },
        ""download"": {
          ""href"": ""/v3/packages/66ed7f6e-d4dd-422d-b83c-7699de081f95/download"",
          ""method"": ""GET""
        },
        ""stage"": {
          ""href"": ""/v3/packages/66ed7f6e-d4dd-422d-b83c-7699de081f95/droplets"",
          ""method"": ""POST""
        },
        ""app"": {
          ""href"": ""/v3/apps/a42892e4-12b4-4116-864e-d6f961a61e00""
        }
      }
    },
    {
      ""guid"": ""f4ab43d0-d7c5-448b-af1e-45ef301955fb"",
      ""type"": ""docker"",
      ""data"": {
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": null
        },
        ""error"": null,
        ""image"": ""http://location-of-image.com"",
        ""credentials"": {

        },
        ""store_image"": false
      },
      ""state"": ""READY"",
      ""created_at"": ""2016-02-11T13:20:51Z"",
      ""updated_at"": null,
      ""links"": {
        ""self"": {
          ""href"": ""/v3/packages/2d7c8ff2-e6f4-4d51-89f6-53ee72538cb1""
        },
        ""app"": {
          ""href"": ""/v3/apps/a42892e4-12b4-4116-864e-d6f961a61e00""
        }
      }
    }
  ]
}";

            PagedResponseCollection<ListAllPackagesResponse> page = Utilities.DeserializePage<ListAllPackagesResponse>(json, null);

            Assert.AreEqual("f4ab43d0-d7c5-448b-af1e-45ef301955fb", TestUtil.ToTestableString(page[0].Guid), true);
            Assert.AreEqual("bits", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("AWAITING_UPLOAD", TestUtil.ToTestableString(page[0].State), true);
            Assert.AreEqual("2016-02-11T13:20:51Z", TestUtil.ToTestableString(page[0].CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].UpdatedAt), true);
            Assert.AreEqual("f4ab43d0-d7c5-448b-af1e-45ef301955fb", TestUtil.ToTestableString(page[1].Guid), true);
            Assert.AreEqual("docker", TestUtil.ToTestableString(page[1].Type), true);
            Assert.AreEqual("READY", TestUtil.ToTestableString(page[1].State), true);
            Assert.AreEqual("2016-02-11T13:20:51Z", TestUtil.ToTestableString(page[1].CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].UpdatedAt), true);
        }

        [TestMethod]
        public void TestStagePackageResponse()
        {
            string json = @"{
  ""guid"": ""80de7aff-a5f6-4450-871e-1b8ac59f9c70"",
  ""state"": ""PENDING"",
  ""error"": null,
  ""lifecycle"": {
    ""type"": ""buildpack"",
    ""data"": {
      ""buildpack"": ""http://github.com/myorg/awesome-buildpack"",
      ""stack"": ""cflinuxfs2""
    }
  },
  ""memory_limit"": 1024,
  ""disk_limit"": 4096,
  ""result"": {
    ""buildpack"": null,
    ""stack"": ""cflinuxfs2"",
    ""process_types"": null,
    ""hash"": {
      ""type"": ""sha1"",
      ""value"": null
    },
    ""execution_metadata"": null
  },
  ""environment_variables"": {
    ""CUSTOM_ENV_VAR"": ""hello"",
    ""VCAP_APPLICATION"": {
      ""limits"": {
        ""mem"": 1024,
        ""disk"": 4096,
        ""fds"": 16384
      },
      ""application_id"": ""2e9696eb-c814-44ec-b0ca-5fc66ab1ddac"",
      ""application_version"": ""whatuuid"",
      ""application_name"": ""name-2090"",
      ""application_uris"": [

      ],
      ""version"": ""whatuuid"",
      ""name"": ""name-2090"",
      ""space_name"": ""name-2087"",
      ""space_id"": ""a3bd814d-66d7-4bd5-8dd1-ec6a30214566"",
      ""uris"": [

      ],
      ""users"": null
    },
    ""CF_STACK"": ""cflinuxfs2"",
    ""MEMORY_LIMIT"": 1024,
    ""VCAP_SERVICES"": {

    }
  },
  ""created_at"": ""2016-02-11T13:20:51Z"",
  ""updated_at"": null,
  ""links"": {
    ""self"": {
      ""href"": ""/v3/droplets/whatuuid""
    },
    ""package"": {
      ""href"": ""/v3/packages/4ae08ae6-1e0c-4d2e-9b0e-fce6757f8df6""
    },
    ""app"": {
      ""href"": ""/v3/apps/2e9696eb-c814-44ec-b0ca-5fc66ab1ddac""
    },
    ""assign_current_droplet"": {
      ""href"": ""/v3/apps/2e9696eb-c814-44ec-b0ca-5fc66ab1ddac/current_droplet"",
      ""method"": ""PUT""
    }
  }
}";

            StagePackageResponse obj = Utilities.DeserializeJson<StagePackageResponse>(json);

            Assert.AreEqual("80de7aff-a5f6-4450-871e-1b8ac59f9c70", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("PENDING", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Error), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("4096", TestUtil.ToTestableString(obj.DiskLimit), true);
            Assert.AreEqual("2016-02-11T13:20:51Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }
    }
}