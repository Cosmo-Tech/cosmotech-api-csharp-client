# Com.Cosmotech.Model.Scenario
a Scenario with base information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Scenario unique identifier | [optional] [readonly] 
**Name** | **string** | the Scenario name | [optional] 
**Description** | **string** | the Scenario description | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**ParentId** | **string** | the Scenario parent id | [optional] 
**OwnerId** | **string** | the user id which own this Scenario | [optional] [readonly] 
**RootId** | **string** | the scenario root id | [optional] [readonly] 
**SolutionId** | **string** | the Solution Id associated with this Scenario | [optional] [readonly] 
**RunTemplateId** | **string** | the Solution Run Template Id associated with this Scenario | [optional] 
**WorkspaceId** | **string** | the associated Workspace Id | [optional] [readonly] 
**State** | **ScenarioJobState** |  | [optional] 
**CreationDate** | **DateTime** | the Scenario creation date | [optional] [readonly] 
**LastUpdate** | **DateTime** | the last time a Scenario was updated | [optional] [readonly] 
**OwnerName** | **string** | the name of the owner | [optional] [readonly] 
**SolutionName** | **string** | the Solution name | [optional] [readonly] 
**RunTemplateName** | **string** | the Solution Run Template name associated with this Scenario | [optional] [readonly] 
**DatasetList** | **List&lt;string&gt;** | the list of Dataset Id associated to this Scenario Run Template | [optional] 
**RunSizing** | [**ScenarioResourceSizing**](ScenarioResourceSizing.md) |  | [optional] 
**ParametersValues** | [**List&lt;ScenarioRunTemplateParameterValue&gt;**](ScenarioRunTemplateParameterValue.md) | the list of Solution Run Template parameters values | [optional] 
**LastRun** | [**ScenarioLastRun**](ScenarioLastRun.md) |  | [optional] 
**ParentLastRun** | [**ScenarioLastRun**](ScenarioLastRun.md) |  | [optional] 
**RootLastRun** | [**ScenarioLastRun**](ScenarioLastRun.md) |  | [optional] 
**ValidationStatus** | **ScenarioValidationStatus** |  | [optional] 
**Security** | [**ScenarioSecurity**](ScenarioSecurity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

