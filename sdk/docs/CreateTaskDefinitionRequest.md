# Finbourne.Workflow.Sdk.Model.CreateTaskDefinitionRequest
Contains required info to create a new Task Definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**States** | [**List&lt;TaskStateDefinition&gt;**](TaskStateDefinition.md) | The states this Task Definition operates over | 
**FieldSchema** | [**List&lt;TaskFieldDefinition&gt;**](TaskFieldDefinition.md) | Defines the fields associated with this Task | [optional] 
**InitialState** | [**InitialState**](InitialState.md) |  | 
**Triggers** | [**List&lt;TransitionTriggerDefinition&gt;**](TransitionTriggerDefinition.md) | Triggers | [optional] 
**Transitions** | [**List&lt;TaskTransitionDefinition&gt;**](TaskTransitionDefinition.md) | Transitions | [optional] 
**Actions** | [**List&lt;ActionDefinition&gt;**](ActionDefinition.md) | Actions | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
List<TaskStateDefinition> states = new List<TaskStateDefinition>();
List<TaskFieldDefinition> fieldSchema = new List<TaskFieldDefinition>();
InitialState initialState = new InitialState();
List<TransitionTriggerDefinition> triggers = new List<TransitionTriggerDefinition>();
List<TaskTransitionDefinition> transitions = new List<TaskTransitionDefinition>();
List<ActionDefinition> actions = new List<ActionDefinition>();

CreateTaskDefinitionRequest createTaskDefinitionRequestInstance = new CreateTaskDefinitionRequest(
    id: id,
    displayName: displayName,
    description: description,
    states: states,
    fieldSchema: fieldSchema,
    initialState: initialState,
    triggers: triggers,
    transitions: transitions,
    actions: actions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
