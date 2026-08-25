# Finbourne.Workflow.Sdk.Model.HorizonIntegration
Configuration for a Worker that executes a Horizon integration instance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | 
**IntegrationInstanceId** | **string** | The id of the Horizon integration instance the worker executes. | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
string integrationInstanceId = "integrationInstanceId";

HorizonIntegration horizonIntegrationInstance = new HorizonIntegration(
    type: type,
    integrationInstanceId: integrationInstanceId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
