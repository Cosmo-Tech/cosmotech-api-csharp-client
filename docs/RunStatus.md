# Com.Cosmotech.Model.RunStatus
a Run status

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Run id | [optional] 
**OrganizationId** | **string** | the Organization id | [optional] 
**WorkspaceId** | **string** | the Workspace id | [optional] 
**RunnerId** | **string** | the Runner id | [optional] 
**WorkflowId** | **string** | the Cosmo Tech compute cluster Argo Workflow Id to search | [optional] 
**WorkflowName** | **string** | the Cosmo Tech compute cluster Argo Workflow Name | [optional] 
**StartTime** | **string** | the Run start Date Time | [optional] 
**EndTime** | **string** | the Run end Date Time | [optional] 
**Phase** | **string** | high-level summary of where the workflow is in its lifecycle | [optional] 
**Progress** | **string** | progress to completion | [optional] 
**Message** | **string** | a  human readable message indicating details about why the workflow is in this condition | [optional] 
**EstimatedDuration** | **int** | estimatedDuration in seconds | [optional] 
**Nodes** | [**List&lt;RunStatusNode&gt;**](RunStatusNode.md) | status of Run nodes | [optional] 
**State** | **RunState** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

