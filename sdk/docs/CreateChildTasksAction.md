# Finbourne.Workflow.Sdk.Model.CreateChildTasksAction
Defines a Create Child Tasks Action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | 
**ChildTaskConfigurations** | [**List&lt;CreateChildTaskConfiguration&gt;**](CreateChildTaskConfiguration.md) | The Child Task Configurations | 
**Ordering** | **string** | How the created child tasks are ordered for execution: Parallel (default) or Series. In Series the child tasks form a chain and only the first is started; each later one is started by its predecessor&#39;s TriggerNextTask action, or by another trigger such as a TriggerChildTasks filter on previousTask. Without one, the chain stops after the first child. | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
List<CreateChildTaskConfiguration> childTaskConfigurations = new List<CreateChildTaskConfiguration>();
string ordering = "example ordering";

CreateChildTasksAction createChildTasksActionInstance = new CreateChildTasksAction(
    type: type,
    childTaskConfigurations: childTaskConfigurations,
    ordering: ordering);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
