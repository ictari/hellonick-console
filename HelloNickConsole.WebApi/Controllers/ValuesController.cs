using System.Web.Http;

namespace HelloNickConsole.WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        public string Get() => "Hello Nick";
    }
}