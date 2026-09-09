# Finbourne.Workflow.Sdk.Model.ExistingTasksRecurringConfiguration
Behaviour applied to an existing (non-terminal) child task whose stacking key matches one or more new child task candidates

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncrementAsAtModified** | **bool** | When true, the existing task&#39;s asAtModified is incremented even if no other change (Trigger or MergeFields) is applied | [optional] 
**Trigger** | **string** | The existing task receives this trigger | [optional] 
**MergeFields** | **List&lt;string&gt;** | The named fields on the existing task are updated with the values from the latest run. Only applies where the new-to-existing stacking key cardinality is one-to-one or one-to-many; unspecified fields are untouched. Data will be merged in even if these fields are in a read-only state. | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

bool incrementAsAtModified = //"True";
string trigger = "example trigger";
List<string> mergeFields = new List<string>();

ExistingTasksRecurringConfiguration existingTasksRecurringConfigurationInstance = new ExistingTasksRecurringConfiguration(
    incrementAsAtModified: incrementAsAtModified,
    trigger: trigger,
    mergeFields: mergeFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
