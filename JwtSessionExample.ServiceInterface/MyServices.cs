using System;
using ServiceStack;
using JwtSessionExample.ServiceModel;

namespace JwtSessionExample.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }

        [Authenticate]
        public object Any(ShowSession request)
        {
            return this.GetSession();
        }
    }

    [Route("/foo")]
    public class ShowSession
    {
        
    }
}
