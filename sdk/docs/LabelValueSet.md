# Finbourne.Workflow.Sdk.Model.LabelValueSet
The set of string labels that make up a multi-value property.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | **List&lt;string&gt;** | The distinct string values of the multi-value property. | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<string> values = new List<string>();

LabelValueSet labelValueSetInstance = new LabelValueSet(
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
