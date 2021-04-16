# Com.Cosmotech - the C# library for the Cosmo Tech Plaform API

Cosmo Tech Platform API

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.1-SNAPSHOT
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Cosmotech.Api;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.azure.cosmo-platform.com";
            // Configure OAuth2 access token for authorization: oAuth2AuthCode
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectorApi(config);

            try
            {
                // List all Connectors
                List<Connector> result = apiInstance.FindAllConnectors();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConnectorApi.FindAllConnectors: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.azure.cosmo-platform.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ConnectorApi* | [**FindAllConnectors**](docs/ConnectorApi.md#findallconnectors) | **GET** /connectors | List all Connectors
*ConnectorApi* | [**FindConnectorById**](docs/ConnectorApi.md#findconnectorbyid) | **GET** /connectors/{connector_id} | Get the details of an connector
*ConnectorApi* | [**RegisterConnector**](docs/ConnectorApi.md#registerconnector) | **POST** /connectors | Register a new connector
*ConnectorApi* | [**UnregisterConnector**](docs/ConnectorApi.md#unregisterconnector) | **DELETE** /connectors/{connector_id} | Unregister an connector
*ConnectorApi* | [**UploadConnector**](docs/ConnectorApi.md#uploadconnector) | **POST** /connectors/upload | Upload and register a new connector
*DatasetApi* | [**CopyDataset**](docs/DatasetApi.md#copydataset) | **POST** /organizations/{organization_id}/datasets/copy | Copy a Dataset to another Dataset. Source must have a read capable connector and Target a write capable connector.
*DatasetApi* | [**CreateDataset**](docs/DatasetApi.md#createdataset) | **POST** /organizations/{organization_id}/datasets | Create a new dataset
*DatasetApi* | [**DeleteDataset**](docs/DatasetApi.md#deletedataset) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id} | Delete a dataset
*DatasetApi* | [**FindAllDatasets**](docs/DatasetApi.md#findalldatasets) | **GET** /organizations/{organization_id}/datasets | List all Datasets
*DatasetApi* | [**FindDatasetById**](docs/DatasetApi.md#finddatasetbyid) | **GET** /organizations/{organization_id}/datasets/{dataset_id} | Get the details of a dataset
*DatasetApi* | [**UpdateDataset**](docs/DatasetApi.md#updatedataset) | **PATCH** /organizations/{organization_id}/datasets/{dataset_id} | Update a dataset
*OrganizationApi* | [**FindAllOrganizations**](docs/OrganizationApi.md#findallorganizations) | **GET** /organizations | List all Organizations
*OrganizationApi* | [**FindOrganizationById**](docs/OrganizationApi.md#findorganizationbyid) | **GET** /organizations/{organization_id} | Get the details of an organization
*OrganizationApi* | [**RegisterOrganization**](docs/OrganizationApi.md#registerorganization) | **POST** /organizations | Register a new organization
*OrganizationApi* | [**UnregisterOrganization**](docs/OrganizationApi.md#unregisterorganization) | **DELETE** /organizations/{organization_id} | Unregister an organization
*OrganizationApi* | [**UpdateOrganization**](docs/OrganizationApi.md#updateorganization) | **PATCH** /organizations/{organization_id} | Update an organization
*ScenarioApi* | [**CompareScenarios**](docs/ScenarioApi.md#comparescenarios) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/compare/{compared_scenario_id} | Compare the Scenario with another one and returns the difference for parameters values
*ScenarioApi* | [**CreateScenario**](docs/ScenarioApi.md#createscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios | Create a new scenario
*ScenarioApi* | [**DeleteScenario**](docs/ScenarioApi.md#deletescenario) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Delete a scenario
*ScenarioApi* | [**FindAllScenarios**](docs/ScenarioApi.md#findallscenarios) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios | List all Scenarios
*ScenarioApi* | [**FindScenarioById**](docs/ScenarioApi.md#findscenariobyid) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Get the details of an scenario
*ScenarioApi* | [**GetScenariosTree**](docs/ScenarioApi.md#getscenariostree) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/tree | Get the Scenarios Tree
*ScenarioApi* | [**UpdateScenario**](docs/ScenarioApi.md#updatescenario) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Update a scenario
*SimulationApi* | [**DeleteSimulation**](docs/SimulationApi.md#deletesimulation) | **DELETE** /organizations/{organization_id}/simulations/{simulation_id} | Delete a simulation
*SimulationApi* | [**FindSimulationById**](docs/SimulationApi.md#findsimulationbyid) | **GET** /organizations/{organization_id}/simulations/{simulation_id} | Get the details of a simulation
*SimulationApi* | [**GetScenarioSimulation**](docs/SimulationApi.md#getscenariosimulation) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/simulations/{simulation_id} | get the Simulation for the Scenario
*SimulationApi* | [**GetScenarioSimulationLogs**](docs/SimulationApi.md#getscenariosimulationlogs) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/simulations/{simulation_id}/logs | get the logs for the Simulation
*SimulationApi* | [**GetScenarioSimulations**](docs/SimulationApi.md#getscenariosimulations) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/simulations | get the list of Simulations for the Scenario
*SimulationApi* | [**GetWorkspaceSimulations**](docs/SimulationApi.md#getworkspacesimulations) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/simulations | get the list of Simulations for the Workspace
*SimulationApi* | [**RunScenario**](docs/SimulationApi.md#runscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/run | run a Simulation for the Scenario
*SimulationApi* | [**SearchSimulationLogs**](docs/SimulationApi.md#searchsimulationlogs) | **POST** /organizations/{organization_id}/simulations/{simulation_id}/logs/search | Search the logs of a simulation
*SimulationApi* | [**SearchSimulations**](docs/SimulationApi.md#searchsimulations) | **POST** /organizations/{organization_id}/simulations/search | Search Simulations
*SimulationApi* | [**StartSimulationContainers**](docs/SimulationApi.md#startsimulationcontainers) | **POST** /organizations/{organization_id}/simulations/startcontainers | Start a new simulation with raw containers definition
*SimulationApi* | [**StartSimulationScenario**](docs/SimulationApi.md#startsimulationscenario) | **POST** /organizations/{organization_id}/simulations/start | Start a new simulation for a Scenario
*SimulationApi* | [**StartSimulationSimulator**](docs/SimulationApi.md#startsimulationsimulator) | **POST** /organizations/{organization_id}/simulations/startsimulator | Start a new simulation for a Simulator Analysis
*SimulatorApi* | [**CreateSimulator**](docs/SimulatorApi.md#createsimulator) | **POST** /organizations/{organization_id}/simulators | Register a new simulator
*SimulatorApi* | [**DeleteSimulator**](docs/SimulatorApi.md#deletesimulator) | **DELETE** /organizations/{organization_id}/simulators/{simulator_id} | Delete a simulator
*SimulatorApi* | [**FindAllSimulators**](docs/SimulatorApi.md#findallsimulators) | **GET** /organizations/{organization_id}/simulators | List all Simulators
*SimulatorApi* | [**FindSimulatorById**](docs/SimulatorApi.md#findsimulatorbyid) | **GET** /organizations/{organization_id}/simulators/{simulator_id} | Get the details of a simulator
*SimulatorApi* | [**UpdateSimulator**](docs/SimulatorApi.md#updatesimulator) | **PATCH** /organizations/{organization_id}/simulators/{simulator_id} | Update a simulator
*SimulatorApi* | [**Upload**](docs/SimulatorApi.md#upload) | **POST** /organizations/{organization_id}/simulators/upload | Upload and register a new simulator
*UserApi* | [**FindAllUsers**](docs/UserApi.md#findallusers) | **GET** /users | List all Users
*UserApi* | [**FindUserById**](docs/UserApi.md#finduserbyid) | **GET** /users/{user_id} | Get the details of an user
*UserApi* | [**GetCurrentUser**](docs/UserApi.md#getcurrentuser) | **GET** /users/me | Get the details of an user
*UserApi* | [**GetOrganizationCurrentUser**](docs/UserApi.md#getorganizationcurrentuser) | **GET** /organizations/{organization_id}/me | Get the details of an user with roles for an Organization
*UserApi* | [**GetWorkspaceCurrentUser**](docs/UserApi.md#getworkspacecurrentuser) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/me | Get the details of an user with roles for a Workspace
*UserApi* | [**RegisterUser**](docs/UserApi.md#registeruser) | **POST** /users | Register a new user
*UserApi* | [**UnregisterUser**](docs/UserApi.md#unregisteruser) | **DELETE** /users/{user_id} | Unregister an user
*UserApi* | [**UpdateUser**](docs/UserApi.md#updateuser) | **PATCH** /users/{user_id} | Update an user
*ValidatorApi* | [**CreateValidator**](docs/ValidatorApi.md#createvalidator) | **POST** /organizations/{organization_id}/datasets/validators | Register a new validator
*ValidatorApi* | [**CreateValidatorRun**](docs/ValidatorApi.md#createvalidatorrun) | **POST** /organizations/{organization_id}/datasets/validators/{validator_id}/history | Register a new validator run
*ValidatorApi* | [**DeleteValidator**](docs/ValidatorApi.md#deletevalidator) | **DELETE** /organizations/{organization_id}/datasets/validators/{validator_id} | Delete a validator
*ValidatorApi* | [**DeleteValidatorRun**](docs/ValidatorApi.md#deletevalidatorrun) | **DELETE** /organizations/{organization_id}/datasets/validators/{validator_id}/history/{validatorrun_id} | Delete a validator run
*ValidatorApi* | [**FindAllValidatorRuns**](docs/ValidatorApi.md#findallvalidatorruns) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id}/history | List all Validator Runs
*ValidatorApi* | [**FindAllValidators**](docs/ValidatorApi.md#findallvalidators) | **GET** /organizations/{organization_id}/datasets/validators | List all Validators
*ValidatorApi* | [**FindValidatorById**](docs/ValidatorApi.md#findvalidatorbyid) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id} | Get the details of a validator
*ValidatorApi* | [**FindValidatorRunById**](docs/ValidatorApi.md#findvalidatorrunbyid) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id}/history/{validatorrun_id} | Get the details of a validator run
*ValidatorApi* | [**RunValidator**](docs/ValidatorApi.md#runvalidator) | **POST** /organizations/{organization_id}/datasets/validators/{validator_id}/run | Run a Validator
*WorkspaceApi* | [**CreateWorkspace**](docs/WorkspaceApi.md#createworkspace) | **POST** /organizations/{organization_id}/workspaces | Create a new workspace
*WorkspaceApi* | [**DeleteWorkspace**](docs/WorkspaceApi.md#deleteworkspace) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id} | Delete a workspace
*WorkspaceApi* | [**FindAllWorkspaces**](docs/WorkspaceApi.md#findallworkspaces) | **GET** /organizations/{organization_id}/workspaces | List all Workspaces
*WorkspaceApi* | [**FindWorkspaceById**](docs/WorkspaceApi.md#findworkspacebyid) | **GET** /organizations/{organization_id}/workspaces/{workspace_id} | Get the details of an workspace
*WorkspaceApi* | [**UpdateWorkspace**](docs/WorkspaceApi.md#updateworkspace) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id} | Update a workspace


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AnalysisParameter](docs/AnalysisParameter.md)
 - [Model.AnalysisParameterGroup](docs/AnalysisParameterGroup.md)
 - [Model.AnalysisResourceStorage](docs/AnalysisResourceStorage.md)
 - [Model.Connector](docs/Connector.md)
 - [Model.ConnectorParameter](docs/ConnectorParameter.md)
 - [Model.ConnectorParameterGroup](docs/ConnectorParameterGroup.md)
 - [Model.Dataset](docs/Dataset.md)
 - [Model.DatasetCompatibility](docs/DatasetCompatibility.md)
 - [Model.DatasetConnector](docs/DatasetConnector.md)
 - [Model.DatasetCopyParameters](docs/DatasetCopyParameters.md)
 - [Model.Organization](docs/Organization.md)
 - [Model.OrganizationUser](docs/OrganizationUser.md)
 - [Model.Scenario](docs/Scenario.md)
 - [Model.ScenarioAllOf](docs/ScenarioAllOf.md)
 - [Model.ScenarioAnalysis](docs/ScenarioAnalysis.md)
 - [Model.ScenarioAnalysisParameterValue](docs/ScenarioAnalysisParameterValue.md)
 - [Model.ScenarioBase](docs/ScenarioBase.md)
 - [Model.ScenarioChangedParameterValue](docs/ScenarioChangedParameterValue.md)
 - [Model.ScenarioComparisonResult](docs/ScenarioComparisonResult.md)
 - [Model.ScenarioUser](docs/ScenarioUser.md)
 - [Model.Simulation](docs/Simulation.md)
 - [Model.SimulationAllOf](docs/SimulationAllOf.md)
 - [Model.SimulationAnalysisParameterValue](docs/SimulationAnalysisParameterValue.md)
 - [Model.SimulationBase](docs/SimulationBase.md)
 - [Model.SimulationContainerLog](docs/SimulationContainerLog.md)
 - [Model.SimulationContainerLogs](docs/SimulationContainerLogs.md)
 - [Model.SimulationContainers](docs/SimulationContainers.md)
 - [Model.SimulationLogs](docs/SimulationLogs.md)
 - [Model.SimulationLogsOptions](docs/SimulationLogsOptions.md)
 - [Model.SimulationSearch](docs/SimulationSearch.md)
 - [Model.SimulationStartContainers](docs/SimulationStartContainers.md)
 - [Model.SimulationStartScenario](docs/SimulationStartScenario.md)
 - [Model.SimulationStartSimulator](docs/SimulationStartSimulator.md)
 - [Model.Simulator](docs/Simulator.md)
 - [Model.SimulatorAnalysis](docs/SimulatorAnalysis.md)
 - [Model.User](docs/User.md)
 - [Model.UserDetails](docs/UserDetails.md)
 - [Model.UserDetailsAllOf](docs/UserDetailsAllOf.md)
 - [Model.UserOrganization](docs/UserOrganization.md)
 - [Model.UserWorkspace](docs/UserWorkspace.md)
 - [Model.Validator](docs/Validator.md)
 - [Model.ValidatorRun](docs/ValidatorRun.md)
 - [Model.Workspace](docs/Workspace.md)
 - [Model.WorkspaceService](docs/WorkspaceService.md)
 - [Model.WorkspaceServices](docs/WorkspaceServices.md)
 - [Model.WorkspaceSimulator](docs/WorkspaceSimulator.md)
 - [Model.WorkspaceUser](docs/WorkspaceUser.md)
 - [Model.WorkspaceUserDetails](docs/WorkspaceUserDetails.md)
 - [Model.WorkspaceUserDetailsAllOf](docs/WorkspaceUserDetailsAllOf.md)
 - [Model.WorkspaceWebApp](docs/WorkspaceWebApp.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oAuth2AuthCode"></a>
### oAuth2AuthCode

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: oauth2/authorize
- **Scopes**: N/A

