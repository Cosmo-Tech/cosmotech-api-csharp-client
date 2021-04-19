# Com.Cosmotech.Model.RunTemplate
a Solution Run Template

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Solution Run Template id | 
**Name** | **string** | the Run Template name | 
**Description** | **string** | the Run Template description | [optional] 
**IsStandardSimulator** | **bool** | whether or not the Run Template use the main standard Simulator directly. False if there is a Custom Simulator set | [optional] [readonly] 
**Simulation** | **string** | the simulation name. This information is send to the Simulator | [optional] 
**Tags** | **List&lt;string&gt;** | the list of Run Template tags | [optional] 
**ComputeSize** | **string** | the compute size needed for this Run Template. Standard sizes are basic and highcpu. Default is basic | [optional] 
**ParametersHandlerResource** | [**RunTemplateResourceStorage**](RunTemplateResourceStorage.md) |  | [optional] 
**DatasetValidatorResource** | [**RunTemplateResourceStorage**](RunTemplateResourceStorage.md) |  | [optional] 
**CustomSimulatorResource** | [**RunTemplateResourceStorage**](RunTemplateResourceStorage.md) |  | [optional] 
**DatasetSchemaResource** | [**RunTemplateResourceStorage**](RunTemplateResourceStorage.md) |  | [optional] 
**ParameterGroups** | [**List&lt;RunTemplateParameterGroup&gt;**](RunTemplateParameterGroup.md) | the list of parameters groups for the Run Template | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

