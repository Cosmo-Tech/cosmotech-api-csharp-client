# Com.Cosmotech.Api.WorkspaceApi

All URIs are relative to *https://api.azure.cosmo-platform.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUsersToOrganizationWorkspace**](WorkspaceApi.md#adduserstoorganizationworkspace) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/users | Add (or replace) users to the Workspace specified
[**CreateWorkspace**](WorkspaceApi.md#createworkspace) | **POST** /organizations/{organization_id}/workspaces | Create a new workspace
[**DeleteWorkspace**](WorkspaceApi.md#deleteworkspace) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id} | Delete a workspace
[**DeleteWorkspaceFile**](WorkspaceApi.md#deleteworkspacefile) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/files | Delete a workspace file
[**FindAllWorkspaceFiles**](WorkspaceApi.md#findallworkspacefiles) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/files | List all Workspace files
[**FindAllWorkspaces**](WorkspaceApi.md#findallworkspaces) | **GET** /organizations/{organization_id}/workspaces | List all Workspaces
[**FindWorkspaceById**](WorkspaceApi.md#findworkspacebyid) | **GET** /organizations/{organization_id}/workspaces/{workspace_id} | Get the details of an workspace
[**RemoveAllUsersOfWorkspace**](WorkspaceApi.md#removeallusersofworkspace) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/users | Remove all users from the Workspace specified
[**UpdateWorkspace**](WorkspaceApi.md#updateworkspace) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id} | Update a workspace
[**UploadWorkspaceFile**](WorkspaceApi.md#uploadworkspacefile) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/files | Upload a file for the Workspace


<a name="adduserstoorganizationworkspace"></a>
# **AddUsersToOrganizationWorkspace**
> List&lt;WorkspaceUser&gt; AddUsersToOrganizationWorkspace (string organizationId, string workspaceId, List<WorkspaceUser> workspaceUser)

Add (or replace) users to the Workspace specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddUsersToOrganizationWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var workspaceUser = new List<WorkspaceUser>(); // List<WorkspaceUser> | the Users to add. Any User with the same ID is overwritten

            try
            {
                // Add (or replace) users to the Workspace specified
                List<WorkspaceUser> result = apiInstance.AddUsersToOrganizationWorkspace(organizationId, workspaceId, workspaceUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.AddUsersToOrganizationWorkspace: " + e.Message );
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
 **workspaceUser** | [**List&lt;WorkspaceUser&gt;**](WorkspaceUser.md)| the Users to add. Any User with the same ID is overwritten | 

### Return type

[**List&lt;WorkspaceUser&gt;**](WorkspaceUser.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Workspace Users |  -  |
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createworkspace"></a>
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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspace = new Workspace(); // Workspace | the Workspace to create

            try
            {
                // Create a new workspace
                Workspace result = apiInstance.CreateWorkspace(organizationId, workspace);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.CreateWorkspace: " + e.Message );
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
 **workspace** | [**Workspace**](Workspace.md)| the Workspace to create | 

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

<a name="deleteworkspace"></a>
# **DeleteWorkspace**
> Workspace DeleteWorkspace (string organizationId, string workspaceId)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier

            try
            {
                // Delete a workspace
                Workspace result = apiInstance.DeleteWorkspace(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.DeleteWorkspace: " + e.Message );
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
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkspacefile"></a>
# **DeleteWorkspaceFile**
> WorkspaceFile DeleteWorkspaceFile (string organizationId, string workspaceId, WorkspaceFile workspaceFile)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var workspaceFile = new WorkspaceFile(); // WorkspaceFile | the file to upload

            try
            {
                // Delete a workspace file
                WorkspaceFile result = apiInstance.DeleteWorkspaceFile(organizationId, workspaceId, workspaceFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.DeleteWorkspaceFile: " + e.Message );
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
 **workspaceFile** | [**WorkspaceFile**](WorkspaceFile.md)| the file to upload | 

### Return type

[**WorkspaceFile**](WorkspaceFile.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the file resource details |  -  |
| **400** | Bad request |  -  |
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallworkspacefiles"></a>
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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier

            try
            {
                // List all Workspace files
                List<WorkspaceFile> result = apiInstance.FindAllWorkspaceFiles(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.FindAllWorkspaceFiles: " + e.Message );
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

<a name="findallworkspaces"></a>
# **FindAllWorkspaces**
> List&lt;Workspace&gt; FindAllWorkspaces (string organizationId)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier

            try
            {
                // List all Workspaces
                List<Workspace> result = apiInstance.FindAllWorkspaces(organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.FindAllWorkspaces: " + e.Message );
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

<a name="findworkspacebyid"></a>
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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier

            try
            {
                // Get the details of an workspace
                Workspace result = apiInstance.FindWorkspaceById(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.FindWorkspaceById: " + e.Message );
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
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeallusersofworkspace"></a>
# **RemoveAllUsersOfWorkspace**
> void RemoveAllUsersOfWorkspace (string organizationId, string workspaceId)

Remove all users from the Workspace specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveAllUsersOfWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier

            try
            {
                // Remove all users from the Workspace specified
                apiInstance.RemoveAllUsersOfWorkspace(organizationId, workspaceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.RemoveAllUsersOfWorkspace: " + e.Message );
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

void (empty response body)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | the operation succeeded |  -  |
| **404** | the Workspace specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateworkspace"></a>
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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var workspace = new Workspace(); // Workspace | the new Workspace details.

            try
            {
                // Update a workspace
                Workspace result = apiInstance.UpdateWorkspace(organizationId, workspaceId, workspace);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.UpdateWorkspace: " + e.Message );
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
 **workspace** | [**Workspace**](Workspace.md)| the new Workspace details. | 

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

<a name="uploadworkspacefile"></a>
# **UploadWorkspaceFile**
> WorkspaceFile UploadWorkspaceFile (string organizationId, string workspaceId, System.IO.Stream fileName = null)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var fileName = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Upload a file for the Workspace
                WorkspaceFile result = apiInstance.UploadWorkspaceFile(organizationId, workspaceId, fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.UploadWorkspaceFile: " + e.Message );
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
 **fileName** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

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

