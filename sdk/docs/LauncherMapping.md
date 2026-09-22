# Finbourne.Workflow.Sdk.Model.LauncherMapping
A value a Launcher either gives as it is or takes from somewhere.              Exactly one of Finbourne.Workflow.WebApi.Common.Dto.Json.Launchers.LauncherMapping.SetTo or Finbourne.Workflow.WebApi.Common.Dto.Json.Launchers.LauncherMapping.MapFrom must be given. Only an Event Launcher has an event to take a value from, so a Schedule Launcher can only use Finbourne.Workflow.WebApi.Common.Dto.Json.Launchers.LauncherMapping.SetTo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SetTo** | **string** | The value to use, given as it is | [optional] 
**MapFrom** | **string** | The path the value is taken from, for example header.userId | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string setTo = "example setTo";
string mapFrom = "example mapFrom";

LauncherMapping launcherMappingInstance = new LauncherMapping(
    setTo: setTo,
    mapFrom: mapFrom);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
