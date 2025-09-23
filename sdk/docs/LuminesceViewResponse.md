# Finbourne.Workflow.Sdk.Model.LuminesceViewResponse
Readonly configuration for a Worker that calls a Luminesce view

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | [optional] 
**Name** | **string** | Name of the view in Luminesce | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "example type";
string name = "example name";

LuminesceViewResponse luminesceViewResponseInstance = new LuminesceViewResponse(
    type: type,
    name: name);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
