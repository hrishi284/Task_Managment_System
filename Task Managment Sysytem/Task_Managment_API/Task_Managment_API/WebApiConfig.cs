using System.Web.Http;
using System.Web.Http.Cors;

public static class WebApiConfig
{
    public static void Register(HttpConfiguration config)
    {
        // Configure CORS to allow requests from 'http://localhost:4200'
        var cors = new EnableCorsAttribute("http://localhost:4200", "*", "*");
        config.EnableCors(cors);

        // Other configuration settings...
    }
}
