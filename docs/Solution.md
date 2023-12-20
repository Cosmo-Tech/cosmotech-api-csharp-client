# Com.Cosmotech.Model.Solution
a version of a Solution

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Solution version unique identifier | [optional] [readonly] 
**OrganizationId** | **string** | the Organization unique identifier | [optional] [readonly] 
**Key** | **string** | the Solution key which group Solution versions | [optional] 
**Name** | **string** | the Solution name | [optional] 
**Description** | **string** | the Solution description | [optional] 
**Repository** | **string** | the registry repository containing the image | [optional] 
**AlwaysPull** | **bool** | set to true if the runtemplate wants to always pull the image | [optional] [default to false]
**CsmSimulator** | **string** | the main Cosmo Tech simulator name used in standard Run Template | [optional] 
**_Version** | **string** | the Solution version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag | [optional] 
**OwnerId** | **string** | the User id which own this Solution | [optional] [readonly] 
**SdkVersion** | **string** | the MAJOR.MINOR version used to build this solution | [optional] 
**Url** | **string** | an optional URL link to solution page | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**Parameters** | [**List&lt;RunTemplateParameter&gt;**](RunTemplateParameter.md) | the list of Run Template Parameters | [optional] 
**ParameterGroups** | [**List&lt;RunTemplateParameterGroup&gt;**](RunTemplateParameterGroup.md) | the list of parameters groups for the Run Templates | [optional] 
**RunTemplates** | [**List&lt;RunTemplate&gt;**](RunTemplate.md) | list of Run Template | [optional] 
**Security** | [**SolutionSecurity**](SolutionSecurity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

