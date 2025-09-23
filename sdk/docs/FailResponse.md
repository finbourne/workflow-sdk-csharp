# Finbourne.Workflow.Sdk.Model.FailResponse
Readonly configuration for a Worker that always Fails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "example type";

FailResponse failResponseInstance = new FailResponse(
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
