# Finbourne.Workflow.Sdk.Model.Parameter
Defines a Worker Parameter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of this Parameter | 
**Name** | **string** | Name | 
**DisplayName** | **string** | DisplayName | [optional] 
**Description** | **string** | Description | [optional] 
**Required** | **bool** | Required or not | 
**DefaultValue** | **string** | DefaultValue | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
string name = "name";
string displayName = "example displayName";
string description = "example description";
bool required = //"True";
string defaultValue = "example defaultValue";

Parameter varParameterInstance = new Parameter(
    type: type,
    name: name,
    displayName: displayName,
    description: description,
    required: required,
    defaultValue: defaultValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
