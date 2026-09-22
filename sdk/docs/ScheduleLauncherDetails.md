# Finbourne.Workflow.Sdk.Model.ScheduleLauncherDetails
A Launcher that starts a run of its Workflow at the times a recurrence pattern gives, and can fill date and time fields of the root task from the instant it fired

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LauncherType** | **string** |  | 
**Schedule** | [**LauncherSchedule**](LauncherSchedule.md) |  | 
**CalendarContexts** | [**List&lt;CalendarContext&gt;**](CalendarContext.md) | The named time zones and holiday calendars this Launcher works in.              Only a Schedule Launcher works in a calendar context | [optional] 
**MapTaskFields** | [**Dictionary&lt;string, ScheduleTaskFieldMapping&gt;**](ScheduleTaskFieldMapping.md) | Fields of the root task filled from the instant the schedule fired, keyed by the field name on the root task definition | [optional] 
**RunAsUserId** | [**LauncherMapping**](LauncherMapping.md) |  | 
**SetTaskFields** | **Dictionary&lt;string, Object&gt;** | Fields of the root task set to a fixed value, keyed by the field name on the root task definition | [optional] 
**SetCorrelationIds** | **List&lt;string&gt;** | Correlation IDs put on the root task as given | [optional] 
**InitialTrigger** | **string** | The trigger given to the root task once it is made and all of its fields are filled. When it is left out the root task is left in its initial state | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string launcherType = "launcherType";
LauncherSchedule schedule = new LauncherSchedule();
List<CalendarContext> calendarContexts = new List<CalendarContext>();
Dictionary<string, ScheduleTaskFieldMapping> mapTaskFields = new Dictionary<string, ScheduleTaskFieldMapping>();
LauncherMapping runAsUserId = new LauncherMapping();
Dictionary<string, Object> setTaskFields = new Dictionary<string, Object>();
List<string> setCorrelationIds = new List<string>();
string initialTrigger = "example initialTrigger";

ScheduleLauncherDetails scheduleLauncherDetailsInstance = new ScheduleLauncherDetails(
    launcherType: launcherType,
    schedule: schedule,
    calendarContexts: calendarContexts,
    mapTaskFields: mapTaskFields,
    runAsUserId: runAsUserId,
    setTaskFields: setTaskFields,
    setCorrelationIds: setCorrelationIds,
    initialTrigger: initialTrigger);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
