# Finbourne.Workflow.Sdk.Model.EventHandlerMapping
Defines a mapping for event handler properties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MapFrom** | **string** | The field to map from | [optional] 
**SetTo** | **string** | The (constant) value to set | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string mapFrom = "example mapFrom";
string setTo = "example setTo";

EventHandlerMapping eventHandlerMappingInstance = new EventHandlerMapping(
    mapFrom: mapFrom,
    setTo: setTo);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
