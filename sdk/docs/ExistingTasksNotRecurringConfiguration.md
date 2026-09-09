# Finbourne.Workflow.Sdk.Model.ExistingTasksNotRecurringConfiguration
Behaviour applied to an existing (non-terminal) child task whose stacking key is not matched by any new child task candidate (i.e. it did not recur on this run)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Trigger** | **string** | The existing task receives this trigger | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string trigger = "example trigger";

ExistingTasksNotRecurringConfiguration existingTasksNotRecurringConfigurationInstance = new ExistingTasksNotRecurringConfiguration(
    trigger: trigger);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
