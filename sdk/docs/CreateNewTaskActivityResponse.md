# Finbourne.Workflow.Sdk.Model.CreateNewTaskActivityResponse
Read only Create new task response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of task activity | [optional] 
**InitialTrigger** | **string** | Trigger to supply to all tasks to be made | [optional] 
**CorrelationIds** | [**List&lt;EventHandlerMapping&gt;**](EventHandlerMapping.md) | The event to correlation ID mappings | [optional] 
**TaskFields** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | The event to task field mappings | [optional] 
**ScheduleDependentTaskFields** | [**Dictionary&lt;string, ScheduledTimeAdjustment&gt;**](ScheduledTimeAdjustment.md) | The Schedule dependent task field mappings. Only relevant if a Finbourne.Workflow.WebApi.Common.Dto.Json.EventHandlers.ScheduleMatchingPattern is specified | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "example type";
string initialTrigger = "example initialTrigger";
List<EventHandlerMapping> correlationIds = new List<EventHandlerMapping>();
Dictionary<string, FieldMapping> taskFields = new Dictionary<string, FieldMapping>();
Dictionary<string, ScheduledTimeAdjustment> scheduleDependentTaskFields = new Dictionary<string, ScheduledTimeAdjustment>();

CreateNewTaskActivityResponse createNewTaskActivityResponseInstance = new CreateNewTaskActivityResponse(
    type: type,
    initialTrigger: initialTrigger,
    correlationIds: correlationIds,
    taskFields: taskFields,
    scheduleDependentTaskFields: scheduleDependentTaskFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
