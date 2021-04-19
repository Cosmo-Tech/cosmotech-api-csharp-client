# Com.Cosmotech.Model.ScenarioBase
a Scenario with base information

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

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

