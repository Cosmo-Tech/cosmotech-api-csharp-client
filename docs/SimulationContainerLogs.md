# Com.Cosmotech.Model.SimulationContainerLogs
logs for a given container

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerId** | **string** | container ID for log source as seen by Docker engine | [optional] [readonly] 
**Computer** | **string** | computer/node that&#39;s generating the log | [optional] [readonly] 
**Logs** | [**List&lt;SimulationContainerLog&gt;**](SimulationContainerLog.md) | the list of container logs in structured format | [optional] [readonly] 
**TextLog** | **string** | the plain text log if plainText option has been set | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

