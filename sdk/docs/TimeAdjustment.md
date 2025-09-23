# Finbourne.Workflow.Sdk.Model.TimeAdjustment
A time adjustment to apply to the scheduled time of an EventHandler with a Finbourne.Workflow.WebApi.Common.Dto.Json.EventHandlers.ScheduleMatchingPattern

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SetTo** | [**SpecifiedTime**](SpecifiedTime.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

SpecifiedTime setTo = new SpecifiedTime();

TimeAdjustment timeAdjustmentInstance = new TimeAdjustment(
    setTo: setTo);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
