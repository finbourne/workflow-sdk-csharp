# Finbourne.Workflow.Sdk.Model.ResourceListOfTask

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;Task&gt;**](Task.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<Task> values = new List<Task>();
string href = "example href";
List<Link> links = new List<Link>();
string nextPage = "example nextPage";
string previousPage = "example previousPage";

ResourceListOfTask resourceListOfTaskInstance = new ResourceListOfTask(
    values: values,
    href: href,
    links: links,
    nextPage: nextPage,
    previousPage: previousPage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
