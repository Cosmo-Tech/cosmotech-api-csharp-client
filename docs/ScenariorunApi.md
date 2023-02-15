# Com.Cosmotech.Api.ScenariorunApi

All URIs are relative to *https://dev.api.cosmotech.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteHistoricalDataOrganization**](ScenariorunApi.md#deletehistoricaldataorganization) | **DELETE** /organizations/{organization_id}/scenarioruns/historicaldata | Delete all historical ScenarioRuns in the Organization
[**DeleteHistoricalDataScenario**](ScenariorunApi.md#deletehistoricaldatascenario) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns/historicaldata | Delete all historical ScenarioRuns in the Scenario
[**DeleteHistoricalDataWorkspace**](ScenariorunApi.md#deletehistoricaldataworkspace) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarioruns/historicaldata | Delete all historical ScenarioRuns in the Workspace
[**DeleteScenarioRun**](ScenariorunApi.md#deletescenariorun) | **DELETE** /organizations/{organization_id}/scenarioruns/{scenariorun_id} | Delete a scenariorun
[**FindScenarioRunById**](ScenariorunApi.md#findscenariorunbyid) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id} | Get the details of a scenariorun
[**GetScenarioRunCumulatedLogs**](ScenariorunApi.md#getscenarioruncumulatedlogs) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/cumulatedlogs | Get the cumulated logs of a scenariorun
[**GetScenarioRunLogs**](ScenariorunApi.md#getscenariorunlogs) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/logs | get the logs for the ScenarioRun
[**GetScenarioRunStatus**](ScenariorunApi.md#getscenariorunstatus) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/status | get the status for the ScenarioRun
[**GetScenarioRuns**](ScenariorunApi.md#getscenarioruns) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns | get the list of ScenarioRuns for the Scenario
[**GetWorkspaceScenarioRuns**](ScenariorunApi.md#getworkspacescenarioruns) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarioruns | get the list of ScenarioRuns for the Workspace
[**ImportScenarioRun**](ScenariorunApi.md#importscenariorun) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/run/import | import a ScenarioRun for the Scenario
[**RunScenario**](ScenariorunApi.md#runscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/run | run a ScenarioRun for the Scenario
[**SearchScenarioRuns**](ScenariorunApi.md#searchscenarioruns) | **POST** /organizations/{organization_id}/scenarioruns/search | Search ScenarioRuns
[**StartScenarioRunContainers**](ScenariorunApi.md#startscenarioruncontainers) | **POST** /organizations/{organization_id}/scenarioruns/startcontainers | Start a new scenariorun with raw containers definition
[**StopScenarioRun**](ScenariorunApi.md#stopscenariorun) | **POST** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/stop | stop a ScenarioRun for the Scenario


<a name="deletehistoricaldataorganization"></a>
# **DeleteHistoricalDataOrganization**
> void DeleteHistoricalDataOrganization (string organizationId, bool? deleteUnknown = null)

Delete all historical ScenarioRuns in the Organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteHistoricalDataOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var deleteUnknown = false;  // bool? | condition to delete runs with an Unknown status (optional)  (default to false)

            try
            {
                // Delete all historical ScenarioRuns in the Organization
                apiInstance.DeleteHistoricalDataOrganization(organizationId, deleteUnknown);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.DeleteHistoricalDataOrganization: " + e.Message );
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
 **deleteUnknown** | **bool?**| condition to delete runs with an Unknown status | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request succeeded |  -  |
| **400** | Bad request |  -  |
| **404** | the Organization specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehistoricaldatascenario"></a>
# **DeleteHistoricalDataScenario**
> void DeleteHistoricalDataScenario (string organizationId, string workspaceId, string scenarioId, bool? deleteUnknown = null)

Delete all historical ScenarioRuns in the Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteHistoricalDataScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var scenarioId = "scenarioId_example";  // string | the Scenario identifier
            var deleteUnknown = false;  // bool? | condition to delete runs with an Unknown status (optional)  (default to false)

            try
            {
                // Delete all historical ScenarioRuns in the Scenario
                apiInstance.DeleteHistoricalDataScenario(organizationId, workspaceId, scenarioId, deleteUnknown);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.DeleteHistoricalDataScenario: " + e.Message );
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
 **deleteUnknown** | **bool?**| condition to delete runs with an Unknown status | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request succeeded |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehistoricaldataworkspace"></a>
# **DeleteHistoricalDataWorkspace**
> void DeleteHistoricalDataWorkspace (string organizationId, string workspaceId, bool? deleteUnknown = null)

Delete all historical ScenarioRuns in the Workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteHistoricalDataWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var deleteUnknown = false;  // bool? | condition to delete runs with an Unknown status (optional)  (default to false)

            try
            {
                // Delete all historical ScenarioRuns in the Workspace
                apiInstance.DeleteHistoricalDataWorkspace(organizationId, workspaceId, deleteUnknown);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.DeleteHistoricalDataWorkspace: " + e.Message );
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
 **deleteUnknown** | **bool?**| condition to delete runs with an Unknown status | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request succeeded |  -  |
| **400** | Bad request |  -  |
| **404** | the Organization or Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletescenariorun"></a>
# **DeleteScenarioRun**
> void DeleteScenarioRun (string organizationId, string scenariorunId)

Delete a scenariorun

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteScenarioRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var scenariorunId = "scenariorunId_example";  // string | the ScenarioRun identifier

            try
            {
                // Delete a scenariorun
                apiInstance.DeleteScenarioRun(organizationId, scenariorunId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.DeleteScenarioRun: " + e.Message );
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
 **scenariorunId** | **string**| the ScenarioRun identifier | 

### Return type

void (empty response body)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request succeeded |  -  |
| **400** | Bad request |  -  |
| **404** | the ScenarioRun specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findscenariorunbyid"></a>
# **FindScenarioRunById**
> ScenarioRun FindScenarioRunById (string organizationId, string scenariorunId)

Get the details of a scenariorun

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindScenarioRunByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var scenariorunId = "scenariorunId_example";  // string | the ScenarioRun identifier

            try
            {
                // Get the details of a scenariorun
                ScenarioRun result = apiInstance.FindScenarioRunById(organizationId, scenariorunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.FindScenarioRunById: " + e.Message );
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
 **scenariorunId** | **string**| the ScenarioRun identifier | 

### Return type

[**ScenarioRun**](ScenarioRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the ScenarioRun details |  -  |
| **404** | the ScenarioRun specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscenarioruncumulatedlogs"></a>
# **GetScenarioRunCumulatedLogs**
> string GetScenarioRunCumulatedLogs (string organizationId, string scenariorunId)

Get the cumulated logs of a scenariorun

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetScenarioRunCumulatedLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var scenariorunId = "scenariorunId_example";  // string | the ScenarioRun identifier

            try
            {
                // Get the cumulated logs of a scenariorun
                string result = apiInstance.GetScenarioRunCumulatedLogs(organizationId, scenariorunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.GetScenarioRunCumulatedLogs: " + e.Message );
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
 **scenariorunId** | **string**| the ScenarioRun identifier | 

### Return type

**string**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the ScenarioRun cumulated logs |  -  |
| **400** | Bad request |  -  |
| **404** | the ScenarioRun specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscenariorunlogs"></a>
# **GetScenarioRunLogs**
> ScenarioRunLogs GetScenarioRunLogs (string organizationId, string scenariorunId)

get the logs for the ScenarioRun

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetScenarioRunLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var scenariorunId = "scenariorunId_example";  // string | the ScenarioRun identifier

            try
            {
                // get the logs for the ScenarioRun
                ScenarioRunLogs result = apiInstance.GetScenarioRunLogs(organizationId, scenariorunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.GetScenarioRunLogs: " + e.Message );
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
 **scenariorunId** | **string**| the ScenarioRun identifier | 

### Return type

[**ScenarioRunLogs**](ScenarioRunLogs.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the scenariorun logs details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscenariorunstatus"></a>
# **GetScenarioRunStatus**
> ScenarioRunStatus GetScenarioRunStatus (string organizationId, string scenariorunId)

get the status for the ScenarioRun

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetScenarioRunStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var scenariorunId = "scenariorunId_example";  // string | the ScenarioRun identifier

            try
            {
                // get the status for the ScenarioRun
                ScenarioRunStatus result = apiInstance.GetScenarioRunStatus(organizationId, scenariorunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.GetScenarioRunStatus: " + e.Message );
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
 **scenariorunId** | **string**| the ScenarioRun identifier | 

### Return type

[**ScenarioRunStatus**](ScenarioRunStatus.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the scenariorun status details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscenarioruns"></a>
# **GetScenarioRuns**
> List&lt;ScenarioRun&gt; GetScenarioRuns (string organizationId, string workspaceId, string scenarioId)

get the list of ScenarioRuns for the Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetScenarioRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var scenarioId = "scenarioId_example";  // string | the Scenario identifier

            try
            {
                // get the list of ScenarioRuns for the Scenario
                List<ScenarioRun> result = apiInstance.GetScenarioRuns(organizationId, workspaceId, scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.GetScenarioRuns: " + e.Message );
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

### Return type

[**List&lt;ScenarioRun&gt;**](ScenarioRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the scenariorun details list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacescenarioruns"></a>
# **GetWorkspaceScenarioRuns**
> List&lt;ScenarioRun&gt; GetWorkspaceScenarioRuns (string organizationId, string workspaceId)

get the list of ScenarioRuns for the Workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetWorkspaceScenarioRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier

            try
            {
                // get the list of ScenarioRuns for the Workspace
                List<ScenarioRun> result = apiInstance.GetWorkspaceScenarioRuns(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.GetWorkspaceScenarioRuns: " + e.Message );
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

### Return type

[**List&lt;ScenarioRun&gt;**](ScenarioRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the scenariorun details list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importscenariorun"></a>
# **ImportScenarioRun**
> ScenarioRun ImportScenarioRun (string organizationId, string workspaceId, string scenarioId, ScenarioRun scenarioRun)

import a ScenarioRun for the Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class ImportScenarioRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var scenarioId = "scenarioId_example";  // string | the Scenario identifier
            var scenarioRun = new ScenarioRun(); // ScenarioRun | the ScenarioRun to import

            try
            {
                // import a ScenarioRun for the Scenario
                ScenarioRun result = apiInstance.ImportScenarioRun(organizationId, workspaceId, scenarioId, scenarioRun);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.ImportScenarioRun: " + e.Message );
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
 **scenarioRun** | [**ScenarioRun**](ScenarioRun.md)| the ScenarioRun to import | 

### Return type

[**ScenarioRun**](ScenarioRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the scenariorun details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runscenario"></a>
# **RunScenario**
> ScenarioRun RunScenario (string organizationId, string workspaceId, string scenarioId)

run a ScenarioRun for the Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RunScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var scenarioId = "scenarioId_example";  // string | the Scenario identifier

            try
            {
                // run a ScenarioRun for the Scenario
                ScenarioRun result = apiInstance.RunScenario(organizationId, workspaceId, scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.RunScenario: " + e.Message );
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

### Return type

[**ScenarioRun**](ScenarioRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the scenariorun details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchscenarioruns"></a>
# **SearchScenarioRuns**
> List&lt;ScenarioRun&gt; SearchScenarioRuns (string organizationId, ScenarioRunSearch scenarioRunSearch)

Search ScenarioRuns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class SearchScenarioRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var scenarioRunSearch = new ScenarioRunSearch(); // ScenarioRunSearch | the ScenarioRun search parameters

            try
            {
                // Search ScenarioRuns
                List<ScenarioRun> result = apiInstance.SearchScenarioRuns(organizationId, scenarioRunSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.SearchScenarioRuns: " + e.Message );
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
 **scenarioRunSearch** | [**ScenarioRunSearch**](ScenarioRunSearch.md)| the ScenarioRun search parameters | 

### Return type

[**List&lt;ScenarioRun&gt;**](ScenarioRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the scenariorun details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startscenarioruncontainers"></a>
# **StartScenarioRunContainers**
> ScenarioRun StartScenarioRunContainers (string organizationId, ScenarioRunStartContainers scenarioRunStartContainers)

Start a new scenariorun with raw containers definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class StartScenarioRunContainersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var scenarioRunStartContainers = new ScenarioRunStartContainers(); // ScenarioRunStartContainers | the raw containers definition

            try
            {
                // Start a new scenariorun with raw containers definition
                ScenarioRun result = apiInstance.StartScenarioRunContainers(organizationId, scenarioRunStartContainers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.StartScenarioRunContainers: " + e.Message );
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
 **scenarioRunStartContainers** | [**ScenarioRunStartContainers**](ScenarioRunStartContainers.md)| the raw containers definition | 

### Return type

[**ScenarioRun**](ScenarioRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | the scenariorun details |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stopscenariorun"></a>
# **StopScenarioRun**
> ScenarioRunStatus StopScenarioRun (string organizationId, string scenariorunId)

stop a ScenarioRun for the Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class StopScenarioRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var scenariorunId = "scenariorunId_example";  // string | the scenariorun identifier

            try
            {
                // stop a ScenarioRun for the Scenario
                ScenarioRunStatus result = apiInstance.StopScenarioRun(organizationId, scenariorunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.StopScenarioRun: " + e.Message );
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
 **scenariorunId** | **string**| the scenariorun identifier | 

### Return type

[**ScenarioRunStatus**](ScenarioRunStatus.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the scenariorun status details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

