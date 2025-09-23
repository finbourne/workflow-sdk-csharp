# Finbourne.Workflow.Sdk.Model.ActionDetailsResponse
Abstracts the kinds of Actions available in a read-only form

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | [optional] 
**ChildTaskConfigurations** | [**List&lt;ResultantChildTaskConfiguration&gt;**](ResultantChildTaskConfiguration.md) | Tasks can be generated from run worker results; this is the configuration | [optional] 
**WorkerId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**WorkerAsAt** | **DateTimeOffset?** | Worker AsAt | [optional] 
**WorkerParameters** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | Parameters for this Worker | [optional] 
**WorkerStatusTriggers** | [**WorkerStatusTriggers**](WorkerStatusTriggers.md) |  | [optional] 
**WorkerTimeout** | **int?** | Worker timeout in seconds | [optional] 
**Trigger** | **string** | Trigger on parent task to be invoked | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;
```
 [CreateChildTasksActionResponse](./CreateChildTasksActionResponse.md)See all compatible oneOf types with ActionDetailsResponse

# Example with ActionDetailsResponse
{
     Type  =  "CreateChildTasksActionResponse"
};
//Create ActionDetailsResponse Instance
var actionDetailsResponseInstance = new actionDetailsResponse(createChildTasksActionResponseInstance)


 * [RunWorkerActionResponse](./RunWorkerActionResponse.md)
 * [TriggerParentTaskActionResponse](./TriggerParentTaskActionResponse.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
