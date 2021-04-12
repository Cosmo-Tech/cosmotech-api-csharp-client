# Com.Cosmotech.Model.ScenarioAllOf
a Scenario with detailed information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SimulatorId** | **string** | the Simulator Id associated with this Scenario | [optional] [readonly] 
**Analyses** | [**List&lt;ScenarioAnalysis&gt;**](ScenarioAnalysis.md) | the configuration for next Analysis | [optional] 
**SuccessfulAnalyses** | [**List&lt;ScenarioSuccessfulAnalysis&gt;**](ScenarioSuccessfulAnalysis.md) | the configuration and information for last successful Analyses Runs | [optional] [readonly] 
**FailedAnalyses** | [**List&lt;ScenarioFailedAnalysis&gt;**](ScenarioFailedAnalysis.md) | the configuration and information for last failed Analyses Runs | [optional] [readonly] 
**RunningAnalyses** | [**List&lt;ScenarioRunningAnalysis&gt;**](ScenarioRunningAnalysis.md) | the configuration and information for currently running Analyses Runs | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

