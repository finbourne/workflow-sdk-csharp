# Finbourne.Workflow.Sdk.Model.Worker
Information about the Worker

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**WorkerConfiguration** | [**WorkerConfigurationResponse**](WorkerConfigurationResponse.md) |  | 
**VarVersion** | [**VersionInfo**](VersionInfo.md) |  | [optional] 
**Parameters** | [**List&lt;Parameter&gt;**](Parameter.md) | The Parameters this Worker accepts or requires. | [optional] 
**ResultFields** | [**List&lt;ResultField&gt;**](ResultField.md) | The Fields that the Worker results will come back with. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
WorkerConfigurationResponse workerConfiguration = new WorkerConfigurationResponse();
VersionInfo? varVersion = new VersionInfo();

List<Parameter> parameters = new List<Parameter>();
List<ResultField> resultFields = new List<ResultField>();
List<Link> links = new List<Link>();

Worker workerInstance = new Worker(
    id: id,
    displayName: displayName,
    description: description,
    workerConfiguration: workerConfiguration,
    varVersion: varVersion,
    parameters: parameters,
    resultFields: resultFields,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
