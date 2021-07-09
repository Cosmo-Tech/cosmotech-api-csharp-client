# Com.Cosmotech.Api.ScenarioApi

All URIs are relative to *https://api.cosmotech.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrReplaceScenarioParameterValues**](ScenarioApi.md#addorreplacescenarioparametervalues) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/parameterValues | Add (or replace) Parameter Values for the Scenario specified
[**AddOrReplaceUsersInScenario**](ScenarioApi.md#addorreplaceusersinscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/users | Add (or replace) users in the Scenario specified
[**CompareScenarios**](ScenarioApi.md#comparescenarios) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/compare/{compared_scenario_id} | Compare the Scenario with another one and returns the difference for parameters values
[**CreateScenario**](ScenarioApi.md#createscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios | Create a new Scenario
[**DeleteAllScenarios**](ScenarioApi.md#deleteallscenarios) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios | Delete all Scenarios of the Workspace
[**DeleteScenario**](ScenarioApi.md#deletescenario) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Delete a scenario
[**FindAllScenarios**](ScenarioApi.md#findallscenarios) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios | List all Scenarios
[**FindScenarioById**](ScenarioApi.md#findscenariobyid) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Get the details of an scenario
[**GetScenariosTree**](ScenarioApi.md#getscenariostree) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/tree | Get the Scenarios Tree
[**RemoveAllScenarioParameterValues**](ScenarioApi.md#removeallscenarioparametervalues) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/parameterValues | Remove all Parameter Values from the Scenario specified
[**RemoveAllUsersOfScenario**](ScenarioApi.md#removeallusersofscenario) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/users | Remove all users from the Scenario specified
[**RemoveUserFromScenario**](ScenarioApi.md#removeuserfromscenario) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/users/{user_id} | Remove the specified user from the given Scenario
[**UpdateScenario**](ScenarioApi.md#updatescenario) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Update a scenario


<a name="addorreplacescenarioparametervalues"></a>
# **AddOrReplaceScenarioParameterValues**
> List&lt;ScenarioRunTemplateParameterValue&gt; AddOrReplaceScenarioParameterValues (string organizationId, string workspaceId, string scenarioId, List<ScenarioRunTemplateParameterValue> scenarioRunTemplateParameterValue)

Add (or replace) Parameter Values for the Scenario specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddOrReplaceScenarioParameterValuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier
            var scenarioRunTemplateParameterValue = new List<ScenarioRunTemplateParameterValue>(); // List<ScenarioRunTemplateParameterValue> | the Parameter Value to add. Any Parameter Value with the same ID is overwritten

            try
            {
                // Add (or replace) Parameter Values for the Scenario specified
                List<ScenarioRunTemplateParameterValue> result = apiInstance.AddOrReplaceScenarioParameterValues(organizationId, workspaceId, scenarioId, scenarioRunTemplateParameterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.AddOrReplaceScenarioParameterValues: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 
 **scenarioRunTemplateParameterValue** | [**List&lt;ScenarioRunTemplateParameterValue&gt;**](ScenarioRunTemplateParameterValue.md)| the Parameter Value to add. Any Parameter Value with the same ID is overwritten | 

### Return type

[**List&lt;ScenarioRunTemplateParameterValue&gt;**](ScenarioRunTemplateParameterValue.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the Parameter values |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorreplaceusersinscenario"></a>
# **AddOrReplaceUsersInScenario**
> List&lt;ScenarioUser&gt; AddOrReplaceUsersInScenario (string organizationId, string workspaceId, string scenarioId, List<ScenarioUser> scenarioUser)

Add (or replace) users in the Scenario specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class AddOrReplaceUsersInScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier
            var scenarioUser = new List<ScenarioUser>(); // List<ScenarioUser> | the Users to add. Any User with the same ID is overwritten

            try
            {
                // Add (or replace) users in the Scenario specified
                List<ScenarioUser> result = apiInstance.AddOrReplaceUsersInScenario(organizationId, workspaceId, scenarioId, scenarioUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.AddOrReplaceUsersInScenario: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 
 **scenarioUser** | [**List&lt;ScenarioUser&gt;**](ScenarioUser.md)| the Users to add. Any User with the same ID is overwritten | 

### Return type

[**List&lt;ScenarioUser&gt;**](ScenarioUser.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the Scenario Users |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="comparescenarios"></a>
# **CompareScenarios**
> ScenarioComparisonResult CompareScenarios (string organizationId, string workspaceId, string scenarioId, string comparedScenarioId)

Compare the Scenario with another one and returns the difference for parameters values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CompareScenariosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier
            var comparedScenarioId = comparedScenarioId_example;  // string | the Scenario identifier to compare to

            try
            {
                // Compare the Scenario with another one and returns the difference for parameters values
                ScenarioComparisonResult result = apiInstance.CompareScenarios(organizationId, workspaceId, scenarioId, comparedScenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.CompareScenarios: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 
 **comparedScenarioId** | **string**| the Scenario identifier to compare to | 

### Return type

[**ScenarioComparisonResult**](ScenarioComparisonResult.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the comparison result for parameters values |  -  |
| **404** | one of the Scenarios specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createscenario"></a>
# **CreateScenario**
> Scenario CreateScenario (string organizationId, string workspaceId, Scenario scenario)

Create a new Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class CreateScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenario = new Scenario(); // Scenario | the Scenario to create

            try
            {
                // Create a new Scenario
                Scenario result = apiInstance.CreateScenario(organizationId, workspaceId, scenario);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.CreateScenario: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 
 **scenario** | [**Scenario**](Scenario.md)| the Scenario to create | 

### Return type

[**Scenario**](Scenario.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the scenario details |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteallscenarios"></a>
# **DeleteAllScenarios**
> void DeleteAllScenarios (string organizationId, string workspaceId)

Delete all Scenarios of the Workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteAllScenariosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier

            try
            {
                // Delete all Scenarios of the Workspace
                apiInstance.DeleteAllScenarios(organizationId, workspaceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.DeleteAllScenarios: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 

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
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletescenario"></a>
# **DeleteScenario**
> void DeleteScenario (string organizationId, string workspaceId, string scenarioId)

Delete a scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier

            try
            {
                // Delete a scenario
                apiInstance.DeleteScenario(organizationId, workspaceId, scenarioId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.DeleteScenario: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 

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
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallscenarios"></a>
# **FindAllScenarios**
> List&lt;Scenario&gt; FindAllScenarios (string organizationId, string workspaceId)

List all Scenarios

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindAllScenariosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier

            try
            {
                // List all Scenarios
                List<Scenario> result = apiInstance.FindAllScenarios(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.FindAllScenarios: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 

### Return type

[**List&lt;Scenario&gt;**](Scenario.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the list of Scenarios |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findscenariobyid"></a>
# **FindScenarioById**
> Scenario FindScenarioById (string organizationId, string workspaceId, string scenarioId)

Get the details of an scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindScenarioByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier

            try
            {
                // Get the details of an scenario
                Scenario result = apiInstance.FindScenarioById(organizationId, workspaceId, scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.FindScenarioById: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 

### Return type

[**Scenario**](Scenario.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Scenario details |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscenariostree"></a>
# **GetScenariosTree**
> List&lt;Scenario&gt; GetScenariosTree (string organizationId, string workspaceId)

Get the Scenarios Tree

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetScenariosTreeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier

            try
            {
                // Get the Scenarios Tree
                List<Scenario> result = apiInstance.GetScenariosTree(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.GetScenariosTree: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 

### Return type

[**List&lt;Scenario&gt;**](Scenario.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the scenario tree |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeallscenarioparametervalues"></a>
# **RemoveAllScenarioParameterValues**
> void RemoveAllScenarioParameterValues (string organizationId, string workspaceId, string scenarioId)

Remove all Parameter Values from the Scenario specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveAllScenarioParameterValuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier

            try
            {
                // Remove all Parameter Values from the Scenario specified
                apiInstance.RemoveAllScenarioParameterValues(organizationId, workspaceId, scenarioId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.RemoveAllScenarioParameterValues: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 

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
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeallusersofscenario"></a>
# **RemoveAllUsersOfScenario**
> void RemoveAllUsersOfScenario (string organizationId, string workspaceId, string scenarioId)

Remove all users from the Scenario specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveAllUsersOfScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier

            try
            {
                // Remove all users from the Scenario specified
                apiInstance.RemoveAllUsersOfScenario(organizationId, workspaceId, scenarioId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.RemoveAllUsersOfScenario: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 

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
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuserfromscenario"></a>
# **RemoveUserFromScenario**
> void RemoveUserFromScenario (string organizationId, string workspaceId, string scenarioId, string userId)

Remove the specified user from the given Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RemoveUserFromScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier
            var userId = userId_example;  // string | the User identifier

            try
            {
                // Remove the specified user from the given Scenario
                apiInstance.RemoveUserFromScenario(organizationId, workspaceId, scenarioId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.RemoveUserFromScenario: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 
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
| **404** | the Scenario or the User specified is unknown or you don&#39;t have access to them |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatescenario"></a>
# **UpdateScenario**
> Scenario UpdateScenario (string organizationId, string workspaceId, string scenarioId, Scenario scenario)

Update a scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class UpdateScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cosmotech.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScenarioApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier
            var scenario = new Scenario(); // Scenario | the new Scenario details.

            try
            {
                // Update a scenario
                Scenario result = apiInstance.UpdateScenario(organizationId, workspaceId, scenarioId, scenario);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScenarioApi.UpdateScenario: " + e.Message );
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
 **workspaceId** | **string**| the Workspace identifier | 
 **scenarioId** | **string**| the Scenario identifier | 
 **scenario** | [**Scenario**](Scenario.md)| the new Scenario details. | 

### Return type

[**Scenario**](Scenario.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the scenario details |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

