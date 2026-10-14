# Finbourne.Workflow.Sdk.Model.TriggerNextTaskAction
Defines a Trigger Next Task Action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | 
**DefaultTrigger** | **string** | Trigger sent to the next task when this task has no nextTaskInitialTrigger of its own | [optional] 
**FallbackActions** | [**TriggerNextTaskFallbackActions**](TriggerNextTaskFallbackActions.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
string defaultTrigger = "example defaultTrigger";
TriggerNextTaskFallbackActions? fallbackActions = new TriggerNextTaskFallbackActions();


TriggerNextTaskAction triggerNextTaskActionInstance = new TriggerNextTaskAction(
    type: type,
    defaultTrigger: defaultTrigger,
    fallbackActions: fallbackActions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
