# Finbourne.Workflow.Sdk.Model.CreateChildTaskConfiguration
Create Child Task Configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionAsAt** | **DateTimeOffset?** | TaskDefinition AsAt timestamp | [optional] 
**InitialTrigger** | **string** | The Initial Trigger for automatic start | [optional] 
**ChildTaskFields** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | Field Mappings | [optional] 
**MapStackingKeyFrom** | **string** | If present, the value of this field on the parent task will be the Stacking Key on any created child tasks | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId taskDefinitionId = new ResourceId();
string initialTrigger = "example initialTrigger";
Dictionary<string, FieldMapping> childTaskFields = new Dictionary<string, FieldMapping>();
string mapStackingKeyFrom = "example mapStackingKeyFrom";

CreateChildTaskConfiguration createChildTaskConfigurationInstance = new CreateChildTaskConfiguration(
    taskDefinitionId: taskDefinitionId,
    taskDefinitionAsAt: taskDefinitionAsAt,
    initialTrigger: initialTrigger,
    childTaskFields: childTaskFields,
    mapStackingKeyFrom: mapStackingKeyFrom);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
