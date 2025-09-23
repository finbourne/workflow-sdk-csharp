# Finbourne.Workflow.Sdk.Model.RelativeMonthRegularity
Relative Month Regularity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Frequency** | **int** | The frequency of the Relative Month Regularity | 
**DaysOfWeek** | **List&lt;string&gt;** | Days of the week | 
**Index** | **string** | Relative index in the month | 
**Type** | **string** | The type of Date Regularity | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<string> daysOfWeek = new List<string>();
string index = "index";
string type = "type";

RelativeMonthRegularity relativeMonthRegularityInstance = new RelativeMonthRegularity(
    frequency: frequency,
    daysOfWeek: daysOfWeek,
    index: index,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
