# Com.Cosmotech.Model.Runner
a Runner with base information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Runner unique identifier | [optional] [readonly] 
**Name** | **string** | the Runner name | [optional] 
**Description** | **string** | the Runner description | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**ParentId** | **string** | the Runner parent id | [optional] 
**OwnerId** | **string** | the user id which own this Runner | [optional] [readonly] 
**RootId** | **string** | the runner root id | [optional] [readonly] 
**SolutionId** | **string** | the Solution Id associated with this Runner | [optional] [readonly] 
**RunTemplateId** | **string** | the Solution Run Template Id associated with this Runner | [optional] 
**OrganizationId** | **string** | the associated Organization Id | [optional] [readonly] 
**WorkspaceId** | **string** | the associated Workspace Id | [optional] [readonly] 
**State** | **RunnerJobState** |  | [optional] 
**CreationDate** | **long** | the Runner creation date | [optional] [readonly] 
**LastUpdate** | **long** | the last time a Runner was updated | [optional] [readonly] 
**OwnerName** | **string** | the name of the owner | [optional] [readonly] 
**SolutionName** | **string** | the Solution name | [optional] [readonly] 
**RunTemplateName** | **string** | the Solution Run Template name associated with this Runner | [optional] [readonly] 
**DatasetList** | **List&lt;string&gt;** | the list of Dataset Id associated to this Runner Run Template | [optional] 
**RunSizing** | [**RunnerResourceSizing**](RunnerResourceSizing.md) |  | [optional] 
**ParametersValues** | [**List&lt;RunnerRunTemplateParameterValue&gt;**](RunnerRunTemplateParameterValue.md) | the list of Solution Run Template parameters values | [optional] 
**LastRun** | [**RunnerLastRun**](RunnerLastRun.md) |  | [optional] 
**ParentLastRun** | [**RunnerLastRun**](RunnerLastRun.md) |  | [optional] 
**RootLastRun** | [**RunnerLastRun**](RunnerLastRun.md) |  | [optional] 
**ValidationStatus** | **RunnerValidationStatus** |  | [optional] 
**Security** | [**RunnerSecurity**](RunnerSecurity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

