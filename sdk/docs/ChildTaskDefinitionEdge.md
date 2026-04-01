# Finbourne.Workflow.Sdk.Model.ChildTaskDefinitionEdge
Represents a parent-child relationship between two Task Definitions in a Workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Parent** | [**VersionedTaskDefinitionId**](VersionedTaskDefinitionId.md) |  | [optional] 
**Child** | [**VersionedTaskDefinitionId**](VersionedTaskDefinitionId.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

VersionedTaskDefinitionId? parent = new VersionedTaskDefinitionId();

VersionedTaskDefinitionId? child = new VersionedTaskDefinitionId();


ChildTaskDefinitionEdge childTaskDefinitionEdgeInstance = new ChildTaskDefinitionEdge(
    parent: parent,
    child: child);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
