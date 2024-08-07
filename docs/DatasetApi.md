# Com.Cosmotech.Api.DatasetApi

All URIs are relative to *https://dev.api.cosmotech.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddDatasetAccessControl**](DatasetApi.md#adddatasetaccesscontrol) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/security/access | Add a control access to the Dataset |
| [**AddOrReplaceDatasetCompatibilityElements**](DatasetApi.md#addorreplacedatasetcompatibilityelements) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/compatibility | Add Dataset Compatibility elements. |
| [**CopyDataset**](DatasetApi.md#copydataset) | **POST** /organizations/{organization_id}/datasets/copy | Copy a Dataset to another Dataset. |
| [**CreateDataset**](DatasetApi.md#createdataset) | **POST** /organizations/{organization_id}/datasets | Create a new Dataset |
| [**CreateSubDataset**](DatasetApi.md#createsubdataset) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/subdataset | Create a sub-dataset from the dataset in parameter |
| [**CreateTwingraphEntities**](DatasetApi.md#createtwingraphentities) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/twingraph/{type} | Create new entities in a graph instance |
| [**DeleteDataset**](DatasetApi.md#deletedataset) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id} | Delete a dataset |
| [**DeleteTwingraphEntities**](DatasetApi.md#deletetwingraphentities) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id}/twingraph/{type} | Delete entities in a graph instance |
| [**DownloadTwingraph**](DatasetApi.md#downloadtwingraph) | **GET** /organizations/{organization_id}/datasets/twingraph/download/{hash} | Download a graph as a zip file |
| [**FindAllDatasets**](DatasetApi.md#findalldatasets) | **GET** /organizations/{organization_id}/datasets | List all Datasets |
| [**FindDatasetById**](DatasetApi.md#finddatasetbyid) | **GET** /organizations/{organization_id}/datasets/{dataset_id} | Get the details of a Dataset |
| [**GetDatasetAccessControl**](DatasetApi.md#getdatasetaccesscontrol) | **GET** /organizations/{organization_id}/datasets/{dataset_id}/security/access/{identity_id} | Get a control access for the Dataset |
| [**GetDatasetSecurity**](DatasetApi.md#getdatasetsecurity) | **GET** /organizations/{organization_id}/datasets/{dataset_id}/security | Get the Dataset security information |
| [**GetDatasetSecurityUsers**](DatasetApi.md#getdatasetsecurityusers) | **GET** /organizations/{organization_id}/datasets/{dataset_id}/security/users | Get the Dataset security users list |
| [**GetDatasetTwingraphStatus**](DatasetApi.md#getdatasettwingraphstatus) | **GET** /organizations/{organization_id}/datasets/{dataset_id}/status | Get the dataset&#39;s refresh job status |
| [**GetTwingraphEntities**](DatasetApi.md#gettwingraphentities) | **GET** /organizations/{organization_id}/datasets/{dataset_id}/twingraph/{type} | Get entities in a graph instance |
| [**LinkWorkspace**](DatasetApi.md#linkworkspace) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/link |  |
| [**RefreshDataset**](DatasetApi.md#refreshdataset) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/refresh | Refresh data on dataset from dataset&#39;s source |
| [**RemoveAllDatasetCompatibilityElements**](DatasetApi.md#removealldatasetcompatibilityelements) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id}/compatibility | Remove all Dataset Compatibility elements from the Dataset specified |
| [**RemoveDatasetAccessControl**](DatasetApi.md#removedatasetaccesscontrol) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id}/security/access/{identity_id} | Remove the specified access from the given Dataset |
| [**RollbackRefresh**](DatasetApi.md#rollbackrefresh) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/refresh/rollback | Rollback the dataset after a failed refresh |
| [**SearchDatasets**](DatasetApi.md#searchdatasets) | **POST** /organizations/{organization_id}/datasets/search | Search Datasets by tags |
| [**SetDatasetDefaultSecurity**](DatasetApi.md#setdatasetdefaultsecurity) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/security/default | Set the Dataset default security |
| [**TwingraphBatchQuery**](DatasetApi.md#twingraphbatchquery) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/batch-query | Run a query on a graph instance and return the result as a zip file in async mode |
| [**TwingraphBatchUpdate**](DatasetApi.md#twingraphbatchupdate) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/batch | Async batch update by loading a CSV file on a graph instance  |
| [**TwingraphQuery**](DatasetApi.md#twingraphquery) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/twingraph | Return the result of a query made on the graph instance as a json |
| [**UnlinkWorkspace**](DatasetApi.md#unlinkworkspace) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/unlink |  |
| [**UpdateDataset**](DatasetApi.md#updatedataset) | **PATCH** /organizations/{organization_id}/datasets/{dataset_id} | Update a dataset |
| [**UpdateDatasetAccessControl**](DatasetApi.md#updatedatasetaccesscontrol) | **PATCH** /organizations/{organization_id}/datasets/{dataset_id}/security/access/{identity_id} | Update the specified access to User for a Dataset |
| [**UpdateTwingraphEntities**](DatasetApi.md#updatetwingraphentities) | **PATCH** /organizations/{organization_id}/datasets/{dataset_id}/twingraph/{type} | Update entities in a graph instance |
| [**UploadTwingraph**](DatasetApi.md#uploadtwingraph) | **POST** /organizations/{organization_id}/datasets/{dataset_id} | Upload data from zip file to dataset&#39;s twingraph |

<a id="adddatasetaccesscontrol"></a>
# **AddDatasetAccessControl**
> DatasetAccessControl AddDatasetAccessControl (string organizationId, string datasetId, DatasetAccessControl datasetAccessControl)

Add a control access to the Dataset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddDatasetAccessControlExample
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
            var datasetAccessControl = new DatasetAccessControl(); // DatasetAccessControl | the new Dataset security access to add.

            try
            {
                // Add a control access to the Dataset
                DatasetAccessControl result = apiInstance.AddDatasetAccessControl(organizationId, datasetId, datasetAccessControl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.AddDatasetAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDatasetAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a control access to the Dataset
    ApiResponse<DatasetAccessControl> response = apiInstance.AddDatasetAccessControlWithHttpInfo(organizationId, datasetId, datasetAccessControl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.AddDatasetAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **datasetAccessControl** | [**DatasetAccessControl**](DatasetAccessControl.md) | the new Dataset security access to add. |  |

### Return type

[**DatasetAccessControl**](DatasetAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Dataset access |  -  |
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addorreplacedatasetcompatibilityelements"></a>
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
                Debug.Print("Exception when calling DatasetApi.AddOrReplaceDatasetCompatibilityElements: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddOrReplaceDatasetCompatibilityElementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Dataset Compatibility elements.
    ApiResponse<List<DatasetCompatibility>> response = apiInstance.AddOrReplaceDatasetCompatibilityElementsWithHttpInfo(organizationId, datasetId, datasetCompatibility);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.AddOrReplaceDatasetCompatibilityElementsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **datasetCompatibility** | [**List&lt;DatasetCompatibility&gt;**](DatasetCompatibility.md) | the Dataset Compatibility elements |  |

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

<a id="copydataset"></a>
# **CopyDataset**
> DatasetCopyParameters CopyDataset (string organizationId, DatasetCopyParameters datasetCopyParameters)

Copy a Dataset to another Dataset.

Not implemented!

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
                // Copy a Dataset to another Dataset.
                DatasetCopyParameters result = apiInstance.CopyDataset(organizationId, datasetCopyParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.CopyDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CopyDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy a Dataset to another Dataset.
    ApiResponse<DatasetCopyParameters> response = apiInstance.CopyDatasetWithHttpInfo(organizationId, datasetCopyParameters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.CopyDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetCopyParameters** | [**DatasetCopyParameters**](DatasetCopyParameters.md) | the Dataset copy parameters |  |

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

<a id="createdataset"></a>
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
                Debug.Print("Exception when calling DatasetApi.CreateDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Dataset
    ApiResponse<Dataset> response = apiInstance.CreateDatasetWithHttpInfo(organizationId, dataset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.CreateDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **dataset** | [**Dataset**](Dataset.md) | the Dataset to create |  |

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

<a id="createsubdataset"></a>
# **CreateSubDataset**
> Dataset CreateSubDataset (string organizationId, string datasetId, SubDatasetGraphQuery subDatasetGraphQuery)

Create a sub-dataset from the dataset in parameter

Create a copy of the dataset using the results of the list of queries given in parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateSubDatasetExample
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
            var subDatasetGraphQuery = new SubDatasetGraphQuery(); // SubDatasetGraphQuery | the Cypher query to filter

            try
            {
                // Create a sub-dataset from the dataset in parameter
                Dataset result = apiInstance.CreateSubDataset(organizationId, datasetId, subDatasetGraphQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.CreateSubDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSubDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a sub-dataset from the dataset in parameter
    ApiResponse<Dataset> response = apiInstance.CreateSubDatasetWithHttpInfo(organizationId, datasetId, subDatasetGraphQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.CreateSubDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **subDatasetGraphQuery** | [**SubDatasetGraphQuery**](SubDatasetGraphQuery.md) | the Cypher query to filter |  |

### Return type

[**Dataset**](Dataset.md)

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

<a id="createtwingraphentities"></a>
# **CreateTwingraphEntities**
> string CreateTwingraphEntities (string organizationId, string datasetId, string type, List<GraphProperties> graphProperties)

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
    public class CreateTwingraphEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Dataset Identifier
            var type = "node";  // string | the entity model type
            var graphProperties = new List<GraphProperties>(); // List<GraphProperties> | the entities to create

            try
            {
                // Create new entities in a graph instance
                string result = apiInstance.CreateTwingraphEntities(organizationId, datasetId, type, graphProperties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.CreateTwingraphEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTwingraphEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create new entities in a graph instance
    ApiResponse<string> response = apiInstance.CreateTwingraphEntitiesWithHttpInfo(organizationId, datasetId, type, graphProperties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.CreateTwingraphEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset Identifier |  |
| **type** | **string** | the entity model type |  |
| **graphProperties** | [**List&lt;GraphProperties&gt;**](GraphProperties.md) | the entities to create |  |

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

<a id="deletedataset"></a>
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
                Debug.Print("Exception when calling DatasetApi.DeleteDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a dataset
    apiInstance.DeleteDatasetWithHttpInfo(organizationId, datasetId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.DeleteDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |

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

<a id="deletetwingraphentities"></a>
# **DeleteTwingraphEntities**
> void DeleteTwingraphEntities (string organizationId, string datasetId, string type, List<string> ids)

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
    public class DeleteTwingraphEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Dataset Identifier
            var type = "node";  // string | the entity model type
            var ids = new List<string>(); // List<string> | the entities to delete

            try
            {
                // Delete entities in a graph instance
                apiInstance.DeleteTwingraphEntities(organizationId, datasetId, type, ids);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.DeleteTwingraphEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTwingraphEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete entities in a graph instance
    apiInstance.DeleteTwingraphEntitiesWithHttpInfo(organizationId, datasetId, type, ids);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.DeleteTwingraphEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset Identifier |  |
| **type** | **string** | the entity model type |  |
| **ids** | [**List&lt;string&gt;**](string.md) | the entities to delete |  |

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

<a id="downloadtwingraph"></a>
# **DownloadTwingraph**
> System.IO.Stream DownloadTwingraph (string organizationId, string hash)

Download a graph as a zip file

Download the compressed graph reference by the hash in a zip file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DownloadTwingraphExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var hash = "hash_example";  // string | the Graph download identifier

            try
            {
                // Download a graph as a zip file
                System.IO.Stream result = apiInstance.DownloadTwingraph(organizationId, hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.DownloadTwingraph: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadTwingraphWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download a graph as a zip file
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadTwingraphWithHttpInfo(organizationId, hash);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.DownloadTwingraphWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **hash** | **string** | the Graph download identifier |  |

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

<a id="findalldatasets"></a>
# **FindAllDatasets**
> List&lt;Dataset&gt; FindAllDatasets (string organizationId, int? page = null, int? size = null)

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
            var page = 56;  // int? | page number to query (optional) 
            var size = 56;  // int? | amount of result by page (optional) 

            try
            {
                // List all Datasets
                List<Dataset> result = apiInstance.FindAllDatasets(organizationId, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.FindAllDatasets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllDatasetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Datasets
    ApiResponse<List<Dataset>> response = apiInstance.FindAllDatasetsWithHttpInfo(organizationId, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.FindAllDatasetsWithHttpInfo: " + e.Message);
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

<a id="finddatasetbyid"></a>
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
                Debug.Print("Exception when calling DatasetApi.FindDatasetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindDatasetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a Dataset
    ApiResponse<Dataset> response = apiInstance.FindDatasetByIdWithHttpInfo(organizationId, datasetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.FindDatasetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |

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

<a id="getdatasetaccesscontrol"></a>
# **GetDatasetAccessControl**
> DatasetAccessControl GetDatasetAccessControl (string organizationId, string datasetId, string identityId)

Get a control access for the Dataset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetDatasetAccessControlExample
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
            var identityId = "identityId_example";  // string | the User identifier

            try
            {
                // Get a control access for the Dataset
                DatasetAccessControl result = apiInstance.GetDatasetAccessControl(organizationId, datasetId, identityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.GetDatasetAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasetAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a control access for the Dataset
    ApiResponse<DatasetAccessControl> response = apiInstance.GetDatasetAccessControlWithHttpInfo(organizationId, datasetId, identityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.GetDatasetAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **identityId** | **string** | the User identifier |  |

### Return type

[**DatasetAccessControl**](DatasetAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Dataset access |  -  |
| **404** | The Dataset or user specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdatasetsecurity"></a>
# **GetDatasetSecurity**
> DatasetSecurity GetDatasetSecurity (string organizationId, string datasetId)

Get the Dataset security information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetDatasetSecurityExample
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
                // Get the Dataset security information
                DatasetSecurity result = apiInstance.GetDatasetSecurity(organizationId, datasetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.GetDatasetSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasetSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Dataset security information
    ApiResponse<DatasetSecurity> response = apiInstance.GetDatasetSecurityWithHttpInfo(organizationId, datasetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.GetDatasetSecurityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |

### Return type

[**DatasetSecurity**](DatasetSecurity.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Dataset security |  -  |
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdatasetsecurityusers"></a>
# **GetDatasetSecurityUsers**
> List&lt;string&gt; GetDatasetSecurityUsers (string organizationId, string datasetId)

Get the Dataset security users list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetDatasetSecurityUsersExample
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
                // Get the Dataset security users list
                List<string> result = apiInstance.GetDatasetSecurityUsers(organizationId, datasetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.GetDatasetSecurityUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasetSecurityUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Dataset security users list
    ApiResponse<List<string>> response = apiInstance.GetDatasetSecurityUsersWithHttpInfo(organizationId, datasetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.GetDatasetSecurityUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |

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
| **200** | The Dataset security users list |  -  |
| **404** | the Dataset or the User specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdatasettwingraphstatus"></a>
# **GetDatasetTwingraphStatus**
> string GetDatasetTwingraphStatus (string organizationId, string datasetId)

Get the dataset's refresh job status

Get the status of the import workflow lauch on the dataset's refresh. This endpoint needs to be called to update a dataset IngestionStatus or TwincacheStatus

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetDatasetTwingraphStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the dataset identifier

            try
            {
                // Get the dataset's refresh job status
                string result = apiInstance.GetDatasetTwingraphStatus(organizationId, datasetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.GetDatasetTwingraphStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasetTwingraphStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the dataset's refresh job status
    ApiResponse<string> response = apiInstance.GetDatasetTwingraphStatusWithHttpInfo(organizationId, datasetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.GetDatasetTwingraphStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the dataset identifier |  |

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

<a id="gettwingraphentities"></a>
# **GetTwingraphEntities**
> string GetTwingraphEntities (string organizationId, string datasetId, string type, List<string> ids)

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
    public class GetTwingraphEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Dataset Identifier
            var type = "node";  // string | the entity model type
            var ids = new List<string>(); // List<string> | the entities to get

            try
            {
                // Get entities in a graph instance
                string result = apiInstance.GetTwingraphEntities(organizationId, datasetId, type, ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.GetTwingraphEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTwingraphEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get entities in a graph instance
    ApiResponse<string> response = apiInstance.GetTwingraphEntitiesWithHttpInfo(organizationId, datasetId, type, ids);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.GetTwingraphEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset Identifier |  |
| **type** | **string** | the entity model type |  |
| **ids** | [**List&lt;string&gt;**](string.md) | the entities to get |  |

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

<a id="linkworkspace"></a>
# **LinkWorkspace**
> Dataset LinkWorkspace (string organizationId, string datasetId, string workspaceId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class LinkWorkspaceExample
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
            var workspaceId = "workspaceId_example";  // string | workspace id to be linked to

            try
            {
                Dataset result = apiInstance.LinkWorkspace(organizationId, datasetId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.LinkWorkspace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dataset> response = apiInstance.LinkWorkspaceWithHttpInfo(organizationId, datasetId, workspaceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.LinkWorkspaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **workspaceId** | **string** | workspace id to be linked to |  |

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
| **200** | the dataset details |  -  |
| **400** | Bad request |  -  |
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refreshdataset"></a>
# **RefreshDataset**
> DatasetTwinGraphInfo RefreshDataset (string organizationId, string datasetId)

Refresh data on dataset from dataset's source

Refresh dataset from parent source. At date, sources can be:      dataset (refresh from another dataset)      Azure Digital twin       Azure storage      Local File (import a new file)  During refresh, datas are overwritten 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RefreshDatasetExample
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
                // Refresh data on dataset from dataset's source
                DatasetTwinGraphInfo result = apiInstance.RefreshDataset(organizationId, datasetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.RefreshDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefreshDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refresh data on dataset from dataset's source
    ApiResponse<DatasetTwinGraphInfo> response = apiInstance.RefreshDatasetWithHttpInfo(organizationId, datasetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.RefreshDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |

### Return type

[**DatasetTwinGraphInfo**](DatasetTwinGraphInfo.md)

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

<a id="removealldatasetcompatibilityelements"></a>
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
                Debug.Print("Exception when calling DatasetApi.RemoveAllDatasetCompatibilityElements: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveAllDatasetCompatibilityElementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove all Dataset Compatibility elements from the Dataset specified
    apiInstance.RemoveAllDatasetCompatibilityElementsWithHttpInfo(organizationId, datasetId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.RemoveAllDatasetCompatibilityElementsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |

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

<a id="removedatasetaccesscontrol"></a>
# **RemoveDatasetAccessControl**
> void RemoveDatasetAccessControl (string organizationId, string datasetId, string identityId)

Remove the specified access from the given Dataset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveDatasetAccessControlExample
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
            var identityId = "identityId_example";  // string | the User identifier

            try
            {
                // Remove the specified access from the given Dataset
                apiInstance.RemoveDatasetAccessControl(organizationId, datasetId, identityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.RemoveDatasetAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveDatasetAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove the specified access from the given Dataset
    apiInstance.RemoveDatasetAccessControlWithHttpInfo(organizationId, datasetId, identityId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.RemoveDatasetAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
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
| **404** | The Dataset or the user specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rollbackrefresh"></a>
# **RollbackRefresh**
> string RollbackRefresh (string organizationId, string datasetId)

Rollback the dataset after a failed refresh

Rollback the twingraph on a dataset after a failed refresh

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RollbackRefreshExample
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
                // Rollback the dataset after a failed refresh
                string result = apiInstance.RollbackRefresh(organizationId, datasetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.RollbackRefresh: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RollbackRefreshWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rollback the dataset after a failed refresh
    ApiResponse<string> response = apiInstance.RollbackRefreshWithHttpInfo(organizationId, datasetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.RollbackRefreshWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |

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

<a id="searchdatasets"></a>
# **SearchDatasets**
> List&lt;Dataset&gt; SearchDatasets (string organizationId, DatasetSearch datasetSearch, int? page = null, int? size = null)

Search Datasets by tags

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
            var page = 56;  // int? | page number to query (optional) 
            var size = 56;  // int? | amount of result by page (optional) 

            try
            {
                // Search Datasets by tags
                List<Dataset> result = apiInstance.SearchDatasets(organizationId, datasetSearch, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.SearchDatasets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchDatasetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Datasets by tags
    ApiResponse<List<Dataset>> response = apiInstance.SearchDatasetsWithHttpInfo(organizationId, datasetSearch, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.SearchDatasetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetSearch** | [**DatasetSearch**](DatasetSearch.md) | the Dataset search parameters |  |
| **page** | **int?** | page number to query | [optional]  |
| **size** | **int?** | amount of result by page | [optional]  |

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

<a id="setdatasetdefaultsecurity"></a>
# **SetDatasetDefaultSecurity**
> DatasetSecurity SetDatasetDefaultSecurity (string organizationId, string datasetId, DatasetRole datasetRole)

Set the Dataset default security

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class SetDatasetDefaultSecurityExample
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
            var datasetRole = new DatasetRole(); // DatasetRole | This change the dataset default security. The default security is the role assigned to any person not on the Access Control List. If the default security is None, then nobody outside of the ACL can access the dataset.

            try
            {
                // Set the Dataset default security
                DatasetSecurity result = apiInstance.SetDatasetDefaultSecurity(organizationId, datasetId, datasetRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.SetDatasetDefaultSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetDatasetDefaultSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the Dataset default security
    ApiResponse<DatasetSecurity> response = apiInstance.SetDatasetDefaultSecurityWithHttpInfo(organizationId, datasetId, datasetRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.SetDatasetDefaultSecurityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **datasetRole** | [**DatasetRole**](DatasetRole.md) | This change the dataset default security. The default security is the role assigned to any person not on the Access Control List. If the default security is None, then nobody outside of the ACL can access the dataset. |  |

### Return type

[**DatasetSecurity**](DatasetSecurity.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Dataset default visibility |  -  |
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="twingraphbatchquery"></a>
# **TwingraphBatchQuery**
> DatasetTwinGraphHash TwingraphBatchQuery (string organizationId, string datasetId, DatasetTwinGraphQuery datasetTwinGraphQuery)

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
    public class TwingraphBatchQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Graph Identifier
            var datasetTwinGraphQuery = new DatasetTwinGraphQuery(); // DatasetTwinGraphQuery | the query to run

            try
            {
                // Run a query on a graph instance and return the result as a zip file in async mode
                DatasetTwinGraphHash result = apiInstance.TwingraphBatchQuery(organizationId, datasetId, datasetTwinGraphQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.TwingraphBatchQuery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TwingraphBatchQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run a query on a graph instance and return the result as a zip file in async mode
    ApiResponse<DatasetTwinGraphHash> response = apiInstance.TwingraphBatchQueryWithHttpInfo(organizationId, datasetId, datasetTwinGraphQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.TwingraphBatchQueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Graph Identifier |  |
| **datasetTwinGraphQuery** | [**DatasetTwinGraphQuery**](DatasetTwinGraphQuery.md) | the query to run |  |

### Return type

[**DatasetTwinGraphHash**](DatasetTwinGraphHash.md)

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

<a id="twingraphbatchupdate"></a>
# **TwingraphBatchUpdate**
> TwinGraphBatchResult TwingraphBatchUpdate (string organizationId, string datasetId, DatasetTwinGraphQuery twinGraphQuery, System.IO.Stream body)

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
    public class TwingraphBatchUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Dataset Identifier
            var twinGraphQuery = new DatasetTwinGraphQuery(); // DatasetTwinGraphQuery | 
            var body = id,name,rank
1,"John Doe",37
2,"Joe Bloggs",14
;  // System.IO.Stream | 

            try
            {
                // Async batch update by loading a CSV file on a graph instance 
                TwinGraphBatchResult result = apiInstance.TwingraphBatchUpdate(organizationId, datasetId, twinGraphQuery, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.TwingraphBatchUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TwingraphBatchUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Async batch update by loading a CSV file on a graph instance 
    ApiResponse<TwinGraphBatchResult> response = apiInstance.TwingraphBatchUpdateWithHttpInfo(organizationId, datasetId, twinGraphQuery, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.TwingraphBatchUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset Identifier |  |
| **twinGraphQuery** | [**DatasetTwinGraphQuery**](DatasetTwinGraphQuery.md) |  |  |
| **body** | **System.IO.Stream****System.IO.Stream** |  |  |

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

<a id="twingraphquery"></a>
# **TwingraphQuery**
> List&lt;Object&gt; TwingraphQuery (string organizationId, string datasetId, DatasetTwinGraphQuery datasetTwinGraphQuery)

Return the result of a query made on the graph instance as a json

Run a query on a graph instance and return the result as a json

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class TwingraphQueryExample
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
            var datasetTwinGraphQuery = new DatasetTwinGraphQuery(); // DatasetTwinGraphQuery | the query to run

            try
            {
                // Return the result of a query made on the graph instance as a json
                List<Object> result = apiInstance.TwingraphQuery(organizationId, datasetId, datasetTwinGraphQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.TwingraphQuery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TwingraphQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return the result of a query made on the graph instance as a json
    ApiResponse<List<Object>> response = apiInstance.TwingraphQueryWithHttpInfo(organizationId, datasetId, datasetTwinGraphQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.TwingraphQueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **datasetTwinGraphQuery** | [**DatasetTwinGraphQuery**](DatasetTwinGraphQuery.md) | the query to run |  |

### Return type

**List<Object>**

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

<a id="unlinkworkspace"></a>
# **UnlinkWorkspace**
> Dataset UnlinkWorkspace (string organizationId, string datasetId, string workspaceId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UnlinkWorkspaceExample
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
            var workspaceId = "workspaceId_example";  // string | workspace id to be linked to

            try
            {
                Dataset result = apiInstance.UnlinkWorkspace(organizationId, datasetId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.UnlinkWorkspace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlinkWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dataset> response = apiInstance.UnlinkWorkspaceWithHttpInfo(organizationId, datasetId, workspaceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.UnlinkWorkspaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **workspaceId** | **string** | workspace id to be linked to |  |

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
| **200** | the dataset details |  -  |
| **400** | Bad request |  -  |
| **404** | the Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatedataset"></a>
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
            var dataset = new Dataset(); // Dataset | the new Dataset details. This endpoint can't be used to update security

            try
            {
                // Update a dataset
                Dataset result = apiInstance.UpdateDataset(organizationId, datasetId, dataset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.UpdateDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a dataset
    ApiResponse<Dataset> response = apiInstance.UpdateDatasetWithHttpInfo(organizationId, datasetId, dataset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.UpdateDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **dataset** | [**Dataset**](Dataset.md) | the new Dataset details. This endpoint can&#39;t be used to update security |  |

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

<a id="updatedatasetaccesscontrol"></a>
# **UpdateDatasetAccessControl**
> DatasetAccessControl UpdateDatasetAccessControl (string organizationId, string datasetId, string identityId, DatasetRole datasetRole)

Update the specified access to User for a Dataset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateDatasetAccessControlExample
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
            var identityId = "identityId_example";  // string | the User identifier
            var datasetRole = new DatasetRole(); // DatasetRole | The new Dataset Access Control

            try
            {
                // Update the specified access to User for a Dataset
                DatasetAccessControl result = apiInstance.UpdateDatasetAccessControl(organizationId, datasetId, identityId, datasetRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.UpdateDatasetAccessControl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDatasetAccessControlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the specified access to User for a Dataset
    ApiResponse<DatasetAccessControl> response = apiInstance.UpdateDatasetAccessControlWithHttpInfo(organizationId, datasetId, identityId, datasetRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.UpdateDatasetAccessControlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **identityId** | **string** | the User identifier |  |
| **datasetRole** | [**DatasetRole**](DatasetRole.md) | The new Dataset Access Control |  |

### Return type

[**DatasetAccessControl**](DatasetAccessControl.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Dataset access |  -  |
| **404** | The Dataset specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetwingraphentities"></a>
# **UpdateTwingraphEntities**
> string UpdateTwingraphEntities (string organizationId, string datasetId, string type, List<GraphProperties> graphProperties)

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
    public class UpdateTwingraphEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DatasetApi(config);
            var organizationId = "organizationId_example";  // string | the Organization identifier
            var datasetId = "datasetId_example";  // string | the Dataset Identifier
            var type = "node";  // string | the entity model type
            var graphProperties = new List<GraphProperties>(); // List<GraphProperties> | the entities to update

            try
            {
                // Update entities in a graph instance
                string result = apiInstance.UpdateTwingraphEntities(organizationId, datasetId, type, graphProperties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.UpdateTwingraphEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTwingraphEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update entities in a graph instance
    ApiResponse<string> response = apiInstance.UpdateTwingraphEntitiesWithHttpInfo(organizationId, datasetId, type, graphProperties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.UpdateTwingraphEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset Identifier |  |
| **type** | **string** | the entity model type |  |
| **graphProperties** | [**List&lt;GraphProperties&gt;**](GraphProperties.md) | the entities to update |  |

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

<a id="uploadtwingraph"></a>
# **UploadTwingraph**
> FileUploadValidation UploadTwingraph (string organizationId, string datasetId, System.IO.Stream body)

Upload data from zip file to dataset's twingraph

To create a new graph from flat files,  you need to create a Zip file. This Zip file must countain two folders named Edges and Nodes.  .zip hierarchy: *main_folder/Nodes *main_folder/Edges  In each folder you can place one or multiple csv files containing your Nodes or Edges data.  Your csv files must follow the following header (column name) requirements:  The Nodes CSVs requires at least one column (the 1st).Column name = 'id'. It will represent the nodes ID Ids must be populated with string  The Edges CSVs require three columns named, in order, * source * target * id  those colomns represent * The source of the edge * The target of the edge * The id of the edge  All following columns content are up to you. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UploadTwingraphExample
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
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Upload data from zip file to dataset's twingraph
                FileUploadValidation result = apiInstance.UploadTwingraph(organizationId, datasetId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.UploadTwingraph: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadTwingraphWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload data from zip file to dataset's twingraph
    ApiResponse<FileUploadValidation> response = apiInstance.UploadTwingraphWithHttpInfo(organizationId, datasetId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.UploadTwingraphWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationId** | **string** | the Organization identifier |  |
| **datasetId** | **string** | the Dataset identifier |  |
| **body** | **System.IO.Stream****System.IO.Stream** |  |  |

### Return type

[**FileUploadValidation**](FileUploadValidation.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | File uploaded successfully. Processing... |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

