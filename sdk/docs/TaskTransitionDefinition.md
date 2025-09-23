# Finbourne.Workflow.Sdk.Model.TaskTransitionDefinition
Defines a State change

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromState** | **string** | The State this Transition if coming From | 
**ToState** | **string** | The State this Transition is going To | 
**Trigger** | **string** | The Trigger for this Transition | 
**Guard** | **string** | The Guard for this Transition, if any | [optional] 
**Action** | **string** | The Action to invoke on successful Transition | [optional] 
**DisplayName** | **string** | Display name for transition | [optional] 
**Description** | **string** | Description for transition | [optional] 
**GuardDescription** | **string** | Guard description for transition | [optional] 
**GuardConditionNotMetMessage** | **string** | Message when guard has not been met | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string fromState = "fromState";
string toState = "toState";
string trigger = "trigger";
string guard = "example guard";
string action = "example action";
string displayName = "example displayName";
string description = "example description";
string guardDescription = "example guardDescription";
string guardConditionNotMetMessage = "example guardConditionNotMetMessage";

TaskTransitionDefinition taskTransitionDefinitionInstance = new TaskTransitionDefinition(
    fromState: fromState,
    toState: toState,
    trigger: trigger,
    guard: guard,
    action: action,
    displayName: displayName,
    description: description,
    guardDescription: guardDescription,
    guardConditionNotMetMessage: guardConditionNotMetMessage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
