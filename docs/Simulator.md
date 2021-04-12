# Com.Cosmotech.Model.Simulator
a version of a Simulator

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Simulator version unique identifier | [optional] [readonly] 
**SimulatorKey** | **string** | the Simulator key which group Simulator versions | 
**Name** | **string** | the Simulator name | 
**Description** | **string** | the Simulator description | [optional] 
**Repository** | **string** | the registry repository containing the image | 
**Version** | **string** | the Simulator version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag | 
**OwnerId** | **string** | the User id which own this Simulator | [optional] [readonly] 
**Url** | **string** | an optional URL link to simulator page | [optional] 
**Tags** | **List&lt;string&gt;** | the list of tags | [optional] 
**Analysis** | [**List&lt;SimulatorAnalysis&gt;**](SimulatorAnalysis.md) | list of Simulator Analysis | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

