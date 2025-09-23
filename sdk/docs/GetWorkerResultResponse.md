# Finbourne.Workflow.Sdk.Model.GetWorkerResultResponse
The RunWorker response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkerStatus** | **string** | The final status of the Worker | 
**Results** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | Results | 
**StatusDetail** | **string** | Detail on the final status | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string workerStatus = "workerStatus";
List<Dictionary<string, Object>> results = new List<Dictionary<string, Object>>();
string statusDetail = "example statusDetail";

GetWorkerResultResponse getWorkerResultResponseInstance = new GetWorkerResultResponse(
    workerStatus: workerStatus,
    results: results,
    statusDetail: statusDetail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
