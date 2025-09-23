# Finbourne.Workflow.Sdk.Model.UpdateWorkerRequest
Request to Update a new worker

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**WorkerConfiguration** | **Object** | Information about how the worker should be executed | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";

UpdateWorkerRequest updateWorkerRequestInstance = new UpdateWorkerRequest(
    displayName: displayName,
    description: description,
    workerConfiguration: workerConfiguration);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
