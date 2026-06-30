# Finbourne.Workflow.Sdk.Model.CreateWorkflowRequest
Contains required info to create a new Workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**RootTaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The properties to set on the Workflow, keyed by property key. Optional. | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
ResourceId rootTaskDefinitionId = new ResourceId();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

CreateWorkflowRequest createWorkflowRequestInstance = new CreateWorkflowRequest(
    id: id,
    displayName: displayName,
    description: description,
    rootTaskDefinitionId: rootTaskDefinitionId,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
