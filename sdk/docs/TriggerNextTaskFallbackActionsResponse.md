# Finbourne.Workflow.Sdk.Model.TriggerNextTaskFallbackActionsResponse
Actions on the same task definition that a Trigger Next Task action runs instead of triggering the next task

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndOfSequence** | **string** | Run when this task has no next task to trigger | [optional] 
**NextTaskError** | **string** | Run when the next task cannot be triggered, e.g. it was deleted or is not in its initial state | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string endOfSequence = "example endOfSequence";
string nextTaskError = "example nextTaskError";

TriggerNextTaskFallbackActionsResponse triggerNextTaskFallbackActionsResponseInstance = new TriggerNextTaskFallbackActionsResponse(
    endOfSequence: endOfSequence,
    nextTaskError: nextTaskError);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
