# Finbourne.Workflow.Sdk.Model.WeekRegularity
Week Regularity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Frequency** | **int** | The frequency of the Week Regularity | 
**DaysOfWeek** | **List&lt;string&gt;** | Days of the week | 
**Type** | **string** | The type of Date Regularity | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<string> daysOfWeek = new List<string>();
string type = "type";

WeekRegularity weekRegularityInstance = new WeekRegularity(
    frequency: frequency,
    daysOfWeek: daysOfWeek,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
