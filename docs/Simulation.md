# Com.Cosmotech.Model.Simulation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Simulation | [optional] [readonly] 
**JobId** | **string** | the Platform compute cluster Job Id | [optional] [readonly] 
**OwnerId** | **string** | the user id which own this simulation | [optional] [readonly] 
**WorkspaceId** | **string** | the Workspace Id | [optional] [readonly] 
**WorkspaceName** | **string** | the Workspace name | [optional] [readonly] 
**ScenarioId** | **string** | the Scenario Id | [optional] [readonly] 
**ScenarioName** | **string** | the Scenario name | [optional] [readonly] 
**SimulatorId** | **string** | the Simulator Id | [optional] [readonly] 
**SimulatorName** | **string** | the Simulator name | [optional] [readonly] 
**SimulatorVersion** | **string** | the Simulator version | [optional] [readonly] 
**SimulatorAnalysisId** | **string** | the Simulator Analysis id | [optional] [readonly] 
**SimulatorAnalysisName** | **string** | the Simulator Analysis name | [optional] [readonly] 
**ComputeSize** | **string** | the compute size needed for this Analysis. Standard sizes are basic and highcpu. Default is basic | [optional] [readonly] 
**State** | **string** | the Simulation state | [optional] [readonly] 
**StartTime** | **string** | the Simulation start Date Time | [optional] [readonly] 
**EndTime** | **string** | the Simulation end Date Time | [optional] [readonly] 
**DatasetList** | **List&lt;string&gt;** | the list of Dataset Id associated to this Analysis | [optional] [readonly] 
**ParametersValues** | [**List&lt;SimulationAnalysisParameterValue&gt;**](SimulationAnalysisParameterValue.md) | the list of Simulator Analysis parameters values | [optional] [readonly] 
**SendInputToDataWarehouse** | **bool** | whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to Simulation Run | [optional] [readonly] 
**DataWarehouseDB** | **string** | the DataWarehouse database name to send data if sendInputToDataWarehouse is set | [optional] 
**ResultsEventBusResourceUri** | **string** | the event bus which receive Workspace Simulation results messages. Message won&#39;t be send if this is not set | [optional] 
**SimulationEventBusResourceUri** | **string** | the event bus which receive Workspace Simulation events messages. Message won&#39;t be send if this is not set | [optional] 
**NodeLabel** | **string** | the node label request | [optional] [readonly] 
**InitContainers** | [**List&lt;SimulationContainers&gt;**](SimulationContainers.md) | the list of init containers | [optional] [readonly] 
**MainContainer** | [**SimulationContainers**](SimulationContainers.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

