# Com.Cosmotech.Api.ScenariorunApi

All URIs are relative to *https://api.azure.cosmo-platform.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteScenarioRun**](ScenariorunApi.md#deletescenariorun) | **DELETE** /organizations/{organization_id}/scenarioruns/{scenariorun_id} | Delete a scenariorun
[**FindScenarioRunById**](ScenariorunApi.md#findscenariorunbyid) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id} | Get the details of a scenariorun
[**GetScenarioScenarioRun**](ScenariorunApi.md#getscenarioscenariorun) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns/{scenariorun_id} | get the ScenarioRun for the Scenario
[**GetScenarioScenarioRunLogs**](ScenariorunApi.md#getscenarioscenariorunlogs) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns/{scenariorun_id}/logs | get the logs for the ScenarioRun
[**GetScenarioScenarioRuns**](ScenariorunApi.md#getscenarioscenarioruns) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns | get the list of ScenarioRuns for the Scenario
[**GetWorkspaceScenarioRuns**](ScenariorunApi.md#getworkspacescenarioruns) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarioruns | get the list of ScenarioRuns for the Workspace
[**RunScenario**](ScenariorunApi.md#runscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/run | run a ScenarioRun for the Scenario
[**SearchScenarioRunLogs**](ScenariorunApi.md#searchscenariorunlogs) | **POST** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/logs/search | Search the logs of a scenariorun
[**SearchScenarioRuns**](ScenariorunApi.md#searchscenarioruns) | **POST** /organizations/{organization_id}/scenarioruns/search | Search ScenarioRuns
[**StartScenarioRunContainers**](ScenariorunApi.md#startscenarioruncontainers) | **POST** /organizations/{organization_id}/scenarioruns/startcontainers | Start a new scenariorun with raw containers definition
[**StartScenarioRunScenario**](ScenariorunApi.md#startscenariorunscenario) | **POST** /organizations/{organization_id}/scenarioruns/start | Start a new scenariorun for a Scenario
[**StartScenarioRunSolution**](ScenariorunApi.md#startscenariorunsolution) | **POST** /organizations/{organization_id}/scenarioruns/startsolution | Start a new scenariorun for a Solution Run Template


<a name="deletescenariorun"></a>
# **DeleteScenarioRun**
> ScenarioRun DeleteScenarioRun (string organizationId, string scenariorunId)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var scenariorunId = scenariorunId_example;  // string | the ScenarioRun identifier

            try
            {
                // Delete a scenariorun
                ScenarioRun result = apiInstance.DeleteScenarioRun(organizationId, scenariorunId);
                Debug.WriteLine(result);
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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var scenariorunId = scenariorunId_example;  // string | the ScenarioRun identifier

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

<a name="getscenarioscenariorun"></a>
# **GetScenarioScenarioRun**
> ScenarioRun GetScenarioScenarioRun (string organizationId, string workspaceId, string scenarioId, string scenariorunId)

get the ScenarioRun for the Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetScenarioScenarioRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier
            var scenariorunId = scenariorunId_example;  // string | the ScenarioRun identifier

            try
            {
                // get the ScenarioRun for the Scenario
                ScenarioRun result = apiInstance.GetScenarioScenarioRun(organizationId, workspaceId, scenarioId, scenariorunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.GetScenarioScenarioRun: " + e.Message );
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

<a name="getscenarioscenariorunlogs"></a>
# **GetScenarioScenarioRunLogs**
> ScenarioRunLogs GetScenarioScenarioRunLogs (string organizationId, string workspaceId, string scenarioId, string scenariorunId)

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
    public class GetScenarioScenarioRunLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier
            var scenariorunId = scenariorunId_example;  // string | the ScenarioRun identifier

            try
            {
                // get the logs for the ScenarioRun
                ScenarioRunLogs result = apiInstance.GetScenarioScenarioRunLogs(organizationId, workspaceId, scenarioId, scenariorunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.GetScenarioScenarioRunLogs: " + e.Message );
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

<a name="getscenarioscenarioruns"></a>
# **GetScenarioScenarioRuns**
> List&lt;ScenarioRunBase&gt; GetScenarioScenarioRuns (string organizationId, string workspaceId, string scenarioId)

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
    public class GetScenarioScenarioRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier

            try
            {
                // get the list of ScenarioRuns for the Scenario
                List<ScenarioRunBase> result = apiInstance.GetScenarioScenarioRuns(organizationId, workspaceId, scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.GetScenarioScenarioRuns: " + e.Message );
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

[**List&lt;ScenarioRunBase&gt;**](ScenarioRunBase.md)

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
> List&lt;ScenarioRunBase&gt; GetWorkspaceScenarioRuns (string organizationId, string workspaceId)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier

            try
            {
                // get the list of ScenarioRuns for the Workspace
                List<ScenarioRunBase> result = apiInstance.GetWorkspaceScenarioRuns(organizationId, workspaceId);
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

[**List&lt;ScenarioRunBase&gt;**](ScenarioRunBase.md)

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

<a name="runscenario"></a>
# **RunScenario**
> ScenarioRunBase RunScenario (string organizationId, string workspaceId, string scenarioId)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier

            try
            {
                // run a ScenarioRun for the Scenario
                ScenarioRunBase result = apiInstance.RunScenario(organizationId, workspaceId, scenarioId);
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

[**ScenarioRunBase**](ScenarioRunBase.md)

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

<a name="searchscenariorunlogs"></a>
# **SearchScenarioRunLogs**
> ScenarioRunLogs SearchScenarioRunLogs (string organizationId, string scenariorunId, ScenarioRunLogsOptions scenarioRunLogsOptions)

Search the logs of a scenariorun

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class SearchScenarioRunLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var scenariorunId = scenariorunId_example;  // string | the ScenarioRun identifier
            var scenarioRunLogsOptions = new ScenarioRunLogsOptions(); // ScenarioRunLogsOptions | the options to search logs

            try
            {
                // Search the logs of a scenariorun
                ScenarioRunLogs result = apiInstance.SearchScenarioRunLogs(organizationId, scenariorunId, scenarioRunLogsOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.SearchScenarioRunLogs: " + e.Message );
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
 **scenarioRunLogsOptions** | [**ScenarioRunLogsOptions**](ScenarioRunLogsOptions.md)| the options to search logs | 

### Return type

[**ScenarioRunLogs**](ScenarioRunLogs.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the ScenarioRun logs |  -  |
| **400** | Bad request |  -  |
| **404** | the ScenarioRun specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchscenarioruns"></a>
# **SearchScenarioRuns**
> List&lt;ScenarioRunBase&gt; SearchScenarioRuns (string organizationId, ScenarioRunSearch scenarioRunSearch)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var scenarioRunSearch = new ScenarioRunSearch(); // ScenarioRunSearch | the ScenarioRun search parameters

            try
            {
                // Search ScenarioRuns
                List<ScenarioRunBase> result = apiInstance.SearchScenarioRuns(organizationId, scenarioRunSearch);
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

[**List&lt;ScenarioRunBase&gt;**](ScenarioRunBase.md)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
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

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | the scenariorun details |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startscenariorunscenario"></a>
# **StartScenarioRunScenario**
> ScenarioRun StartScenarioRunScenario (string organizationId, ScenarioRunStart scenarioRunStart)

Start a new scenariorun for a Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class StartScenarioRunScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var scenarioRunStart = new ScenarioRunStart(); // ScenarioRunStart | the Scenario information to start

            try
            {
                // Start a new scenariorun for a Scenario
                ScenarioRun result = apiInstance.StartScenarioRunScenario(organizationId, scenarioRunStart);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.StartScenarioRunScenario: " + e.Message );
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
 **scenarioRunStart** | [**ScenarioRunStart**](ScenarioRunStart.md)| the Scenario information to start | 

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
| **202** | the scenariorun details |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startscenariorunsolution"></a>
# **StartScenarioRunSolution**
> ScenarioRun StartScenarioRunSolution (string organizationId, ScenarioRunStartSolution scenarioRunStartSolution)

Start a new scenariorun for a Solution Run Template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class StartScenarioRunSolutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenariorunApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var scenarioRunStartSolution = new ScenarioRunStartSolution(); // ScenarioRunStartSolution | the Solution Run Template information to start

            try
            {
                // Start a new scenariorun for a Solution Run Template
                ScenarioRun result = apiInstance.StartScenarioRunSolution(organizationId, scenarioRunStartSolution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenariorunApi.StartScenarioRunSolution: " + e.Message );
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
 **scenarioRunStartSolution** | [**ScenarioRunStartSolution**](ScenarioRunStartSolution.md)| the Solution Run Template information to start | 

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
| **202** | the scenariorun details |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

