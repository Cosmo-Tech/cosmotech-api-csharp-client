# Com.Cosmotech.Api.SolutionApi

All URIs are relative to *https://dev.api.cosmotech.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrReplaceParameterGroups**](SolutionApi.md#addorreplaceparametergroups) | **POST** /organizations/{organization_id}/solutions/{solution_id}/parameterGroups | Add Parameter Groups. Any item with the same ID will be overwritten
[**AddOrReplaceParameters**](SolutionApi.md#addorreplaceparameters) | **POST** /organizations/{organization_id}/solutions/{solution_id}/parameters | Add Parameters. Any item with the same ID will be overwritten
[**AddOrReplaceRunTemplates**](SolutionApi.md#addorreplaceruntemplates) | **POST** /organizations/{organization_id}/solutions/{solution_id}/runTemplates | Add Run Templates. Any item with the same ID will be overwritten
[**AddSolutionAccessControl**](SolutionApi.md#addsolutionaccesscontrol) | **POST** /organizations/{organization_id}/solutions/{solution_id}/security/access | Add a control access to the Solution
[**CreateSolution**](SolutionApi.md#createsolution) | **POST** /organizations/{organization_id}/solutions | Register a new solution
[**DeleteSolution**](SolutionApi.md#deletesolution) | **DELETE** /organizations/{organization_id}/solutions/{solution_id} | Delete a solution
[**DeleteSolutionRunTemplate**](SolutionApi.md#deletesolutionruntemplate) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/runTemplates/{run_template_id} | Remove the specified Solution Run Template
[**DownloadRunTemplateHandler**](SolutionApi.md#downloadruntemplatehandler) | **GET** /organizations/{organization_id}/solutions/{solution_id}/runtemplates/{run_template_id}/handlers/{handler_id}/download | Download a Run Template step handler zip file
[**FindAllSolutions**](SolutionApi.md#findallsolutions) | **GET** /organizations/{organization_id}/solutions | List all Solutions
[**FindSolutionById**](SolutionApi.md#findsolutionbyid) | **GET** /organizations/{organization_id}/solutions/{solution_id} | Get the details of a solution
[**GetSolutionAccessControl**](SolutionApi.md#getsolutionaccesscontrol) | **GET** /organizations/{organization_id}/solutions/{solution_id}/security/access/{identity_id} | Get a control access for the Solution
[**GetSolutionSecurityUsers**](SolutionApi.md#getsolutionsecurityusers) | **GET** /organizations/{organization_id}/solutions/{solution_id}/security/users | Get the Solution security users list
[**RemoveAllRunTemplates**](SolutionApi.md#removeallruntemplates) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/runTemplates | Remove all Run Templates from the Solution specified
[**RemoveAllSolutionParameterGroups**](SolutionApi.md#removeallsolutionparametergroups) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/parameterGroups | Remove all Parameter Groups from the Solution specified
[**RemoveAllSolutionParameters**](SolutionApi.md#removeallsolutionparameters) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/parameters | Remove all Parameters from the Solution specified
[**RemoveSolutionAccessControl**](SolutionApi.md#removesolutionaccesscontrol) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/security/access/{identity_id} | Remove the specified access from the given Organization Solution
[**UpdateSolution**](SolutionApi.md#updatesolution) | **PATCH** /organizations/{organization_id}/solutions/{solution_id} | Update a solution
[**UpdateSolutionAccessControl**](SolutionApi.md#updatesolutionaccesscontrol) | **PATCH** /organizations/{organization_id}/solutions/{solution_id}/security/access/{identity_id} | Update the specified access to User for a Solution
[**UpdateSolutionRunTemplate**](SolutionApi.md#updatesolutionruntemplate) | **PATCH** /organizations/{organization_id}/solutions/{solution_id}/runTemplates/{run_template_id} | Update the specified Solution Run Template
[**UploadRunTemplateHandler**](SolutionApi.md#uploadruntemplatehandler) | **POST** /organizations/{organization_id}/solutions/{solution_id}/runtemplates/{run_template_id}/handlers/{handler_id}/upload | Upload a Run Template step handler zip file


<a name="addorreplaceparametergroups"></a>
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
                Debug.Print("Exception when calling SolutionApi.AddOrReplaceParameterGroups: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **runTemplateParameterGroup** | [**List&lt;RunTemplateParameterGroup&gt;**](RunTemplateParameterGroup.md)| the Parameter Groups | 

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

<a name="addorreplaceparameters"></a>
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
                Debug.Print("Exception when calling SolutionApi.AddOrReplaceParameters: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **runTemplateParameter** | [**List&lt;RunTemplateParameter&gt;**](RunTemplateParameter.md)| the Parameters | 

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

<a name="addorreplaceruntemplates"></a>
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
                Debug.Print("Exception when calling SolutionApi.AddOrReplaceRunTemplates: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **runTemplate** | [**List&lt;RunTemplate&gt;**](RunTemplate.md)| the Run Templates | 

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

<a name="addsolutionaccesscontrol"></a>
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
                Debug.Print("Exception when calling SolutionApi.AddSolutionAccessControl: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **solutionAccessControl** | [**SolutionAccessControl**](SolutionAccessControl.md)| the new Solution security access to add. | 

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

<a name="createsolution"></a>
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
                Debug.Print("Exception when calling SolutionApi.CreateSolution: " + e.Message );
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
 **solution** | [**Solution**](Solution.md)| the Solution to create | 

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

<a name="deletesolution"></a>
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
                Debug.Print("Exception when calling SolutionApi.DeleteSolution: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 

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

<a name="deletesolutionruntemplate"></a>
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
                Debug.Print("Exception when calling SolutionApi.DeleteSolutionRunTemplate: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **runTemplateId** | **string**| the Run Template identifier | 

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

<a name="downloadruntemplatehandler"></a>
# **DownloadRunTemplateHandler**
> System.IO.Stream DownloadRunTemplateHandler (string organizationId, string solutionId, string runTemplateId, RunTemplateHandlerId handlerId)

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
            var handlerId = (RunTemplateHandlerId) "parameters_handler";  // RunTemplateHandlerId | the Handler identifier

            try
            {
                // Download a Run Template step handler zip file
                System.IO.Stream result = apiInstance.DownloadRunTemplateHandler(organizationId, solutionId, runTemplateId, handlerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.DownloadRunTemplateHandler: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **runTemplateId** | **string**| the Run Template identifier | 
 **handlerId** | **RunTemplateHandlerId**| the Handler identifier | 

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
| **200** | the run template handle file as a resource |  -  |
| **404** | the Run Template Handler file specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallsolutions"></a>
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
                Debug.Print("Exception when calling SolutionApi.FindAllSolutions: " + e.Message );
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
 **page** | **int?**| page number to query | [optional] 
 **size** | **int?**| amount of result by page | [optional] 

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

<a name="findsolutionbyid"></a>
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
                Debug.Print("Exception when calling SolutionApi.FindSolutionById: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 

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

<a name="getsolutionaccesscontrol"></a>
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
                Debug.Print("Exception when calling SolutionApi.GetSolutionAccessControl: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **identityId** | **string**| the User identifier | 

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

<a name="getsolutionsecurityusers"></a>
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
                Debug.Print("Exception when calling SolutionApi.GetSolutionSecurityUsers: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 

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

<a name="removeallruntemplates"></a>
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
                Debug.Print("Exception when calling SolutionApi.RemoveAllRunTemplates: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 

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

<a name="removeallsolutionparametergroups"></a>
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
                Debug.Print("Exception when calling SolutionApi.RemoveAllSolutionParameterGroups: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 

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

<a name="removeallsolutionparameters"></a>
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
                Debug.Print("Exception when calling SolutionApi.RemoveAllSolutionParameters: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 

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

<a name="removesolutionaccesscontrol"></a>
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
                Debug.Print("Exception when calling SolutionApi.RemoveSolutionAccessControl: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **identityId** | **string**| the User identifier | 

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

<a name="updatesolution"></a>
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
            var solution = new Solution(); // Solution | the new Solution details.

            try
            {
                // Update a solution
                Solution result = apiInstance.UpdateSolution(organizationId, solutionId, solution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.UpdateSolution: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **solution** | [**Solution**](Solution.md)| the new Solution details. | 

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

<a name="updatesolutionaccesscontrol"></a>
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
                Debug.Print("Exception when calling SolutionApi.UpdateSolutionAccessControl: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **identityId** | **string**| the User identifier | 
 **solutionRole** | [**SolutionRole**](SolutionRole.md)| The new Solution Access Control | 

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

<a name="updatesolutionruntemplate"></a>
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
                Debug.Print("Exception when calling SolutionApi.UpdateSolutionRunTemplate: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **runTemplateId** | **string**| the Run Template identifier | 
 **runTemplate** | [**RunTemplate**](RunTemplate.md)| the Run Templates | 

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

<a name="uploadruntemplatehandler"></a>
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
            var handlerId = (RunTemplateHandlerId) "parameters_handler";  // RunTemplateHandlerId | the Handler identifier
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 
            var overwrite = false;  // bool? | whether to overwrite any existing handler resource (optional)  (default to false)

            try
            {
                // Upload a Run Template step handler zip file
                apiInstance.UploadRunTemplateHandler(organizationId, solutionId, runTemplateId, handlerId, body, overwrite);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.UploadRunTemplateHandler: " + e.Message );
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
 **solutionId** | **string**| the Solution identifier | 
 **runTemplateId** | **string**| the Run Template identifier | 
 **handlerId** | **RunTemplateHandlerId**| the Handler identifier | 
 **body** | **System.IO.Stream****System.IO.Stream**|  | 
 **overwrite** | **bool?**| whether to overwrite any existing handler resource | [optional] [default to false]

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

