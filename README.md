# AlexaDotNetCore
C# Utilities for building Amazon Alexa Applications

## Alexa.Net.Core

Alexa.Net.Core provides strong typed models to represent Alexa requests and Alexa responses. The two primary models are `AlexaRequest` and `AlexaResponse`

You can use these two models as follows
```C#
public AlexaResponse AlexaHandler(AlexaRequest request, ILambdaContext context)
{
  // logic for handling request goes here
  
  // create response object
  var response = new AlexaResponse();
  
  //logic for populating the response could go here
  
  return response;
}
```
