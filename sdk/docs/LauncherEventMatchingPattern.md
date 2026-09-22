# Finbourne.Workflow.Sdk.Model.LauncherEventMatchingPattern
Which events make an Event Launcher start a run of its Workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The type of event to listen for. The list of available event types can be discovered by calling the ListEventTypes API endpoint in the Notifications service. Note that event types published by the Workflow service itself are not supported as Launcher triggers, and giving one will be rejected. | 
**Filter** | **string** | A filter on the event. See https://support.lusid.com/filtering-results-from-lusid for more information. An empty filter matches every event of the type | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string eventType = "eventType";
string filter = "example filter";

LauncherEventMatchingPattern launcherEventMatchingPatternInstance = new LauncherEventMatchingPattern(
    eventType: eventType,
    filter: filter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
