using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Reflection;
using System.Text.Encodings.Web;

namespace portfolio_backend_dotnet
{
    public class SiteDataController : Controller
    {
        [Route("site-data")]
        public ContentResult GetSiteData()
        {
            // an S3 bucket would be more appropriate but I'm using this as a trivial example
            // of a dotnet core controller.
            
            var assembly = typeof(portfolio_backend_dotnet.SiteDataController).GetTypeInfo().Assembly;
            using Stream resource = assembly.GetManifestResourceStream("portfolio_backend_dotnet.json.SiteData.json");
            using StreamReader reader = new StreamReader(resource);
            return Content(reader.ReadToEnd(), "application/json");
        }
    }
}