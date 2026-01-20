# Finbourne.Workflow.Sdk.Model.RecurrencePattern
The Recurrence Pattern

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeConstraints** | [**TimeConstraints**](TimeConstraints.md) |  | 
**DateRegularity** | [**DateRegularity**](DateRegularity.md) |  | 
**BusinessDayAdjustment** | **string** | The Business Day Adjustment. One of None, Previous, Following, ModifiedPrevious, ModifiedFollowing, HalfMonthModifiedFollowing, Nearest | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

TimeConstraints timeConstraints = new TimeConstraints();
DateRegularity dateRegularity = new DateRegularity();
string businessDayAdjustment = "businessDayAdjustment";

RecurrencePattern recurrencePatternInstance = new RecurrencePattern(
    timeConstraints: timeConstraints,
    dateRegularity: dateRegularity,
    businessDayAdjustment: businessDayAdjustment);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
