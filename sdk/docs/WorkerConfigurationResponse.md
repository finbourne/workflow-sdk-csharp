# Finbourne.Workflow.Sdk.Model.WorkerConfigurationResponse
Readonly information about how the worker should be executed

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | 
**Url** | **string** | The URL to check, eg: https://www.google.com/ | [optional] 
**IntegrationInstanceId** | **string** | The id of the Horizon integration instance the worker executes. Null on the library worker. | [optional] 
**WorkspaceKey** | **string** | The Workspaces key of the multi-query the worker runs | [optional] 
**DriveLocationAndFileName** | **string** | Where in Drive the results are saved, which may contain placeholders | [optional] 
**Format** | **string** | The format the results are saved in, csv when not given | [optional] 
**MayOverwrite** | **bool?** | Whether an existing file of the same name may be overwritten | [optional] 
**DriveTemplateLocation** | **string** | The Drive path of the template the results are saved with | [optional] 
**DateTimeFormat** | **string** | The format DateTime values are written in | [optional] 
**WhenSomeFail** | **bool?** | Whether the results of the queries that succeeded are still saved when others did not | [optional] 
**KeepForSeconds** | **int** | How long Luminesce keeps the results once done, in seconds | [optional] 
**Name** | **string** | Name of the view in Luminesce | [optional] 
**JobId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;
```
 [FailResponse](./FailResponse.md)See all compatible oneOf types with WorkerConfigurationResponse

# Example with WorkerConfigurationResponse
{
     Type  =  "FailResponse"
};
//Create WorkerConfigurationResponse Instance
var workerConfigurationResponseInstance = new workerConfigurationResponse(failResponseInstance)


 * [GroupReconciliationResponse](./GroupReconciliationResponse.md)
 * [HealthCheckResponse](./HealthCheckResponse.md)
 * [HorizonIntegrationResponse](./HorizonIntegrationResponse.md)
 * [InstantiateRecResponse](./InstantiateRecResponse.md)
 * [LibraryResponse](./LibraryResponse.md)
 * [LuminesceMultiQueryResponse](./LuminesceMultiQueryResponse.md)
 * [LuminesceViewResponse](./LuminesceViewResponse.md)
 * [LusidEntityDataQualityCheckResponse](./LusidEntityDataQualityCheckResponse.md)
 * [PortfolioHoldingDataQualityCheckResponse](./PortfolioHoldingDataQualityCheckResponse.md)
 * [PortfolioTransactionDataQualityCheckResponse](./PortfolioTransactionDataQualityCheckResponse.md)
 * [SchedulerJobResponse](./SchedulerJobResponse.md)
 * [SleepResponse](./SleepResponse.md)
 * [StructuredResultDataQualityCheckResponse](./StructuredResultDataQualityCheckResponse.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
