# Finbourne.Workflow.Sdk.Model.TriggerChildTasksAction
Defines a Trigger Child Tasks Action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | 
**Trigger** | **string** | Trigger on child tasks to be invoked | 
**Filter** | **string** | Optional LUSID filter expression to limit the action to a subset of the child tasks | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
string trigger = "trigger";
string filter = "example filter";

TriggerChildTasksAction triggerChildTasksActionInstance = new TriggerChildTasksAction(
    type: type,
    trigger: trigger,
    filter: filter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
