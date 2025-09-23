# Finbourne.Workflow.Sdk.Model.BatchUpdateTasksRequest
A request to update multiple Tasks

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UpdateTasks** | [**List&lt;UpdateTaskWithIdAndTriggerRequest&gt;**](UpdateTaskWithIdAndTriggerRequest.md) | A Dictionary of task IDs to UpdateTaskRequest | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<UpdateTaskWithIdAndTriggerRequest> updateTasks = new List<UpdateTaskWithIdAndTriggerRequest>();

BatchUpdateTasksRequest batchUpdateTasksRequestInstance = new BatchUpdateTasksRequest(
    updateTasks: updateTasks);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
