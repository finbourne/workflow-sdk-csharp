# Finbourne.Workflow.Sdk.Model.WorkflowStructureNodes
The nodes of a Workflow structure graph — the Task Definitions and the Launchers involved

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskDefinitions** | [**List&lt;TaskDefinition&gt;**](TaskDefinition.md) | The Task Definitions that make up the nodes of this Workflow | [optional] 
**Launchers** | [**List&lt;LauncherResponse&gt;**](LauncherResponse.md) | The Launchers of this Workflow, as full Launcher objects. At most the first 10 by launcher id are returned, in the same order as ListLaunchers gives by default. Inactive Launchers are included. When the Workflow has more, launchersTruncated is true and ListLaunchers returns the full set | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<TaskDefinition> taskDefinitions = new List<TaskDefinition>();
List<LauncherResponse> launchers = new List<LauncherResponse>();

WorkflowStructureNodes workflowStructureNodesInstance = new WorkflowStructureNodes(
    taskDefinitions: taskDefinitions,
    launchers: launchers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
