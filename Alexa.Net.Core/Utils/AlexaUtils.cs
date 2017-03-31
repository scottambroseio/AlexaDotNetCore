using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexa.Net.Core.Utils
{
    public static class AlexaUtils
    {
        public static bool RequestIsMentForApplication(AlexaRequest request, string appId)
        {
            return request.Session.Application.ApplicationId == appId;
        }

        public static bool IsLaunchRequest(AlexaRequest request)
        {
            return request.Request.Type == RequestType.LaunchRequest;
        }

        public static bool IsIntentRequest(AlexaRequest request)
        {
            return request.Request.Type == RequestType.IntentRequest;
        }

        public static bool IsSessionEndedRequest(AlexaRequest request)
        {
            return request.Request.Type == RequestType.SessionEndedRequest;
        }
    }
}
