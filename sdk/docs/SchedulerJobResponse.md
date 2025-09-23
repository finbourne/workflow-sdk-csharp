# Finbourne.Workflow.Sdk.Model.SchedulerJobResponse
Readonly configuration for a Worker that calls a Scheduler job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | [optional] 
**JobId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "example type";
ResourceId? jobId = new ResourceId();


SchedulerJobResponse schedulerJobResponseInstance = new SchedulerJobResponse(
    type: type,
    jobId: jobId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
