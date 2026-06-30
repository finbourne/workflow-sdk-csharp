# Finbourne.Workflow.Sdk.Model.UpdateWorkflowRequest
Contains required info to update an existing Workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**RootTaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The properties to set on the Workflow, keyed by property key. Optional. A null property value deletes the property. | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
ResourceId rootTaskDefinitionId = new ResourceId();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

UpdateWorkflowRequest updateWorkflowRequestInstance = new UpdateWorkflowRequest(
    displayName: displayName,
    description: description,
    rootTaskDefinitionId: rootTaskDefinitionId,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
