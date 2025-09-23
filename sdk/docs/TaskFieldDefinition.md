# Finbourne.Workflow.Sdk.Model.TaskFieldDefinition
Defines a Task Definition Field

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of this Field | 
**Type** | **string** | The value type for the field. Available values are: \&quot;String\&quot;, \&quot;Decimal\&quot;, \&quot;DateTime\&quot;, \&quot;Boolean\&quot;) | 
**ReadOnlyStates** | [**ReadOnlyStates**](ReadOnlyStates.md) |  | [optional] 
**ValueConstraints** | [**ValueConstraints**](ValueConstraints.md) |  | [optional] 
**DisplayName** | **string** | Display name for field definition | [optional] 
**Description** | **string** | Description for field definition | [optional] 
**Category** | **string** | Category for field definition | [optional] 
**ContainsUrl** | **bool?** | Field contains url | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string name = "name";
string type = "type";
ReadOnlyStates? readOnlyStates = new ReadOnlyStates();

ValueConstraints? valueConstraints = new ValueConstraints();

string displayName = "example displayName";
string description = "example description";
string category = "example category";
bool? containsUrl = //"True";

TaskFieldDefinition taskFieldDefinitionInstance = new TaskFieldDefinition(
    name: name,
    type: type,
    readOnlyStates: readOnlyStates,
    valueConstraints: valueConstraints,
    displayName: displayName,
    description: description,
    category: category,
    containsUrl: containsUrl);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
