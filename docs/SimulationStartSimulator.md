# Com.Cosmotech.Model.SimulationStartSimulator
the parameters to run directly a Simulator

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SimulatorId** | **string** | the Simulator Id | [optional] 
**SimulatorAnalysisId** | **string** | the Simulator Analysis id | [optional] 
**DatasetList** | **List&lt;string&gt;** | the list of Dataset Id associated to this Analysis | [optional] 
**ParametersValues** | [**List&lt;SimulationAnalysisParameterValue&gt;**](SimulationAnalysisParameterValue.md) | the list of Simulator Analysis parameters values | [optional] 
**SendInputToDataWarehouse** | **bool** | whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to Simulation Run | [optional] 
**DataWarehouseDB** | **string** | the DataWarehouse database name to send data if sendInputToDataWarehouse is set | [optional] 
**ResultsEventBusResourceUri** | **string** | the event bus which receive Workspace Simulation results messages. Message won&#39;t be send if this is not set | [optional] 
**SimulationEventBusResourceUri** | **string** | the event bus which receive Workspace Simulation events messages. Message won&#39;t be send if this is not set | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

