# Com.Cosmotech.Api.TwingraphApi

All URIs are relative to *https://dev.api.cosmotech.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Delete**](TwingraphApi.md#delete) | **DELETE** /organizations/{organization_id}/twingraph/{graph_id} | 
[**ImportGraph**](TwingraphApi.md#importgraph) | **POST** /organizations/{organization_id}/twingraph/import | 
[**JobStatus**](TwingraphApi.md#jobstatus) | **GET** /organizations/{organization_id}/job/{job_id}/status | 
[**Query**](TwingraphApi.md#query) | **POST** /organizations/{organization_id}/twingraph/{graph_id}/query | 


<a name="delete"></a>
# **Delete**
> void Delete (string organizationId, string graphId)



Launch a mass delete job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TwingraphApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var graphId = "graphId_example";  // string | the Graph Identifier

            try
            {
                apiInstance.Delete(organizationId, graphId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.Delete: " + e.Message );
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
 **graphId** | **string**| the Graph Identifier | 

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
| **204** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importgraph"></a>
# **ImportGraph**
> TwinGraphImportInfo ImportGraph (string organizationId, TwinGraphImport twinGraphImport)



Import a new version of a twin graph

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class ImportGraphExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TwingraphApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var twinGraphImport = new TwinGraphImport(); // TwinGraphImport | the graph to import

            try
            {
                TwinGraphImportInfo result = apiInstance.ImportGraph(organizationId, twinGraphImport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.ImportGraph: " + e.Message );
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
 **twinGraphImport** | [**TwinGraphImport**](TwinGraphImport.md)| the graph to import | 

### Return type

[**TwinGraphImportInfo**](TwinGraphImportInfo.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobstatus"></a>
# **JobStatus**
> string JobStatus (string organizationId, string jobId)



Get the status of a job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class JobStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TwingraphApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var jobId = "jobId_example";  // string | the job identifier

            try
            {
                string result = apiInstance.JobStatus(organizationId, jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.JobStatus: " + e.Message );
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
 **jobId** | **string**| the job identifier | 

### Return type

**string**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/yaml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="query"></a>
# **Query**
> string Query (string organizationId, string graphId, TwinGraphQuery twinGraphQuery)



Run a query on a graph instance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class QueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TwingraphApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var graphId = "graphId_example";  // string | the Graph Identifier
            var twinGraphQuery = new TwinGraphQuery(); // TwinGraphQuery | the query to run

            try
            {
                string result = apiInstance.Query(organizationId, graphId, twinGraphQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.Query: " + e.Message );
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
 **graphId** | **string**| the Graph Identifier | 
 **twinGraphQuery** | [**TwinGraphQuery**](TwinGraphQuery.md)| the query to run | 

### Return type

**string**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

