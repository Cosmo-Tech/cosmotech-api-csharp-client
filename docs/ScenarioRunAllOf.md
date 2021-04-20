# Com.Cosmotech.Model.ScenarioRunAllOf
a ScenarioRun

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatasetList** | **List&lt;string&gt;** | the list of Dataset Id associated to this Analysis | [optional] [readonly] 
**ParametersValues** | [**List&lt;RunTemplateParameterValue&gt;**](RunTemplateParameterValue.md) | the list of Run Template parameters values | [optional] [readonly] 
**SendInputToDataWarehouse** | **bool** | whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to ScenarioRun Run | [optional] [readonly] 
**DataWarehouseDB** | **string** | the DataWarehouse database name to send data if sendInputToDataWarehouse is set | [optional] 
**ResultsEventBusResourceUri** | **string** | the event bus which receive Workspace ScenarioRun results messages. Message won&#39;t be send if this is not set | [optional] 
**ScenariorunEventBusResourceUri** | **string** | the event bus which receive Workspace ScenarioRun events messages. Message won&#39;t be send if this is not set | [optional] 
**NodeLabel** | **string** | the node label request | [optional] [readonly] 
**InitContainers** | [**List&lt;ScenarioRunContainers&gt;**](ScenarioRunContainers.md) | the list of init containers | [optional] [readonly] 
**MainContainer** | [**ScenarioRunContainers**](ScenarioRunContainers.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

