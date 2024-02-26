# Com.Cosmotech.Model.Run
a Run with only base properties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Run | [optional] [readonly] 
**State** | **RunState** |  | [optional] 
**OrganizationId** | **string** | the Organization id | [optional] 
**WorkflowId** | **string** | the Cosmo Tech compute cluster Argo Workflow Id to search | [optional] 
**CsmSimulationRun** | **string** | the Cosmo Tech Simulation Run Id | [optional] [readonly] 
**GenerateName** | **string** | the base name for workflow name generation | [optional] 
**WorkflowName** | **string** | the Cosmo Tech compute cluster Argo Workflow Name | [optional] 
**OwnerId** | **string** | the user id which own this run | [optional] [readonly] 
**WorkspaceId** | **string** | the Workspace Id | [optional] [readonly] 
**WorkspaceKey** | **string** | technical key for resource name convention and version grouping. Must be unique | [optional] [readonly] 
**RunnerId** | **string** | the Runner Id | [optional] [readonly] 
**SolutionId** | **string** | the Solution Id | [optional] [readonly] 
**RunTemplateId** | **string** | the Solution Run Template id | [optional] [readonly] 
**ComputeSize** | **string** | the compute size needed for this Analysis. Standard sizes are basic and highcpu. Default is basic | [optional] [readonly] 
**CreatedAt** | **string** | the Run creation date | [optional] [readonly] 
**DatasetList** | **List&lt;string&gt;** | the list of Dataset Id associated to this Run | [optional] [readonly] 
**ParametersValues** | [**List&lt;RunTemplateParameterValue&gt;**](RunTemplateParameterValue.md) | the list of Run Template parameters values | [optional] [readonly] 
**NodeLabel** | **string** | the node label request | [optional] [readonly] 
**Containers** | [**List&lt;RunContainer&gt;**](RunContainer.md) | the containers list. This information is not returned by the API. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

