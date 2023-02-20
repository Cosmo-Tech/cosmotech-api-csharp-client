# Com.Cosmotech.Api.DatasetApi

All URIs are relative to *https://dev.api.cosmotech.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrReplaceDatasetCompatibilityElements**](DatasetApi.md#addorreplacedatasetcompatibilityelements) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/compatibility | Add Dataset Compatibility elements.
[**CopyDataset**](DatasetApi.md#copydataset) | **POST** /organizations/{organization_id}/datasets/copy | Copy a Dataset to another Dataset. Source must have a read capable connector and Target a write capable connector.
[**CreateDataset**](DatasetApi.md#createdataset) | **POST** /organizations/{organization_id}/datasets | Create a new Dataset
[**DeleteDataset**](DatasetApi.md#deletedataset) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id} | Delete a dataset
[**FindAllDatasets**](DatasetApi.md#findalldatasets) | **GET** /organizations/{organization_id}/datasets | List all Datasets
[**FindDatasetById**](DatasetApi.md#finddatasetbyid) | **GET** /organizations/{organization_id}/datasets/{dataset_id} | Get the details of a Dataset
[**RemoveAllDatasetCompatibilityElements**](DatasetApi.md#removealldatasetcompatibilityelements) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id}/compatibility | Remove all Dataset Compatibility elements from the Dataset specified
[**SearchDatasets**](DatasetApi.md#searchdatasets) | **POST** /organizations/{organization_id}/datasets/search | Search Datasets
[**UpdateDataset**](DatasetApi.md#updatedataset) | **PATCH** /organizations/{organization_id}/datasets/{dataset_id} | Update a dataset


<a name="addorreplacedatasetcompatibilityelements"></a>
# **AddOrReplaceDatasetCompatibilityElements**
> List&lt;DatasetCompatibility&gt; AddOrReplaceDatasetCompatibilityElements (string organizationId, string datasetId, List<DatasetCompatibility> datasetCompatibility)

Add Dataset Compatibility elements.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddOrReplaceDatasetCompatibilityElementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Dataset identifier
            var datasetCompatibility = new List<DatasetCompatibility>(); // List<DatasetCompatibility> | the Dataset Compatibility elements

            try
            {
                // Add Dataset Compatibility elements.
                List<DatasetCompatibility> result = apiInstance.AddOrReplaceDatasetCompatibilityElements(organizationId, datasetId, datasetCompatibility);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.AddOrReplaceDatasetCompatibilityElements: " + e.Message );
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
 **datasetId** | **string**| the Dataset identifier | 
 **datasetCompatibility** | [**List&lt;DatasetCompatibility&gt;**](DatasetCompatibility.md)| the Dataset Compatibility elements | 

### Return type

[**List&lt;DatasetCompatibility&gt;**](DatasetCompatibility.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the Dataset Compatibility elements |  -  |
| **400** | Bad request |  -  |
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copydataset"></a>
# **CopyDataset**
> DatasetCopyParameters CopyDataset (string organizationId, DatasetCopyParameters datasetCopyParameters)

Copy a Dataset to another Dataset. Source must have a read capable connector and Target a write capable connector.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CopyDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetCopyParameters = new DatasetCopyParameters(); // DatasetCopyParameters | the Dataset copy parameters

            try
            {
                // Copy a Dataset to another Dataset. Source must have a read capable connector and Target a write capable connector.
                DatasetCopyParameters result = apiInstance.CopyDataset(organizationId, datasetCopyParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.CopyDataset: " + e.Message );
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
 **datasetCopyParameters** | [**DatasetCopyParameters**](DatasetCopyParameters.md)| the Dataset copy parameters | 

### Return type

[**DatasetCopyParameters**](DatasetCopyParameters.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the Dataset copy operation parameters |  -  |
| **400** | Bad request |  -  |
| **404** | the Dataset specified as Source or Target is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdataset"></a>
# **CreateDataset**
> Dataset CreateDataset (string organizationId, Dataset dataset)

Create a new Dataset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var dataset = new Dataset(); // Dataset | the Dataset to create

            try
            {
                // Create a new Dataset
                Dataset result = apiInstance.CreateDataset(organizationId, dataset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.CreateDataset: " + e.Message );
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
 **dataset** | [**Dataset**](Dataset.md)| the Dataset to create | 

### Return type

[**Dataset**](Dataset.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the dataset details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedataset"></a>
# **DeleteDataset**
> void DeleteDataset (string organizationId, string datasetId)

Delete a dataset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Dataset identifier

            try
            {
                // Delete a dataset
                apiInstance.DeleteDataset(organizationId, datasetId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.DeleteDataset: " + e.Message );
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
 **datasetId** | **string**| the Dataset identifier | 

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
| **204** | Request successful |  -  |
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findalldatasets"></a>
# **FindAllDatasets**
> List&lt;Dataset&gt; FindAllDatasets (string organizationId)

List all Datasets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllDatasetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier

            try
            {
                // List all Datasets
                List<Dataset> result = apiInstance.FindAllDatasets(organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.FindAllDatasets: " + e.Message );
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

[**List&lt;Dataset&gt;**](Dataset.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the list of Datasets |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finddatasetbyid"></a>
# **FindDatasetById**
> Dataset FindDatasetById (string organizationId, string datasetId)

Get the details of a Dataset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindDatasetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Dataset identifier

            try
            {
                // Get the details of a Dataset
                Dataset result = apiInstance.FindDatasetById(organizationId, datasetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.FindDatasetById: " + e.Message );
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
 **datasetId** | **string**| the Dataset identifier | 

### Return type

[**Dataset**](Dataset.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Dataset details |  -  |
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removealldatasetcompatibilityelements"></a>
# **RemoveAllDatasetCompatibilityElements**
> void RemoveAllDatasetCompatibilityElements (string organizationId, string datasetId)

Remove all Dataset Compatibility elements from the Dataset specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveAllDatasetCompatibilityElementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Dataset identifier

            try
            {
                // Remove all Dataset Compatibility elements from the Dataset specified
                apiInstance.RemoveAllDatasetCompatibilityElements(organizationId, datasetId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.RemoveAllDatasetCompatibilityElements: " + e.Message );
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
 **datasetId** | **string**| the Dataset identifier | 

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
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchdatasets"></a>
# **SearchDatasets**
> List&lt;Dataset&gt; SearchDatasets (string organizationId, DatasetSearch datasetSearch)

Search Datasets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class SearchDatasetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetSearch = new DatasetSearch(); // DatasetSearch | the Dataset search parameters

            try
            {
                // Search Datasets
                List<Dataset> result = apiInstance.SearchDatasets(organizationId, datasetSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.SearchDatasets: " + e.Message );
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
 **datasetSearch** | [**DatasetSearch**](DatasetSearch.md)| the Dataset search parameters | 

### Return type

[**List&lt;Dataset&gt;**](Dataset.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the list of Datasets |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedataset"></a>
# **UpdateDataset**
> Dataset UpdateDataset (string organizationId, string datasetId, Dataset dataset)

Update a dataset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Dataset identifier
            var dataset = new Dataset(); // Dataset | the new Dataset details.

            try
            {
                // Update a dataset
                Dataset result = apiInstance.UpdateDataset(organizationId, datasetId, dataset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.UpdateDataset: " + e.Message );
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
 **datasetId** | **string**| the Dataset identifier | 
 **dataset** | [**Dataset**](Dataset.md)| the new Dataset details. | 

### Return type

[**Dataset**](Dataset.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the dataset details |  -  |
| **400** | Bad request |  -  |
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

