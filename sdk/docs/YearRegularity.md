# Finbourne.Workflow.Sdk.Model.YearRegularity
Year Regularity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dates** | [**List&lt;DayOfYear&gt;**](DayOfYear.md) | The dates in the year | 
**Type** | **string** | The type of Date Regularity | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<DayOfYear> dates = new List<DayOfYear>();
string type = "type";

YearRegularity yearRegularityInstance = new YearRegularity(
    dates: dates,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
