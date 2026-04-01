# Finbourne.Workflow.Sdk.Model.WorkflowStructureEdges
The edges of a Workflow structure graph — the parent-child relationships between Task Definitions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChildTaskDefinitions** | [**List&lt;ChildTaskDefinitionEdge&gt;**](ChildTaskDefinitionEdge.md) | The child Task Definition relationships | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<ChildTaskDefinitionEdge> childTaskDefinitions = new List<ChildTaskDefinitionEdge>();

WorkflowStructureEdges workflowStructureEdgesInstance = new WorkflowStructureEdges(
    childTaskDefinitions: childTaskDefinitions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
