# Com.Cosmotech.Api.RunnerApi

All URIs are relative to *https://dev.api.cosmotech.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddRunnerAccessControl**](RunnerApi.md#addrunneraccesscontrol) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/security/access | Add a control access to the Runner |
| [**CreateRunner**](RunnerApi.md#createrunner) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/runners | Create a new Runner |
| [**DeleteRunner**](RunnerApi.md#deleterunner) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id} | Delete a runner |
| [**GetRunner**](RunnerApi.md#getrunner) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id} | Get the details of an runner |
| [**GetRunnerAccessControl**](RunnerApi.md#getrunneraccesscontrol) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/security/access/{identity_id} | Get a control access for the Runner |
| [**GetRunnerPermissions**](RunnerApi.md#getrunnerpermissions) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/permissions/{role} | Get the Runner permission by given role |
| [**GetRunnerSecurity**](RunnerApi.md#getrunnersecurity) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/security | Get the Runner security information |
| [**GetRunnerSecurityUsers**](RunnerApi.md#getrunnersecurityusers) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/security/users | Get the Runner security users list |
| [**ListRunners**](RunnerApi.md#listrunners) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/runners | List all Runners |
| [**RemoveRunnerAccessControl**](RunnerApi.md#removerunneraccesscontrol) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/security/access/{identity_id} | Remove the specified access from the given Organization Runner |
| [**SetRunnerDefaultSecurity**](RunnerApi.md#setrunnerdefaultsecurity) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/security/default | Set the Runner default security |
| [**StartRun**](RunnerApi.md#startrun) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/start | Start a run with runner parameters |
| [**StopRun**](RunnerApi.md#stoprun) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/stop | Stop the last run |
| [**UpdateRunner**](RunnerApi.md#updaterunner) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id} | Update a runner |
| [**UpdateRunnerAccessControl**](RunnerApi.md#updaterunneraccesscontrol) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/runners/{runner_id}/security/access/{identity_id} | Update the specified access to User for a Runner |

<a id="addrunneraccesscontrol"></a>
# **AddRunnerAccessControl**
> RunnerAccessControl AddRunnerAccessControl (string organizationId, string workspaceId, string runnerId, RunnerAccessControl runnerAccessControl)

Add a control access to the Runner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddRunnerAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var runnerAccessControl = new RunnerAccessControl(); // RunnerAccessControl | the new Runner security access to add.

            try
            {
                // Add a control access to the Runner
                RunnerAccessControl result = apiInstance.AddRunnerAccessControl(organizationId, workspaceId, runnerId, runnerAccessControl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.AddRunnerAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddRunnerAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a control access to the Runner
    ApiResponse<RunnerAccessControl> response = apiInstance.AddRunnerAccessControlWithHttpInfo(organizationId, workspaceId, runnerId, runnerAccessControl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.AddRunnerAccessControlWithHttpInfo: " + e.Message);
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
| **runnerAccessControl** | [**RunnerAccessControl**](RunnerAccessControl.md) | the new Runner security access to add. |  |

### Return type

[**RunnerAccessControl**](RunnerAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Runner access |  -  |
| **404** | the Runner specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createrunner"></a>
# **CreateRunner**
> Runner CreateRunner (string organizationId, string workspaceId, Runner runner)

Create a new Runner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateRunnerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runner = new Runner(); // Runner | the Runner to create

            try
            {
                // Create a new Runner
                Runner result = apiInstance.CreateRunner(organizationId, workspaceId, runner);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.CreateRunner: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRunnerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Runner
    ApiResponse<Runner> response = apiInstance.CreateRunnerWithHttpInfo(organizationId, workspaceId, runner);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.CreateRunnerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **runner** | [**Runner**](Runner.md) | the Runner to create |  |

### Return type

[**Runner**](Runner.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the runner details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterunner"></a>
# **DeleteRunner**
> void DeleteRunner (string organizationId, string workspaceId, string runnerId)

Delete a runner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteRunnerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier

            try
            {
                // Delete a runner
                apiInstance.DeleteRunner(organizationId, workspaceId, runnerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.DeleteRunner: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRunnerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a runner
    apiInstance.DeleteRunnerWithHttpInfo(organizationId, workspaceId, runnerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.DeleteRunnerWithHttpInfo: " + e.Message);
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
| **404** | the Runner specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrunner"></a>
# **GetRunner**
> Runner GetRunner (string organizationId, string workspaceId, string runnerId)

Get the details of an runner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetRunnerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier

            try
            {
                // Get the details of an runner
                Runner result = apiInstance.GetRunner(organizationId, workspaceId, runnerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.GetRunner: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunnerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of an runner
    ApiResponse<Runner> response = apiInstance.GetRunnerWithHttpInfo(organizationId, workspaceId, runnerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.GetRunnerWithHttpInfo: " + e.Message);
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

### Return type

[**Runner**](Runner.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Runner details |  -  |
| **404** | the Runner specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrunneraccesscontrol"></a>
# **GetRunnerAccessControl**
> RunnerAccessControl GetRunnerAccessControl (string organizationId, string workspaceId, string runnerId, string identityId)

Get a control access for the Runner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetRunnerAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var identityId = "identityId_example";  // string | the User identifier

            try
            {
                // Get a control access for the Runner
                RunnerAccessControl result = apiInstance.GetRunnerAccessControl(organizationId, workspaceId, runnerId, identityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.GetRunnerAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunnerAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a control access for the Runner
    ApiResponse<RunnerAccessControl> response = apiInstance.GetRunnerAccessControlWithHttpInfo(organizationId, workspaceId, runnerId, identityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.GetRunnerAccessControlWithHttpInfo: " + e.Message);
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
| **identityId** | **string** | the User identifier |  |

### Return type

[**RunnerAccessControl**](RunnerAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Runner access |  -  |
| **404** | the Runner or user specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrunnerpermissions"></a>
# **GetRunnerPermissions**
> List&lt;string&gt; GetRunnerPermissions (string organizationId, string workspaceId, string runnerId, string role)

Get the Runner permission by given role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetRunnerPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var role = "role_example";  // string | the Role

            try
            {
                // Get the Runner permission by given role
                List<string> result = apiInstance.GetRunnerPermissions(organizationId, workspaceId, runnerId, role);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.GetRunnerPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunnerPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Runner permission by given role
    ApiResponse<List<string>> response = apiInstance.GetRunnerPermissionsWithHttpInfo(organizationId, workspaceId, runnerId, role);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.GetRunnerPermissionsWithHttpInfo: " + e.Message);
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
| **role** | **string** | the Role |  |

### Return type

**List<string>**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Runners security permission list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrunnersecurity"></a>
# **GetRunnerSecurity**
> RunnerSecurity GetRunnerSecurity (string organizationId, string workspaceId, string runnerId)

Get the Runner security information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetRunnerSecurityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier

            try
            {
                // Get the Runner security information
                RunnerSecurity result = apiInstance.GetRunnerSecurity(organizationId, workspaceId, runnerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.GetRunnerSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunnerSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Runner security information
    ApiResponse<RunnerSecurity> response = apiInstance.GetRunnerSecurityWithHttpInfo(organizationId, workspaceId, runnerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.GetRunnerSecurityWithHttpInfo: " + e.Message);
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

### Return type

[**RunnerSecurity**](RunnerSecurity.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Runner security |  -  |
| **404** | the Runner specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrunnersecurityusers"></a>
# **GetRunnerSecurityUsers**
> List&lt;string&gt; GetRunnerSecurityUsers (string organizationId, string workspaceId, string runnerId)

Get the Runner security users list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetRunnerSecurityUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier

            try
            {
                // Get the Runner security users list
                List<string> result = apiInstance.GetRunnerSecurityUsers(organizationId, workspaceId, runnerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.GetRunnerSecurityUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunnerSecurityUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Runner security users list
    ApiResponse<List<string>> response = apiInstance.GetRunnerSecurityUsersWithHttpInfo(organizationId, workspaceId, runnerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.GetRunnerSecurityUsersWithHttpInfo: " + e.Message);
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

### Return type

**List<string>**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Runner security users list |  -  |
| **404** | the Runner specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listrunners"></a>
# **ListRunners**
> List&lt;Runner&gt; ListRunners (string organizationId, string workspaceId, int? page = null, int? size = null)

List all Runners

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class ListRunnersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var page = 56;  // int? | page number to query (optional) 
            var size = 56;  // int? | amount of result by page (optional) 

            try
            {
                // List all Runners
                List<Runner> result = apiInstance.ListRunners(organizationId, workspaceId, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.ListRunners: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRunnersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Runners
    ApiResponse<List<Runner>> response = apiInstance.ListRunnersWithHttpInfo(organizationId, workspaceId, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.ListRunnersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **page** | **int?** | page number to query | [optional]  |
| **size** | **int?** | amount of result by page | [optional]  |

### Return type

[**List&lt;Runner&gt;**](Runner.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the list of Runners |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removerunneraccesscontrol"></a>
# **RemoveRunnerAccessControl**
> void RemoveRunnerAccessControl (string organizationId, string workspaceId, string runnerId, string identityId)

Remove the specified access from the given Organization Runner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveRunnerAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var identityId = "identityId_example";  // string | the User identifier

            try
            {
                // Remove the specified access from the given Organization Runner
                apiInstance.RemoveRunnerAccessControl(organizationId, workspaceId, runnerId, identityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.RemoveRunnerAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveRunnerAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove the specified access from the given Organization Runner
    apiInstance.RemoveRunnerAccessControlWithHttpInfo(organizationId, workspaceId, runnerId, identityId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.RemoveRunnerAccessControlWithHttpInfo: " + e.Message);
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
| **identityId** | **string** | the User identifier |  |

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
| **404** | the Runner or the user specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setrunnerdefaultsecurity"></a>
# **SetRunnerDefaultSecurity**
> RunnerSecurity SetRunnerDefaultSecurity (string organizationId, string workspaceId, string runnerId, RunnerRole runnerRole)

Set the Runner default security

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class SetRunnerDefaultSecurityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var runnerRole = new RunnerRole(); // RunnerRole | This change the runner default security. The default security is the role assigned to any person not on the Access Control List. If the default security is None, then nobody outside of the ACL can access the runner.

            try
            {
                // Set the Runner default security
                RunnerSecurity result = apiInstance.SetRunnerDefaultSecurity(organizationId, workspaceId, runnerId, runnerRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.SetRunnerDefaultSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetRunnerDefaultSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the Runner default security
    ApiResponse<RunnerSecurity> response = apiInstance.SetRunnerDefaultSecurityWithHttpInfo(organizationId, workspaceId, runnerId, runnerRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.SetRunnerDefaultSecurityWithHttpInfo: " + e.Message);
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
| **runnerRole** | [**RunnerRole**](RunnerRole.md) | This change the runner default security. The default security is the role assigned to any person not on the Access Control List. If the default security is None, then nobody outside of the ACL can access the runner. |  |

### Return type

[**RunnerSecurity**](RunnerSecurity.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Runner default visibility |  -  |
| **404** | the Runner specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="startrun"></a>
# **StartRun**
> RunnerLastRun StartRun (string organizationId, string workspaceId, string runnerId)

Start a run with runner parameters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class StartRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier

            try
            {
                // Start a run with runner parameters
                RunnerLastRun result = apiInstance.StartRun(organizationId, workspaceId, runnerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.StartRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start a run with runner parameters
    ApiResponse<RunnerLastRun> response = apiInstance.StartRunWithHttpInfo(organizationId, workspaceId, runnerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.StartRunWithHttpInfo: " + e.Message);
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

### Return type

[**RunnerLastRun**](RunnerLastRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | the Run id started |  -  |
| **404** | the Runner specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="stoprun"></a>
# **StopRun**
> void StopRun (string organizationId, string workspaceId, string runnerId)

Stop the last run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class StopRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier

            try
            {
                // Stop the last run
                apiInstance.StopRun(organizationId, workspaceId, runnerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.StopRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StopRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stop the last run
    apiInstance.StopRunWithHttpInfo(organizationId, workspaceId, runnerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.StopRunWithHttpInfo: " + e.Message);
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
| **202** | the last Run has been stopped |  -  |
| **404** | the Runner specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updaterunner"></a>
# **UpdateRunner**
> Runner UpdateRunner (string organizationId, string workspaceId, string runnerId, Runner runner)

Update a runner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateRunnerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var runner = new Runner(); // Runner | the new Runner details. This endpoint can't be used to update security

            try
            {
                // Update a runner
                Runner result = apiInstance.UpdateRunner(organizationId, workspaceId, runnerId, runner);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.UpdateRunner: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRunnerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a runner
    ApiResponse<Runner> response = apiInstance.UpdateRunnerWithHttpInfo(organizationId, workspaceId, runnerId, runner);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.UpdateRunnerWithHttpInfo: " + e.Message);
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
| **runner** | [**Runner**](Runner.md) | the new Runner details. This endpoint can&#39;t be used to update security |  |

### Return type

[**Runner**](Runner.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the runner details |  -  |
| **400** | Bad request |  -  |
| **404** | the Runner specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updaterunneraccesscontrol"></a>
# **UpdateRunnerAccessControl**
> RunnerAccessControl UpdateRunnerAccessControl (string organizationId, string workspaceId, string runnerId, string identityId, RunnerRole runnerRole)

Update the specified access to User for a Runner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateRunnerAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunnerApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var runnerId = "runnerId_example";  // string | the Runner identifier
            var identityId = "identityId_example";  // string | the User identifier
            var runnerRole = new RunnerRole(); // RunnerRole | The new Runner Access Control

            try
            {
                // Update the specified access to User for a Runner
                RunnerAccessControl result = apiInstance.UpdateRunnerAccessControl(organizationId, workspaceId, runnerId, identityId, runnerRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunnerApi.UpdateRunnerAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRunnerAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the specified access to User for a Runner
    ApiResponse<RunnerAccessControl> response = apiInstance.UpdateRunnerAccessControlWithHttpInfo(organizationId, workspaceId, runnerId, identityId, runnerRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunnerApi.UpdateRunnerAccessControlWithHttpInfo: " + e.Message);
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
| **identityId** | **string** | the User identifier |  |
| **runnerRole** | [**RunnerRole**](RunnerRole.md) | The new Runner Access Control |  |

### Return type

[**RunnerAccessControl**](RunnerAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Runner access |  -  |
| **404** | The Organization specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

