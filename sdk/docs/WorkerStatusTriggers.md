# Finbourne.Workflow.Sdk.Model.WorkerStatusTriggers
Defines triggers that will be invoked per Worker outcome

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Started** | **string** | Trigger to invoke when the Worker has Started | [optional] 
**CompletedWithResults** | **string** | Trigger to invoke when the Worker has Completed (with results) | [optional] 
**CompletedNoResults** | **string** | Trigger to invoke when the Worker has Completed (no results) | [optional] 
**FailedToStart** | **string** | Trigger to invoke when the Worker has Failed to Start | [optional] 
**FailedToComplete** | **string** | Trigger to invoke when the Worker has Failed to Complete | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string started = "example started";
string completedWithResults = "example completedWithResults";
string completedNoResults = "example completedNoResults";
string failedToStart = "example failedToStart";
string failedToComplete = "example failedToComplete";

WorkerStatusTriggers workerStatusTriggersInstance = new WorkerStatusTriggers(
    started: started,
    completedWithResults: completedWithResults,
    completedNoResults: completedNoResults,
    failedToStart: failedToStart,
    failedToComplete: failedToComplete);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
