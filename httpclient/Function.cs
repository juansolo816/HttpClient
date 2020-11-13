using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using System.Dynamic;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices.WindowsRuntime;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace httpclient
{
    public class Functions
    {
        public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
        {
            /**
            Person person1 = new Person()
            {
                ID = 1,
                Name = "John Wick"
            };

            Person person2 = new Person()
            {
                ID = 2,
                Name = "David Blaine",
            };

            object copy = new Person()
            {
                ID = 0,
                Name = "NOT SET",
            };

            object req = request.QueryStringParameters.TryGetValue("id", out string queryString);
            if (!String.IsNullOrEmpty(queryString))
            {
                switch (queryString)
                {
                   case "1":
                       copy = person1;
                       break;
                   case "2":
                       copy = person2;
                       break;
                   default:
                      break;
                }
            }**/
           
            context.Logger.LogLine("Get Request\n");
            var response = new APIGatewayProxyResponse()
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = "Hello from your lambda function 'httpclient'",
                Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
            };
            return response;
        }
    }
}
