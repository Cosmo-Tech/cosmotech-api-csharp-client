# Com.Cosmotech.Model.Scenario

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Scenario unique identifier | [optional] [readonly] 
**Name** | **string** | the Scenario name | 
**Description** | **string** | the Scenario description | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**ParentId** | **string** | the Scenario parent id | [optional] 
**OwnerId** | **string** | the user id which own this Scenario | [optional] [readonly] 
**UserList** | [**List&lt;ScenarioUser&gt;**](ScenarioUser.md) | the list of users Id with their role | [optional] 
**SimulatorId** | **string** | the Simulator Id associated with this Scenario | [optional] [readonly] 
**Analyses** | [**List&lt;ScenarioAnalysis&gt;**](ScenarioAnalysis.md) | the configuration for next Analysis | [optional] 
**SuccessfulAnalyses** | [**List&lt;ScenarioSuccessfulAnalysis&gt;**](ScenarioSuccessfulAnalysis.md) | the configuration and information for last successful Analyses Runs | [optional] [readonly] 
**FailedAnalyses** | [**List&lt;ScenarioFailedAnalysis&gt;**](ScenarioFailedAnalysis.md) | the configuration and information for last failed Analyses Runs | [optional] [readonly] 
**RunningAnalyses** | [**List&lt;ScenarioRunningAnalysis&gt;**](ScenarioRunningAnalysis.md) | the configuration and information for currently running Analyses Runs | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

