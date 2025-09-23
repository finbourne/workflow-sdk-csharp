# Finbourne.Workflow.Sdk.Model.DeleteTasksRequest
Contains required info to delete Tasks

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskIds** | **List&lt;string&gt;** | The Ids of the Tasks to delete | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<string> taskIds = new List<string>();

DeleteTasksRequest deleteTasksRequestInstance = new DeleteTasksRequest(
    taskIds: taskIds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
