using System.Web.Http;

namespace TWChinaApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("TWChinaApi", "api/{controller}/{action}/{id}",
                new {id = RouteParameter.Optional}
                );

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", 
                new {id = RouteParameter.Optional}
                );
        }
    }
}