# Finbourne.Workflow.Sdk.Model.HorizonIntegrationResponse
Readonly configuration for the Horizon Integration Worker

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | [optional] 
**IntegrationInstanceId** | **string** | The id of the Horizon integration instance the worker executes. Null on the library worker. | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "example type";
string integrationInstanceId = "example integrationInstanceId";

HorizonIntegrationResponse horizonIntegrationResponseInstance = new HorizonIntegrationResponse(
    type: type,
    integrationInstanceId: integrationInstanceId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
