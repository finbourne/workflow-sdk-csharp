# Finbourne.Workflow.Sdk.Model.TriggerParentTaskAction
Defines a Trigger Parent Task Action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | 
**Trigger** | **string** | Trigger on parent task to be invoked | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
string trigger = "trigger";

TriggerParentTaskAction triggerParentTaskActionInstance = new TriggerParentTaskAction(
    type: type,
    trigger: trigger);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
