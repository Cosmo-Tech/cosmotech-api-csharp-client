# Com.Cosmotech.Api.TwingraphApi

All URIs are relative to *https://dev.api.cosmotech.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchQuery**](TwingraphApi.md#batchquery) | **POST** /organizations/{organization_id}/twingraph/{graph_id}/batch-query | Run a query on a graph instance and return the result as a zip file in async mode
[**BatchUploadUpdate**](TwingraphApi.md#batchuploadupdate) | **POST** /organizations/{organization_id}/twingraph/{graph_id}/batch | Async batch update by loading a CSV file on a graph instance 
[**CreateEntities**](TwingraphApi.md#createentities) | **POST** /organizations/{organization_id}/twingraph/{graph_id}/entity/{type} | Create new entities in a graph instance
[**CreateGraph**](TwingraphApi.md#creategraph) | **POST** /organizations/{organization_id}/twingraph/{graph_id} | Create a new graph
[**Delete**](TwingraphApi.md#delete) | **DELETE** /organizations/{organization_id}/twingraph/{graph_id} | Delete all versions of a graph and his metadatas
[**DeleteEntities**](TwingraphApi.md#deleteentities) | **DELETE** /organizations/{organization_id}/twingraph/{graph_id}/entity/{type} | Delete entities in a graph instance
[**DownloadGraph**](TwingraphApi.md#downloadgraph) | **GET** /organizations/{organization_id}/twingraph/download/{hash} | Download a graph compressed in a zip file
[**FindAllTwingraphs**](TwingraphApi.md#findalltwingraphs) | **GET** /organizations/{organization_id}/twingraphs | Return the list of all graphs stored in the organization
[**GetEntities**](TwingraphApi.md#getentities) | **GET** /organizations/{organization_id}/twingraph/{graph_id}/entity/{type} | Get entities in a graph instance
[**GetGraphMetaData**](TwingraphApi.md#getgraphmetadata) | **GET** /organizations/{organization_id}/twingraph/{graph_id}/metadata | Return the metaData of the specified graph
[**ImportGraph**](TwingraphApi.md#importgraph) | **POST** /organizations/{organization_id}/twingraph/import | Import a new version of a twin graph
[**JobStatus**](TwingraphApi.md#jobstatus) | **GET** /organizations/{organization_id}/job/{job_id}/status | Get the status of a job
[**Query**](TwingraphApi.md#query) | **POST** /organizations/{organization_id}/twingraph/{graph_id}/query | Run a query on a graph instance
[**UpdateEntities**](TwingraphApi.md#updateentities) | **PATCH** /organizations/{organization_id}/twingraph/{graph_id}/entity/{type} | Update entities in a graph instance
[**UpdateGraphMetaData**](TwingraphApi.md#updategraphmetadata) | **PATCH** /organizations/{organization_id}/twingraph/{graph_id}/metadata | Update the metaData of the specified graph


<a name="batchquery"></a>
# **BatchQuery**
> TwinGraphHash BatchQuery (string organizationId, string graphId, TwinGraphQuery twinGraphQuery)

Run a query on a graph instance and return the result as a zip file in async mode

Run a query on a graph instance and return the result as a zip file in async mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class BatchQueryExample
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
                // Run a query on a graph instance and return the result as a zip file in async mode
                TwinGraphHash result = apiInstance.BatchQuery(organizationId, graphId, twinGraphQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.BatchQuery: " + e.Message );
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

[**TwinGraphHash**](TwinGraphHash.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchuploadupdate"></a>
# **BatchUploadUpdate**
> TwinGraphBatchResult BatchUploadUpdate (string organizationId, string graphId, TwinGraphQuery twinGraphQuery, System.IO.Stream body)

Async batch update by loading a CSV file on a graph instance 

Async batch update by loading a CSV file on a graph instance 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class BatchUploadUpdateExample
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
            var twinGraphQuery = new TwinGraphQuery(); // TwinGraphQuery | 
            var body = id,name,rank
1,"John Doe",37
2,"Joe Bloggs",14
;  // System.IO.Stream | 

            try
            {
                // Async batch update by loading a CSV file on a graph instance 
                TwinGraphBatchResult result = apiInstance.BatchUploadUpdate(organizationId, graphId, twinGraphQuery, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.BatchUploadUpdate: " + e.Message );
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
 **twinGraphQuery** | [**TwinGraphQuery**](TwinGraphQuery.md)|  | 
 **body** | **System.IO.Stream****System.IO.Stream**|  | 

### Return type

[**TwinGraphBatchResult**](TwinGraphBatchResult.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: text/csv, application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | csv file processed |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createentities"></a>
# **CreateEntities**
> string CreateEntities (string organizationId, string graphId, string type, List<GraphProperties> graphProperties)

Create new entities in a graph instance

create new entities in a graph instance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateEntitiesExample
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
            var type = "node";  // string | the entity model type
            var graphProperties = new List<GraphProperties>(); // List<GraphProperties> | the entities to create

            try
            {
                // Create new entities in a graph instance
                string result = apiInstance.CreateEntities(organizationId, graphId, type, graphProperties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.CreateEntities: " + e.Message );
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
 **type** | **string**| the entity model type | 
 **graphProperties** | [**List&lt;GraphProperties&gt;**](GraphProperties.md)| the entities to create | 

### Return type

**string**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategraph"></a>
# **CreateGraph**
> void CreateGraph (string organizationId, string graphId, System.IO.Stream body = null)

Create a new graph

To create a new graph from flat files,  you need to create a Zip file. This Zip file must countain two folders named Edges and Nodes.  .zip hierarchy: *main_folder/Nodes *main_folder/Edges  In each folder you can place one or multiple csv files containing your Nodes or Edges data.  Your csv files must follow the following header (column name) requirements:  The Nodes CSVs requires at least one column (the 1st).Column name = 'Id'. It will represent the nodes ID Ids must be populated with string  The Edges CSVs require three columns named, in order, * source * target * Id  those colomns represent * The source of the edge * The target of the edge * The Id of the edge  All following columns content are up to you. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateGraphExample
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
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Create a new graph
                apiInstance.CreateGraph(organizationId, graphId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.CreateGraph: " + e.Message );
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
 **body** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

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
| **204** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> void Delete (string organizationId, string graphId)

Delete all versions of a graph and his metadatas

Delete all versions of a graph and his metadatas

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
                // Delete all versions of a graph and his metadatas
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

<a name="deleteentities"></a>
# **DeleteEntities**
> void DeleteEntities (string organizationId, string graphId, string type, List<string> ids)

Delete entities in a graph instance

delete entities in a graph instance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteEntitiesExample
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
            var type = "node";  // string | the entity model type
            var ids = new List<string>(); // List<string> | the entities to delete

            try
            {
                // Delete entities in a graph instance
                apiInstance.DeleteEntities(organizationId, graphId, type, ids);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.DeleteEntities: " + e.Message );
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
 **type** | **string**| the entity model type | 
 **ids** | [**List&lt;string&gt;**](string.md)| the entities to delete | 

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
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadgraph"></a>
# **DownloadGraph**
> System.IO.Stream DownloadGraph (string organizationId, string hash)

Download a graph compressed in a zip file

Download a graph compressed in a zip file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DownloadGraphExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TwingraphApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var hash = "hash_example";  // string | the Graph download identifier

            try
            {
                // Download a graph compressed in a zip file
                System.IO.Stream result = apiInstance.DownloadGraph(organizationId, hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.DownloadGraph: " + e.Message );
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
 **hash** | **string**| the Graph download identifier | 

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
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findalltwingraphs"></a>
# **FindAllTwingraphs**
> List&lt;string&gt; FindAllTwingraphs (string organizationId)

Return the list of all graphs stored in the organization

Return the list of all graphs stored in the organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllTwingraphsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TwingraphApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier

            try
            {
                // Return the list of all graphs stored in the organization
                List<string> result = apiInstance.FindAllTwingraphs(organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.FindAllTwingraphs: " + e.Message );
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

**List<string>**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentities"></a>
# **GetEntities**
> string GetEntities (string organizationId, string graphId, string type, List<string> ids)

Get entities in a graph instance

get entities in a graph instance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetEntitiesExample
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
            var type = "node";  // string | the entity model type
            var ids = new List<string>(); // List<string> | the entities to get

            try
            {
                // Get entities in a graph instance
                string result = apiInstance.GetEntities(organizationId, graphId, type, ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.GetEntities: " + e.Message );
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
 **type** | **string**| the entity model type | 
 **ids** | [**List&lt;string&gt;**](string.md)| the entities to get | 

### Return type

**string**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgraphmetadata"></a>
# **GetGraphMetaData**
> Object GetGraphMetaData (string organizationId, string graphId)

Return the metaData of the specified graph

Return the metaData of the specified graph

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetGraphMetaDataExample
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
                // Return the metaData of the specified graph
                Object result = apiInstance.GetGraphMetaData(organizationId, graphId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.GetGraphMetaData: " + e.Message );
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

**Object**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importgraph"></a>
# **ImportGraph**
> TwinGraphImportInfo ImportGraph (string organizationId, TwinGraphImport twinGraphImport)

Import a new version of a twin graph

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
                // Import a new version of a twin graph
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
                // Get the status of a job
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
                // Run a query on a graph instance
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

<a name="updateentities"></a>
# **UpdateEntities**
> string UpdateEntities (string organizationId, string graphId, string type, List<GraphProperties> graphProperties)

Update entities in a graph instance

update entities in a graph instance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateEntitiesExample
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
            var type = "node";  // string | the entity model type
            var graphProperties = new List<GraphProperties>(); // List<GraphProperties> | the entities to update

            try
            {
                // Update entities in a graph instance
                string result = apiInstance.UpdateEntities(organizationId, graphId, type, graphProperties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.UpdateEntities: " + e.Message );
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
 **type** | **string**| the entity model type | 
 **graphProperties** | [**List&lt;GraphProperties&gt;**](GraphProperties.md)| the entities to update | 

### Return type

**string**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategraphmetadata"></a>
# **UpdateGraphMetaData**
> Object UpdateGraphMetaData (string organizationId, string graphId, Dictionary<string, string> requestBody)

Update the metaData of the specified graph

Update the metaData of the specified graph

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateGraphMetaDataExample
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
            var requestBody = new Dictionary<string, string>(); // Dictionary<string, string> | the metaData to update

            try
            {
                // Update the metaData of the specified graph
                Object result = apiInstance.UpdateGraphMetaData(organizationId, graphId, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwingraphApi.UpdateGraphMetaData: " + e.Message );
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
 **requestBody** | [**Dictionary&lt;string, string&gt;**](string.md)| the metaData to update | 

### Return type

**Object**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

