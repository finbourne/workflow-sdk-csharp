# Finbourne.Workflow.Sdk.Model.CreateLauncherRequest
Contains information for creating a Launcher on a Workflow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LauncherId** | **string** | The identifier of the Launcher inside its Workflow | 
**DisplayName** | **string** | Human-readable name | 
**Description** | **string** | Human-readable description | [optional] 
**Status** | **string** | The current status of the Launcher. One of - Active, Inactive | 
**LauncherDetails** | [**LauncherDetails**](LauncherDetails.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string launcherId = "launcherId";
string displayName = "displayName";
string description = "example description";
string status = "status";
LauncherDetails launcherDetails = new LauncherDetails();

CreateLauncherRequest createLauncherRequestInstance = new CreateLauncherRequest(
    launcherId: launcherId,
    displayName: displayName,
    description: description,
    status: status,
    launcherDetails: launcherDetails);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
