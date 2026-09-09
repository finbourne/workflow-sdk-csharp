# Finbourne.Workflow.Sdk.Model.ResultsNotRecurringConfiguration
Behaviour applied when a new child task candidate's stacking key does not match any existing (non-terminal) child task, and to an existing child task whose stacking key is not matched by any new candidate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExistingTasks** | [**ExistingTasksNotRecurringConfiguration**](ExistingTasksNotRecurringConfiguration.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ExistingTasksNotRecurringConfiguration existingTasks = new ExistingTasksNotRecurringConfiguration();

ResultsNotRecurringConfiguration resultsNotRecurringConfigurationInstance = new ResultsNotRecurringConfiguration(
    existingTasks: existingTasks);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
