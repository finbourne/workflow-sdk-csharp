# Finbourne.Workflow.Sdk.Model.BatchUpsertTaskDefinitionPropertiesResponse
The result of a batch upsert of properties on a Task Definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The properties that were successfully upserted or deleted, keyed by property key. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The properties that could not be upserted or deleted, keyed by property key. | [optional] 
**AsAtDate** | **DateTimeOffset** | The asAt datetime at which the properties were updated or created. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

Dictionary<string, PerpetualProperty> values = new Dictionary<string, PerpetualProperty>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

BatchUpsertTaskDefinitionPropertiesResponse batchUpsertTaskDefinitionPropertiesResponseInstance = new BatchUpsertTaskDefinitionPropertiesResponse(
    values: values,
    failed: failed,
    asAtDate: asAtDate,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
