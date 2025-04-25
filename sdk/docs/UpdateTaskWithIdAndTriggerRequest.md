# Finbourne.Workflow.Sdk.Model.UpdateTaskWithIdAndTriggerRequest
A request to update multiple Tasks  Includes a trigger which is supplied from route in single update request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskInstanceId** | **string** | The ID of the task instance | [optional] 
**CorrelationIds** | **List&lt;string&gt;** | A set of guid identifiers that allow correlation across the application tier | [optional] 
**Fields** | [**List&lt;TaskInstanceField&gt;**](TaskInstanceField.md) | Defines the fields associated with the update | [optional] 
**StackingKey** | **string** | The key for the Stack that this Task should be added to | [optional] 
**TriggerName** | **string** | The trigger we want to update the task with | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

