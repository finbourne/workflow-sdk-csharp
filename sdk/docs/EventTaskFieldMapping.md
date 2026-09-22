# Finbourne.Workflow.Sdk.Model.EventTaskFieldMapping
How an Event Launcher fills one field of the root task from the event that arrived

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MapFrom** | **string** | The path into the event the value is taken from, for example header.timestamp | 
**DateTimeAdjustment** | [**DateTimeAdjustment**](DateTimeAdjustment.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string mapFrom = "mapFrom";
DateTimeAdjustment? dateTimeAdjustment = new DateTimeAdjustment();


EventTaskFieldMapping eventTaskFieldMappingInstance = new EventTaskFieldMapping(
    mapFrom: mapFrom,
    dateTimeAdjustment: dateTimeAdjustment);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
