# Com.Cosmotech.Model.SimulatorAnalysis
a Simulator Analysis run template

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Simulator Analysis id | 
**Name** | **string** | the Simulator Analysis name | 
**Description** | **string** | the Simulator Analysis description | [optional] 
**Simulation** | **string** | the simulation name | 
**Tags** | **List&lt;string&gt;** | the list of Simulator Analysis tags | [optional] 
**ComputeSize** | **string** | the compute size needed for this Analysis. Standard sizes are basic and highcpu. Default is basic | [optional] 
**ParametersHandlerResource** | [**AnalysisResourceStorage**](AnalysisResourceStorage.md) |  | [optional] 
**DatasetValidatorResource** | [**AnalysisResourceStorage**](AnalysisResourceStorage.md) |  | [optional] 
**CustomDriverResource** | [**AnalysisResourceStorage**](AnalysisResourceStorage.md) |  | [optional] 
**ParameterGroups** | [**List&lt;AnalysisParameterGroup&gt;**](AnalysisParameterGroup.md) | the list of parameters groups for the Analysis | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

