# Finbourne.Workflow.Sdk.Model.WorkerConfiguration
Information about how the worker should be executed

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of worker | 
**Url** | **string** | The URL to check, eg: https://www.google.com/ | 
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
 * [LuminesceView](./LuminesceView.md)
 * [LusidEntityDataQualityCheck](./LusidEntityDataQualityCheck.md)
 * [SchedulerJob](./SchedulerJob.md)
 * [Sleep](./Sleep.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
