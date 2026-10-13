# Finbourne.Workflow.Sdk.Model.LaunchedBy
The Launcher that started a run of a Workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LauncherId** | **string** | The ID of the Launcher inside its Workflow | 
**LauncherType** | **string** | The type of Launcher. One of - Schedule, Event | 
**LauncherAsAt** | **DateTimeOffset** | The version.asAtModified of the Launcher definition that fired | 
**FiredAt** | **DateTimeOffset** | When the Launcher fired. For a Schedule Launcher this is the scheduled trigger time, and for an Event Launcher it is the timestamp of the event | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string launcherId = "launcherId";
string launcherType = "launcherType";

LaunchedBy launchedByInstance = new LaunchedBy(
    launcherId: launcherId,
    launcherType: launcherType,
    launcherAsAt: launcherAsAt,
    firedAt: firedAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
