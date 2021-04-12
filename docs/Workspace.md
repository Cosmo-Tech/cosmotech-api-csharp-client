# Com.Cosmotech.Model.Workspace
a Workspace

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Workspace version unique identifier | [optional] [readonly] 
**Name** | **string** | the Workspace name | 
**Description** | **string** | the Workspace description | [optional] 
**Version** | **string** | the Workspace version MAJOR.MINOR.PATCH. | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**OwnerId** | **string** | the user id which own this workspace | [optional] [readonly] 
**Simulator** | [**WorkspaceSimulator**](WorkspaceSimulator.md) |  | 
**UserList** | [**List&lt;WorkspaceUser&gt;**](WorkspaceUser.md) | the list of users Id with their role | [optional] 
**WebApp** | [**WorkspaceWebApp**](WorkspaceWebApp.md) |  | [optional] 
**Services** | [**WorkspaceServices**](WorkspaceServices.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

