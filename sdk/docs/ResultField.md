# Finbourne.Workflow.Sdk.Model.ResultField
Defines a Worker Result Field

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name | 
**Type** | **string** | The type of this Parameter | 
**DisplayName** | **string** | DisplayName | [optional] 
**Description** | **string** | Description | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string name = "name";
string type = "type";
string displayName = "example displayName";
string description = "example description";

ResultField resultFieldInstance = new ResultField(
    name: name,
    type: type,
    displayName: displayName,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
