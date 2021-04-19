# Com.Cosmotech.Api.SolutionApi

All URIs are relative to *https://api.azure.cosmo-platform.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSolution**](SolutionApi.md#createsolution) | **POST** /organizations/{organization_id}/solutions | Register a new solution
[**DeleteSolution**](SolutionApi.md#deletesolution) | **DELETE** /organizations/{organization_id}/solutions/{solution_id} | Delete a solution
[**FindAllSolutions**](SolutionApi.md#findallsolutions) | **GET** /organizations/{organization_id}/solutions | List all Solutions
[**FindSolutionById**](SolutionApi.md#findsolutionbyid) | **GET** /organizations/{organization_id}/solutions/{solution_id} | Get the details of a solution
[**UpdateSolution**](SolutionApi.md#updatesolution) | **PATCH** /organizations/{organization_id}/solutions/{solution_id} | Update a solution
[**Upload**](SolutionApi.md#upload) | **POST** /organizations/{organization_id}/solutions/upload | Upload and register a new solution


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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
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

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the solution details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesolution"></a>
# **DeleteSolution**
> Solution DeleteSolution (string organizationId, string solutionId)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var solutionId = solutionId_example;  // string | the Solution identifier

            try
            {
                // Delete a solution
                Solution result = apiInstance.DeleteSolution(organizationId, solutionId);
                Debug.WriteLine(result);
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

[**Solution**](Solution.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the solution details |  -  |
| **400** | Bad request |  -  |
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallsolutions"></a>
# **FindAllSolutions**
> List&lt;Solution&gt; FindAllSolutions (string organizationId)

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier

            try
            {
                // List all Solutions
                List<Solution> result = apiInstance.FindAllSolutions(organizationId);
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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var solutionId = solutionId_example;  // string | the Solution identifier

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
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var solutionId = solutionId_example;  // string | the Solution identifier
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

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the solution details |  -  |
| **400** | Bad request |  -  |
| **404** | the Solution specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upload"></a>
# **Upload**
> Solution Upload (string organizationId, System.IO.Stream body)

Upload and register a new solution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolutionApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var body = BINARY_DATA_HERE;  // System.IO.Stream | the Solution to upload and register

            try
            {
                // Upload and register a new solution
                Solution result = apiInstance.Upload(organizationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolutionApi.Upload: " + e.Message );
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
 **body** | **System.IO.Stream****System.IO.Stream**| the Solution to upload and register | 

### Return type

[**Solution**](Solution.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the solution details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

