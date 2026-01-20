# Finbourne.Workflow.Sdk.Model.ScheduleMatchingPatternContext
Context for a Schedule Matching Pattern

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarTimeZone** | **string** | The time zone to use. A TZ Identifier e.g. \&quot;Europe/London\&quot; | 
**HolidayCalendars** | [**List&lt;CalendarReference&gt;**](CalendarReference.md) | References to any Holiday Calendars to use | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string varTimeZone = "varTimeZone";
List<CalendarReference> holidayCalendars = new List<CalendarReference>();

ScheduleMatchingPatternContext scheduleMatchingPatternContextInstance = new ScheduleMatchingPatternContext(
    varTimeZone: varTimeZone,
    holidayCalendars: holidayCalendars);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
