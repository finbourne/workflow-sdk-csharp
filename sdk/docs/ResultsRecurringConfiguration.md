# Finbourne.Workflow.Sdk.Model.ResultsRecurringConfiguration
Behaviour applied to new child task candidates, and to existing child tasks, when their stacking keys match one another

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewTasks** | [**NewTasksRecurringConfiguration**](NewTasksRecurringConfiguration.md) |  | 
**ExistingTasks** | [**ExistingTasksRecurringConfiguration**](ExistingTasksRecurringConfiguration.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

NewTasksRecurringConfiguration newTasks = new NewTasksRecurringConfiguration();
ExistingTasksRecurringConfiguration existingTasks = new ExistingTasksRecurringConfiguration();

ResultsRecurringConfiguration resultsRecurringConfigurationInstance = new ResultsRecurringConfiguration(
    newTasks: newTasks,
    existingTasks: existingTasks);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
