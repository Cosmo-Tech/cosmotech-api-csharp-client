# Com.Cosmotech.Model.Solution
a version of a Solution

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Solution version unique identifier | [optional] [readonly] 
**Key** | **string** | the Solution key which group Solution versions | 
**Name** | **string** | the Solution name | 
**Description** | **string** | the Solution description | [optional] 
**Repository** | **string** | the registry repository containing the image | 
**CsmSimulator** | **string** | the main Cosmo Tech simulator name used in standard Run Template | [optional] 
**Version** | **string** | the Solution version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag | 
**OwnerId** | **string** | the User id which own this Solution | [optional] [readonly] 
**Url** | **string** | an optional URL link to solution page | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**Parameters** | [**List&lt;RunTemplateParameter&gt;**](RunTemplateParameter.md) | the list of Run Template Parameters | [optional] 
**ParameterGroups** | [**List&lt;RunTemplateParameterGroup&gt;**](RunTemplateParameterGroup.md) | the list of parameters groups for the Run Templates | [optional] 
**RunTemplates** | [**List&lt;RunTemplate&gt;**](RunTemplate.md) | list of Run Template | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

