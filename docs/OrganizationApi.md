# Com.Cosmotech.Api.OrganizationApi

All URIs are relative to *https://api.azure.cosmo-platform.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrReplaceUsersInOrganization**](OrganizationApi.md#addorreplaceusersinorganization) | **POST** /organizations/{organization_id}/users | Add (or replace) users in the Organization specified
[**FindAllOrganizations**](OrganizationApi.md#findallorganizations) | **GET** /organizations | List all Organizations
[**FindOrganizationById**](OrganizationApi.md#findorganizationbyid) | **GET** /organizations/{organization_id} | Get the details of an Organization
[**RegisterOrganization**](OrganizationApi.md#registerorganization) | **POST** /organizations | Register a new organization
[**RemoveAllUsersInOrganization**](OrganizationApi.md#removeallusersinorganization) | **DELETE** /organizations/{organization_id}/users | Remove all users from the Organization specified
[**RemoveUserFromOrganization**](OrganizationApi.md#removeuserfromorganization) | **DELETE** /organizations/{organization_id}/users/{user_id} | Remove the specified user from the given Organization
[**UnregisterOrganization**](OrganizationApi.md#unregisterorganization) | **DELETE** /organizations/{organization_id} | Unregister an organization
[**UpdateOrganization**](OrganizationApi.md#updateorganization) | **PATCH** /organizations/{organization_id} | Update an Organization
[**UpdateSolutionsContainerRegistryByOrganizationId**](OrganizationApi.md#updatesolutionscontainerregistrybyorganizationid) | **PATCH** /organizations/{organization_id}/services/solutionsContainerRegistry | Update the solutions container registry configuration for the Organization specified
[**UpdateStorageByOrganizationId**](OrganizationApi.md#updatestoragebyorganizationid) | **PATCH** /organizations/{organization_id}/services/storage | Update storage configuration for the Organization specified
[**UpdateTenantCredentialsByOrganizationId**](OrganizationApi.md#updatetenantcredentialsbyorganizationid) | **PATCH** /organizations/{organization_id}/services/tenantCredentials | Update tenant credentials for the Organization specified


<a name="addorreplaceusersinorganization"></a>
# **AddOrReplaceUsersInOrganization**
> List&lt;OrganizationUser&gt; AddOrReplaceUsersInOrganization (string organizationId, List<OrganizationUser> organizationUser)

Add (or replace) users in the Organization specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddOrReplaceUsersInOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var organizationUser = new List<OrganizationUser>(); // List<OrganizationUser> | the Users to add. Any User with the same ID is overwritten

            try
            {
                // Add (or replace) users in the Organization specified
                List<OrganizationUser> result = apiInstance.AddOrReplaceUsersInOrganization(organizationId, organizationUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.AddOrReplaceUsersInOrganization: " + e.Message );
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
 **organizationUser** | [**List&lt;OrganizationUser&gt;**](OrganizationUser.md)| the Users to add. Any User with the same ID is overwritten | 

### Return type

[**List&lt;OrganizationUser&gt;**](OrganizationUser.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the Organization Users |  -  |
| **400** | Bad request |  -  |
| **404** | the Organization specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallorganizations"></a>
# **FindAllOrganizations**
> List&lt;Organization&gt; FindAllOrganizations ()

List all Organizations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllOrganizationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);

            try
            {
                // List all Organizations
                List<Organization> result = apiInstance.FindAllOrganizations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.FindAllOrganizations: " + e.Message );
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

[**List&lt;Organization&gt;**](Organization.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the list of Organizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findorganizationbyid"></a>
# **FindOrganizationById**
> Organization FindOrganizationById (string organizationId)

Get the details of an Organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindOrganizationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier

            try
            {
                // Get the details of an Organization
                Organization result = apiInstance.FindOrganizationById(organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.FindOrganizationById: " + e.Message );
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

[**Organization**](Organization.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Organization details |  -  |
| **404** | the Organization specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerorganization"></a>
# **RegisterOrganization**
> Organization RegisterOrganization (Organization organization)

Register a new organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RegisterOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);
            var organization = new Organization(); // Organization | the Organization to register

            try
            {
                // Register a new organization
                Organization result = apiInstance.RegisterOrganization(organization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.RegisterOrganization: " + e.Message );
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
 **organization** | [**Organization**](Organization.md)| the Organization to register | 

### Return type

[**Organization**](Organization.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the Organization details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeallusersinorganization"></a>
# **RemoveAllUsersInOrganization**
> void RemoveAllUsersInOrganization (string organizationId)

Remove all users from the Organization specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveAllUsersInOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier

            try
            {
                // Remove all users from the Organization specified
                apiInstance.RemoveAllUsersInOrganization(organizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.RemoveAllUsersInOrganization: " + e.Message );
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
| **404** | the Organization specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuserfromorganization"></a>
# **RemoveUserFromOrganization**
> void RemoveUserFromOrganization (string organizationId, string userId)

Remove the specified user from the given Organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveUserFromOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var userId = userId_example;  // string | the User identifier

            try
            {
                // Remove the specified user from the given Organization
                apiInstance.RemoveUserFromOrganization(organizationId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.RemoveUserFromOrganization: " + e.Message );
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
 **userId** | **string**| the User identifier | 

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
| **404** | the Organization or the User specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unregisterorganization"></a>
# **UnregisterOrganization**
> void UnregisterOrganization (string organizationId)

Unregister an organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UnregisterOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier

            try
            {
                // Unregister an organization
                apiInstance.UnregisterOrganization(organizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.UnregisterOrganization: " + e.Message );
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
| **404** | the Organization specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorganization"></a>
# **UpdateOrganization**
> Organization UpdateOrganization (string organizationId, Organization organization)

Update an Organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var organization = new Organization(); // Organization | the new Organization details

            try
            {
                // Update an Organization
                Organization result = apiInstance.UpdateOrganization(organizationId, organization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.UpdateOrganization: " + e.Message );
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
 **organization** | [**Organization**](Organization.md)| the new Organization details | 

### Return type

[**Organization**](Organization.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the organization details |  -  |
| **400** | Bad request |  -  |
| **404** | the Organization specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesolutionscontainerregistrybyorganizationid"></a>
# **UpdateSolutionsContainerRegistryByOrganizationId**
> OrganizationService UpdateSolutionsContainerRegistryByOrganizationId (string organizationId, OrganizationService organizationService)

Update the solutions container registry configuration for the Organization specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateSolutionsContainerRegistryByOrganizationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var organizationService = new OrganizationService(); // OrganizationService | the new solutions container registry configuration to use

            try
            {
                // Update the solutions container registry configuration for the Organization specified
                OrganizationService result = apiInstance.UpdateSolutionsContainerRegistryByOrganizationId(organizationId, organizationService);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.UpdateSolutionsContainerRegistryByOrganizationId: " + e.Message );
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
 **organizationService** | [**OrganizationService**](OrganizationService.md)| the new solutions container registry configuration to use | 

### Return type

[**OrganizationService**](OrganizationService.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Organization solutions container registry configuration |  -  |
| **404** | the Organization specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoragebyorganizationid"></a>
# **UpdateStorageByOrganizationId**
> OrganizationService UpdateStorageByOrganizationId (string organizationId, OrganizationService organizationService)

Update storage configuration for the Organization specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateStorageByOrganizationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var organizationService = new OrganizationService(); // OrganizationService | the new Storage configuration to use

            try
            {
                // Update storage configuration for the Organization specified
                OrganizationService result = apiInstance.UpdateStorageByOrganizationId(organizationId, organizationService);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.UpdateStorageByOrganizationId: " + e.Message );
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
 **organizationService** | [**OrganizationService**](OrganizationService.md)| the new Storage configuration to use | 

### Return type

[**OrganizationService**](OrganizationService.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Organization Storage configuration |  -  |
| **404** | the Organization specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetenantcredentialsbyorganizationid"></a>
# **UpdateTenantCredentialsByOrganizationId**
> Dictionary&lt;string, Object&gt; UpdateTenantCredentialsByOrganizationId (string organizationId, Dictionary<string, Object> requestBody)

Update tenant credentials for the Organization specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateTenantCredentialsByOrganizationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | the new Tenant Credentials to use

            try
            {
                // Update tenant credentials for the Organization specified
                Dictionary<string, Object> result = apiInstance.UpdateTenantCredentialsByOrganizationId(organizationId, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.UpdateTenantCredentialsByOrganizationId: " + e.Message );
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
 **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md)| the new Tenant Credentials to use | 

### Return type

**Dictionary<string, Object>**

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Organization Tenant Credentials |  -  |
| **404** | the Organization specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

