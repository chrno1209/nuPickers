using ClientDependency.Core;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace nuPickers.EmbeddedResource
{

    public class EmbeddedResourceComponent : IComponent
    {
        public void Initialize()
        {
            RouteTable
                .Routes
                .MapRoute(
                    name: "nuPickersShared",
                    url: EmbeddedResource.ROOT_URL.TrimStart("~/") + "{folder}/{file}",
                    defaults: new
                    {
                        controller = "EmbeddedResource",
                        action = "GetSharedResource"
                    },
                    namespaces: new[] { "nuPickers.EmbeddedResource" });

            FileWriters.AddWriterForExtension(EmbeddedResource.FILE_EXTENSION, new EmbeddedResourceVirtualFileWriter());
        }

        // terminate: runs once when Umbraco stops
        public void Terminate()
        {
        }
    }
}
