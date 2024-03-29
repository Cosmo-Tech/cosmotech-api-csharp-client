# Com.Cosmotech.Model.Workspace
a Workspace

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Workspace unique identifier generated by the API | [optional] [readonly] 
**OrganizationId** | **string** | Organization unique identifier under which the workspace resides | [optional] [readonly] 
**Key** | **string** | technical key for resource name convention and version grouping. Must be unique | 
**Name** | **string** | Workspace name. This name is display in the sample webApp | 
**Description** | **string** | the Workspace description | [optional] 
**LinkedDatasetIdList** | **List&lt;string&gt;** | list of dataset linked to this dataset | [optional] 
**VarVersion** | **string** | the Workspace version MAJOR.MINOR.PATCH. | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**OwnerId** | **string** | the user id which own this workspace. set by the API from Authentification service receved id | [optional] [readonly] 
**Solution** | [**WorkspaceSolution**](WorkspaceSolution.md) |  | 
**WebApp** | [**WorkspaceWebApp**](WorkspaceWebApp.md) |  | [optional] 
**SendInputToDataWarehouse** | **bool** | default setting for all Scenarios and Run Templates to set whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to the ScenarioRun | [optional] 
**UseDedicatedEventHubNamespace** | **bool** | Set this property to true to use a dedicated Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;probesmeasures\\&#39; and \\&#39;scenariorun\\&#39;. | [optional] [default to false]
**DedicatedEventHubSasKeyName** | **string** | the Dedicated Event Hub SAS key name, default to RootManageSharedAccessKey. Use the /secret endpoint to set the key value | [optional] 
**DedicatedEventHubAuthenticationStrategy** | **string** | the Event Hub authentication strategy, SHARED_ACCESS_POLICY or TENANT_CLIENT_CREDENTIALS. Default to the one defined for the tenant. | [optional] 
**SendScenarioRunToEventHub** | **bool** | default setting for all Scenarios and Run Templates to set whether or not the ScenarioRun is send to the Event Hub | [optional] [default to true]
**SendScenarioMetadataToEventHub** | **bool** | Set this property to false to not send scenario metada to Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;scenariometadata\\&#39; and \\&#39;scenariorunmetadata\\&#39;. | [optional] [default to false]
**DatasetCopy** | **bool** | Activate the copy of dataset on scenario creation, meaning that each scenario created in this workspace will make this copy. when false, scenario use directly the dataset specified. | [optional] [default to true]
**Security** | [**WorkspaceSecurity**](WorkspaceSecurity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

