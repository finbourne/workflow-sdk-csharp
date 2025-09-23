# Finbourne.Workflow.Sdk.Model.SchedulerJob
Configuration for a Worker that calls a Scheduler Job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | 
**JobId** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
ResourceId jobId = new ResourceId();

SchedulerJob schedulerJobInstance = new SchedulerJob(
    type: type,
    jobId: jobId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
