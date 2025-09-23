# Finbourne.Workflow.Sdk.Model.CreateChildTasksAction
Defines a Create Child Tasks Action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | 
**ChildTaskConfigurations** | [**List&lt;CreateChildTaskConfiguration&gt;**](CreateChildTaskConfiguration.md) | The Child Task Configurations | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "type";
List<CreateChildTaskConfiguration> childTaskConfigurations = new List<CreateChildTaskConfiguration>();

CreateChildTasksAction createChildTasksActionInstance = new CreateChildTasksAction(
    type: type,
    childTaskConfigurations: childTaskConfigurations);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
