# Com.Cosmotech.Model.ScenarioRun
a ScenarioRun with only base properties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the ScenarioRun | [optional] [readonly] 
**WorkflowId** | **string** | the Cosmo Tech compute cluster Argo Workflow Id to search | [optional] 
**GenerateName** | **string** | the base name for workflow name generation | [optional] 
**WorkflowName** | **string** | the Cosmo Tech compute cluster Argo Workflow Name | [optional] 
**OwnerId** | **string** | the user id which own this scenariorun | [optional] [readonly] 
**WorkspaceId** | **string** | the Workspace Id | [optional] [readonly] 
**WorkspaceKey** | **string** | technical key for resource name convention and version grouping. Must be unique | [optional] [readonly] 
**ScenarioId** | **string** | the Scenario Id | [optional] [readonly] 
**SolutionId** | **string** | the Solution Id | [optional] [readonly] 
**RunTemplateId** | **string** | the Solution Run Template id | [optional] [readonly] 
**ComputeSize** | **string** | the compute size needed for this Analysis. Standard sizes are basic and highcpu. Default is basic | [optional] [readonly] 
**State** | **string** | the ScenarioRun state | [optional] [readonly] 
**FailedStep** | **string** | the failed step if state is Failed | [optional] [readonly] 
**FailedContainerId** | **string** | the failed container Id if state is Failed | [optional] [readonly] 
**StartTime** | **string** | the ScenarioRun start Date Time | [optional] [readonly] 
**EndTime** | **string** | the ScenarioRun end Date Time | [optional] [readonly] 
**DatasetList** | **List&lt;string&gt;** | the list of Dataset Id associated to this Analysis | [optional] [readonly] 
**ParametersValues** | [**List&lt;RunTemplateParameterValue&gt;**](RunTemplateParameterValue.md) | the list of Run Template parameters values | [optional] [readonly] 
**SendDatasetsToDataWarehouse** | **bool** | whether or not the Datasets values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting | [optional] [readonly] 
**SendInputParametersToDataWarehouse** | **bool** | whether or not the input parameters values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting | [optional] [readonly] 
**NodeLabel** | **string** | the node label request | [optional] [readonly] 
**Containers** | [**List&lt;ScenarioRunContainer&gt;**](ScenarioRunContainer.md) | the containers list | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

