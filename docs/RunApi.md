# Com.Cosmotech.Api.RunApi

All URIs are relative to *https://dev.api.cosmotech.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteRun**](RunApi.md#deleterun) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/runs/{run_id} | Delete a run |
| [**GetRun**](RunApi.md#getrun) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/runs/{run_id} | Get the details of a run |
| [**GetRunLogs**](RunApi.md#getrunlogs) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/runs/{run_id}/logs | get the logs for the Run |
| [**GetRunStatus**](RunApi.md#getrunstatus) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/runs/{run_id}/status | get the status for the Run |
| [**ListRuns**](RunApi.md#listruns) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/runs | get the list of Runs for the Runner |

<a id="deleterun"></a>
# **DeleteRun**
> void DeleteRun (string organizationId, string workspaceId, string runnerId, string runId)

Delete a run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var runId = "runId_example";  // string | the Run identifier

            try
            {
                // Delete a run
                apiInstance.DeleteRun(organizationId, workspaceId, runnerId, runId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunApi.DeleteRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a run
    apiInstance.DeleteRunWithHttpInfo(organizationId, workspaceId, runnerId, runId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunApi.DeleteRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **runnerId** | **string** | the Runner identifier |  |
| **runId** | **string** | the Run identifier |  |

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
| **404** | the Run specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrun"></a>
# **GetRun**
> Run GetRun (string organizationId, string workspaceId, string runnerId, string runId)

Get the details of a run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var runId = "runId_example";  // string | the Run identifier

            try
            {
                // Get the details of a run
                Run result = apiInstance.GetRun(organizationId, workspaceId, runnerId, runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunApi.GetRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a run
    ApiResponse<Run> response = apiInstance.GetRunWithHttpInfo(organizationId, workspaceId, runnerId, runId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunApi.GetRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **runnerId** | **string** | the Runner identifier |  |
| **runId** | **string** | the Run identifier |  |

### Return type

[**Run**](Run.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Run details |  -  |
| **404** | the Run specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrunlogs"></a>
# **GetRunLogs**
> RunLogs GetRunLogs (string organizationId, string workspaceId, string runnerId, string runId)

get the logs for the Run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetRunLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var runId = "runId_example";  // string | the Run identifier

            try
            {
                // get the logs for the Run
                RunLogs result = apiInstance.GetRunLogs(organizationId, workspaceId, runnerId, runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunApi.GetRunLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get the logs for the Run
    ApiResponse<RunLogs> response = apiInstance.GetRunLogsWithHttpInfo(organizationId, workspaceId, runnerId, runId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunApi.GetRunLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **runnerId** | **string** | the Runner identifier |  |
| **runId** | **string** | the Run identifier |  |

### Return type

[**RunLogs**](RunLogs.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the run logs details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrunstatus"></a>
# **GetRunStatus**
> RunStatus GetRunStatus (string organizationId, string workspaceId, string runnerId, string runId)

get the status for the Run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetRunStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var runId = "runId_example";  // string | the Run identifier

            try
            {
                // get the status for the Run
                RunStatus result = apiInstance.GetRunStatus(organizationId, workspaceId, runnerId, runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunApi.GetRunStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get the status for the Run
    ApiResponse<RunStatus> response = apiInstance.GetRunStatusWithHttpInfo(organizationId, workspaceId, runnerId, runId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunApi.GetRunStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **runnerId** | **string** | the Runner identifier |  |
| **runId** | **string** | the Run identifier |  |

### Return type

[**RunStatus**](RunStatus.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the run status details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listruns"></a>
# **ListRuns**
> List&lt;Run&gt; ListRuns (string organizationId, string workspaceId, string runnerId, int? page = null, int? size = null)

get the list of Runs for the Runner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class ListRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var page = 56;  // int? | page number to query (optional) 
            var size = 56;  // int? | amount of result by page (optional) 

            try
            {
                // get the list of Runs for the Runner
                List<Run> result = apiInstance.ListRuns(organizationId, workspaceId, runnerId, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunApi.ListRuns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRunsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get the list of Runs for the Runner
    ApiResponse<List<Run>> response = apiInstance.ListRunsWithHttpInfo(organizationId, workspaceId, runnerId, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunApi.ListRunsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **runnerId** | **string** | the Runner identifier |  |
| **page** | **int?** | page number to query | [optional]  |
| **size** | **int?** | amount of result by page | [optional]  |

### Return type

[**List&lt;Run&gt;**](Run.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the run details list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

