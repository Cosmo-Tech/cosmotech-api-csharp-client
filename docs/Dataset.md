# Com.Cosmotech.Model.Dataset
a Dataset

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Dataset unique identifier | [optional] [readonly] 
**Name** | **string** | the Dataset name | [optional] 
**Description** | **string** | the Dataset description | [optional] 
**OwnerId** | **string** | the User id which own this Dataset | [optional] [readonly] 
**OrganizationId** | **string** | the Organization Id related to this Dataset | [optional] [readonly] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**Connector** | [**DatasetConnector**](DatasetConnector.md) |  | [optional] 
**FragmentsIds** | **List&lt;string&gt;** | the list of other Datasets ids to compose as fragments | [optional] 
**ValidatorId** | **string** | the validator id | [optional] 
**Compatibility** | [**List&lt;DatasetCompatibility&gt;**](DatasetCompatibility.md) | the list of compatible Solutions versions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

