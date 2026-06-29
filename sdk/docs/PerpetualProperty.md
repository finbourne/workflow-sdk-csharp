# Finbourne.Workflow.Sdk.Model.PerpetualProperty
A perpetual property (i.e. without effective dates) on a Workflow. A property is deleted by supplying a null Finbourne.Workflow.WebApi.Common.Dto.Json.Properties.PerpetualProperty.Value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The property key in the form {domain}/{scope}/{code}. The domain must be &#39;Workflow&#39;. | 
**Value** | [**PropertyValue**](PropertyValue.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string key = "key";
PropertyValue? value = new PropertyValue();


PerpetualProperty perpetualPropertyInstance = new PerpetualProperty(
    key: key,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
