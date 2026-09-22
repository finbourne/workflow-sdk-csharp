# Finbourne.Workflow.Sdk.Model.UpdateLauncherRequest
Contains information for updating a Launcher on a Workflow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Human-readable name | 
**Description** | **string** | Human-readable description | [optional] 
**Status** | **string** | The current status of the Launcher. One of - Active, Inactive | 
**LauncherDetails** | [**LauncherDetails**](LauncherDetails.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
string status = "status";
LauncherDetails launcherDetails = new LauncherDetails();

UpdateLauncherRequest updateLauncherRequestInstance = new UpdateLauncherRequest(
    displayName: displayName,
    description: description,
    status: status,
    launcherDetails: launcherDetails);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
