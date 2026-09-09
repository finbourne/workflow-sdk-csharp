# Finbourne.Workflow.Sdk.Model.ReRunConfiguration
Defines how re-run results for a given (child) TaskDefinitionId should be reconciled against existing (non-terminal) child tasks of the same parent Task instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**ResultsRecurring** | [**ResultsRecurringConfiguration**](ResultsRecurringConfiguration.md) |  | 
**ResultsNotRecurring** | [**ResultsNotRecurringConfiguration**](ResultsNotRecurringConfiguration.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId taskDefinitionId = new ResourceId();
ResultsRecurringConfiguration resultsRecurring = new ResultsRecurringConfiguration();
ResultsNotRecurringConfiguration resultsNotRecurring = new ResultsNotRecurringConfiguration();

ReRunConfiguration reRunConfigurationInstance = new ReRunConfiguration(
    taskDefinitionId: taskDefinitionId,
    resultsRecurring: resultsRecurring,
    resultsNotRecurring: resultsNotRecurring);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
