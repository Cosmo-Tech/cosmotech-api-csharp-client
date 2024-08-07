# Com.Cosmotech.Api.ConnectorApi

All URIs are relative to *https://dev.api.cosmotech.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FindAllConnectors**](ConnectorApi.md#findallconnectors) | **GET** /connectors | List all Connectors |
| [**FindConnectorById**](ConnectorApi.md#findconnectorbyid) | **GET** /connectors/{connector_id} | Get the details of a connector |
| [**RegisterConnector**](ConnectorApi.md#registerconnector) | **POST** /connectors | Register a new connector |
| [**UnregisterConnector**](ConnectorApi.md#unregisterconnector) | **DELETE** /connectors/{connector_id} | Unregister a connector |

<a id="findallconnectors"></a>
# **FindAllConnectors**
> List&lt;Connector&gt; FindAllConnectors (int? page = null, int? size = null)

List all Connectors

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllConnectorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectorApi(config);
            var page = 56;  // int? | page number to query (optional) 
            var size = 56;  // int? | amount of result by page (optional) 

            try
            {
                // List all Connectors
                List<Connector> result = apiInstance.FindAllConnectors(page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.FindAllConnectors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllConnectorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Connectors
    ApiResponse<List<Connector>> response = apiInstance.FindAllConnectorsWithHttpInfo(page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorApi.FindAllConnectorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number to query | [optional]  |
| **size** | **int?** | amount of result by page | [optional]  |

### Return type

[**List&lt;Connector&gt;**](Connector.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the list of Connectors |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findconnectorbyid"></a>
# **FindConnectorById**
> Connector FindConnectorById (string connectorId)

Get the details of a connector

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindConnectorByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectorApi(config);
            var connectorId = "connectorId_example";  // string | the Connector identifier

            try
            {
                // Get the details of a connector
                Connector result = apiInstance.FindConnectorById(connectorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.FindConnectorById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindConnectorByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a connector
    ApiResponse<Connector> response = apiInstance.FindConnectorByIdWithHttpInfo(connectorId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorApi.FindConnectorByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **connectorId** | **string** | the Connector identifier |  |

### Return type

[**Connector**](Connector.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Connector details |  -  |
| **404** | the Connector specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="registerconnector"></a>
# **RegisterConnector**
> Connector RegisterConnector (Connector connector)

Register a new connector

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RegisterConnectorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectorApi(config);
            var connector = new Connector(); // Connector | the Connector to register

            try
            {
                // Register a new connector
                Connector result = apiInstance.RegisterConnector(connector);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.RegisterConnector: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterConnectorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register a new connector
    ApiResponse<Connector> response = apiInstance.RegisterConnectorWithHttpInfo(connector);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorApi.RegisterConnectorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **connector** | [**Connector**](Connector.md) | the Connector to register |  |

### Return type

[**Connector**](Connector.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the connector details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unregisterconnector"></a>
# **UnregisterConnector**
> void UnregisterConnector (string connectorId)

Unregister a connector

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UnregisterConnectorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectorApi(config);
            var connectorId = "connectorId_example";  // string | the Connector identifier

            try
            {
                // Unregister a connector
                apiInstance.UnregisterConnector(connectorId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.UnregisterConnector: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnregisterConnectorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unregister a connector
    apiInstance.UnregisterConnectorWithHttpInfo(connectorId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorApi.UnregisterConnectorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **connectorId** | **string** | the Connector identifier |  |

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
| **404** | the Connector specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

