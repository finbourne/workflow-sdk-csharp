# Finbourne.Workflow.Sdk.Model.WorkerConfiguration
Information about how the worker should be executed

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | 
**Url** | **string** | The URL to check, eg: https://www.google.com/ | 
**IntegrationInstanceId** | **string** | The id of the Horizon integration instance the worker executes. | 
**WorkspaceKey** | **string** | The Workspaces key of the multi-query, e.g. &#x60;shared/SomeWorkspace/items/sets/SomeSet&#x60;, read as each run starts. An item of a personal workspace can only be read by the user who saved it, so only runs as that user can use it. | 
**DriveLocationAndFileName** | **string** | Where in Drive to save the results. May contain the placeholders &#x60;{executionId}&#x60;, &#x60;{date:format}&#x60; (when the queries started, UTC) and &#x60;{param:name}&#x60; (a scalar parameter&#39;s value); the extension comes from the format. | 
**Format** | **string** | The format to save in: csv (the default), pipe, excel, json, jsonProper, jsonProperWithLineage, jsonProperByTable, xml, parquet, sqlite or pdf. Several results are one worksheet each for excel, one table each for sqlite, one key each for jsonProperByTable, and otherwise one file each within a zip. | [optional] 
**MayOverwrite** | **bool?** | Whether an existing file of the same name may be overwritten, rather than the run failing. False by default. | [optional] 
**DriveTemplateLocation** | **string** | The Drive path and file name of a template to save with. Only excel and pdf support templates. | [optional] 
**DateTimeFormat** | **string** | The format to write DateTime values in, Luminesce&#39;s default (&#x60;yyyy-MM-dd HH:mm:ss.fff&#x60;) when not given. | [optional] 
**WhenSomeFail** | **bool?** | Whether the results of the queries that succeeded are still saved when others did not, the worker then completing with the status PartiallyCompleted. False by default, the worker then failing with nothing saved. | [optional] 
**KeepForSeconds** | **int?** | How long Luminesce keeps the results once done, e.g. to look into a run or save them again: 2 hours by default, at most 31 days. | [optional] 
**Name** | **string** | Name of the view in Luminesce | 
**JobId** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;
```
 [Fail](./Fail.md)See all compatible oneOf types with WorkerConfiguration

# Example with WorkerConfiguration
{
     Type  =  "Fail"
};
//Create WorkerConfiguration Instance
var workerConfigurationInstance = new workerConfiguration(failInstance)


 * [GroupReconciliation](./GroupReconciliation.md)
 * [HealthCheck](./HealthCheck.md)
 * [HorizonIntegration](./HorizonIntegration.md)
 * [InstantiateRec](./InstantiateRec.md)
 * [LuminesceMultiQuery](./LuminesceMultiQuery.md)
 * [LuminesceView](./LuminesceView.md)
 * [LusidEntityDataQualityCheck](./LusidEntityDataQualityCheck.md)
 * [PortfolioHoldingDataQualityCheck](./PortfolioHoldingDataQualityCheck.md)
 * [PortfolioTransactionDataQualityCheck](./PortfolioTransactionDataQualityCheck.md)
 * [SchedulerJob](./SchedulerJob.md)
 * [Sleep](./Sleep.md)
 * [StructuredResultDataQualityCheck](./StructuredResultDataQualityCheck.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
