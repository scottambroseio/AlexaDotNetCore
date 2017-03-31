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
                return LaunchRequest(request, context);
            }

            if (AlexaUtils.IsIntentRequest(request))
            {
                return IntentRequest(request, context);
            }

            if (AlexaUtils.IsSessionEndedRequest(request))
            {
                return SessionEndedRequest(request, context);
            }

            //return unhandled etc
            return null;
        }

        private AlexaResponse LaunchRequest(AlexaRequest request, ILambdaContext context)
        {
            Console.WriteLine("Request is a LaunchRequest");

            return null;
        }

        private AlexaResponse IntentRequest(AlexaRequest request, ILambdaContext context)
        {
            var intent = AlexaUtils.GetIntent(request);

            Console.WriteLine("Request is a IntentRequest");
            Console.WriteLine(String.Format("Intent is for the {0} intent", intent.Name));

            return null;
        }

        private AlexaResponse SessionEndedRequest(AlexaRequest request, ILambdaContext context)
        {
            Console.WriteLine("Request is a SessionEndedRequest");

            return null;
        }
    }
}
