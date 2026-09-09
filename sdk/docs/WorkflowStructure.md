# Finbourne.Workflow.Sdk.Model.WorkflowStructure
Describes the structure of a Workflow as a graph of Task Definitions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nodes** | [**WorkflowStructureNodes**](WorkflowStructureNodes.md) |  | [optional] 
**Edges** | [**WorkflowStructureEdges**](WorkflowStructureEdges.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

WorkflowStructureNodes? nodes = new WorkflowStructureNodes();

WorkflowStructureEdges? edges = new WorkflowStructureEdges();


WorkflowStructure workflowStructureInstance = new WorkflowStructure(
    nodes: nodes,
    edges: edges);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
