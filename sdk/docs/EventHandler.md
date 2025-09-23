# Finbourne.Workflow.Sdk.Model.EventHandler
Information about an Event Handler

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**VarVersion** | [**VersionInfo**](VersionInfo.md) |  | [optional] 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**Status** | **string** | The current status of the event handler | 
**EventMatchingPattern** | [**EventMatchingPattern**](EventMatchingPattern.md) |  | [optional] 
**ScheduleMatchingPattern** | [**ScheduleMatchingPattern**](ScheduleMatchingPattern.md) |  | [optional] 
**RunAsUserId** | [**EventHandlerMapping**](EventHandlerMapping.md) |  | 
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionAsAt** | **DateTimeOffset?** | AsAt of the required task definition | [optional] 
**TaskActivity** | [**TaskActivityResponse**](TaskActivityResponse.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId id = new ResourceId();
VersionInfo? varVersion = new VersionInfo();

string displayName = "displayName";
string description = "example description";
string status = "status";
EventMatchingPattern? eventMatchingPattern = new EventMatchingPattern();

ScheduleMatchingPattern? scheduleMatchingPattern = new ScheduleMatchingPattern();

EventHandlerMapping runAsUserId = new EventHandlerMapping();
ResourceId taskDefinitionId = new ResourceId();
TaskActivityResponse taskActivity = new TaskActivityResponse();

EventHandler eventHandlerInstance = new EventHandler(
    id: id,
    varVersion: varVersion,
    displayName: displayName,
    description: description,
    status: status,
    eventMatchingPattern: eventMatchingPattern,
    scheduleMatchingPattern: scheduleMatchingPattern,
    runAsUserId: runAsUserId,
    taskDefinitionId: taskDefinitionId,
    taskDefinitionAsAt: taskDefinitionAsAt,
    taskActivity: taskActivity);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
