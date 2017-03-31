using Alexa.Net.Core.Utils;
using System;
using Xunit;

namespace Alexa.Net.Core.Tests
{
    public class AlexaUtilsTests
    {
        [Fact]
        public void ShouldCorrectlyValidateRequestMentForApplicationWhenRequestIsValid()
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
        public void ShouldCorrectlyValidateRequestMentForApplicationWhenRequestIsInvalid()
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

        //[Fact]
        //public void Test1()
        //{
        //}

        //[Fact]
        //public void Test1()
        //{
        //}

        //[Fact]
        //public void Test1()
        //{
        //}
    }
}
