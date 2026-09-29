# Finbourne.Workflow.Sdk.Model.WorkflowStructureEdges
The edges of a Workflow structure graph — the parent-child relationships between Task Definitions and the relationships between Launchers and the Task Definitions they start

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChildTaskDefinitions** | [**List&lt;ChildTaskDefinitionEdge&gt;**](ChildTaskDefinitionEdge.md) | The child Task Definition relationships | [optional] 
**Launchers** | [**List&lt;LauncherEdge&gt;**](LauncherEdge.md) | The Launcher relationships. There is one entry per Launcher in nodes.launchers, in the same order | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<ChildTaskDefinitionEdge> childTaskDefinitions = new List<ChildTaskDefinitionEdge>();
List<LauncherEdge> launchers = new List<LauncherEdge>();

WorkflowStructureEdges workflowStructureEdgesInstance = new WorkflowStructureEdges(
    childTaskDefinitions: childTaskDefinitions,
    launchers: launchers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
