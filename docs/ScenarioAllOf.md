# Com.Cosmotech.Model.ScenarioAllOf
a Scenario with detailed information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OwnerName** | **string** | the name of the owner | [optional] [readonly] 
**SolutionName** | **string** | the Solution name | [optional] [readonly] 
**RunTemplateName** | **string** | the Solution Run Template name associated with this Scenario | [optional] [readonly] 
**DatasetList** | **List&lt;string&gt;** | the list of Dataset Id associated to this Scenario Run Template | [optional] 
**ParametersValues** | [**List&lt;ScenarioRunTemplateParameterValue&gt;**](ScenarioRunTemplateParameterValue.md) | the list of Solution Run Template parameters values | [optional] 
**SendInputToDataWarehouse** | **bool** | whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to Simulation Run | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

