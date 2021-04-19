# Com.Cosmotech.Model.SimulationStartSolution
the parameters to run directly a Solution

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SolutionId** | **string** | the Solution Id | [optional] 
**RunTemplateId** | **string** | the Solution Run Template id | [optional] 
**DatasetList** | **List&lt;string&gt;** | the list of Dataset Id associated to this Analysis | [optional] 
**ParametersValues** | [**List&lt;RunTemplateParameterValue&gt;**](RunTemplateParameterValue.md) | the list of Solution Run Template parameters values | [optional] 
**SendInputToDataWarehouse** | **bool** | whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to Simulation Run | [optional] 
**DataWarehouseDB** | **string** | the DataWarehouse database name to send data if sendInputToDataWarehouse is set | [optional] 
**ResultsEventBusResourceUri** | **string** | the event bus which receive Workspace Simulation results messages. Message won&#39;t be send if this is not set | [optional] 
**SimulationEventBusResourceUri** | **string** | the event bus which receive Workspace Simulation events messages. Message won&#39;t be send if this is not set | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

