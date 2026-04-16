# Finbourne.Workflow.Sdk.Model.UpdateWorkflowRequest
Contains required info to update an existing Workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**RootTaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
ResourceId rootTaskDefinitionId = new ResourceId();

UpdateWorkflowRequest updateWorkflowRequestInstance = new UpdateWorkflowRequest(
    displayName: displayName,
    description: description,
    rootTaskDefinitionId: rootTaskDefinitionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
