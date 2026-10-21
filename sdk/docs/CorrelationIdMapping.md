# Finbourne.Workflow.Sdk.Model.CorrelationIdMapping
How an Event Launcher fills one correlation ID of the root task from the event that arrived.              A mapped correlation ID joins the fixed correlation IDs of the Launcher

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MapFrom** | **string** | The path into the event the correlation ID is taken from, for example body.fileId. The path must be in the schema of the event type, and a value of any type is written as a string | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string mapFrom = "mapFrom";

CorrelationIdMapping correlationIdMappingInstance = new CorrelationIdMapping(
    mapFrom: mapFrom);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
