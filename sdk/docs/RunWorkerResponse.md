# Finbourne.Workflow.Sdk.Model.RunWorkerResponse
The RunWorker response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **Guid** | Identifies a Worker run | 
**StatusDetail** | **string** | Detail on the final status | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

Guid runId = "runId";
string statusDetail = "example statusDetail";

RunWorkerResponse runWorkerResponseInstance = new RunWorkerResponse(
    runId: runId,
    statusDetail: statusDetail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
