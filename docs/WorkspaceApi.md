# Com.Cosmotech.Api.WorkspaceApi

All URIs are relative to *https://dev.api.cosmotech.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddWorkspaceAccessControl**](WorkspaceApi.md#addworkspaceaccesscontrol) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/security/access | Add a control access to the Workspace |
| [**CreateSecret**](WorkspaceApi.md#createsecret) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/secret | Create a secret for the Workspace |
| [**CreateWorkspace**](WorkspaceApi.md#createworkspace) | **POST** /organizations/{organization_id}/workspaces | Create a new workspace |
| [**DeleteAllWorkspaceFiles**](WorkspaceApi.md#deleteallworkspacefiles) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/files | Delete all Workspace files |
| [**DeleteWorkspace**](WorkspaceApi.md#deleteworkspace) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id} | Delete a workspace |
| [**DeleteWorkspaceFile**](WorkspaceApi.md#deleteworkspacefile) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/files/delete | Delete a workspace file |
| [**DownloadWorkspaceFile**](WorkspaceApi.md#downloadworkspacefile) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/files/download | Download the Workspace File specified |
| [**FindAllWorkspaceFiles**](WorkspaceApi.md#findallworkspacefiles) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/files | List all Workspace files |
| [**FindAllWorkspaces**](WorkspaceApi.md#findallworkspaces) | **GET** /organizations/{organization_id}/workspaces | List all Workspaces |
| [**FindWorkspaceById**](WorkspaceApi.md#findworkspacebyid) | **GET** /organizations/{organization_id}/workspaces/{workspace_id} | Get the details of an workspace |
| [**GetWorkspaceAccessControl**](WorkspaceApi.md#getworkspaceaccesscontrol) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/security/access/{identity_id} | Get a control access for the Workspace |
| [**GetWorkspacePermissions**](WorkspaceApi.md#getworkspacepermissions) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/permissions/{role} | Get the Workspace permission by given role |
| [**GetWorkspaceSecurity**](WorkspaceApi.md#getworkspacesecurity) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/security | Get the Workspace security information |
| [**GetWorkspaceSecurityUsers**](WorkspaceApi.md#getworkspacesecurityusers) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/security/users | Get the Workspace security users list |
| [**LinkDataset**](WorkspaceApi.md#linkdataset) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/link |  |
| [**RemoveWorkspaceAccessControl**](WorkspaceApi.md#removeworkspaceaccesscontrol) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/security/access/{identity_id} | Remove the specified access from the given Organization Workspace |
| [**SetWorkspaceDefaultSecurity**](WorkspaceApi.md#setworkspacedefaultsecurity) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/security/default | Set the Workspace default security |
| [**UnlinkDataset**](WorkspaceApi.md#unlinkdataset) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/unlink |  |
| [**UpdateWorkspace**](WorkspaceApi.md#updateworkspace) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id} | Update a workspace |
| [**UpdateWorkspaceAccessControl**](WorkspaceApi.md#updateworkspaceaccesscontrol) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/security/access/{identity_id} | Update the specified access to User for a Workspace |
| [**UploadWorkspaceFile**](WorkspaceApi.md#uploadworkspacefile) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/files | Upload a file for the Workspace |

<a id="addworkspaceaccesscontrol"></a>
# **AddWorkspaceAccessControl**
> WorkspaceAccessControl AddWorkspaceAccessControl (string organizationId, string workspaceId, WorkspaceAccessControl workspaceAccessControl)

Add a control access to the Workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddWorkspaceAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var workspaceAccessControl = new WorkspaceAccessControl(); // WorkspaceAccessControl | the new Workspace security access to add.

            try
            {
                // Add a control access to the Workspace
                WorkspaceAccessControl result = apiInstance.AddWorkspaceAccessControl(organizationId, workspaceId, workspaceAccessControl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.AddWorkspaceAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddWorkspaceAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a control access to the Workspace
    ApiResponse<WorkspaceAccessControl> response = apiInstance.AddWorkspaceAccessControlWithHttpInfo(organizationId, workspaceId, workspaceAccessControl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.AddWorkspaceAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **workspaceAccessControl** | [**WorkspaceAccessControl**](WorkspaceAccessControl.md) | the new Workspace security access to add. |  |

### Return type

[**WorkspaceAccessControl**](WorkspaceAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Workspace access |  -  |
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsecret"></a>
# **CreateSecret**
> void CreateSecret (string organizationId, string workspaceId, WorkspaceSecret workspaceSecret)

Create a secret for the Workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var workspaceSecret = new WorkspaceSecret(); // WorkspaceSecret | the definition of the secret

            try
            {
                // Create a secret for the Workspace
                apiInstance.CreateSecret(organizationId, workspaceId, workspaceSecret);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.CreateSecret: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSecretWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a secret for the Workspace
    apiInstance.CreateSecretWithHttpInfo(organizationId, workspaceId, workspaceSecret);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.CreateSecretWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **workspaceSecret** | [**WorkspaceSecret**](WorkspaceSecret.md) | the definition of the secret |  |

### Return type

void (empty response body)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request succeeded |  -  |
| **404** | the Workspace or the User specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createworkspace"></a>
# **CreateWorkspace**
> Workspace CreateWorkspace (string organizationId, Workspace workspace)

Create a new workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspace = new Workspace(); // Workspace | the Workspace to create

            try
            {
                // Create a new workspace
                Workspace result = apiInstance.CreateWorkspace(organizationId, workspace);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.CreateWorkspace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new workspace
    ApiResponse<Workspace> response = apiInstance.CreateWorkspaceWithHttpInfo(organizationId, workspace);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.CreateWorkspaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspace** | [**Workspace**](Workspace.md) | the Workspace to create |  |

### Return type

[**Workspace**](Workspace.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the workspace details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteallworkspacefiles"></a>
# **DeleteAllWorkspaceFiles**
> void DeleteAllWorkspaceFiles (string organizationId, string workspaceId)

Delete all Workspace files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteAllWorkspaceFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier

            try
            {
                // Delete all Workspace files
                apiInstance.DeleteAllWorkspaceFiles(organizationId, workspaceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.DeleteAllWorkspaceFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAllWorkspaceFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all Workspace files
    apiInstance.DeleteAllWorkspaceFilesWithHttpInfo(organizationId, workspaceId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.DeleteAllWorkspaceFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |

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
| **404** | the Workspace specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteworkspace"></a>
# **DeleteWorkspace**
> void DeleteWorkspace (string organizationId, string workspaceId)

Delete a workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier

            try
            {
                // Delete a workspace
                apiInstance.DeleteWorkspace(organizationId, workspaceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.DeleteWorkspace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a workspace
    apiInstance.DeleteWorkspaceWithHttpInfo(organizationId, workspaceId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.DeleteWorkspaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |

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
| **204** | the workspace details |  -  |
| **400** | Bad request |  -  |
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteworkspacefile"></a>
# **DeleteWorkspaceFile**
> void DeleteWorkspaceFile (string organizationId, string workspaceId, string fileName)

Delete a workspace file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteWorkspaceFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var fileName = "fileName_example";  // string | the file name

            try
            {
                // Delete a workspace file
                apiInstance.DeleteWorkspaceFile(organizationId, workspaceId, fileName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.DeleteWorkspaceFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWorkspaceFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a workspace file
    apiInstance.DeleteWorkspaceFileWithHttpInfo(organizationId, workspaceId, fileName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.DeleteWorkspaceFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **fileName** | **string** | the file name |  |

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
| **404** | the Workspace or the file specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="downloadworkspacefile"></a>
# **DownloadWorkspaceFile**
> System.IO.Stream DownloadWorkspaceFile (string organizationId, string workspaceId, string fileName)

Download the Workspace File specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DownloadWorkspaceFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var fileName = "fileName_example";  // string | the file name

            try
            {
                // Download the Workspace File specified
                System.IO.Stream result = apiInstance.DownloadWorkspaceFile(organizationId, workspaceId, fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.DownloadWorkspaceFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadWorkspaceFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download the Workspace File specified
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadWorkspaceFileWithHttpInfo(organizationId, workspaceId, fileName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.DownloadWorkspaceFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **fileName** | **string** | the file name |  |

### Return type

**System.IO.Stream**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the workspace file as a resource |  -  |
| **404** | the Workspace file specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findallworkspacefiles"></a>
# **FindAllWorkspaceFiles**
> List&lt;WorkspaceFile&gt; FindAllWorkspaceFiles (string organizationId, string workspaceId)

List all Workspace files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllWorkspaceFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier

            try
            {
                // List all Workspace files
                List<WorkspaceFile> result = apiInstance.FindAllWorkspaceFiles(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.FindAllWorkspaceFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllWorkspaceFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Workspace files
    ApiResponse<List<WorkspaceFile>> response = apiInstance.FindAllWorkspaceFilesWithHttpInfo(organizationId, workspaceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.FindAllWorkspaceFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |

### Return type

[**List&lt;WorkspaceFile&gt;**](WorkspaceFile.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the workspace files |  -  |
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findallworkspaces"></a>
# **FindAllWorkspaces**
> List&lt;Workspace&gt; FindAllWorkspaces (string organizationId, int? page = null, int? size = null)

List all Workspaces

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllWorkspacesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var page = 56;  // int? | page number to query (optional) 
            var size = 56;  // int? | amount of result by page (optional) 

            try
            {
                // List all Workspaces
                List<Workspace> result = apiInstance.FindAllWorkspaces(organizationId, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.FindAllWorkspaces: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllWorkspacesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Workspaces
    ApiResponse<List<Workspace>> response = apiInstance.FindAllWorkspacesWithHttpInfo(organizationId, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.FindAllWorkspacesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **page** | **int?** | page number to query | [optional]  |
| **size** | **int?** | amount of result by page | [optional]  |

### Return type

[**List&lt;Workspace&gt;**](Workspace.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the workspace details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findworkspacebyid"></a>
# **FindWorkspaceById**
> Workspace FindWorkspaceById (string organizationId, string workspaceId)

Get the details of an workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindWorkspaceByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier

            try
            {
                // Get the details of an workspace
                Workspace result = apiInstance.FindWorkspaceById(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.FindWorkspaceById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindWorkspaceByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of an workspace
    ApiResponse<Workspace> response = apiInstance.FindWorkspaceByIdWithHttpInfo(organizationId, workspaceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.FindWorkspaceByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |

### Return type

[**Workspace**](Workspace.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Workspace details |  -  |
| **404** | The Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkspaceaccesscontrol"></a>
# **GetWorkspaceAccessControl**
> WorkspaceAccessControl GetWorkspaceAccessControl (string organizationId, string workspaceId, string identityId)

Get a control access for the Workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetWorkspaceAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var identityId = "identityId_example";  // string | the User identifier

            try
            {
                // Get a control access for the Workspace
                WorkspaceAccessControl result = apiInstance.GetWorkspaceAccessControl(organizationId, workspaceId, identityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetWorkspaceAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkspaceAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a control access for the Workspace
    ApiResponse<WorkspaceAccessControl> response = apiInstance.GetWorkspaceAccessControlWithHttpInfo(organizationId, workspaceId, identityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.GetWorkspaceAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **identityId** | **string** | the User identifier |  |

### Return type

[**WorkspaceAccessControl**](WorkspaceAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Workspace access |  -  |
| **404** | The Workspace or user specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkspacepermissions"></a>
# **GetWorkspacePermissions**
> List&lt;string&gt; GetWorkspacePermissions (string organizationId, string workspaceId, string role)

Get the Workspace permission by given role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetWorkspacePermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var role = "role_example";  // string | the Role

            try
            {
                // Get the Workspace permission by given role
                List<string> result = apiInstance.GetWorkspacePermissions(organizationId, workspaceId, role);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetWorkspacePermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkspacePermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Workspace permission by given role
    ApiResponse<List<string>> response = apiInstance.GetWorkspacePermissionsWithHttpInfo(organizationId, workspaceId, role);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.GetWorkspacePermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
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
| **200** | The Workspace security permission list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkspacesecurity"></a>
# **GetWorkspaceSecurity**
> WorkspaceSecurity GetWorkspaceSecurity (string organizationId, string workspaceId)

Get the Workspace security information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetWorkspaceSecurityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier

            try
            {
                // Get the Workspace security information
                WorkspaceSecurity result = apiInstance.GetWorkspaceSecurity(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetWorkspaceSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkspaceSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Workspace security information
    ApiResponse<WorkspaceSecurity> response = apiInstance.GetWorkspaceSecurityWithHttpInfo(organizationId, workspaceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.GetWorkspaceSecurityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |

### Return type

[**WorkspaceSecurity**](WorkspaceSecurity.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Workspace security |  -  |
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkspacesecurityusers"></a>
# **GetWorkspaceSecurityUsers**
> List&lt;string&gt; GetWorkspaceSecurityUsers (string organizationId, string workspaceId)

Get the Workspace security users list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetWorkspaceSecurityUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier

            try
            {
                // Get the Workspace security users list
                List<string> result = apiInstance.GetWorkspaceSecurityUsers(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetWorkspaceSecurityUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkspaceSecurityUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Workspace security users list
    ApiResponse<List<string>> response = apiInstance.GetWorkspaceSecurityUsersWithHttpInfo(organizationId, workspaceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.GetWorkspaceSecurityUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |

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
| **200** | The Workspace security users list |  -  |
| **404** | the Workspace or the User specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="linkdataset"></a>
# **LinkDataset**
> Workspace LinkDataset (string organizationId, string workspaceId, string datasetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class LinkDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var datasetId = "datasetId_example";  // string | dataset id to be linked to

            try
            {
                Workspace result = apiInstance.LinkDataset(organizationId, workspaceId, datasetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.LinkDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Workspace> response = apiInstance.LinkDatasetWithHttpInfo(organizationId, workspaceId, datasetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.LinkDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **datasetId** | **string** | dataset id to be linked to |  |

### Return type

[**Workspace**](Workspace.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the workspace details |  -  |
| **400** | Bad request |  -  |
| **404** | the workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeworkspaceaccesscontrol"></a>
# **RemoveWorkspaceAccessControl**
> void RemoveWorkspaceAccessControl (string organizationId, string workspaceId, string identityId)

Remove the specified access from the given Organization Workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveWorkspaceAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var identityId = "identityId_example";  // string | the User identifier

            try
            {
                // Remove the specified access from the given Organization Workspace
                apiInstance.RemoveWorkspaceAccessControl(organizationId, workspaceId, identityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.RemoveWorkspaceAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveWorkspaceAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove the specified access from the given Organization Workspace
    apiInstance.RemoveWorkspaceAccessControlWithHttpInfo(organizationId, workspaceId, identityId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.RemoveWorkspaceAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
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
| **404** | The Workspace or the user specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setworkspacedefaultsecurity"></a>
# **SetWorkspaceDefaultSecurity**
> WorkspaceSecurity SetWorkspaceDefaultSecurity (string organizationId, string workspaceId, WorkspaceRole workspaceRole)

Set the Workspace default security

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class SetWorkspaceDefaultSecurityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var workspaceRole = new WorkspaceRole(); // WorkspaceRole | This change the workspace default security. The default security is the role assigned to any person not on the Access Control List. If the default security is None, then nobody outside of the ACL can access the workspace.

            try
            {
                // Set the Workspace default security
                WorkspaceSecurity result = apiInstance.SetWorkspaceDefaultSecurity(organizationId, workspaceId, workspaceRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.SetWorkspaceDefaultSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetWorkspaceDefaultSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the Workspace default security
    ApiResponse<WorkspaceSecurity> response = apiInstance.SetWorkspaceDefaultSecurityWithHttpInfo(organizationId, workspaceId, workspaceRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.SetWorkspaceDefaultSecurityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **workspaceRole** | [**WorkspaceRole**](WorkspaceRole.md) | This change the workspace default security. The default security is the role assigned to any person not on the Access Control List. If the default security is None, then nobody outside of the ACL can access the workspace. |  |

### Return type

[**WorkspaceSecurity**](WorkspaceSecurity.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Workspace default visibility |  -  |
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unlinkdataset"></a>
# **UnlinkDataset**
> Workspace UnlinkDataset (string organizationId, string workspaceId, string datasetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UnlinkDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var datasetId = "datasetId_example";  // string | dataset id to be linked to

            try
            {
                Workspace result = apiInstance.UnlinkDataset(organizationId, workspaceId, datasetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.UnlinkDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlinkDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Workspace> response = apiInstance.UnlinkDatasetWithHttpInfo(organizationId, workspaceId, datasetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.UnlinkDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **datasetId** | **string** | dataset id to be linked to |  |

### Return type

[**Workspace**](Workspace.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the workspace details |  -  |
| **400** | Bad request |  -  |
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateworkspace"></a>
# **UpdateWorkspace**
> Workspace UpdateWorkspace (string organizationId, string workspaceId, Workspace workspace)

Update a workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var workspace = new Workspace(); // Workspace | The new Workspace details. This endpoint can't be used to update security

            try
            {
                // Update a workspace
                Workspace result = apiInstance.UpdateWorkspace(organizationId, workspaceId, workspace);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.UpdateWorkspace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a workspace
    ApiResponse<Workspace> response = apiInstance.UpdateWorkspaceWithHttpInfo(organizationId, workspaceId, workspace);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.UpdateWorkspaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **workspace** | [**Workspace**](Workspace.md) | The new Workspace details. This endpoint can&#39;t be used to update security |  |

### Return type

[**Workspace**](Workspace.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the workspace details |  -  |
| **400** | Bad request |  -  |
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateworkspaceaccesscontrol"></a>
# **UpdateWorkspaceAccessControl**
> WorkspaceAccessControl UpdateWorkspaceAccessControl (string organizationId, string workspaceId, string identityId, WorkspaceRole workspaceRole)

Update the specified access to User for a Workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateWorkspaceAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var identityId = "identityId_example";  // string | the User identifier
            var workspaceRole = new WorkspaceRole(); // WorkspaceRole | The new Workspace Access Control

            try
            {
                // Update the specified access to User for a Workspace
                WorkspaceAccessControl result = apiInstance.UpdateWorkspaceAccessControl(organizationId, workspaceId, identityId, workspaceRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.UpdateWorkspaceAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWorkspaceAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the specified access to User for a Workspace
    ApiResponse<WorkspaceAccessControl> response = apiInstance.UpdateWorkspaceAccessControlWithHttpInfo(organizationId, workspaceId, identityId, workspaceRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.UpdateWorkspaceAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **identityId** | **string** | the User identifier |  |
| **workspaceRole** | [**WorkspaceRole**](WorkspaceRole.md) | The new Workspace Access Control |  |

### Return type

[**WorkspaceAccessControl**](WorkspaceAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Workspace access |  -  |
| **404** | The Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadworkspacefile"></a>
# **UploadWorkspaceFile**
> WorkspaceFile UploadWorkspaceFile (string organizationId, string workspaceId, System.IO.Stream file, bool? overwrite = null, string? destination = null)

Upload a file for the Workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UploadWorkspaceFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var workspaceId = "workspaceId_example";  // string | the Workspace identifier
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 
            var overwrite = false;  // bool? |  (optional)  (default to false)
            var destination = "destination_example";  // string? | Destination path. Must end with a '/' if specifying a folder. Note that paths may or may not start with a '/', but they are always treated as relative to the Workspace root location.  (optional) 

            try
            {
                // Upload a file for the Workspace
                WorkspaceFile result = apiInstance.UploadWorkspaceFile(organizationId, workspaceId, file, overwrite, destination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.UploadWorkspaceFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadWorkspaceFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a file for the Workspace
    ApiResponse<WorkspaceFile> response = apiInstance.UploadWorkspaceFileWithHttpInfo(organizationId, workspaceId, file, overwrite, destination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.UploadWorkspaceFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **workspaceId** | **string** | the Workspace identifier |  |
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |
| **overwrite** | **bool?** |  | [optional] [default to false] |
| **destination** | **string?** | Destination path. Must end with a &#39;/&#39; if specifying a folder. Note that paths may or may not start with a &#39;/&#39;, but they are always treated as relative to the Workspace root location.  | [optional]  |

### Return type

[**WorkspaceFile**](WorkspaceFile.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the file resource details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

