# Finbourne.Workflow.Sdk.Model.ScheduleTaskFieldMapping
How a Schedule Launcher fills one field of the root task from the instant the schedule fired

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MapFrom** | **string** | The value the field is taken from. One of - ScheduledTime | 
**DateTimeAdjustment** | [**DateTimeAdjustment**](DateTimeAdjustment.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string mapFrom = "mapFrom";
DateTimeAdjustment? dateTimeAdjustment = new DateTimeAdjustment();


ScheduleTaskFieldMapping scheduleTaskFieldMappingInstance = new ScheduleTaskFieldMapping(
    mapFrom: mapFrom,
    dateTimeAdjustment: dateTimeAdjustment);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
