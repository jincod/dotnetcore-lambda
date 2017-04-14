using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace SimpleLambda
{
    public class Functions
    {
        public static void Main()
        {
            
        }
        public APIGatewayProxyResponse Process(APIGatewayProxyRequest request, ILambdaContext context)
        {
            return new APIGatewayProxyResponse();
        }
    }
}
