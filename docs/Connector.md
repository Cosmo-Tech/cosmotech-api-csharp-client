# Com.Cosmotech.Model.Connector
a version of a Connector

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Connector version unique identifier | [optional] [readonly] 
**Key** | **string** | the Connector key which group Connector versions | [optional] 
**Name** | **string** | the Connector name | [optional] 
**Description** | **string** | the Connector description | [optional] 
**Repository** | **string** | the registry repository containing the image | [optional] 
**VarVersion** | **string** | the Connector version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**OwnerId** | **string** | the user id which own this connector version | [optional] [readonly] 
**Url** | **string** | an optional URL link to connector page | [optional] 
**IoTypes** | [**List&lt;IoTypesEnum&gt;**](IoTypesEnum.md) |  | [optional] 
**ParameterGroups** | [**List&lt;ConnectorParameterGroup&gt;**](ConnectorParameterGroup.md) | the list of connector parameters groups | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

