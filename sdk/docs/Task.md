# Finbourne.Workflow.Sdk.Model.Task
Defines a Task created based on a Task Definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The unique id for this Task | 
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionVersion** | [**TaskDefinitionVersion**](TaskDefinitionVersion.md) |  | 
**TaskDefinitionDisplayName** | **string** | The display name of the Task Definition used by this Task | 
**WorkflowId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**WorkflowDisplayName** | **string** | The display name of the Workflow that this Task is a member of, if any | [optional] 
**State** | **string** | Current State | 
**UltimateParentTask** | [**TaskSummary**](TaskSummary.md) |  | 
**ParentTask** | [**TaskSummary**](TaskSummary.md) |  | [optional] 
**ChildTasks** | [**List&lt;TaskSummary&gt;**](TaskSummary.md) | This Task&#39;s child tasks | [optional] 
**CorrelationIds** | **List&lt;string&gt;** | User-provided ID used to link entities and tasks | [optional] 
**VarVersion** | [**VersionInfo**](VersionInfo.md) |  | [optional] 
**TerminalState** | **bool** | True if no onward transitions are possible | 
**AsAtLastTransition** | **DateTimeOffset?** | Last Transition timestamp | [optional] 
**Fields** | [**List&lt;TaskInstanceField&gt;**](TaskInstanceField.md) | Fields and their latest values - should correspond with the Task Definition field schema | [optional] 
**StackingKey** | **string** | The key used to determine which stack to add the Task to | [optional] 
**Stack** | [**Stack**](Stack.md) |  | [optional] 
**ActionLogIdCreated** | **Guid?** | The Id of the Action that created this Task | [optional] 
**ActionLogIdModified** | **Guid?** | The Id of the Action that last modified this Task | [optional] 
**ActionLogIdSubmitted** | **Guid?** | The Id of the last Action submitted by this Task | [optional] 
**HierarchicalPosition** | **string** | The hierarchical position of this Task: UltimateParent, IntermediateParent, Child, or Standalone | [optional] 
**CompletionStatus** | **string** | The completion status of this Task: NotStarted, InProgress, or Completed | [optional] 
**OpenDuration** | **long?** | Duration in seconds since the Task was created. If the Task is Completed, this is the duration from creation to the last transition. | [optional] 
**OpenDurationSinceLastUpdate** | **long?** | Duration in seconds since the Task was last updated. 0 if the Task is Completed. | [optional] 
**OpenDurationSinceLastTransition** | **long?** | Duration in seconds since the Task last transitioned. 0 if the Task is Completed. | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

Guid id = "id";
ResourceId taskDefinitionId = new ResourceId();
TaskDefinitionVersion taskDefinitionVersion = new TaskDefinitionVersion();
string taskDefinitionDisplayName = "taskDefinitionDisplayName";
ResourceId? workflowId = new ResourceId();

string workflowDisplayName = "example workflowDisplayName";
string state = "state";
TaskSummary ultimateParentTask = new TaskSummary();
TaskSummary? parentTask = new TaskSummary();

List<TaskSummary> childTasks = new List<TaskSummary>();
List<string> correlationIds = new List<string>();
VersionInfo? varVersion = new VersionInfo();

bool terminalState = //"True";
List<TaskInstanceField> fields = new List<TaskInstanceField>();
string stackingKey = "example stackingKey";
Stack? stack = new Stack();

Guid? actionLogIdCreated = "example actionLogIdCreated";
Guid? actionLogIdModified = "example actionLogIdModified";
Guid? actionLogIdSubmitted = "example actionLogIdSubmitted";
string hierarchicalPosition = "example hierarchicalPosition";
string completionStatus = "example completionStatus";

Task taskInstance = new Task(
    id: id,
    taskDefinitionId: taskDefinitionId,
    taskDefinitionVersion: taskDefinitionVersion,
    taskDefinitionDisplayName: taskDefinitionDisplayName,
    workflowId: workflowId,
    workflowDisplayName: workflowDisplayName,
    state: state,
    ultimateParentTask: ultimateParentTask,
    parentTask: parentTask,
    childTasks: childTasks,
    correlationIds: correlationIds,
    varVersion: varVersion,
    terminalState: terminalState,
    asAtLastTransition: asAtLastTransition,
    fields: fields,
    stackingKey: stackingKey,
    stack: stack,
    actionLogIdCreated: actionLogIdCreated,
    actionLogIdModified: actionLogIdModified,
    actionLogIdSubmitted: actionLogIdSubmitted,
    hierarchicalPosition: hierarchicalPosition,
    completionStatus: completionStatus,
    openDuration: openDuration,
    openDurationSinceLastUpdate: openDurationSinceLastUpdate,
    openDurationSinceLastTransition: openDurationSinceLastTransition);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
