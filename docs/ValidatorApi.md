# Com.Cosmotech.Api.ValidatorApi

All URIs are relative to *http://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateValidator**](ValidatorApi.md#createvalidator) | **POST** /organizations/{organization_id}/datasets/validators | Register a new validator
[**CreateValidatorRun**](ValidatorApi.md#createvalidatorrun) | **POST** /organizations/{organization_id}/datasets/validators/{validator_id}/history | Register a new validator run
[**DeleteValidator**](ValidatorApi.md#deletevalidator) | **DELETE** /organizations/{organization_id}/datasets/validators/{validator_id} | Delete a validator
[**DeleteValidatorRun**](ValidatorApi.md#deletevalidatorrun) | **DELETE** /organizations/{organization_id}/datasets/validators/{validator_id}/history/{validatorrun_id} | Delete a validator run
[**FindAllValidatorRuns**](ValidatorApi.md#findallvalidatorruns) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id}/history | List all Validator Runs
[**FindAllValidators**](ValidatorApi.md#findallvalidators) | **GET** /organizations/{organization_id}/datasets/validators | List all Validators
[**FindValidatorById**](ValidatorApi.md#findvalidatorbyid) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id} | Get the details of a validator
[**FindValidatorRunById**](ValidatorApi.md#findvalidatorrunbyid) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id}/history/{validatorrun_id} | Get the details of a validator run
[**RunValidator**](ValidatorApi.md#runvalidator) | **POST** /organizations/{organization_id}/datasets/validators/{validator_id}/run | Run a Validator


<a name="createvalidator"></a>
# **CreateValidator**
> Validator CreateValidator (string organizationId, Validator validator)

Register a new validator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateValidatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ValidatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var validator = new Validator(); // Validator | the Validator to create

            try
            {
                // Register a new validator
                Validator result = apiInstance.CreateValidator(organizationId, validator);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidatorApi.CreateValidator: " + e.Message );
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
 **validator** | [**Validator**](Validator.md)| the Validator to create | 

### Return type

[**Validator**](Validator.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the validator details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvalidatorrun"></a>
# **CreateValidatorRun**
> ValidatorRun CreateValidatorRun (string organizationId, string validatorId, ValidatorRun validatorRun)

Register a new validator run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateValidatorRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ValidatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var validatorId = validatorId_example;  // string | the ValidatorRun identifier
            var validatorRun = new ValidatorRun(); // ValidatorRun | the Validator Run to create

            try
            {
                // Register a new validator run
                ValidatorRun result = apiInstance.CreateValidatorRun(organizationId, validatorId, validatorRun);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidatorApi.CreateValidatorRun: " + e.Message );
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
 **validatorId** | **string**| the ValidatorRun identifier | 
 **validatorRun** | [**ValidatorRun**](ValidatorRun.md)| the Validator Run to create | 

### Return type

[**ValidatorRun**](ValidatorRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the validator run details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevalidator"></a>
# **DeleteValidator**
> Validator DeleteValidator (string organizationId, string validatorId)

Delete a validator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteValidatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ValidatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var validatorId = validatorId_example;  // string | the Validator identifier

            try
            {
                // Delete a validator
                Validator result = apiInstance.DeleteValidator(organizationId, validatorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidatorApi.DeleteValidator: " + e.Message );
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
 **validatorId** | **string**| the Validator identifier | 

### Return type

[**Validator**](Validator.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the validator details |  -  |
| **400** | Bad request |  -  |
| **404** | the Validator specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevalidatorrun"></a>
# **DeleteValidatorRun**
> ValidatorRun DeleteValidatorRun (string organizationId, string validatorId, string validatorrunId)

Delete a validator run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteValidatorRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ValidatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var validatorId = validatorId_example;  // string | the Validator identifier
            var validatorrunId = validatorrunId_example;  // string | the Validator Run identifier

            try
            {
                // Delete a validator run
                ValidatorRun result = apiInstance.DeleteValidatorRun(organizationId, validatorId, validatorrunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidatorApi.DeleteValidatorRun: " + e.Message );
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
 **validatorId** | **string**| the Validator identifier | 
 **validatorrunId** | **string**| the Validator Run identifier | 

### Return type

[**ValidatorRun**](ValidatorRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the validator run details |  -  |
| **400** | Bad request |  -  |
| **404** | the ValidatorRun specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallvalidatorruns"></a>
# **FindAllValidatorRuns**
> List&lt;ValidatorRun&gt; FindAllValidatorRuns (string organizationId, string validatorId)

List all Validator Runs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllValidatorRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ValidatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var validatorId = validatorId_example;  // string | the ValidatorRun identifier

            try
            {
                // List all Validator Runs
                List<ValidatorRun> result = apiInstance.FindAllValidatorRuns(organizationId, validatorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidatorApi.FindAllValidatorRuns: " + e.Message );
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
 **validatorId** | **string**| the ValidatorRun identifier | 

### Return type

[**List&lt;ValidatorRun&gt;**](ValidatorRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the validator run details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallvalidators"></a>
# **FindAllValidators**
> List&lt;Validator&gt; FindAllValidators (string organizationId)

List all Validators

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllValidatorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ValidatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier

            try
            {
                // List all Validators
                List<Validator> result = apiInstance.FindAllValidators(organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidatorApi.FindAllValidators: " + e.Message );
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

[**List&lt;Validator&gt;**](Validator.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the validator details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findvalidatorbyid"></a>
# **FindValidatorById**
> Validator FindValidatorById (string organizationId, string validatorId)

Get the details of a validator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindValidatorByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ValidatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var validatorId = validatorId_example;  // string | the Validator identifier

            try
            {
                // Get the details of a validator
                Validator result = apiInstance.FindValidatorById(organizationId, validatorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidatorApi.FindValidatorById: " + e.Message );
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
 **validatorId** | **string**| the Validator identifier | 

### Return type

[**Validator**](Validator.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Validator details |  -  |
| **404** | the Validator specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findvalidatorrunbyid"></a>
# **FindValidatorRunById**
> ValidatorRun FindValidatorRunById (string organizationId, string validatorId, string validatorrunId)

Get the details of a validator run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindValidatorRunByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ValidatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var validatorId = validatorId_example;  // string | the Validator identifier
            var validatorrunId = validatorrunId_example;  // string | the Validator Run identifier

            try
            {
                // Get the details of a validator run
                ValidatorRun result = apiInstance.FindValidatorRunById(organizationId, validatorId, validatorrunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidatorApi.FindValidatorRunById: " + e.Message );
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
 **validatorId** | **string**| the Validator identifier | 
 **validatorrunId** | **string**| the Validator Run identifier | 

### Return type

[**ValidatorRun**](ValidatorRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Validator Run details |  -  |
| **404** | the ValidatorRun specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runvalidator"></a>
# **RunValidator**
> ValidatorRun RunValidator (string organizationId, string validatorId, ValidatorRun validatorRun)

Run a Validator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RunValidatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ValidatorApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var validatorId = validatorId_example;  // string | the ValidatorRun identifier
            var validatorRun = new ValidatorRun(); // ValidatorRun | the Validator to run

            try
            {
                // Run a Validator
                ValidatorRun result = apiInstance.RunValidator(organizationId, validatorId, validatorRun);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidatorApi.RunValidator: " + e.Message );
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
 **validatorId** | **string**| the ValidatorRun identifier | 
 **validatorRun** | [**ValidatorRun**](ValidatorRun.md)| the Validator to run | 

### Return type

[**ValidatorRun**](ValidatorRun.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the validator run details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

