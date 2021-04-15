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
**SimulatorId** | **string** | the Simulator Id associated with this Scenario | [optional] [readonly] 
**Users** | [**List&lt;ScenarioUser&gt;**](ScenarioUser.md) | the list of users Id with their role | [optional] 
**SimulatorName** | **string** |  | [optional] 
**SimulatorAnalysisName** | **string** |  | [optional] 
**Analysis** | [**ScenarioAnalysis**](ScenarioAnalysis.md) |  | [optional] 
**SendInputToDataWarehouse** | **bool** | default setting for all Analysis to set whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to Simulation Run | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

