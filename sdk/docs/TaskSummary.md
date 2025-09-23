# Finbourne.Workflow.Sdk.Model.TaskSummary
Summary of a Task created based on a Task Definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The unique id for this Task | 
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionVersion** | [**TaskDefinitionVersion**](TaskDefinitionVersion.md) |  | 
**TaskDefinitionDisplayName** | **string** | The display name of the Task Definition used by this Task | 
**State** | **string** | Current State | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

Guid id = "id";
ResourceId taskDefinitionId = new ResourceId();
TaskDefinitionVersion taskDefinitionVersion = new TaskDefinitionVersion();
string taskDefinitionDisplayName = "taskDefinitionDisplayName";
string state = "state";

TaskSummary taskSummaryInstance = new TaskSummary(
    id: id,
    taskDefinitionId: taskDefinitionId,
    taskDefinitionVersion: taskDefinitionVersion,
    taskDefinitionDisplayName: taskDefinitionDisplayName,
    state: state);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
