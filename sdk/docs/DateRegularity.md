# Finbourne.Workflow.Sdk.Model.DateRegularity
A Date Regularity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of Date Regularity | 
**Frequency** | **int** | The frequency of the Week Regularity | 
**DaysOfWeek** | **List&lt;string&gt;** | Days of the week | 
**Index** | **string** | Relative index in the month | 
**DaysOfMonth** | **List&lt;int&gt;** | Days of the month | 
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
