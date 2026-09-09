# Finbourne.Workflow.Sdk.Model.NewTasksRecurringConfiguration
Behaviour applied to a new child task candidate whose stacking key matches an existing (non-terminal) child task

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DoNotCreate** | **bool** | When true, the new child task will not be created | [optional] 
**InitialTriggerOverride** | **string** | When DoNotCreate is false, the new child task will be created with this trigger instead of the ChildTaskConfiguration&#39;s InitialTrigger | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

bool doNotCreate = //"True";
string initialTriggerOverride = "example initialTriggerOverride";

NewTasksRecurringConfiguration newTasksRecurringConfigurationInstance = new NewTasksRecurringConfiguration(
    doNotCreate: doNotCreate,
    initialTriggerOverride: initialTriggerOverride);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
