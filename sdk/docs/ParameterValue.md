# Finbourne.Workflow.Sdk.Model.ParameterValue
Defines a Parameter Value

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name | 
**Value** | **Object** | Value which can be a String, Boolean, Decimal or DateTime (ISO 8601) | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string name = "name";

ParameterValue parameterValueInstance = new ParameterValue(
    name: name,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
