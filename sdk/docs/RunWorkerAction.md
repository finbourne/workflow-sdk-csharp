# Finbourne.Workflow.Sdk.Model.RunWorkerAction
Defines a Run Worker Action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | 
**WorkerId** | [**ResourceId**](ResourceId.md) |  | 
**WorkerAsAt** | **DateTimeOffset?** | Worker AsAt | [optional] 
**WorkerParameters** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | Parameters for this Worker | [optional] 
**WorkerStatusTriggers** | [**WorkerStatusTriggers**](WorkerStatusTriggers.md) |  | [optional] 
**ChildTaskConfigurations** | [**List&lt;ResultantChildTaskConfiguration&gt;**](ResultantChildTaskConfiguration.md) | Tasks can be generated from run worker results; this is the configuration | [optional] 
**WorkerTimeout** | **int?** | Worker WorkerTimeout in seconds | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
ResourceId workerId = new ResourceId();
Dictionary<string, FieldMapping> workerParameters = new Dictionary<string, FieldMapping>();
WorkerStatusTriggers? workerStatusTriggers = new WorkerStatusTriggers();

List<ResultantChildTaskConfiguration> childTaskConfigurations = new List<ResultantChildTaskConfiguration>();

RunWorkerAction runWorkerActionInstance = new RunWorkerAction(
    type: type,
    workerId: workerId,
    workerAsAt: workerAsAt,
    workerParameters: workerParameters,
    workerStatusTriggers: workerStatusTriggers,
    childTaskConfigurations: childTaskConfigurations,
    workerTimeout: workerTimeout);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
