# Finbourne.Workflow.Sdk.Model.ScheduleMatchingPattern
The Schedule Matching Pattern to trigger on

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | [**ScheduleMatchingPatternContext**](ScheduleMatchingPatternContext.md) |  | 
**RecurrencePattern** | [**RecurrencePattern**](RecurrencePattern.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ScheduleMatchingPatternContext context = new ScheduleMatchingPatternContext();
RecurrencePattern recurrencePattern = new RecurrencePattern();

ScheduleMatchingPattern scheduleMatchingPatternInstance = new ScheduleMatchingPattern(
    context: context,
    recurrencePattern: recurrencePattern);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
