# Com.Cosmotech.Api.SimulationApi

All URIs are relative to *https://api.azure.cosmo-platform.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSimulation**](SimulationApi.md#deletesimulation) | **DELETE** /organizations/{organization_id}/simulations/{simulation_id} | Delete a simulation
[**FindSimulationById**](SimulationApi.md#findsimulationbyid) | **GET** /organizations/{organization_id}/simulations/{simulation_id} | Get the details of a simulation
[**GetScenarioSimulation**](SimulationApi.md#getscenariosimulation) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/simulations/{simulation_id} | get the Simulation for the Scenario
[**GetScenarioSimulationLogs**](SimulationApi.md#getscenariosimulationlogs) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/simulations/{simulation_id}/logs | get the logs for the Simulation
[**GetScenarioSimulations**](SimulationApi.md#getscenariosimulations) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/simulations | get the list of Simulations for the Scenario
[**GetWorkspaceSimulations**](SimulationApi.md#getworkspacesimulations) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/simulations | get the list of Simulations for the Workspace
[**RunScenario**](SimulationApi.md#runscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/run | run a Simulation for the Scenario
[**SearchSimulationLogs**](SimulationApi.md#searchsimulationlogs) | **POST** /organizations/{organization_id}/simulations/{simulation_id}/logs/search | Search the logs of a simulation
[**SearchSimulations**](SimulationApi.md#searchsimulations) | **POST** /organizations/{organization_id}/simulations/search | Search Simulations
[**StartSimulationContainers**](SimulationApi.md#startsimulationcontainers) | **POST** /organizations/{organization_id}/simulations/startcontainers | Start a new simulation with raw containers definition
[**StartSimulationScenario**](SimulationApi.md#startsimulationscenario) | **POST** /organizations/{organization_id}/simulations/start | Start a new simulation for a Scenario
[**StartSimulationSimulator**](SimulationApi.md#startsimulationsimulator) | **POST** /organizations/{organization_id}/simulations/startsimulator | Start a new simulation for a Simulator Analysis


<a name="deletesimulation"></a>
# **DeleteSimulation**
> Simulation DeleteSimulation (string organizationId, string simulationId)

Delete a simulation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class DeleteSimulationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulationId = simulationId_example;  // string | the Simulation identifier

            try
            {
                // Delete a simulation
                Simulation result = apiInstance.DeleteSimulation(organizationId, simulationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.DeleteSimulation: " + e.Message );
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
 **simulationId** | **string**| the Simulation identifier | 

### Return type

[**Simulation**](Simulation.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the simulation details |  -  |
| **400** | Bad request |  -  |
| **404** | the Simulation specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findsimulationbyid"></a>
# **FindSimulationById**
> Simulation FindSimulationById (string organizationId, string simulationId)

Get the details of a simulation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class FindSimulationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulationId = simulationId_example;  // string | the Simulation identifier

            try
            {
                // Get the details of a simulation
                Simulation result = apiInstance.FindSimulationById(organizationId, simulationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.FindSimulationById: " + e.Message );
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
 **simulationId** | **string**| the Simulation identifier | 

### Return type

[**Simulation**](Simulation.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Simulation details |  -  |
| **404** | the Simulation specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscenariosimulation"></a>
# **GetScenarioSimulation**
> Simulation GetScenarioSimulation (string organizationId, string workspaceId, string scenarioId, string simulationId)

get the Simulation for the Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetScenarioSimulationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier
            var simulationId = simulationId_example;  // string | the Simulation identifier

            try
            {
                // get the Simulation for the Scenario
                Simulation result = apiInstance.GetScenarioSimulation(organizationId, workspaceId, scenarioId, simulationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.GetScenarioSimulation: " + e.Message );
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
 **simulationId** | **string**| the Simulation identifier | 

### Return type

[**Simulation**](Simulation.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the simulation details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscenariosimulationlogs"></a>
# **GetScenarioSimulationLogs**
> SimulationLogs GetScenarioSimulationLogs (string organizationId, string workspaceId, string scenarioId, string simulationId)

get the logs for the Simulation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetScenarioSimulationLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier
            var simulationId = simulationId_example;  // string | the Simulation identifier

            try
            {
                // get the logs for the Simulation
                SimulationLogs result = apiInstance.GetScenarioSimulationLogs(organizationId, workspaceId, scenarioId, simulationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.GetScenarioSimulationLogs: " + e.Message );
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
 **simulationId** | **string**| the Simulation identifier | 

### Return type

[**SimulationLogs**](SimulationLogs.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the simulation logs details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscenariosimulations"></a>
# **GetScenarioSimulations**
> List&lt;SimulationBase&gt; GetScenarioSimulations (string organizationId, string workspaceId, string scenarioId)

get the list of Simulations for the Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetScenarioSimulationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier

            try
            {
                // get the list of Simulations for the Scenario
                List<SimulationBase> result = apiInstance.GetScenarioSimulations(organizationId, workspaceId, scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.GetScenarioSimulations: " + e.Message );
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

[**List&lt;SimulationBase&gt;**](SimulationBase.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the simulation details list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacesimulations"></a>
# **GetWorkspaceSimulations**
> List&lt;SimulationBase&gt; GetWorkspaceSimulations (string organizationId, string workspaceId)

get the list of Simulations for the Workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class GetWorkspaceSimulationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier

            try
            {
                // get the list of Simulations for the Workspace
                List<SimulationBase> result = apiInstance.GetWorkspaceSimulations(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.GetWorkspaceSimulations: " + e.Message );
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

[**List&lt;SimulationBase&gt;**](SimulationBase.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the simulation details list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runscenario"></a>
# **RunScenario**
> SimulationBase RunScenario (string organizationId, string workspaceId, string scenarioId)

run a Simulation for the Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class RunScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var workspaceId = workspaceId_example;  // string | the Workspace identifier
            var scenarioId = scenarioId_example;  // string | the Scenario identifier

            try
            {
                // run a Simulation for the Scenario
                SimulationBase result = apiInstance.RunScenario(organizationId, workspaceId, scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.RunScenario: " + e.Message );
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

[**SimulationBase**](SimulationBase.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the simulation details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchsimulationlogs"></a>
# **SearchSimulationLogs**
> SimulationLogs SearchSimulationLogs (string organizationId, string simulationId, SimulationLogsOptions simulationLogsOptions)

Search the logs of a simulation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class SearchSimulationLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulationId = simulationId_example;  // string | the Simulation identifier
            var simulationLogsOptions = new SimulationLogsOptions(); // SimulationLogsOptions | the options to search logs

            try
            {
                // Search the logs of a simulation
                SimulationLogs result = apiInstance.SearchSimulationLogs(organizationId, simulationId, simulationLogsOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.SearchSimulationLogs: " + e.Message );
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
 **simulationId** | **string**| the Simulation identifier | 
 **simulationLogsOptions** | [**SimulationLogsOptions**](SimulationLogsOptions.md)| the options to search logs | 

### Return type

[**SimulationLogs**](SimulationLogs.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the Simulation logs |  -  |
| **400** | Bad request |  -  |
| **404** | the Simulation specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchsimulations"></a>
# **SearchSimulations**
> List&lt;SimulationBase&gt; SearchSimulations (string organizationId, SimulationSearch simulationSearch)

Search Simulations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class SearchSimulationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulationSearch = new SimulationSearch(); // SimulationSearch | the Simulation search parameters

            try
            {
                // Search Simulations
                List<SimulationBase> result = apiInstance.SearchSimulations(organizationId, simulationSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.SearchSimulations: " + e.Message );
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
 **simulationSearch** | [**SimulationSearch**](SimulationSearch.md)| the Simulation search parameters | 

### Return type

[**List&lt;SimulationBase&gt;**](SimulationBase.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the simulation details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startsimulationcontainers"></a>
# **StartSimulationContainers**
> Simulation StartSimulationContainers (string organizationId, SimulationStartContainers simulationStartContainers)

Start a new simulation with raw containers definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class StartSimulationContainersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulationStartContainers = new SimulationStartContainers(); // SimulationStartContainers | the raw containers definition

            try
            {
                // Start a new simulation with raw containers definition
                Simulation result = apiInstance.StartSimulationContainers(organizationId, simulationStartContainers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.StartSimulationContainers: " + e.Message );
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
 **simulationStartContainers** | [**SimulationStartContainers**](SimulationStartContainers.md)| the raw containers definition | 

### Return type

[**Simulation**](Simulation.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | the simulation details |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startsimulationscenario"></a>
# **StartSimulationScenario**
> Simulation StartSimulationScenario (string organizationId, SimulationStartScenario simulationStartScenario)

Start a new simulation for a Scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class StartSimulationScenarioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulationStartScenario = new SimulationStartScenario(); // SimulationStartScenario | the Scenario information to start

            try
            {
                // Start a new simulation for a Scenario
                Simulation result = apiInstance.StartSimulationScenario(organizationId, simulationStartScenario);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.StartSimulationScenario: " + e.Message );
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
 **simulationStartScenario** | [**SimulationStartScenario**](SimulationStartScenario.md)| the Scenario information to start | 

### Return type

[**Simulation**](Simulation.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | the simulation details |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startsimulationsimulator"></a>
# **StartSimulationSimulator**
> Simulation StartSimulationSimulator (string organizationId, SimulationStartSimulator simulationStartSimulator)

Start a new simulation for a Simulator Analysis

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class StartSimulationSimulatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SimulationApi(config);
            var organizationId = organizationId_example;  // string | the Organization identifier
            var simulationStartSimulator = new SimulationStartSimulator(); // SimulationStartSimulator | the Simulator Analysis information to start

            try
            {
                // Start a new simulation for a Simulator Analysis
                Simulation result = apiInstance.StartSimulationSimulator(organizationId, simulationStartSimulator);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimulationApi.StartSimulationSimulator: " + e.Message );
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
 **simulationStartSimulator** | [**SimulationStartSimulator**](SimulationStartSimulator.md)| the Simulator Analysis information to start | 

### Return type

[**Simulation**](Simulation.md)

### Authorization

[oAuth2AuthCode](../README.md#oAuth2AuthCode)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | the simulation details |  -  |
| **400** | Bad request |  -  |
| **404** | the Scenario specified is unknown or you don&#39;t have access to it |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

