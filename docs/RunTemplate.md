# Com.Cosmotech.Model.RunTemplate
a Solution Run Template

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the Solution Run Template id | 
**Name** | **string** | the Run Template name | [optional] 
**Description** | **string** | the Run Template description | [optional] 
**CsmSimulation** | **string** | the Cosmo Tech simulation name. This information is send to the Engine. Mandatory information if no Engine is defined | [optional] 
**Tags** | **List&lt;string&gt;** | the list of Run Template tags | [optional] 
**ComputeSize** | **string** | the compute size needed for this Run Template. Standard sizes are basic and highcpu. Default is basic | [optional] 
**RunSizing** | [**RunTemplateResourceSizing**](RunTemplateResourceSizing.md) |  | [optional] 
**NoDataIngestionState** | **bool** | set to true if the run template does not want to check data ingestion state (no probes or not control plane) | [optional] 
**FetchDatasets** | **bool** | whether or not the fetch dataset step is done | [optional] 
**ScenarioDataDownloadTransform** | **bool** | whether or not the scenario data download transform step step is done | [optional] 
**FetchScenarioParameters** | **bool** | whether or not the fetch parameters step is done | [optional] 
**ApplyParameters** | **bool** | whether or not the apply parameter step is done | [optional] 
**ValidateData** | **bool** | whether or not the validate step is done | [optional] 
**SendDatasetsToDataWarehouse** | **bool** | whether or not the Datasets values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting | [optional] 
**SendInputParametersToDataWarehouse** | **bool** | whether or not the input parameters values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting | [optional] 
**PreRun** | **bool** | whether or not the pre-run step is done | [optional] 
**Run** | **bool** | whether or not the run step is done | [optional] 
**PostRun** | **bool** | whether or not the post-run step is done | [optional] 
**ParametersJson** | **bool** | whether or not to store the scenario parameters in json instead of csv | [optional] 
**ParametersHandlerSource** | **RunTemplateStepSource** |  | [optional] 
**DatasetValidatorSource** | **RunTemplateStepSource** |  | [optional] 
**PreRunSource** | **RunTemplateStepSource** |  | [optional] 
**RunSource** | **RunTemplateStepSource** |  | [optional] 
**PostRunSource** | **RunTemplateStepSource** |  | [optional] 
**ScenariodataTransformSource** | **RunTemplateStepSource** |  | [optional] 
**ParameterGroups** | **List&lt;string&gt;** | the ordered list of parameters groups for the Run Template | [optional] 
**StackSteps** | **bool** | whether or not to stack adjacent scenario run steps in one container run which will chain steps | [optional] 
**GitRepositoryUrl** | **string** | an optional URL to the git repository | [optional] 
**GitBranchName** | **string** | an optional git branch name | [optional] 
**RunTemplateSourceDir** | **string** | an optional directory where to find the run template source | [optional] 
**ExecutionTimeout** | **int** | an optional duration in seconds in which a workflow is allowed to run | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

