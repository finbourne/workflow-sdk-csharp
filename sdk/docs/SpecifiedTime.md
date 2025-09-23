# Finbourne.Workflow.Sdk.Model.SpecifiedTime
A specified time in the day

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hours** | **int** | Hours | 
**Minutes** | **int** | Minutes | 
**Type** | **string** | The type of Time of Day | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";

SpecifiedTime specifiedTimeInstance = new SpecifiedTime(
    hours: hours,
    minutes: minutes,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
