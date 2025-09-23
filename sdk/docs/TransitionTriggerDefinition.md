# Finbourne.Workflow.Sdk.Model.TransitionTriggerDefinition
State changes happen in response to Triggers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The key/Name of this Trigger | 
**Trigger** | [**TriggerSchema**](TriggerSchema.md) |  | 
**DisplayName** | **string** | Display name for trigger | [optional] 
**Description** | **string** | Description of trigger | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string name = "name";
TriggerSchema trigger = new TriggerSchema();
string displayName = "example displayName";
string description = "example description";

TransitionTriggerDefinition transitionTriggerDefinitionInstance = new TransitionTriggerDefinition(
    name: name,
    trigger: trigger,
    displayName: displayName,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
