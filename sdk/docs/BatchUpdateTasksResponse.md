# Finbourne.Workflow.Sdk.Model.BatchUpdateTasksResponse
Defines a representation of tasks that have been updated

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;Task&gt;**](Task.md) | Successful tasks brought back from the BatchUpdate call | [optional] [readonly] 
**Failed** | [**List&lt;ErrorDetail&gt;**](ErrorDetail.md) | Individual failures for each task returned from the BatchUpdate call | [optional] [readonly] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<Task> values = new List<Task>();
List<ErrorDetail> failed = new List<ErrorDetail>();
List<Link> links = new List<Link>();

BatchUpdateTasksResponse batchUpdateTasksResponseInstance = new BatchUpdateTasksResponse(
    values: values,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
