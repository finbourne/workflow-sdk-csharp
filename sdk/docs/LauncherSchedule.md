# Finbourne.Workflow.Sdk.Model.LauncherSchedule
When a Schedule Launcher starts a run of its Workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalendarContext** | **string** | The name of the calendar context the schedule is read in, which must be one the Launcher declares | 
**RecurrencePattern** | [**RecurrencePattern**](RecurrencePattern.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string calendarContext = "calendarContext";
RecurrencePattern recurrencePattern = new RecurrencePattern();

LauncherSchedule launcherScheduleInstance = new LauncherSchedule(
    calendarContext: calendarContext,
    recurrencePattern: recurrencePattern);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
