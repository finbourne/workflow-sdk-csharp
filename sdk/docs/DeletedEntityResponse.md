# Finbourne.Workflow.Sdk.Model.DeletedEntityResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The Uri related to this Entity | [optional] 
**EffectiveFrom** | **DateTimeOffset?** | The EffectiveFrom for this response | [optional] 
**AsAt** | **DateTimeOffset** | The AsAt for this response | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string href = "example href";
List<Link> links = new List<Link>();

DeletedEntityResponse deletedEntityResponseInstance = new DeletedEntityResponse(
    href: href,
    effectiveFrom: effectiveFrom,
    asAt: asAt,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
