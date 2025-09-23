# Finbourne.Workflow.Sdk.Model.ActionDetails
Abstracts the kinds of Actions available

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | 
**ChildTaskConfigurations** | [**List&lt;ResultantChildTaskConfiguration&gt;**](ResultantChildTaskConfiguration.md) | Tasks can be generated from run worker results; this is the configuration | 
**WorkerId** | [**ResourceId**](ResourceId.md) |  | 
**WorkerAsAt** | **DateTimeOffset?** | Worker AsAt | [optional] 
**WorkerParameters** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | Parameters for this Worker | [optional] 
**WorkerStatusTriggers** | [**WorkerStatusTriggers**](WorkerStatusTriggers.md) |  | [optional] 
**WorkerTimeout** | **int?** | Worker WorkerTimeout in seconds | [optional] 
**Trigger** | **string** | Trigger on parent task to be invoked | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;
```
 [CreateChildTasksAction](./CreateChildTasksAction.md)See all compatible oneOf types with ActionDetails

# Example with ActionDetails
{
     Type  =  "CreateChildTasksAction"
};
//Create ActionDetails Instance
var actionDetailsInstance = new actionDetails(createChildTasksActionInstance)


 * [RunWorkerAction](./RunWorkerAction.md)
 * [TriggerParentTaskAction](./TriggerParentTaskAction.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
