using System;
using Amazon.Lambda.Core;
using Alexa.Net.Core;
using Alexa.Net.Core.Utils;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace ExampleAlexaFunction
{
    public class Function
    {
        private readonly string _applicationId = "1234";

        public AlexaResponse FunctionHandler(AlexaRequest request, ILambdaContext context)
        {
            if (!AlexaUtils.RequestIsMentForApplication(request, _applicationId))
            {
                return null;
            }

            if (AlexaUtils.IsLaunchRequest(request))
            {
                Console.WriteLine("Request is a LaunchRequest");
            }

            if (AlexaUtils.IsIntentRequest(request))
            {
                Console.WriteLine("Request is a IntentRequest");
            }

            if (AlexaUtils.IsSessionEndedRequest(request))
            {
                Console.WriteLine("Request is a SessionEndedRequest");
            }

            return null;
        }
    }
}
