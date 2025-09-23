# Finbourne.Workflow.Sdk.Model.EventMatchingPattern
The matching event pattern object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The type of event to subscribe to. The list of available event types can be discovered by calling the ‘List available EventTypes’ API endpoint in the Notifications service | 
**Filter** | **string** | A filter on the event. See https://support.lusid.com/filtering-results-from-lusid for more information. If not provided, all events will be matched. | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string eventType = "eventType";
string filter = "example filter";

EventMatchingPattern eventMatchingPatternInstance = new EventMatchingPattern(
    eventType: eventType,
    filter: filter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
