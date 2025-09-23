# Finbourne.Workflow.Sdk.Model.Stack
Information pertaining to the Tasks Stack if one is present

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemberAddedAsAt** | **DateTimeOffset** | When the Task was added to the Stack | [optional] 
**StackOpenedAsAt** | **DateTimeOffset** | When the Stack was opened | [optional] 
**StackClosedAsAt** | **DateTimeOffset?** | When the Stack was closed | [optional] 
**StackMembershipType** | **string** | Whether the task is the Lead task of the Stack or a Member within the Stack | [optional] 
**StackStatus** | **string** | Status of the Stack (Open/Closed) | [optional] 
**LeadTaskId** | **Guid** | ID of the Lead Task | [optional] 
**LeadTaskState** | **string** | State of the Lead Task | [optional] 
**TasksInStack** | **int** | Number of Tasks in the Stack | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string stackMembershipType = "example stackMembershipType";
string stackStatus = "example stackStatus";
Guid leadTaskId = "example leadTaskId";
string leadTaskState = "example leadTaskState";

Stack stackInstance = new Stack(
    memberAddedAsAt: memberAddedAsAt,
    stackOpenedAsAt: stackOpenedAsAt,
    stackClosedAsAt: stackClosedAsAt,
    stackMembershipType: stackMembershipType,
    stackStatus: stackStatus,
    leadTaskId: leadTaskId,
    leadTaskState: leadTaskState,
    tasksInStack: tasksInStack);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
