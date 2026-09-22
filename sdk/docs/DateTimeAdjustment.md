# Finbourne.Workflow.Sdk.Model.DateTimeAdjustment
A change applied to the date and the time of a source value, in a named calendar context.              At least one of Finbourne.Workflow.WebApi.Common.Dto.Json.Launchers.DateTimeAdjustment.DateAdjustment or Finbourne.Workflow.WebApi.Common.Dto.Json.Launchers.DateTimeAdjustment.TimeAdjustment must be given

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalendarContext** | **string** | The name of the calendar context this change happens in, which must be one the Launcher declares. When it is left out a Schedule Launcher uses the context of its schedule | [optional] 
**DateAdjustment** | [**DateAdjustment**](DateAdjustment.md) |  | [optional] 
**TimeAdjustment** | [**TimeAdjustment**](TimeAdjustment.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string calendarContext = "example calendarContext";
DateAdjustment? dateAdjustment = new DateAdjustment();

TimeAdjustment? timeAdjustment = new TimeAdjustment();


DateTimeAdjustment dateTimeAdjustmentInstance = new DateTimeAdjustment(
    calendarContext: calendarContext,
    dateAdjustment: dateAdjustment,
    timeAdjustment: timeAdjustment);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
