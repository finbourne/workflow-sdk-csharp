# Finbourne.Workflow.Sdk.Model.ResultantChildTaskConfiguration
Child Task Configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultMatchingPattern** | [**ResultMatchingPattern**](ResultMatchingPattern.md) |  | [optional] 
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionAsAt** | **DateTimeOffset?** | TaskDefinition AsAt timestamp | [optional] 
**InitialTrigger** | **string** | The Initial Trigger for automatic start | [optional] 
**ChildTaskFields** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | Field Mappings | 
**MapStackingKeyFrom** | **string** | The field to be mapped as the ChildTasks Stacking Key | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResultMatchingPattern? resultMatchingPattern = new ResultMatchingPattern();

ResourceId taskDefinitionId = new ResourceId();
string initialTrigger = "example initialTrigger";
Dictionary<string, FieldMapping> childTaskFields = new Dictionary<string, FieldMapping>();
string mapStackingKeyFrom = "example mapStackingKeyFrom";

ResultantChildTaskConfiguration resultantChildTaskConfigurationInstance = new ResultantChildTaskConfiguration(
    resultMatchingPattern: resultMatchingPattern,
    taskDefinitionId: taskDefinitionId,
    taskDefinitionAsAt: taskDefinitionAsAt,
    initialTrigger: initialTrigger,
    childTaskFields: childTaskFields,
    mapStackingKeyFrom: mapStackingKeyFrom);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
