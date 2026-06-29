# Finbourne.Workflow.Sdk.Model.PropertyValue
The value of a property. Exactly one of Finbourne.Workflow.WebApi.Common.Dto.Json.Properties.PropertyValue.LabelValue, Finbourne.Workflow.WebApi.Common.Dto.Json.Properties.PropertyValue.MetricValue or Finbourne.Workflow.WebApi.Common.Dto.Json.Properties.PropertyValue.LabelValueSet should be supplied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LabelValue** | **string** | The value of a text property. | [optional] 
**MetricValue** | [**MetricValue**](MetricValue.md) |  | [optional] 
**LabelValueSet** | [**LabelValueSet**](LabelValueSet.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string labelValue = "example labelValue";
MetricValue? metricValue = new MetricValue();

LabelValueSet? labelValueSet = new LabelValueSet();


PropertyValue propertyValueInstance = new PropertyValue(
    labelValue: labelValue,
    metricValue: metricValue,
    labelValueSet: labelValueSet);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
