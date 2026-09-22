# Finbourne.Workflow.Sdk.Model.EventLauncherDetailsResponse
A read only Event Launcher, which starts a run of its Workflow when a matching platform event arrives

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LauncherType** | **string** |  | [optional] 
**EventMatchingPattern** | [**LauncherEventMatchingPattern**](LauncherEventMatchingPattern.md) |  | [optional] 
**MapTaskFields** | [**Dictionary&lt;string, EventTaskFieldMapping&gt;**](EventTaskFieldMapping.md) | Fields of the root task filled from the event, keyed by the field name on the root task definition | [optional] 
**MapCorrelationIds** | [**List&lt;CorrelationIdMapping&gt;**](CorrelationIdMapping.md) | Correlation IDs of the root task filled from the event | [optional] 
**RunAsUserId** | [**LauncherMapping**](LauncherMapping.md) |  | [optional] 
**SetTaskFields** | **Dictionary&lt;string, Object&gt;** | Fields of the root task set to a fixed value, keyed by the field name on the root task definition | [optional] 
**SetCorrelationIds** | **List&lt;string&gt;** | Correlation IDs put on the root task as given | [optional] 
**InitialTrigger** | **string** | The trigger given to the root task once it is made and all of its fields are filled, or null when the root task is left in its initial state | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string launcherType = "example launcherType";
LauncherEventMatchingPattern? eventMatchingPattern = new LauncherEventMatchingPattern();

Dictionary<string, EventTaskFieldMapping> mapTaskFields = new Dictionary<string, EventTaskFieldMapping>();
List<CorrelationIdMapping> mapCorrelationIds = new List<CorrelationIdMapping>();
LauncherMapping? runAsUserId = new LauncherMapping();

Dictionary<string, Object> setTaskFields = new Dictionary<string, Object>();
List<string> setCorrelationIds = new List<string>();
string initialTrigger = "example initialTrigger";

EventLauncherDetailsResponse eventLauncherDetailsResponseInstance = new EventLauncherDetailsResponse(
    launcherType: launcherType,
    eventMatchingPattern: eventMatchingPattern,
    mapTaskFields: mapTaskFields,
    mapCorrelationIds: mapCorrelationIds,
    runAsUserId: runAsUserId,
    setTaskFields: setTaskFields,
    setCorrelationIds: setCorrelationIds,
    initialTrigger: initialTrigger);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
