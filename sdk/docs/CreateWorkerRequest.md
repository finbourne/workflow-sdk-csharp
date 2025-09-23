# Finbourne.Workflow.Sdk.Model.CreateWorkerRequest
Request to Create a new worker

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**WorkerConfiguration** | [**WorkerConfiguration**](WorkerConfiguration.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
WorkerConfiguration workerConfiguration = new WorkerConfiguration();

CreateWorkerRequest createWorkerRequestInstance = new CreateWorkerRequest(
    id: id,
    displayName: displayName,
    description: description,
    workerConfiguration: workerConfiguration);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
