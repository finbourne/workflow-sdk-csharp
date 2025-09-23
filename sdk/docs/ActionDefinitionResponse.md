# Finbourne.Workflow.Sdk.Model.ActionDefinitionResponse
Defines the Actions for a Task in a read-only form

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The Name of this Action | [optional] 
**RunAsUserId** | **string** | The ID of the user that this action will be performed by. If not specified, the actions will be performed by the \&quot;current user\&quot;. | [optional] 
**ActionDetails** | [**ActionDetailsResponse**](ActionDetailsResponse.md) |  | [optional] 
**DisplayName** | **string** | Schema for the Action | [optional] 
**Description** | **string** | Schema for the Action | [optional] 
**Category** | **string** | Schema for the Action | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string name = "example name";
string runAsUserId = "example runAsUserId";
ActionDetailsResponse? actionDetails = new ActionDetailsResponse();

string displayName = "example displayName";
string description = "example description";
string category = "example category";

ActionDefinitionResponse actionDefinitionResponseInstance = new ActionDefinitionResponse(
    name: name,
    runAsUserId: runAsUserId,
    actionDetails: actionDetails,
    displayName: displayName,
    description: description,
    category: category);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
