# Com.Cosmotech.Api.SolutionApi

All URIs are relative to *https://dev.api.cosmotech.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddOrReplaceParameterGroups**](SolutionApi.md#addorreplaceparametergroups) | **POST** /organizations/{organization_id}/solutions/{solution_id}/parameterGroups | Add Parameter Groups. Any item with the same ID will be overwritten |
| [**AddOrReplaceParameters**](SolutionApi.md#addorreplaceparameters) | **POST** /organizations/{organization_id}/solutions/{solution_id}/parameters | Add Parameters. Any item with the same ID will be overwritten |
| [**AddOrReplaceRunTemplates**](SolutionApi.md#addorreplaceruntemplates) | **POST** /organizations/{organization_id}/solutions/{solution_id}/runTemplates | Add Run Templates. Any item with the same ID will be overwritten |
| [**AddSolutionAccessControl**](SolutionApi.md#addsolutionaccesscontrol) | **POST** /organizations/{organization_id}/solutions/{solution_id}/security/access | Add a control access to the Solution |
| [**CreateSolution**](SolutionApi.md#createsolution) | **POST** /organizations/{organization_id}/solutions | Register a new solution |
| [**DeleteSolution**](SolutionApi.md#deletesolution) | **DELETE** /organizations/{organization_id}/solutions/{solution_id} | Delete a solution |
| [**DeleteSolutionRunTemplate**](SolutionApi.md#deletesolutionruntemplate) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/runTemplates/{run_template_id} | Remove the specified Solution Run Template |
| [**DownloadRunTemplateHandler**](SolutionApi.md#downloadruntemplatehandler) | **GET** /organizations/{organization_id}/solutions/{solution_id}/runtemplates/{run_template_id}/handlers/{handler_id}/download | Download a Run Template step handler zip file |
| [**FindAllSolutions**](SolutionApi.md#findallsolutions) | **GET** /organizations/{organization_id}/solutions | List all Solutions |
| [**FindSolutionById**](SolutionApi.md#findsolutionbyid) | **GET** /organizations/{organization_id}/solutions/{solution_id} | Get the details of a solution |
| [**GetSolutionAccessControl**](SolutionApi.md#getsolutionaccesscontrol) | **GET** /organizations/{organization_id}/solutions/{solution_id}/security/access/{identity_id} | Get a control access for the Solution |
| [**GetSolutionSecurity**](SolutionApi.md#getsolutionsecurity) | **GET** /organizations/{organization_id}/solutions/{solution_id}/security | Get the Solution security information |
| [**GetSolutionSecurityUsers**](SolutionApi.md#getsolutionsecurityusers) | **GET** /organizations/{organization_id}/solutions/{solution_id}/security/users | Get the Solution security users list |
| [**RemoveAllRunTemplates**](SolutionApi.md#removeallruntemplates) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/runTemplates | Remove all Run Templates from the Solution specified |
| [**RemoveAllSolutionParameterGroups**](SolutionApi.md#removeallsolutionparametergroups) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/parameterGroups | Remove all Parameter Groups from the Solution specified |
| [**RemoveAllSolutionParameters**](SolutionApi.md#removeallsolutionparameters) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/parameters | Remove all Parameters from the Solution specified |
| [**RemoveSolutionAccessControl**](SolutionApi.md#removesolutionaccesscontrol) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/security/access/{identity_id} | Remove the specified access from the given Organization Solution |
| [**SetSolutionDefaultSecurity**](SolutionApi.md#setsolutiondefaultsecurity) | **POST** /organizations/{organization_id}/solutions/{solution_id}/security/default | Set the Solution default security |
| [**UpdateSolution**](SolutionApi.md#updatesolution) | **PATCH** /organizations/{organization_id}/solutions/{solution_id} | Update a solution |
| [**UpdateSolutionAccessControl**](SolutionApi.md#updatesolutionaccesscontrol) | **PATCH** /organizations/{organization_id}/solutions/{solution_id}/security/access/{identity_id} | Update the specified access to User for a Solution |
| [**UpdateSolutionRunTemplate**](SolutionApi.md#updatesolutionruntemplate) | **PATCH** /organizations/{organization_id}/solutions/{solution_id}/runTemplates/{run_template_id} | Update the specified Solution Run Template |
| [**UploadRunTemplateHandler**](SolutionApi.md#uploadruntemplatehandler) | **POST** /organizations/{organization_id}/solutions/{solution_id}/runtemplates/{run_template_id}/handlers/{handler_id}/upload | Upload a Run Template step handler zip file |

<a id="addorreplaceparametergroups"></a>
# **AddOrReplaceParameterGroups**
> List&lt;RunTemplateParameterGroup&gt; AddOrReplaceParameterGroups (string organizationId, string solutionId, List<RunTemplateParameterGroup> runTemplateParameterGroup)

Add Parameter Groups. Any item with the same ID will be overwritten

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddOrReplaceParameterGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var runTemplateParameterGroup = new List<RunTemplateParameterGroup>(); // List<RunTemplateParameterGroup> | the Parameter Groups

            try
            {
                // Add Parameter Groups. Any item with the same ID will be overwritten
                List<RunTemplateParameterGroup> result = apiInstance.AddOrReplaceParameterGroups(organizationId, solutionId, runTemplateParameterGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.AddOrReplaceParameterGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddOrReplaceParameterGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Parameter Groups. Any item with the same ID will be overwritten
    ApiResponse<List<RunTemplateParameterGroup>> response = apiInstance.AddOrReplaceParameterGroupsWithHttpInfo(organizationId, solutionId, runTemplateParameterGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.AddOrReplaceParameterGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **runTemplateParameterGroup** | [**List&lt;RunTemplateParameterGroup&gt;**](RunTemplateParameterGroup.md) | the Parameter Groups |  |

### Return type

[**List&lt;RunTemplateParameterGroup&gt;**](RunTemplateParameterGroup.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the Parameter Groups |  -  |
| **400** | Bad request |  -  |
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addorreplaceparameters"></a>
# **AddOrReplaceParameters**
> List&lt;RunTemplateParameter&gt; AddOrReplaceParameters (string organizationId, string solutionId, List<RunTemplateParameter> runTemplateParameter)

Add Parameters. Any item with the same ID will be overwritten

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddOrReplaceParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var runTemplateParameter = new List<RunTemplateParameter>(); // List<RunTemplateParameter> | the Parameters

            try
            {
                // Add Parameters. Any item with the same ID will be overwritten
                List<RunTemplateParameter> result = apiInstance.AddOrReplaceParameters(organizationId, solutionId, runTemplateParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.AddOrReplaceParameters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddOrReplaceParametersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Parameters. Any item with the same ID will be overwritten
    ApiResponse<List<RunTemplateParameter>> response = apiInstance.AddOrReplaceParametersWithHttpInfo(organizationId, solutionId, runTemplateParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.AddOrReplaceParametersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **runTemplateParameter** | [**List&lt;RunTemplateParameter&gt;**](RunTemplateParameter.md) | the Parameters |  |

### Return type

[**List&lt;RunTemplateParameter&gt;**](RunTemplateParameter.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the Parameters |  -  |
| **400** | Bad request |  -  |
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addorreplaceruntemplates"></a>
# **AddOrReplaceRunTemplates**
> List&lt;RunTemplate&gt; AddOrReplaceRunTemplates (string organizationId, string solutionId, List<RunTemplate> runTemplate)

Add Run Templates. Any item with the same ID will be overwritten

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddOrReplaceRunTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var runTemplate = new List<RunTemplate>(); // List<RunTemplate> | the Run Templates

            try
            {
                // Add Run Templates. Any item with the same ID will be overwritten
                List<RunTemplate> result = apiInstance.AddOrReplaceRunTemplates(organizationId, solutionId, runTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.AddOrReplaceRunTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddOrReplaceRunTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Run Templates. Any item with the same ID will be overwritten
    ApiResponse<List<RunTemplate>> response = apiInstance.AddOrReplaceRunTemplatesWithHttpInfo(organizationId, solutionId, runTemplate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.AddOrReplaceRunTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **runTemplate** | [**List&lt;RunTemplate&gt;**](RunTemplate.md) | the Run Templates |  |

### Return type

[**List&lt;RunTemplate&gt;**](RunTemplate.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the Parameters |  -  |
| **400** | Bad request |  -  |
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addsolutionaccesscontrol"></a>
# **AddSolutionAccessControl**
> SolutionAccessControl AddSolutionAccessControl (string organizationId, string solutionId, SolutionAccessControl solutionAccessControl)

Add a control access to the Solution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddSolutionAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var solutionAccessControl = new SolutionAccessControl(); // SolutionAccessControl | the new Solution security access to add.

            try
            {
                // Add a control access to the Solution
                SolutionAccessControl result = apiInstance.AddSolutionAccessControl(organizationId, solutionId, solutionAccessControl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.AddSolutionAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddSolutionAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a control access to the Solution
    ApiResponse<SolutionAccessControl> response = apiInstance.AddSolutionAccessControlWithHttpInfo(organizationId, solutionId, solutionAccessControl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.AddSolutionAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **solutionAccessControl** | [**SolutionAccessControl**](SolutionAccessControl.md) | the new Solution security access to add. |  |

### Return type

[**SolutionAccessControl**](SolutionAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Solution access |  -  |
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsolution"></a>
# **CreateSolution**
> Solution CreateSolution (string organizationId, Solution solution)

Register a new solution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateSolutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solution = new Solution(); // Solution | the Solution to create

            try
            {
                // Register a new solution
                Solution result = apiInstance.CreateSolution(organizationId, solution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.CreateSolution: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSolutionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register a new solution
    ApiResponse<Solution> response = apiInstance.CreateSolutionWithHttpInfo(organizationId, solution);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.CreateSolutionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solution** | [**Solution**](Solution.md) | the Solution to create |  |

### Return type

[**Solution**](Solution.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the solution details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesolution"></a>
# **DeleteSolution**
> void DeleteSolution (string organizationId, string solutionId)

Delete a solution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteSolutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier

            try
            {
                // Delete a solution
                apiInstance.DeleteSolution(organizationId, solutionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.DeleteSolution: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSolutionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a solution
    apiInstance.DeleteSolutionWithHttpInfo(organizationId, solutionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.DeleteSolutionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |

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
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesolutionruntemplate"></a>
# **DeleteSolutionRunTemplate**
> void DeleteSolutionRunTemplate (string organizationId, string solutionId, string runTemplateId)

Remove the specified Solution Run Template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteSolutionRunTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var runTemplateId = "runTemplateId_example";  // string | the Run Template identifier

            try
            {
                // Remove the specified Solution Run Template
                apiInstance.DeleteSolutionRunTemplate(organizationId, solutionId, runTemplateId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.DeleteSolutionRunTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSolutionRunTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove the specified Solution Run Template
    apiInstance.DeleteSolutionRunTemplateWithHttpInfo(organizationId, solutionId, runTemplateId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.DeleteSolutionRunTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **runTemplateId** | **string** | the Run Template identifier |  |

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
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="downloadruntemplatehandler"></a>
# **DownloadRunTemplateHandler**
> byte[] DownloadRunTemplateHandler (string organizationId, string solutionId, string runTemplateId, RunTemplateHandlerId handlerId)

Download a Run Template step handler zip file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DownloadRunTemplateHandlerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var runTemplateId = "runTemplateId_example";  // string | the Run Template identifier
            var handlerId = new RunTemplateHandlerId(); // RunTemplateHandlerId | the Handler identifier

            try
            {
                // Download a Run Template step handler zip file
                byte[] result = apiInstance.DownloadRunTemplateHandler(organizationId, solutionId, runTemplateId, handlerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.DownloadRunTemplateHandler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadRunTemplateHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download a Run Template step handler zip file
    ApiResponse<byte[]> response = apiInstance.DownloadRunTemplateHandlerWithHttpInfo(organizationId, solutionId, runTemplateId, handlerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.DownloadRunTemplateHandlerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **runTemplateId** | **string** | the Run Template identifier |  |
| **handlerId** | [**RunTemplateHandlerId**](RunTemplateHandlerId.md) | the Handler identifier |  |

### Return type

**byte[]**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the run template handle file as a resource |  * Content-Disposition - Run Template step handler zip file <br>  |
| **404** | the Run Template Handler file specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findallsolutions"></a>
# **FindAllSolutions**
> List&lt;Solution&gt; FindAllSolutions (string organizationId, int? page = null, int? size = null)

List all Solutions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllSolutionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var page = 56;  // int? | page number to query (optional) 
            var size = 56;  // int? | amount of result by page (optional) 

            try
            {
                // List all Solutions
                List<Solution> result = apiInstance.FindAllSolutions(organizationId, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.FindAllSolutions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllSolutionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Solutions
    ApiResponse<List<Solution>> response = apiInstance.FindAllSolutionsWithHttpInfo(organizationId, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.FindAllSolutionsWithHttpInfo: " + e.Message);
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

[**List&lt;Solution&gt;**](Solution.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the solution details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findsolutionbyid"></a>
# **FindSolutionById**
> Solution FindSolutionById (string organizationId, string solutionId)

Get the details of a solution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindSolutionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier

            try
            {
                // Get the details of a solution
                Solution result = apiInstance.FindSolutionById(organizationId, solutionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.FindSolutionById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindSolutionByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a solution
    ApiResponse<Solution> response = apiInstance.FindSolutionByIdWithHttpInfo(organizationId, solutionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.FindSolutionByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |

### Return type

[**Solution**](Solution.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Solution details |  -  |
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsolutionaccesscontrol"></a>
# **GetSolutionAccessControl**
> SolutionAccessControl GetSolutionAccessControl (string organizationId, string solutionId, string identityId)

Get a control access for the Solution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetSolutionAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var identityId = "identityId_example";  // string | the User identifier

            try
            {
                // Get a control access for the Solution
                SolutionAccessControl result = apiInstance.GetSolutionAccessControl(organizationId, solutionId, identityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.GetSolutionAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolutionAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a control access for the Solution
    ApiResponse<SolutionAccessControl> response = apiInstance.GetSolutionAccessControlWithHttpInfo(organizationId, solutionId, identityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.GetSolutionAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **identityId** | **string** | the User identifier |  |

### Return type

[**SolutionAccessControl**](SolutionAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Solution access |  -  |
| **404** | The Solution or user specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsolutionsecurity"></a>
# **GetSolutionSecurity**
> SolutionSecurity GetSolutionSecurity (string organizationId, string solutionId)

Get the Solution security information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetSolutionSecurityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier

            try
            {
                // Get the Solution security information
                SolutionSecurity result = apiInstance.GetSolutionSecurity(organizationId, solutionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.GetSolutionSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolutionSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Solution security information
    ApiResponse<SolutionSecurity> response = apiInstance.GetSolutionSecurityWithHttpInfo(organizationId, solutionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.GetSolutionSecurityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |

### Return type

[**SolutionSecurity**](SolutionSecurity.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Solution security |  -  |
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsolutionsecurityusers"></a>
# **GetSolutionSecurityUsers**
> List&lt;string&gt; GetSolutionSecurityUsers (string organizationId, string solutionId)

Get the Solution security users list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetSolutionSecurityUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier

            try
            {
                // Get the Solution security users list
                List<string> result = apiInstance.GetSolutionSecurityUsers(organizationId, solutionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.GetSolutionSecurityUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolutionSecurityUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Solution security users list
    ApiResponse<List<string>> response = apiInstance.GetSolutionSecurityUsersWithHttpInfo(organizationId, solutionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.GetSolutionSecurityUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |

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
| **200** | The Solution security users list |  -  |
| **404** | the Solution or the User specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeallruntemplates"></a>
# **RemoveAllRunTemplates**
> void RemoveAllRunTemplates (string organizationId, string solutionId)

Remove all Run Templates from the Solution specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveAllRunTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier

            try
            {
                // Remove all Run Templates from the Solution specified
                apiInstance.RemoveAllRunTemplates(organizationId, solutionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.RemoveAllRunTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveAllRunTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove all Run Templates from the Solution specified
    apiInstance.RemoveAllRunTemplatesWithHttpInfo(organizationId, solutionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.RemoveAllRunTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |

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
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeallsolutionparametergroups"></a>
# **RemoveAllSolutionParameterGroups**
> void RemoveAllSolutionParameterGroups (string organizationId, string solutionId)

Remove all Parameter Groups from the Solution specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveAllSolutionParameterGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier

            try
            {
                // Remove all Parameter Groups from the Solution specified
                apiInstance.RemoveAllSolutionParameterGroups(organizationId, solutionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.RemoveAllSolutionParameterGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveAllSolutionParameterGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove all Parameter Groups from the Solution specified
    apiInstance.RemoveAllSolutionParameterGroupsWithHttpInfo(organizationId, solutionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.RemoveAllSolutionParameterGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |

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
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeallsolutionparameters"></a>
# **RemoveAllSolutionParameters**
> void RemoveAllSolutionParameters (string organizationId, string solutionId)

Remove all Parameters from the Solution specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveAllSolutionParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier

            try
            {
                // Remove all Parameters from the Solution specified
                apiInstance.RemoveAllSolutionParameters(organizationId, solutionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.RemoveAllSolutionParameters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveAllSolutionParametersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove all Parameters from the Solution specified
    apiInstance.RemoveAllSolutionParametersWithHttpInfo(organizationId, solutionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.RemoveAllSolutionParametersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |

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
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removesolutionaccesscontrol"></a>
# **RemoveSolutionAccessControl**
> void RemoveSolutionAccessControl (string organizationId, string solutionId, string identityId)

Remove the specified access from the given Organization Solution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveSolutionAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var identityId = "identityId_example";  // string | the User identifier

            try
            {
                // Remove the specified access from the given Organization Solution
                apiInstance.RemoveSolutionAccessControl(organizationId, solutionId, identityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.RemoveSolutionAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveSolutionAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove the specified access from the given Organization Solution
    apiInstance.RemoveSolutionAccessControlWithHttpInfo(organizationId, solutionId, identityId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.RemoveSolutionAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
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
| **404** | The Solution or the user specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setsolutiondefaultsecurity"></a>
# **SetSolutionDefaultSecurity**
> SolutionSecurity SetSolutionDefaultSecurity (string organizationId, string solutionId, SolutionRole solutionRole)

Set the Solution default security

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class SetSolutionDefaultSecurityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var solutionRole = new SolutionRole(); // SolutionRole | This change the solution default security. The default security is the role assigned to any person not on the Access Control List. If the default security is None, then nobody outside of the ACL can access the solution.

            try
            {
                // Set the Solution default security
                SolutionSecurity result = apiInstance.SetSolutionDefaultSecurity(organizationId, solutionId, solutionRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.SetSolutionDefaultSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetSolutionDefaultSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the Solution default security
    ApiResponse<SolutionSecurity> response = apiInstance.SetSolutionDefaultSecurityWithHttpInfo(organizationId, solutionId, solutionRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.SetSolutionDefaultSecurityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **solutionRole** | [**SolutionRole**](SolutionRole.md) | This change the solution default security. The default security is the role assigned to any person not on the Access Control List. If the default security is None, then nobody outside of the ACL can access the solution. |  |

### Return type

[**SolutionSecurity**](SolutionSecurity.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Solution default visibility |  -  |
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesolution"></a>
# **UpdateSolution**
> Solution UpdateSolution (string organizationId, string solutionId, Solution solution)

Update a solution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateSolutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var solution = new Solution(); // Solution | the new Solution details. This endpoint can't be used to update security

            try
            {
                // Update a solution
                Solution result = apiInstance.UpdateSolution(organizationId, solutionId, solution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.UpdateSolution: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSolutionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a solution
    ApiResponse<Solution> response = apiInstance.UpdateSolutionWithHttpInfo(organizationId, solutionId, solution);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.UpdateSolutionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **solution** | [**Solution**](Solution.md) | the new Solution details. This endpoint can&#39;t be used to update security |  |

### Return type

[**Solution**](Solution.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the solution details |  -  |
| **400** | Bad request |  -  |
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesolutionaccesscontrol"></a>
# **UpdateSolutionAccessControl**
> SolutionAccessControl UpdateSolutionAccessControl (string organizationId, string solutionId, string identityId, SolutionRole solutionRole)

Update the specified access to User for a Solution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateSolutionAccessControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var identityId = "identityId_example";  // string | the User identifier
            var solutionRole = new SolutionRole(); // SolutionRole | The new Solution Access Control

            try
            {
                // Update the specified access to User for a Solution
                SolutionAccessControl result = apiInstance.UpdateSolutionAccessControl(organizationId, solutionId, identityId, solutionRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.UpdateSolutionAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSolutionAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the specified access to User for a Solution
    ApiResponse<SolutionAccessControl> response = apiInstance.UpdateSolutionAccessControlWithHttpInfo(organizationId, solutionId, identityId, solutionRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.UpdateSolutionAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **identityId** | **string** | the User identifier |  |
| **solutionRole** | [**SolutionRole**](SolutionRole.md) | The new Solution Access Control |  |

### Return type

[**SolutionAccessControl**](SolutionAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Solution access |  -  |
| **404** | The Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesolutionruntemplate"></a>
# **UpdateSolutionRunTemplate**
> List&lt;RunTemplate&gt; UpdateSolutionRunTemplate (string organizationId, string solutionId, string runTemplateId, RunTemplate runTemplate)

Update the specified Solution Run Template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateSolutionRunTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var runTemplateId = "runTemplateId_example";  // string | the Run Template identifier
            var runTemplate = new RunTemplate(); // RunTemplate | the Run Templates

            try
            {
                // Update the specified Solution Run Template
                List<RunTemplate> result = apiInstance.UpdateSolutionRunTemplate(organizationId, solutionId, runTemplateId, runTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.UpdateSolutionRunTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSolutionRunTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the specified Solution Run Template
    ApiResponse<List<RunTemplate>> response = apiInstance.UpdateSolutionRunTemplateWithHttpInfo(organizationId, solutionId, runTemplateId, runTemplate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.UpdateSolutionRunTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **runTemplateId** | **string** | the Run Template identifier |  |
| **runTemplate** | [**RunTemplate**](RunTemplate.md) | the Run Templates |  |

### Return type

[**List&lt;RunTemplate&gt;**](RunTemplate.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Parameters |  -  |
| **400** | Bad request |  -  |
| **404** | the Solution or Run Template specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadruntemplatehandler"></a>
# **UploadRunTemplateHandler**
> void UploadRunTemplateHandler (string organizationId, string solutionId, string runTemplateId, RunTemplateHandlerId handlerId, System.IO.Stream body, bool? overwrite = null)

Upload a Run Template step handler zip file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UploadRunTemplateHandlerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var solutionId = "solutionId_example";  // string | the Solution identifier
            var runTemplateId = "runTemplateId_example";  // string | the Run Template identifier
            var handlerId = new RunTemplateHandlerId(); // RunTemplateHandlerId | the Handler identifier
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 
            var overwrite = false;  // bool? | whether to overwrite any existing handler resource (optional)  (default to false)

            try
            {
                // Upload a Run Template step handler zip file
                apiInstance.UploadRunTemplateHandler(organizationId, solutionId, runTemplateId, handlerId, body, overwrite);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.UploadRunTemplateHandler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadRunTemplateHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a Run Template step handler zip file
    apiInstance.UploadRunTemplateHandlerWithHttpInfo(organizationId, solutionId, runTemplateId, handlerId, body, overwrite);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolutionApi.UploadRunTemplateHandlerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **solutionId** | **string** | the Solution identifier |  |
| **runTemplateId** | **string** | the Run Template identifier |  |
| **handlerId** | [**RunTemplateHandlerId**](RunTemplateHandlerId.md) | the Handler identifier |  |
| **body** | **System.IO.Stream****System.IO.Stream** |  |  |
| **overwrite** | **bool?** | whether to overwrite any existing handler resource | [optional] [default to false] |

### Return type

void (empty response body)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | zip file uploaded |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

