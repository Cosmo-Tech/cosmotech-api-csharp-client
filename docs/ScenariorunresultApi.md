# Com.Cosmotech.Api.ScenariorunresultApi

All URIs are relative to *https://dev.api.cosmotech.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetScenarioRunResult**](ScenariorunresultApi.md#getscenariorunresult) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns/{scenariorun_id}/probes/{probe_id} | Get a ScenarioRunResult in the Organization
[**SendScenarioRunResult**](ScenariorunresultApi.md#sendscenariorunresult) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns/{scenariorun_id}/probes/{probe_id} | Create a new ScenarioRunResult in the Organization


<a name="getscenariorunresult"></a>
# **GetScenarioRunResult**
> ScenarioRunResult GetScenarioRunResult (string organizationId, string workspaceId, string scenarioId, string scenariorunId, string probeId)

Get a ScenarioRunResult in the Organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetScenarioRunResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunresultApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var scenarioId = "scenarioId_example";  // string | the Scenario identifier
            var scenariorunId = "scenariorunId_example";  // string | the ScenarioRun identifier
            var probeId = "probeId_example";  // string | the Probe identifier

            try
            {
                // Get a ScenarioRunResult in the Organization
                ScenarioRunResult result = apiInstance.GetScenarioRunResult(organizationId, workspaceId, scenarioId, scenariorunId, probeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunresultApi.GetScenarioRunResult: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| the Organization identifier | 
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 
 **scenariorunId** | **string**| the ScenarioRun identifier | 
 **probeId** | **string**| the Probe identifier | 

### Return type

[**ScenarioRunResult**](ScenarioRunResult.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Organization details |  -  |
| **404** | the ScenarioRunResult specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendscenariorunresult"></a>
# **SendScenarioRunResult**
> ScenarioRunResult SendScenarioRunResult (string organizationId, string workspaceId, string scenarioId, string scenariorunId, string probeId, Dictionary<string, string> requestBody)

Create a new ScenarioRunResult in the Organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class SendScenarioRunResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunresultApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var scenarioId = "scenarioId_example";  // string | the Scenario identifier
            var scenariorunId = "scenariorunId_example";  // string | the ScenarioRun identifier
            var probeId = "probeId_example";  // string | the Probe identifier
            var requestBody = new Dictionary<string, string>(); // Dictionary<string, string> | the ScenarioRunResult to register

            try
            {
                // Create a new ScenarioRunResult in the Organization
                ScenarioRunResult result = apiInstance.SendScenarioRunResult(organizationId, workspaceId, scenarioId, scenariorunId, probeId, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunresultApi.SendScenarioRunResult: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| the Organization identifier | 
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 
 **scenariorunId** | **string**| the ScenarioRun identifier | 
 **probeId** | **string**| the Probe identifier | 
 **requestBody** | [**Dictionary&lt;string, string&gt;**](string.md)| the ScenarioRunResult to register | 

### Return type

[**ScenarioRunResult**](ScenarioRunResult.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Organization details |  -  |
| **400** | the ScenarioRunResult specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

