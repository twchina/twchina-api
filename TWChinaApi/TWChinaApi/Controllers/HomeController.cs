using System.Web.Http;

namespace TWChinaApi.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public string Home()
        {
            return "home in home controller";
        }
         
    }
}