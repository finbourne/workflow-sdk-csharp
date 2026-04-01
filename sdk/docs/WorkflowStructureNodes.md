# Finbourne.Workflow.Sdk.Model.WorkflowStructureNodes
The nodes of a Workflow structure graph — the Task Definitions involved

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskDefinitions** | [**List&lt;TaskDefinition&gt;**](TaskDefinition.md) | The Task Definitions that make up the nodes of this Workflow | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

List<TaskDefinition> taskDefinitions = new List<TaskDefinition>();

WorkflowStructureNodes workflowStructureNodesInstance = new WorkflowStructureNodes(
    taskDefinitions: taskDefinitions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
