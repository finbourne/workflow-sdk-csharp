# Finbourne.Workflow.Sdk.Model.DateRegularity
A Date Regularity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of Date Regularity | 
**Frequency** | **int** | The frequency of the Week Regularity. For example, a value of 2 indicates every 2 weeks | 
**DaysOfWeek** | **List&lt;string&gt;** | Days of the week. One or more of - Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday | 
**Index** | **string** | Relative index in the month. One of - First, Second, Third, Fourth, Last. For example, to specify the second Tuesday of every month, set DaysOfWeek to [\&quot;Tuesday\&quot;] and Index to \&quot;Second\&quot; | 
**DaysOfMonth** | **List&lt;int&gt;** | Days of the month. For example, to specify the 1st and 15th of every month, set DaysOfMonth to [1, 15] | 
**Dates** | [**List&lt;DayOfYear&gt;**](DayOfYear.md) | The dates in the year | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;
```
 [DayRegularity](./DayRegularity.md)See all compatible oneOf types with DateRegularity

# Example with DateRegularity
{
     Type  =  "DayRegularity"
};
//Create DateRegularity Instance
var dateRegularityInstance = new dateRegularity(dayRegularityInstance)


 * [RelativeMonthRegularity](./RelativeMonthRegularity.md)
 * [SpecificMonthRegularity](./SpecificMonthRegularity.md)
 * [WeekRegularity](./WeekRegularity.md)
 * [YearRegularity](./YearRegularity.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
