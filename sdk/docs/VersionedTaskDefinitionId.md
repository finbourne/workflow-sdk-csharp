# Finbourne.Workflow.Sdk.Model.VersionedTaskDefinitionId
A Task Definition Id with an optional asAt timestamp identifying a specific version

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TaskDefinitionAsAt** | **DateTimeOffset?** | The asAt time of this version of the Task Definition. Null means the latest version. | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId? taskDefinitionId = new ResourceId();


VersionedTaskDefinitionId versionedTaskDefinitionIdInstance = new VersionedTaskDefinitionId(
    taskDefinitionId: taskDefinitionId,
    taskDefinitionAsAt: taskDefinitionAsAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
