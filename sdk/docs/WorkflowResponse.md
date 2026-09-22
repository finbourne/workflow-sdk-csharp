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
**WorkflowStructure** | [**WorkflowStructure**](WorkflowStructure.md) |  | 
**RunCount** | **int** | The number of times this Workflow has been run. Starts at 0 and increments by 1 each time a new run is instantiated. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The properties of the Workflow, keyed by property key. | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId id = new ResourceId();
VersionInfo? varVersion = new VersionInfo();

string displayName = "displayName";
string description = "example description";
ResourceId rootTaskDefinitionId = new ResourceId();
WorkflowStructure workflowStructure = new WorkflowStructure();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

WorkflowResponse workflowResponseInstance = new WorkflowResponse(
    id: id,
    varVersion: varVersion,
    displayName: displayName,
    description: description,
    rootTaskDefinitionId: rootTaskDefinitionId,
    workflowStructure: workflowStructure,
    runCount: runCount,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
