using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web;
using System.Web.Http;

namespace TWChinaApi.Controllers
{
    public class HomeController : ApiController
    {
        //http://spec.commonmark.org/0.21/
        [HttpGet]
        public string HomeTest()
        {

            return "home in home controller";
        }

        [HttpGet]
        public HttpResponseMessage Home()
        {
            var result = CommonMark.CommonMarkConverter.Convert(
                @"
this is head of taotao
===

# h1
## h2
### h3

- this is first label
- this is first label
- this is second label
- this is third label

**this is bold**

common text bold
");

            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(result, Encoding.UTF8, "text/html"),
            };
            return httpResponseMessage;
        }
    }
}