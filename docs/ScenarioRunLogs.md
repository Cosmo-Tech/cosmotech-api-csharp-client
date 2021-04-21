# Com.Cosmotech.Model.ScenarioRunLogs
the scenariorun logs returned by all containers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenariorunId** | **string** | the ScenarioRun Id | [optional] [readonly] 
**Options** | [**ScenarioRunLogsOptions**](ScenarioRunLogsOptions.md) |  | [optional] 
**FetchDatasetLogs** | [**List&lt;ScenarioRunContainerLogs&gt;**](ScenarioRunContainerLogs.md) | logs for the containers which fetch the Scenario Datasets | [optional] [readonly] 
**FetchScenarioParametersLog** | [**ScenarioRunContainerLogs**](ScenarioRunContainerLogs.md) |  | [optional] 
**ApplyParametersLogs** | [**ScenarioRunContainerLogs**](ScenarioRunContainerLogs.md) |  | [optional] 
**ValidateDataLogs** | [**ScenarioRunContainerLogs**](ScenarioRunContainerLogs.md) |  | [optional] 
**SendDataWarehouseLogs** | [**ScenarioRunContainerLogs**](ScenarioRunContainerLogs.md) |  | [optional] 
**PreRunLogs** | [**ScenarioRunContainerLogs**](ScenarioRunContainerLogs.md) |  | [optional] 
**RunLogs** | [**ScenarioRunContainerLogs**](ScenarioRunContainerLogs.md) |  | [optional] 
**PostRunLogs** | [**ScenarioRunContainerLogs**](ScenarioRunContainerLogs.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

