# Finbourne.Workflow.Sdk.Model.WorkflowStructure
Describes the structure of a Workflow as a graph of its Task Definitions and its Launchers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nodes** | [**WorkflowStructureNodes**](WorkflowStructureNodes.md) |  | [optional] 
**Edges** | [**WorkflowStructureEdges**](WorkflowStructureEdges.md) |  | [optional] 
**LaunchersTruncated** | **bool** | True when the Workflow has more Launchers than were returned inline in nodes.launchers. Call ListLaunchers for the full set | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

WorkflowStructureNodes? nodes = new WorkflowStructureNodes();

WorkflowStructureEdges? edges = new WorkflowStructureEdges();

bool launchersTruncated = //"True";

WorkflowStructure workflowStructureInstance = new WorkflowStructure(
    nodes: nodes,
    edges: edges,
    launchersTruncated: launchersTruncated);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
