# Finbourne.Workflow.Sdk.Model.LauncherDetails
What makes a Launcher start a run of its Workflow, and what it puts on the root task when it does.              The members here belong to every Launcher. Finbourne.Workflow.WebApi.Common.Dto.Json.Launchers.Requests.ScheduleLauncherDetails and Finbourne.Workflow.WebApi.Common.Dto.Json.Launchers.Requests.EventLauncherDetails add what only a schedule or only an event needs

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LauncherType** | **string** | The type of Launcher. One of - Schedule, Event | 
**RunAsUserId** | [**LauncherMapping**](LauncherMapping.md) |  | 
**SetTaskFields** | **Dictionary&lt;string, Object&gt;** | Fields of the root task set to a fixed value, keyed by the field name on the root task definition | [optional] 
**SetCorrelationIds** | **List&lt;string&gt;** | Correlation IDs put on the root task as given | [optional] 
**InitialTrigger** | **string** | The trigger given to the root task once it is made and all of its fields are filled. When it is left out the root task is left in its initial state | [optional] 
**EventMatchingPattern** | [**LauncherEventMatchingPattern**](LauncherEventMatchingPattern.md) |  | 
**MapTaskFields** | [**Dictionary&lt;string, ScheduleTaskFieldMapping&gt;**](ScheduleTaskFieldMapping.md) | Fields of the root task filled from the instant the schedule fired, keyed by the field name on the root task definition | [optional] 
**MapCorrelationIds** | [**List&lt;CorrelationIdMapping&gt;**](CorrelationIdMapping.md) | Correlation IDs of the root task filled from the event | [optional] 
**Schedule** | [**LauncherSchedule**](LauncherSchedule.md) |  | 
**CalendarContexts** | [**List&lt;CalendarContext&gt;**](CalendarContext.md) | The named time zones and holiday calendars this Launcher works in.              Only a Schedule Launcher works in a calendar context | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;
```
 [EventLauncherDetails](./EventLauncherDetails.md)See all compatible oneOf types with LauncherDetails

# Example with LauncherDetails
{
     Type  =  "EventLauncherDetails"
};
//Create LauncherDetails Instance
var launcherDetailsInstance = new launcherDetails(eventLauncherDetailsInstance)


 * [ScheduleLauncherDetails](./ScheduleLauncherDetails.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
