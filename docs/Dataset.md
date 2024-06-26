# Com.Cosmotech.Model.Dataset
a Dataset

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Dataset unique identifier | [optional] [readonly] 
**Name** | **string** | the Dataset name | [optional] 
**Description** | **string** | the Dataset description | [optional] 
**OwnerId** | **string** | the User id which own this Dataset | [optional] [readonly] 
**OwnerName** | **string** | the name of the owner | [optional] [readonly] 
**OrganizationId** | **string** | the Organization Id related to this Dataset | [optional] [readonly] 
**ParentId** | **string** | the Dataset id which is the parent of this Dataset | [optional] 
**LinkedWorkspaceIdList** | **List&lt;string&gt;** | list of workspace linked to this dataset | [optional] 
**TwingraphId** | **string** | the twin graph id | [optional] 
**Main** | **bool** | is this the main dataset | [optional] 
**CreationDate** | **long** | the Dataset creation date | [optional] [readonly] 
**RefreshDate** | **long** | the last time a refresh was done | [optional] [readonly] 
**SourceType** | **DatasetSourceType** |  | [optional] 
**Source** | [**SourceInfo**](SourceInfo.md) |  | [optional] 
**IngestionStatus** | **IngestionStatusEnum** |  | [optional] 
**TwincacheStatus** | **TwincacheStatusEnum** |  | [optional] 
**Queries** | **List&lt;string&gt;** | the list of queries | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**Connector** | [**DatasetConnector**](DatasetConnector.md) |  | [optional] 
**FragmentsIds** | **List&lt;string&gt;** | the list of other Datasets ids to compose as fragments | [optional] 
**ValidatorId** | **string** | the validator id | [optional] 
**Compatibility** | [**List&lt;DatasetCompatibility&gt;**](DatasetCompatibility.md) | the list of compatible Solutions versions | [optional] 
**Security** | [**DatasetSecurity**](DatasetSecurity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

