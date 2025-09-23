# Finbourne.Workflow.Sdk.Model.HealthCheckResponse
Readonly configuration for a Worker that performs a GET against a given Url.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | [optional] 
**Url** | **string** | The URL to check, eg: https://www.google.com/ | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "example type";
string url = "example url";

HealthCheckResponse healthCheckResponseInstance = new HealthCheckResponse(
    type: type,
    url: url);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
