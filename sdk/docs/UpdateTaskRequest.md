# Finbourne.Workflow.Sdk.Model.UpdateTaskRequest
A request to update a Task

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationIds** | **List&lt;string&gt;** | A set of guid identifiers that allow correlation across the application tier | [optional] 
**Fields** | [**List&lt;TaskInstanceField&gt;**](TaskInstanceField.md) | Defines the fields associated with the update | [optional] 
**StackingKey** | **string** | The key for the Stack that this Task should be added to | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<string> correlationIds = new List<string>();
List<TaskInstanceField> fields = new List<TaskInstanceField>();
string stackingKey = "example stackingKey";

UpdateTaskRequest updateTaskRequestInstance = new UpdateTaskRequest(
    correlationIds: correlationIds,
    fields: fields,
    stackingKey: stackingKey);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
