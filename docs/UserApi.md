# Com.Cosmotech.Api.UserApi

All URIs are relative to *https://api.azure.cosmo-platform.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindAllUsers**](UserApi.md#findallusers) | **GET** /users | List all Users
[**FindUserById**](UserApi.md#finduserbyid) | **GET** /users/{user_id} | Get the details of an user
[**RegisterUser**](UserApi.md#registeruser) | **POST** /users | Register a new user
[**UnregisterUser**](UserApi.md#unregisteruser) | **DELETE** /users/{user_id} | Unregister an user
[**UpdateUser**](UserApi.md#updateuser) | **PATCH** /users/{user_id} | Update an user


<a name="findallusers"></a>
# **FindAllUsers**
> List&lt;UserDetails&gt; FindAllUsers ()

List all Users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);

            try
            {
                // List all Users
                List<UserDetails> result = apiInstance.FindAllUsers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.FindAllUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;UserDetails&gt;**](UserDetails.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the user details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finduserbyid"></a>
# **FindUserById**
> UserDetails FindUserById (string userId)

Get the details of an user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindUserByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);
            var userId = userId_example;  // string | the User identifier

            try
            {
                // Get the details of an user
                UserDetails result = apiInstance.FindUserById(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.FindUserById: " + e.Message );
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
 **userId** | **string**| the User identifier | 

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the User details |  -  |
| **404** | the User specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registeruser"></a>
# **RegisterUser**
> UserDetails RegisterUser (User user)

Register a new user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RegisterUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);
            var user = new User(); // User | the User to register

            try
            {
                // Register a new user
                UserDetails result = apiInstance.RegisterUser(user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.RegisterUser: " + e.Message );
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
 **user** | [**User**](User.md)| the User to register | 

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the user details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unregisteruser"></a>
# **UnregisterUser**
> UserDetails UnregisterUser (string userId)

Unregister an user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UnregisterUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);
            var userId = userId_example;  // string | the User identifier

            try
            {
                // Unregister an user
                UserDetails result = apiInstance.UnregisterUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UnregisterUser: " + e.Message );
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
 **userId** | **string**| the User identifier | 

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the user details |  -  |
| **400** | Bad request |  -  |
| **404** | the User specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> UserDetails UpdateUser (string userId, User user)

Update an user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);
            var userId = userId_example;  // string | the User identifier
            var user = new User(); // User | the new User details. Organization membership is handled in Organzation service.

            try
            {
                // Update an user
                UserDetails result = apiInstance.UpdateUser(userId, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUser: " + e.Message );
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
 **userId** | **string**| the User identifier | 
 **user** | [**User**](User.md)| the new User details. Organization membership is handled in Organzation service. | 

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the user details |  -  |
| **400** | Bad request |  -  |
| **404** | the User specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

