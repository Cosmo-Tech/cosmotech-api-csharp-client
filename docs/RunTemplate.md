# Com.Cosmotech.Model.RunTemplate
a Solution Run Template

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Solution Run Template id | 
**Name** | **string** | the Run Template name | 
**Description** | **string** | the Run Template description | [optional] 
**UseDirectCsmSimulator** | **bool** | whether or not the Run Template use the main standard csmSimulator directly. False if there is an Engine set | [optional] [readonly] 
**CsmSimulation** | **string** | the Cosmo Tech simulation name. This information is send to the Engine. Mandatory information if no Engine is defined | [optional] 
**Tags** | **List&lt;string&gt;** | the list of Run Template tags | [optional] 
**ComputeSize** | **string** | the compute size needed for this Run Template. Standard sizes are basic and highcpu. Default is basic | [optional] 
**ParametersHandlerResource** | [**RunTemplateResourceStorage**](RunTemplateResourceStorage.md) |  | [optional] 
**DatasetValidatorResource** | [**RunTemplateResourceStorage**](RunTemplateResourceStorage.md) |  | [optional] 
**PreRunResource** | [**RunTemplateResourceStorage**](RunTemplateResourceStorage.md) |  | [optional] 
**EngineResource** | [**RunTemplateResourceStorage**](RunTemplateResourceStorage.md) |  | [optional] 
**PostRunResource** | [**RunTemplateResourceStorage**](RunTemplateResourceStorage.md) |  | [optional] 
**SendInputToDataWarehouse** | **bool** | whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to Simulation Run | [optional] [default to true]
**ParameterGroups** | [**List&lt;RunTemplateParameterGroup&gt;**](RunTemplateParameterGroup.md) | the list of parameters groups for the Run Template | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

