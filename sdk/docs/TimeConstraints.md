# Finbourne.Workflow.Sdk.Model.TimeConstraints
Time constraints for a Recurrence Pattern

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | **string** | Start date of the Recurrence Pattern e.g. 2025-12-25 | 
**EndDate** | **string** | Optional end date of the Recurrence Pattern e.g. 2025-12-31 | [optional] 
**TimesOfDay** | [**List&lt;TimeOfDay&gt;**](TimeOfDay.md) | Times of the day to run the Recurrence Pattern | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string startDate = "startDate";
string endDate = "example endDate";
List<TimeOfDay> timesOfDay = new List<TimeOfDay>();

TimeConstraints timeConstraintsInstance = new TimeConstraints(
    startDate: startDate,
    endDate: endDate,
    timesOfDay: timesOfDay);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
