# Finbourne.Workflow.Sdk.Model.EventHandler
Information about an Event Handler

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**VarVersion** | [**VersionInfo**](VersionInfo.md) |  | [optional] 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**Status** | **string** | The current status of the event handler | 
**EventMatchingPattern** | [**EventMatchingPattern**](EventMatchingPattern.md) |  | [optional] 
**ScheduleMatchingPattern** | [**ScheduleMatchingPattern**](ScheduleMatchingPattern.md) |  | [optional] 
**RunAsUserId** | [**EventHandlerMapping**](EventHandlerMapping.md) |  | 
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionAsAt** | **DateTimeOffset?** | AsAt of the required task definition | [optional] 
**TaskActivity** | [**TaskActivityResponse**](TaskActivityResponse.md) |  | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

