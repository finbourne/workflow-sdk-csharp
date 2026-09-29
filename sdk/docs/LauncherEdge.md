# Finbourne.Workflow.Sdk.Model.LauncherEdge
Represents the relationship between a Launcher of a Workflow and the Task Definition it starts a run of

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LauncherId** | **string** | The identifier of the Launcher inside its Workflow | [optional] 
**TargetTaskDefinition** | [**VersionedTaskDefinitionId**](VersionedTaskDefinitionId.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string launcherId = "example launcherId";
VersionedTaskDefinitionId? targetTaskDefinition = new VersionedTaskDefinitionId();


LauncherEdge launcherEdgeInstance = new LauncherEdge(
    launcherId: launcherId,
    targetTaskDefinition: targetTaskDefinition);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
