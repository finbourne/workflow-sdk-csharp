# Finbourne.Workflow.Sdk.Model.TaskStateDefinition
A Task Definition/Task has a given set of States

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The Name of this State | 
**DisplayName** | **string** | The display name of this State | [optional] 
**Description** | **string** | The description of this State | [optional] 
**Category** | **string** | The category of this State | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string name = "name";
string displayName = "example displayName";
string description = "example description";
string category = "example category";

TaskStateDefinition taskStateDefinitionInstance = new TaskStateDefinition(
    name: name,
    displayName: displayName,
    description: description,
    category: category);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
