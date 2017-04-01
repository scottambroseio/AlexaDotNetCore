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
            var response = new AlexaResponse
            {
                Response = new Response
                {
                    OutputSpeech = new OutputSpeech
                    {
                        Type = OutputSpeechType.Text,
                        Text = "The request was a Launch Request"
                    }
                }
            };

            return response;
        }

        private AlexaResponse IntentRequest(AlexaRequest request, ILambdaContext context)
        {
            var intent = AlexaUtils.GetIntent(request);

            var response = new AlexaResponse
            {
                Response = new Response
                {
                    OutputSpeech = new OutputSpeech
                    {
                        Type = OutputSpeechType.Text,
                        Text = String.Format("The request was a Intent Request for the {0} intention", intent.Name)
                    }
                }
            };


            return response;
        }

        private AlexaResponse SessionEndedRequest(AlexaRequest request, ILambdaContext context)
        {
            var response = new AlexaResponse
            {
                Response = new Response
                {
                    OutputSpeech = new OutputSpeech
                    {
                        Type = OutputSpeechType.Text,
                        Text = "The request was a Session Ended Request"
                    }
                }
            };

            return response;
        }
    }
}
