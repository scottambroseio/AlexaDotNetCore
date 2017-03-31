using Alexa.Net.Core.Utils;
using System;
using Xunit;

namespace Alexa.Net.Core.Tests
{
    public class AlexaUtilsTests
    {
        [Fact]
        public void RequestMentForApplicationShouldReturnTrueWhenRequestIsValid()
        {
            var appId = "APPID";
            var request = new AlexaRequest
            {
                Session = new Session
                {
                    Application = new Application
                    {
                        ApplicationId = appId
                    }
                }
            };

            var result = AlexaUtils.RequestIsMentForApplication(request, appId);

            Assert.Equal(result, true);
        }

        [Fact]
        public void RequestMentForApplicationShouldReturnFalseWhenRequestIsInvalid()
        {
            var appId = "APPID";
            var request = new AlexaRequest
            {
                Session = new Session
                {
                    Application = new Application
                    {
                        ApplicationId = "WRONGID"
                    }
                }
            };

            var result = AlexaUtils.RequestIsMentForApplication(request, appId);

            Assert.Equal(result, false);
        }

        [Fact]
        public void IsLaunchRequestShouldReturnTrueWhenRequestIsValid()
        {
            var request = new AlexaRequest
            {
                Request = new Request
                {
                    Type = RequestType.LaunchRequest
                }
            };

            var result = AlexaUtils.IsLaunchRequest(request);

            Assert.Equal(result, true);
        }

        [Fact]
        public void IsLaunchRequestShouldReturnFalseWhenRequestIsInvalid()
        {
            var request = new AlexaRequest
            {
                Request = new Request
                {
                    Type = RequestType.IntentRequest
                }
            };

            var result = AlexaUtils.IsLaunchRequest(request);

            Assert.Equal(result, false);
        }

        [Fact]
        public void IsIntentRequestShouldReturnTrueWhenRequestIsValid()
        {
            var request = new AlexaRequest
            {
                Request = new Request
                {
                    Type = RequestType.IntentRequest
                }
            };

            var result = AlexaUtils.IsIntentRequest(request);

            Assert.Equal(result, true);
        }

        [Fact]
        public void IsIntentRequestShouldReturnFalseWhenRequestIsInvalid()
        {
            var request = new AlexaRequest
            {
                Request = new Request
                {
                    Type = RequestType.LaunchRequest
                }
            };

            var result = AlexaUtils.IsIntentRequest(request);

            Assert.Equal(result, false);
        }

        [Fact]
        public void IsSessionEndedRequestShouldReturnTrueWhenRequestIsValid()
        {
            var request = new AlexaRequest
            {
                Request = new Request
                {
                    Type = RequestType.SessionEndedRequest
                }
            };

            var result = AlexaUtils.IsSessionEndedRequest(request);

            Assert.Equal(result, true);
        }

        [Fact]
        public void IsSessionEndedRequestShouldReturnFalseWhenRequestIsInvalid()
        {
            var request = new AlexaRequest
            {
                Request = new Request
                {
                    Type = RequestType.IntentRequest
                }
            };

            var result = AlexaUtils.IsSessionEndedRequest(request);

            Assert.Equal(result, false);
        }

        [Fact]
        public void GetIntentShouldReturnTheIntent()
        {
            var intent = new Intent
            {
                Name = "TESTINTENT"
            };

            var request = new AlexaRequest
            {
                Request = new Request
                {
                    Type = RequestType.IntentRequest,
                    Intent = intent
                }
            };

            var result = AlexaUtils.GetIntent(request);

            Assert.Equal(result, intent);
        }
    }
}
