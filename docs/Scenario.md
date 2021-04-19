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
**SolutionId** | **string** | the Solution Id associated with this Scenario | [optional] [readonly] 
**RunTemplateId** | **string** | the Solution Run Template Id associated with this Scenario | [optional] 
**Users** | [**List&lt;ScenarioUser&gt;**](ScenarioUser.md) | the list of users Id with their role | [optional] 
**State** | **string** | the Scenario state | [optional] [readonly] 
**CreationDate** | **string** | the Scenario creation date | [optional] [readonly] 
**OwnerName** | **string** | the name of the owner | [optional] [readonly] 
**SolutionName** | **string** | the Solution name | [optional] [readonly] 
**RunTemplateName** | **string** | the Solution Run Template name associated with this Scenario | [optional] [readonly] 
**DatasetList** | **List&lt;string&gt;** | the list of Dataset Id associated to this Scenario Run Template | [optional] 
**ParametersValues** | [**List&lt;ScenarioRunTemplateParameterValue&gt;**](ScenarioRunTemplateParameterValue.md) | the list of Solution Run Template parameters values | [optional] 
**SendInputToDataWarehouse** | **bool** | whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to Simulation Run | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

