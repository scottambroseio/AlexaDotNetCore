# AlexaDotNetCore
C# Utilities for building Amazon Alexa Applications

## Alexa.Net.Core

Alexa.Net.Core provides strong typed models to represent Alexa requests and Alexa responses. The two primary models are `AlexaRequest` and `AlexaResponse`

An example of how you could use these two models is as follows (in the context of hosting the skill on AWS Lambda)
```C#
public AlexaResponse AlexaHandler(AlexaRequest request, ILambdaContext context)
{
  // some logic for handling request
  
  // create response object
  var response = new AlexaResponse();
  
  // some logic for populating the response
  
  return response;
}
```
