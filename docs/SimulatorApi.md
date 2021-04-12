# Com.Cosmotech.Api.SimulatorApi

All URIs are relative to *https://api.azure.cosmo-platform.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSimulator**](SimulatorApi.md#createsimulator) | **POST** /organizations/{organization_id}/simulators | Register a new simulator
[**DeleteSimulator**](SimulatorApi.md#deletesimulator) | **DELETE** /organizations/{organization_id}/simulators/{simulator_id} | Delete a simulator
[**FindAllSimulators**](SimulatorApi.md#findallsimulators) | **GET** /organizations/{organization_id}/simulators | List all Simulators
[**FindSimulatorById**](SimulatorApi.md#findsimulatorbyid) | **GET** /organizations/{organization_id}/simulators/{simulator_id} | Get the details of a simulator
[**UpdateSimulator**](SimulatorApi.md#updatesimulator) | **PATCH** /organizations/{organization_id}/simulators/{simulator_id} | Update a simulator
[**Upload**](SimulatorApi.md#upload) | **POST** /organizations/{organization_id}/simulators/upload | Upload and register a new simulator


<a name="createsimulator"></a>
# **CreateSimulator**
> Simulator CreateSimulator (string organizationId, Simulator simulator)

Register a new simulator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateSimulatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: AADOAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SimulatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulator = new Simulator(); // Simulator | the Simulator to create

            try
            {
                // Register a new simulator
                Simulator result = apiInstance.CreateSimulator(organizationId, simulator);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulatorApi.CreateSimulator: " + e.Message );
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
 **simulator** | [**Simulator**](Simulator.md)| the Simulator to create | 

### Return type

[**Simulator**](Simulator.md)

### Authorization

[AADOAuth2AuthCode](../README.md#AADOAuth2AuthCode), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the simulator details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesimulator"></a>
# **DeleteSimulator**
> Simulator DeleteSimulator (string organizationId, string simulatorId)

Delete a simulator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteSimulatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: AADOAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SimulatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulatorId = simulatorId_example;  // string | the Simulator identifier

            try
            {
                // Delete a simulator
                Simulator result = apiInstance.DeleteSimulator(organizationId, simulatorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulatorApi.DeleteSimulator: " + e.Message );
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
 **simulatorId** | **string**| the Simulator identifier | 

### Return type

[**Simulator**](Simulator.md)

### Authorization

[AADOAuth2AuthCode](../README.md#AADOAuth2AuthCode), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the simulator details |  -  |
| **400** | Bad request |  -  |
| **404** | the Simulator specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallsimulators"></a>
# **FindAllSimulators**
> List&lt;Simulator&gt; FindAllSimulators (string organizationId)

List all Simulators

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllSimulatorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: AADOAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SimulatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier

            try
            {
                // List all Simulators
                List<Simulator> result = apiInstance.FindAllSimulators(organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulatorApi.FindAllSimulators: " + e.Message );
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

[**List&lt;Simulator&gt;**](Simulator.md)

### Authorization

[AADOAuth2AuthCode](../README.md#AADOAuth2AuthCode), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the simulator details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findsimulatorbyid"></a>
# **FindSimulatorById**
> Simulator FindSimulatorById (string organizationId, string simulatorId)

Get the details of a simulator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindSimulatorByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: AADOAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SimulatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulatorId = simulatorId_example;  // string | the Simulator identifier

            try
            {
                // Get the details of a simulator
                Simulator result = apiInstance.FindSimulatorById(organizationId, simulatorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulatorApi.FindSimulatorById: " + e.Message );
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
 **simulatorId** | **string**| the Simulator identifier | 

### Return type

[**Simulator**](Simulator.md)

### Authorization

[AADOAuth2AuthCode](../README.md#AADOAuth2AuthCode), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Simulator details |  -  |
| **404** | the Simulator specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesimulator"></a>
# **UpdateSimulator**
> Simulator UpdateSimulator (string organizationId, string simulatorId, Simulator simulator)

Update a simulator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateSimulatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: AADOAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SimulatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulatorId = simulatorId_example;  // string | the Simulator identifier
            var simulator = new Simulator(); // Simulator | the new Simulator details.

            try
            {
                // Update a simulator
                Simulator result = apiInstance.UpdateSimulator(organizationId, simulatorId, simulator);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulatorApi.UpdateSimulator: " + e.Message );
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
 **simulatorId** | **string**| the Simulator identifier | 
 **simulator** | [**Simulator**](Simulator.md)| the new Simulator details. | 

### Return type

[**Simulator**](Simulator.md)

### Authorization

[AADOAuth2AuthCode](../README.md#AADOAuth2AuthCode), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the simulator details |  -  |
| **400** | Bad request |  -  |
| **404** | the Simulator specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upload"></a>
# **Upload**
> Simulator Upload (string organizationId, System.IO.Stream body)

Upload and register a new simulator

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
            // Configure OAuth2 access token for authorization: AADOAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SimulatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var body = BINARY_DATA_HERE;  // System.IO.Stream | the Simulator to upload and register

            try
            {
                // Upload and register a new simulator
                Simulator result = apiInstance.Upload(organizationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulatorApi.Upload: " + e.Message );
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
 **body** | **System.IO.Stream****System.IO.Stream**| the Simulator to upload and register | 

### Return type

[**Simulator**](Simulator.md)

### Authorization

[AADOAuth2AuthCode](../README.md#AADOAuth2AuthCode), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the simulator details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

