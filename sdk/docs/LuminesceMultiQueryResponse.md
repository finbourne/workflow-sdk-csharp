# Finbourne.Workflow.Sdk.Model.LuminesceMultiQueryResponse
Readonly configuration for the Luminesce custom multi-query Worker

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | [optional] 
**WorkspaceKey** | **string** | The Workspaces key of the multi-query the worker runs | [optional] 
**DriveLocationAndFileName** | **string** | Where in Drive the results are saved, which may contain placeholders | [optional] 
**Format** | **string** | The format the results are saved in, csv when not given | [optional] 
**MayOverwrite** | **bool?** | Whether an existing file of the same name may be overwritten | [optional] 
**DriveTemplateLocation** | **string** | The Drive path of the template the results are saved with | [optional] 
**DateTimeFormat** | **string** | The format DateTime values are written in | [optional] 
**WhenSomeFail** | **bool?** | Whether the results of the queries that succeeded are still saved when others did not | [optional] 
**KeepForSeconds** | **int** | How long Luminesce keeps the results once done, in seconds | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string type = "example type";
string workspaceKey = "example workspaceKey";
string driveLocationAndFileName = "example driveLocationAndFileName";
string format = "example format";
bool? mayOverwrite = //"True";
string driveTemplateLocation = "example driveTemplateLocation";
string dateTimeFormat = "example dateTimeFormat";
bool? whenSomeFail = //"True";

LuminesceMultiQueryResponse luminesceMultiQueryResponseInstance = new LuminesceMultiQueryResponse(
    type: type,
    workspaceKey: workspaceKey,
    driveLocationAndFileName: driveLocationAndFileName,
    format: format,
    mayOverwrite: mayOverwrite,
    driveTemplateLocation: driveTemplateLocation,
    dateTimeFormat: dateTimeFormat,
    whenSomeFail: whenSomeFail,
    keepForSeconds: keepForSeconds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
