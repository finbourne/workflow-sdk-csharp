# Finbourne.Workflow.Sdk.Model.WorkflowResponse
A Workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**VarVersion** | [**VersionInfo**](VersionInfo.md) |  | [optional] 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**RootTaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**WorkflowStructure** | [**WorkflowStructure**](WorkflowStructure.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId id = new ResourceId();
VersionInfo? varVersion = new VersionInfo();

string displayName = "displayName";
string description = "example description";
ResourceId rootTaskDefinitionId = new ResourceId();
WorkflowStructure? workflowStructure = new WorkflowStructure();


WorkflowResponse workflowResponseInstance = new WorkflowResponse(
    id: id,
    varVersion: varVersion,
    displayName: displayName,
    description: description,
    rootTaskDefinitionId: rootTaskDefinitionId,
    workflowStructure: workflowStructure);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
