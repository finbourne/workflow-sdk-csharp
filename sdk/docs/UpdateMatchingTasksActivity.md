# Finbourne.Workflow.Sdk.Model.UpdateMatchingTasksActivity
Update all matching tasks based on filter matches

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of task activity | 
**Filter** | **string** | The filter that matches on existing tasks | [optional] 
**Trigger** | **string** | Trigger to supply to all tasks that have been matched | 
**CorrelationIds** | [**List&lt;EventHandlerMapping&gt;**](EventHandlerMapping.md) | The event to correlation ID mappings | [optional] 
**TaskFields** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | The event to task field mappings | [optional] 
**ScheduleDependentTaskFields** | [**Dictionary&lt;string, ScheduledTimeAdjustment&gt;**](ScheduledTimeAdjustment.md) | The Schedule dependent task field mappings. Only relevant if a Finbourne.Workflow.WebApi.Common.Dto.Json.EventHandlers.ScheduleMatchingPattern is specified | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
string filter = "example filter";
string trigger = "trigger";
List<EventHandlerMapping> correlationIds = new List<EventHandlerMapping>();
Dictionary<string, FieldMapping> taskFields = new Dictionary<string, FieldMapping>();
Dictionary<string, ScheduledTimeAdjustment> scheduleDependentTaskFields = new Dictionary<string, ScheduledTimeAdjustment>();

UpdateMatchingTasksActivity updateMatchingTasksActivityInstance = new UpdateMatchingTasksActivity(
    type: type,
    filter: filter,
    trigger: trigger,
    correlationIds: correlationIds,
    taskFields: taskFields,
    scheduleDependentTaskFields: scheduleDependentTaskFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
