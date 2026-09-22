# Finbourne.Workflow.Sdk.Model.WorkflowRun
Information about the run of the Workflow that created this Task, inherited from the root/ultimate parent Task.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The id of this run of the Workflow. Assigned once, when the run is instantiated. | 
**AsAtCreated** | **DateTimeOffset** | The version.asAtCreated of the root/ultimate parent Task of this run. | 
**CompletionStatus** | **string** | The completion status of the root/ultimate parent Task of this run: NotStarted, InProgress, or Completed. | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string completionStatus = "completionStatus";

WorkflowRun workflowRunInstance = new WorkflowRun(
    id: id,
    asAtCreated: asAtCreated,
    completionStatus: completionStatus);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
