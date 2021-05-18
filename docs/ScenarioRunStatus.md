# Com.Cosmotech.Model.ScenarioRunStatus
a ScenarioRun status

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the ScenarioRun id | [optional] 
**OrganizationId** | **string** | the ScenarioRun id | [optional] 
**WorkflowId** | **string** | the Cosmo Tech compute cluster Argo Workflow Id to search | [optional] 
**WorkflowName** | **string** | the Cosmo Tech compute cluster Argo Workflow Name | [optional] 
**StartTime** | **string** | the ScenarioRun start Date Time | [optional] 
**EndTime** | **string** | the ScenarioRun end Date Time | [optional] 
**Phase** | **string** | high-level summary of where the workflow is in its lifecycle | [optional] 
**Progress** | **string** | progress to completion | [optional] 
**Message** | **string** | a  human readable message indicating details about why the workflow is in this condition | [optional] 
**EstimatedDuration** | **int** | estimatedDuration in seconds | [optional] 
**Nodes** | [**List&lt;ScenarioRunStatusNode&gt;**](ScenarioRunStatusNode.md) | status of ScenarioRun nodes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

