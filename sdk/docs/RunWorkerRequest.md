# Finbourne.Workflow.Sdk.Model.RunWorkerRequest
Request to Create a new worker

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Parameters** | [**List&lt;ParameterValue&gt;**](ParameterValue.md) | The Parameter and their values. | 
**WorkerTimeout** | **int?** | The timeout in seconds for the worker | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<ParameterValue> parameters = new List<ParameterValue>();

RunWorkerRequest runWorkerRequestInstance = new RunWorkerRequest(
    parameters: parameters,
    workerTimeout: workerTimeout);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
