# Finbourne.Workflow.Sdk.Model.LauncherResponse
A Launcher, which starts a run of one Workflow either at the times a schedule gives or when a matching event arrives

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkflowId** | [**ResourceId**](ResourceId.md) |  | 
**LauncherId** | **string** | The identifier of this Launcher inside its Workflow | 
**DisplayName** | **string** | Human-readable name | 
**Description** | **string** | Human-readable description | [optional] 
**Status** | **string** | The current status of the Launcher. One of - Active, Inactive | 
**LauncherDetails** | [**LauncherDetailsResponse**](LauncherDetailsResponse.md) |  | 
**Summaries** | [**LauncherSummaries**](LauncherSummaries.md) |  | [optional] 
**VarVersion** | [**VersionInfo**](VersionInfo.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

ResourceId workflowId = new ResourceId();
string launcherId = "launcherId";
string displayName = "displayName";
string description = "example description";
string status = "status";
LauncherDetailsResponse launcherDetails = new LauncherDetailsResponse();
LauncherSummaries? summaries = new LauncherSummaries();

VersionInfo? varVersion = new VersionInfo();


LauncherResponse launcherResponseInstance = new LauncherResponse(
    workflowId: workflowId,
    launcherId: launcherId,
    displayName: displayName,
    description: description,
    status: status,
    launcherDetails: launcherDetails,
    summaries: summaries,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
