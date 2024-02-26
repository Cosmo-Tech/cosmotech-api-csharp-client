# Com.Cosmotech.Model.RunContainer
a Run container description

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the container Id | [optional] [readonly] 
**Name** | **string** | the container name | 
**Labels** | **Dictionary&lt;string, string&gt;** | the metadata labels | [optional] 
**EnvVars** | **Dictionary&lt;string, string&gt;** | environment variable map | [optional] 
**Image** | **string** | the container image URI | 
**Entrypoint** | **string** | the container entry point | [optional] 
**RunArgs** | **List&lt;string&gt;** | the list of run arguments for the container | [optional] 
**Dependencies** | **List&lt;string&gt;** | the list of dependencies container name to run this container | [optional] 
**SolutionContainer** | **bool** | whether or not this container is a Cosmo Tech solution container | [optional] [readonly] 
**NodeLabel** | **string** | the node label request | [optional] 
**RunSizing** | [**ContainerResourceSizing**](ContainerResourceSizing.md) |  | [optional] 
**Artifacts** | [**List&lt;RunContainerArtifact&gt;**](RunContainerArtifact.md) | the list of artifacts | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

