# Finbourne.Workflow.Sdk.Model.DateAdjustment
A date adjustment to apply to the scheduled time of an EventHandler with a Finbourne.Workflow.WebApi.Common.Dto.Json.EventHandlers.ScheduleMatchingPattern

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeltaDays** | **int** | The delta to apply to the date part of the scheduled time, in days | 
**BusinessDayAdjustment** | **string** | The Business Day Adjustment | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string businessDayAdjustment = "businessDayAdjustment";

DateAdjustment dateAdjustmentInstance = new DateAdjustment(
    deltaDays: deltaDays,
    businessDayAdjustment: businessDayAdjustment);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
