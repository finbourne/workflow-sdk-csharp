# Finbourne.Workflow.Sdk.Model.SpecificMonthRegularity
Specific Month Regularity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Frequency** | **int** | The frequency of the Specific Month Regularity | 
**DaysOfMonth** | **List&lt;int&gt;** | Days of the month | 
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
