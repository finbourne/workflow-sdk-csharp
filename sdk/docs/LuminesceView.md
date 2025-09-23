# Finbourne.Workflow.Sdk.Model.LuminesceView
Configuration for a Worker that calls a Luminesce view

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | 
**Name** | **string** | Name of the view in Luminesce | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
string name = "name";

LuminesceView luminesceViewInstance = new LuminesceView(
    type: type,
    name: name);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
