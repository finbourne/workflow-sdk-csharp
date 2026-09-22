# Finbourne.Workflow.Sdk.Model.CalendarContext
A named time zone and set of holiday calendars.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name the schedule and the date and time adjustments use to name this context | 
**VarTimeZone** | **string** | The time zone to use. A TZ identifier, for example \&quot;Europe/London\&quot; | 
**HolidayCalendars** | [**List&lt;CalendarReference&gt;**](CalendarReference.md) | The holiday calendars that decide which dates are business days in this context | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string name = "name";
string varTimeZone = "varTimeZone";
List<CalendarReference> holidayCalendars = new List<CalendarReference>();

CalendarContext calendarContextInstance = new CalendarContext(
    name: name,
    varTimeZone: varTimeZone,
    holidayCalendars: holidayCalendars);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
