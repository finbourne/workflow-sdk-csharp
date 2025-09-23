# Finbourne.Workflow.Sdk.Model.InitialState
Defines the Initial State of the Task

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The Initial State of the Task | 
**RequiredFields** | **List&lt;string&gt;** | Required input Fields for the Initial State | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string name = "name";
List<string> requiredFields = new List<string>();

InitialState initialStateInstance = new InitialState(
    name: name,
    requiredFields: requiredFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
