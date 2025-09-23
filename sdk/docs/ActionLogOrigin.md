# Finbourne.Workflow.Sdk.Model.ActionLogOrigin
The Action Log Origin contains information about how the Action was created

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskId** | **Guid?** | The Id of the Task that created this Action | [optional] 
**RequestId** | **string** | The request Id of the request that caused this Action to be triggered. This could be the original request that caused a sequence of Actions that resulted in this Action | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

Guid? taskId = "example taskId";
string requestId = "requestId";

ActionLogOrigin actionLogOriginInstance = new ActionLogOrigin(
    taskId: taskId,
    requestId: requestId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
