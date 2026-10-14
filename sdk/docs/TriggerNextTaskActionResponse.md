# Finbourne.Workflow.Sdk.Model.TriggerNextTaskActionResponse
Trigger Next Task Action Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | [optional] 
**DefaultTrigger** | **string** | Trigger sent to the next task when this task has no nextTaskInitialTrigger of its own | [optional] 
**FallbackActions** | [**TriggerNextTaskFallbackActionsResponse**](TriggerNextTaskFallbackActionsResponse.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "example type";
string defaultTrigger = "example defaultTrigger";
TriggerNextTaskFallbackActionsResponse? fallbackActions = new TriggerNextTaskFallbackActionsResponse();


TriggerNextTaskActionResponse triggerNextTaskActionResponseInstance = new TriggerNextTaskActionResponse(
    type: type,
    defaultTrigger: defaultTrigger,
    fallbackActions: fallbackActions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
