# Finbourne.Workflow.Sdk.Model.TriggerParentTaskActionResponse
Defines a read-only Trigger Parent Task Action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | [optional] 
**Trigger** | **string** | Trigger on parent task to be invoked | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "example type";
string trigger = "example trigger";

TriggerParentTaskActionResponse triggerParentTaskActionResponseInstance = new TriggerParentTaskActionResponse(
    type: type,
    trigger: trigger);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
