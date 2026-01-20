# Finbourne.Workflow.Sdk.Model.SpecificMonthRegularity
Specific Month Regularity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Frequency** | **int** | The frequency of the Specific Month Regularity. For example, a value of 2 indicates every 2 months | 
**DaysOfMonth** | **List&lt;int&gt;** | Days of the month. For example, to specify the 1st and 15th of every month, set DaysOfMonth to [1, 15] | 
**Type** | **string** | The type of Date Regularity | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<int> daysOfMonth = new List<int>();
string type = "type";

SpecificMonthRegularity specificMonthRegularityInstance = new SpecificMonthRegularity(
    frequency: frequency,
    daysOfMonth: daysOfMonth,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
