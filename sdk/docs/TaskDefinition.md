# Finbourne.Workflow.Sdk.Model.TaskDefinition
Task Definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**VarVersion** | [**VersionInfo**](VersionInfo.md) |  | [optional] 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**States** | [**List&lt;TaskStateDefinition&gt;**](TaskStateDefinition.md) | The states this Task Definition operates over | 
**FieldSchema** | [**List&lt;TaskFieldDefinition&gt;**](TaskFieldDefinition.md) | The Fields that this Task Definition operates on | [optional] 
**InitialState** | [**InitialState**](InitialState.md) |  | 
**Triggers** | [**List&lt;TransitionTriggerDefinition&gt;**](TransitionTriggerDefinition.md) | The Triggers for State transition | [optional] 
**Actions** | [**List&lt;ActionDefinitionResponse&gt;**](ActionDefinitionResponse.md) | The Actions of this Task - executed after a Transition completion | [optional] 
**Transitions** | [**List&lt;TaskTransitionDefinition&gt;**](TaskTransitionDefinition.md) | The Transitions between States | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId id = new ResourceId();
VersionInfo? varVersion = new VersionInfo();

string displayName = "displayName";
string description = "example description";
List<TaskStateDefinition> states = new List<TaskStateDefinition>();
List<TaskFieldDefinition> fieldSchema = new List<TaskFieldDefinition>();
InitialState initialState = new InitialState();
List<TransitionTriggerDefinition> triggers = new List<TransitionTriggerDefinition>();
List<ActionDefinitionResponse> actions = new List<ActionDefinitionResponse>();
List<TaskTransitionDefinition> transitions = new List<TaskTransitionDefinition>();

TaskDefinition taskDefinitionInstance = new TaskDefinition(
    id: id,
    varVersion: varVersion,
    displayName: displayName,
    description: description,
    states: states,
    fieldSchema: fieldSchema,
    initialState: initialState,
    triggers: triggers,
    actions: actions,
    transitions: transitions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
