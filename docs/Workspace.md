# Com.Cosmotech.Model.Workspace
a Workspace

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Workspace version unique identifier | [optional] [readonly] 
**Key** | **string** | technical key for resource name convention and version grouping. Must be unique | 
**Name** | **string** | the Workspace name | 
**Description** | **string** | the Workspace description | [optional] 
**_Version** | **string** | the Workspace version MAJOR.MINOR.PATCH. | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**OwnerId** | **string** | the user id which own this workspace | [optional] [readonly] 
**Solution** | [**WorkspaceSolution**](WorkspaceSolution.md) |  | 
**WebApp** | [**WorkspaceWebApp**](WorkspaceWebApp.md) |  | [optional] 
**SendInputToDataWarehouse** | **bool** | default setting for all Scenarios and Run Templates to set whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to the ScenarioRun | [optional] 
**UseDedicatedEventHubNamespace** | **bool** | Set this property to true to use a dedicated Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;probesmeasures\\&#39; and \\&#39;scenariorun\\&#39;. | [optional] [default to false]
**SendScenarioMetadataToEventHub** | **bool** | Set this property to false to not send scenario metada to Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;scenariometadata\\&#39; and \\&#39;scenariorunmetadata\\&#39;. | [optional] [default to false]
**Security** | [**WorkspaceSecurity**](WorkspaceSecurity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

