# Com.Cosmotech - the C# library for the Cosmo Tech Plaform API

Cosmo Tech Platform API

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.4-SNAPSHOT
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://github.com/Cosmo-Tech/cosmotech-api](https://github.com/Cosmo-Tech/cosmotech-api)

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

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

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
*ConnectorApi* | [**FindConnectorById**](docs/ConnectorApi.md#findconnectorbyid) | **GET** /connectors/{connector_id} | Get the details of a connector
*ConnectorApi* | [**RegisterConnector**](docs/ConnectorApi.md#registerconnector) | **POST** /connectors | Register a new connector
*ConnectorApi* | [**UnregisterConnector**](docs/ConnectorApi.md#unregisterconnector) | **DELETE** /connectors/{connector_id} | Unregister a connector
*DatasetApi* | [**AddOrReplaceDatasetCompatibilityElements**](docs/DatasetApi.md#addorreplacedatasetcompatibilityelements) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/compatibility | Add Dataset Compatibility elements.
*DatasetApi* | [**CopyDataset**](docs/DatasetApi.md#copydataset) | **POST** /organizations/{organization_id}/datasets/copy | Copy a Dataset to another Dataset. Source must have a read capable connector and Target a write capable connector.
*DatasetApi* | [**CreateDataset**](docs/DatasetApi.md#createdataset) | **POST** /organizations/{organization_id}/datasets | Create a new Dataset
*DatasetApi* | [**DeleteDataset**](docs/DatasetApi.md#deletedataset) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id} | Delete a dataset
*DatasetApi* | [**FindAllDatasets**](docs/DatasetApi.md#findalldatasets) | **GET** /organizations/{organization_id}/datasets | List all Datasets
*DatasetApi* | [**FindDatasetById**](docs/DatasetApi.md#finddatasetbyid) | **GET** /organizations/{organization_id}/datasets/{dataset_id} | Get the details of a Dataset
*DatasetApi* | [**RemoveAllDatasetCompatibilityElements**](docs/DatasetApi.md#removealldatasetcompatibilityelements) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id}/compatibility | Remove all Dataset Compatibility elements from the Dataset specified
*DatasetApi* | [**UpdateDataset**](docs/DatasetApi.md#updatedataset) | **PATCH** /organizations/{organization_id}/datasets/{dataset_id} | Update a dataset
*OrganizationApi* | [**AddOrReplaceUsersInOrganization**](docs/OrganizationApi.md#addorreplaceusersinorganization) | **POST** /organizations/{organization_id}/users | Add (or replace) users in the Organization specified
*OrganizationApi* | [**FindAllOrganizations**](docs/OrganizationApi.md#findallorganizations) | **GET** /organizations | List all Organizations
*OrganizationApi* | [**FindOrganizationById**](docs/OrganizationApi.md#findorganizationbyid) | **GET** /organizations/{organization_id} | Get the details of an Organization
*OrganizationApi* | [**RegisterOrganization**](docs/OrganizationApi.md#registerorganization) | **POST** /organizations | Register a new organization
*OrganizationApi* | [**RemoveAllUsersInOrganization**](docs/OrganizationApi.md#removeallusersinorganization) | **DELETE** /organizations/{organization_id}/users | Remove all users from the Organization specified
*OrganizationApi* | [**RemoveUserFromOrganization**](docs/OrganizationApi.md#removeuserfromorganization) | **DELETE** /organizations/{organization_id}/users/{user_id} | Remove the specified user from the given Organization
*OrganizationApi* | [**UnregisterOrganization**](docs/OrganizationApi.md#unregisterorganization) | **DELETE** /organizations/{organization_id} | Unregister an organization
*OrganizationApi* | [**UpdateOrganization**](docs/OrganizationApi.md#updateorganization) | **PATCH** /organizations/{organization_id} | Update an Organization
*OrganizationApi* | [**UpdateSolutionsContainerRegistryByOrganizationId**](docs/OrganizationApi.md#updatesolutionscontainerregistrybyorganizationid) | **PATCH** /organizations/{organization_id}/services/solutionsContainerRegistry | Update the solutions container registry configuration for the Organization specified
*OrganizationApi* | [**UpdateStorageByOrganizationId**](docs/OrganizationApi.md#updatestoragebyorganizationid) | **PATCH** /organizations/{organization_id}/services/storage | Update storage configuration for the Organization specified
*OrganizationApi* | [**UpdateTenantCredentialsByOrganizationId**](docs/OrganizationApi.md#updatetenantcredentialsbyorganizationid) | **PATCH** /organizations/{organization_id}/services/tenantCredentials | Update tenant credentials for the Organization specified
*ScenarioApi* | [**AddOrReplaceScenarioParameterValues**](docs/ScenarioApi.md#addorreplacescenarioparametervalues) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/parameterValues | Add (or replace) Parameter Values for the Scenario specified
*ScenarioApi* | [**AddOrReplaceUsersInScenario**](docs/ScenarioApi.md#addorreplaceusersinscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/users | Add (or replace) users in the Scenario specified
*ScenarioApi* | [**CompareScenarios**](docs/ScenarioApi.md#comparescenarios) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/compare/{compared_scenario_id} | Compare the Scenario with another one and returns the difference for parameters values
*ScenarioApi* | [**CreateScenario**](docs/ScenarioApi.md#createscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios | Create a new Scenario
*ScenarioApi* | [**DeleteScenario**](docs/ScenarioApi.md#deletescenario) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Delete a scenario
*ScenarioApi* | [**FindAllScenarios**](docs/ScenarioApi.md#findallscenarios) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios | List all Scenarios
*ScenarioApi* | [**FindScenarioById**](docs/ScenarioApi.md#findscenariobyid) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Get the details of an scenario
*ScenarioApi* | [**GetScenariosTree**](docs/ScenarioApi.md#getscenariostree) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/tree | Get the Scenarios Tree
*ScenarioApi* | [**RemoveAllScenarioParameterValues**](docs/ScenarioApi.md#removeallscenarioparametervalues) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/parameterValues | Remove all Parameter Values from the Scenario specified
*ScenarioApi* | [**RemoveAllUsersOfScenario**](docs/ScenarioApi.md#removeallusersofscenario) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/users | Remove all users from the Scenario specified
*ScenarioApi* | [**RemoveUserFromScenario**](docs/ScenarioApi.md#removeuserfromscenario) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/users/{user_id} | Remove the specified user from the given Scenario
*ScenarioApi* | [**UpdateScenario**](docs/ScenarioApi.md#updatescenario) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Update a scenario
*ScenariorunApi* | [**DeleteScenarioRun**](docs/ScenariorunApi.md#deletescenariorun) | **DELETE** /organizations/{organization_id}/scenarioruns/{scenariorun_id} | Delete a scenariorun
*ScenariorunApi* | [**FindScenarioRunById**](docs/ScenariorunApi.md#findscenariorunbyid) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id} | Get the details of a scenariorun
*ScenariorunApi* | [**GetScenarioRunCumulatedLogs**](docs/ScenariorunApi.md#getscenarioruncumulatedlogs) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/cumulatedlogs | Get the cumulated logs of a scenariorun
*ScenariorunApi* | [**GetScenarioRunLogs**](docs/ScenariorunApi.md#getscenariorunlogs) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/logs | get the logs for the ScenarioRun
*ScenariorunApi* | [**GetScenarioRunStatus**](docs/ScenariorunApi.md#getscenariorunstatus) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/status | get the status for the ScenarioRun
*ScenariorunApi* | [**GetScenarioRuns**](docs/ScenariorunApi.md#getscenarioruns) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns | get the list of ScenarioRuns for the Scenario
*ScenariorunApi* | [**GetWorkspaceScenarioRuns**](docs/ScenariorunApi.md#getworkspacescenarioruns) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarioruns | get the list of ScenarioRuns for the Workspace
*ScenariorunApi* | [**RunScenario**](docs/ScenariorunApi.md#runscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/run | run a ScenarioRun for the Scenario
*ScenariorunApi* | [**SearchScenarioRuns**](docs/ScenariorunApi.md#searchscenarioruns) | **POST** /organizations/{organization_id}/scenarioruns/search | Search ScenarioRuns
*ScenariorunApi* | [**StartScenarioRunContainers**](docs/ScenariorunApi.md#startscenarioruncontainers) | **POST** /organizations/{organization_id}/scenarioruns/startcontainers | Start a new scenariorun with raw containers definition
*SolutionApi* | [**AddOrReplaceParameterGroups**](docs/SolutionApi.md#addorreplaceparametergroups) | **POST** /organizations/{organization_id}/solutions/{solution_id}/parameterGroups | Add Parameter Groups. Any item with the same ID will be overwritten
*SolutionApi* | [**AddOrReplaceParameters**](docs/SolutionApi.md#addorreplaceparameters) | **POST** /organizations/{organization_id}/solutions/{solution_id}/parameters | Add Parameters. Any item with the same ID will be overwritten
*SolutionApi* | [**AddOrReplaceRunTemplates**](docs/SolutionApi.md#addorreplaceruntemplates) | **POST** /organizations/{organization_id}/solutions/{solution_id}/runTemplates | Add Run Templates. Any item with the same ID will be overwritten
*SolutionApi* | [**CreateSolution**](docs/SolutionApi.md#createsolution) | **POST** /organizations/{organization_id}/solutions | Register a new solution
*SolutionApi* | [**DeleteSolution**](docs/SolutionApi.md#deletesolution) | **DELETE** /organizations/{organization_id}/solutions/{solution_id} | Delete a solution
*SolutionApi* | [**DeleteSolutionRunTemplate**](docs/SolutionApi.md#deletesolutionruntemplate) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/runTemplates/{run_template_id} | Remove the specified Solution Run Template
*SolutionApi* | [**FindAllSolutions**](docs/SolutionApi.md#findallsolutions) | **GET** /organizations/{organization_id}/solutions | List all Solutions
*SolutionApi* | [**FindSolutionById**](docs/SolutionApi.md#findsolutionbyid) | **GET** /organizations/{organization_id}/solutions/{solution_id} | Get the details of a solution
*SolutionApi* | [**RemoveAllRunTemplates**](docs/SolutionApi.md#removeallruntemplates) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/runTemplates | Remove all Run Templates from the Solution specified
*SolutionApi* | [**RemoveAllSolutionParameterGroups**](docs/SolutionApi.md#removeallsolutionparametergroups) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/parameterGroups | Remove all Parameter Groups from the Solution specified
*SolutionApi* | [**RemoveAllSolutionParameters**](docs/SolutionApi.md#removeallsolutionparameters) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/parameters | Remove all Parameters from the Solution specified
*SolutionApi* | [**UpdateSolution**](docs/SolutionApi.md#updatesolution) | **PATCH** /organizations/{organization_id}/solutions/{solution_id} | Update a solution
*SolutionApi* | [**UpdateSolutionRunTemplate**](docs/SolutionApi.md#updatesolutionruntemplate) | **PATCH** /organizations/{organization_id}/solutions/{solution_id}/runTemplates/{run_template_id} | Update the specified Solution Run Template
*SolutionApi* | [**UploadRunTemplateHandler**](docs/SolutionApi.md#uploadruntemplatehandler) | **POST** /organizations/{organization_id}/solutions/{solution_id}/runtemplates/{run_template_id}/handlers/{handler_id}/upload | Upload a Run Template step handler zip file
*UserApi* | [**AuthorizeUser**](docs/UserApi.md#authorizeuser) | **GET** /oauth2/authorize | Authorize an User with OAuth2. Delegated to configured OAuth2 service
*UserApi* | [**FindAllUsers**](docs/UserApi.md#findallusers) | **GET** /users | List all Users
*UserApi* | [**FindUserById**](docs/UserApi.md#finduserbyid) | **GET** /users/{user_id} | Get the details of an user
*UserApi* | [**GetCurrentUser**](docs/UserApi.md#getcurrentuser) | **GET** /users/me | Get the details of the logged-in User
*UserApi* | [**GetOrganizationCurrentUser**](docs/UserApi.md#getorganizationcurrentuser) | **GET** /organizations/{organization_id}/me | Get the details of a logged-in User with roles for an Organization
*UserApi* | [**GetWorkspaceCurrentUser**](docs/UserApi.md#getworkspacecurrentuser) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/me | Get the details of the logged-in user with roles for a Workspace
*UserApi* | [**RegisterUser**](docs/UserApi.md#registeruser) | **POST** /users | Register a new user
*UserApi* | [**TestPlatform**](docs/UserApi.md#testplatform) | **GET** /test | test platform API call
*UserApi* | [**UnregisterUser**](docs/UserApi.md#unregisteruser) | **DELETE** /users/{user_id} | Unregister an user
*UserApi* | [**UpdateUser**](docs/UserApi.md#updateuser) | **PATCH** /users/{user_id} | Update a User
*ValidatorApi* | [**CreateValidator**](docs/ValidatorApi.md#createvalidator) | **POST** /organizations/{organization_id}/datasets/validators | Register a new validator
*ValidatorApi* | [**CreateValidatorRun**](docs/ValidatorApi.md#createvalidatorrun) | **POST** /organizations/{organization_id}/datasets/validators/{validator_id}/history | Register a new validator run
*ValidatorApi* | [**DeleteValidator**](docs/ValidatorApi.md#deletevalidator) | **DELETE** /organizations/{organization_id}/datasets/validators/{validator_id} | Delete a validator
*ValidatorApi* | [**DeleteValidatorRun**](docs/ValidatorApi.md#deletevalidatorrun) | **DELETE** /organizations/{organization_id}/datasets/validators/{validator_id}/history/{validatorrun_id} | Delete a validator run
*ValidatorApi* | [**FindAllValidatorRuns**](docs/ValidatorApi.md#findallvalidatorruns) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id}/history | List all Validator Runs
*ValidatorApi* | [**FindAllValidators**](docs/ValidatorApi.md#findallvalidators) | **GET** /organizations/{organization_id}/datasets/validators | List all Validators
*ValidatorApi* | [**FindValidatorById**](docs/ValidatorApi.md#findvalidatorbyid) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id} | Get the details of a validator
*ValidatorApi* | [**FindValidatorRunById**](docs/ValidatorApi.md#findvalidatorrunbyid) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id}/history/{validatorrun_id} | Get the details of a validator run
*ValidatorApi* | [**RunValidator**](docs/ValidatorApi.md#runvalidator) | **POST** /organizations/{organization_id}/datasets/validators/{validator_id}/run | Run a Validator
*WorkspaceApi* | [**AddOrReplaceUsersInOrganizationWorkspace**](docs/WorkspaceApi.md#addorreplaceusersinorganizationworkspace) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/users | Add (or replace) users to the Workspace specified
*WorkspaceApi* | [**CreateWorkspace**](docs/WorkspaceApi.md#createworkspace) | **POST** /organizations/{organization_id}/workspaces | Create a new workspace
*WorkspaceApi* | [**DeleteAllWorkspaceFiles**](docs/WorkspaceApi.md#deleteallworkspacefiles) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/files | Delete all Workspace files
*WorkspaceApi* | [**DeleteWorkspace**](docs/WorkspaceApi.md#deleteworkspace) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id} | Delete a workspace
*WorkspaceApi* | [**DeleteWorkspaceFile**](docs/WorkspaceApi.md#deleteworkspacefile) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/files/delete | Delete a workspace file
*WorkspaceApi* | [**DownloadWorkspaceFile**](docs/WorkspaceApi.md#downloadworkspacefile) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/files/download | Download the Workspace File specified
*WorkspaceApi* | [**FindAllWorkspaceFiles**](docs/WorkspaceApi.md#findallworkspacefiles) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/files | List all Workspace files
*WorkspaceApi* | [**FindAllWorkspaces**](docs/WorkspaceApi.md#findallworkspaces) | **GET** /organizations/{organization_id}/workspaces | List all Workspaces
*WorkspaceApi* | [**FindWorkspaceById**](docs/WorkspaceApi.md#findworkspacebyid) | **GET** /organizations/{organization_id}/workspaces/{workspace_id} | Get the details of an workspace
*WorkspaceApi* | [**RemoveAllUsersOfWorkspace**](docs/WorkspaceApi.md#removeallusersofworkspace) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/users | Remove all users from the Workspace specified
*WorkspaceApi* | [**RemoveUserFromOrganizationWorkspace**](docs/WorkspaceApi.md#removeuserfromorganizationworkspace) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/users/{user_id} | Remove the specified user from the given Organization Workspace
*WorkspaceApi* | [**UpdateWorkspace**](docs/WorkspaceApi.md#updateworkspace) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id} | Update a workspace
*WorkspaceApi* | [**UploadWorkspaceFile**](docs/WorkspaceApi.md#uploadworkspacefile) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/files | Upload a file for the Workspace


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Connector](docs/Connector.md)
 - [Model.ConnectorParameter](docs/ConnectorParameter.md)
 - [Model.ConnectorParameterGroup](docs/ConnectorParameterGroup.md)
 - [Model.Dataset](docs/Dataset.md)
 - [Model.DatasetCompatibility](docs/DatasetCompatibility.md)
 - [Model.DatasetConnector](docs/DatasetConnector.md)
 - [Model.DatasetCopyParameters](docs/DatasetCopyParameters.md)
 - [Model.Organization](docs/Organization.md)
 - [Model.OrganizationService](docs/OrganizationService.md)
 - [Model.OrganizationServices](docs/OrganizationServices.md)
 - [Model.OrganizationUser](docs/OrganizationUser.md)
 - [Model.RunTemplate](docs/RunTemplate.md)
 - [Model.RunTemplateHandlerId](docs/RunTemplateHandlerId.md)
 - [Model.RunTemplateParameter](docs/RunTemplateParameter.md)
 - [Model.RunTemplateParameterGroup](docs/RunTemplateParameterGroup.md)
 - [Model.RunTemplateParameterValue](docs/RunTemplateParameterValue.md)
 - [Model.RunTemplateStepSource](docs/RunTemplateStepSource.md)
 - [Model.Scenario](docs/Scenario.md)
 - [Model.ScenarioChangedParameterValue](docs/ScenarioChangedParameterValue.md)
 - [Model.ScenarioComparisonResult](docs/ScenarioComparisonResult.md)
 - [Model.ScenarioRun](docs/ScenarioRun.md)
 - [Model.ScenarioRunContainer](docs/ScenarioRunContainer.md)
 - [Model.ScenarioRunContainerLogs](docs/ScenarioRunContainerLogs.md)
 - [Model.ScenarioRunLogs](docs/ScenarioRunLogs.md)
 - [Model.ScenarioRunSearch](docs/ScenarioRunSearch.md)
 - [Model.ScenarioRunStartContainers](docs/ScenarioRunStartContainers.md)
 - [Model.ScenarioRunStatus](docs/ScenarioRunStatus.md)
 - [Model.ScenarioRunStatusNode](docs/ScenarioRunStatusNode.md)
 - [Model.ScenarioRunTemplateParameterValue](docs/ScenarioRunTemplateParameterValue.md)
 - [Model.ScenarioUser](docs/ScenarioUser.md)
 - [Model.Solution](docs/Solution.md)
 - [Model.User](docs/User.md)
 - [Model.UserOrganization](docs/UserOrganization.md)
 - [Model.UserWorkspace](docs/UserWorkspace.md)
 - [Model.Validator](docs/Validator.md)
 - [Model.ValidatorRun](docs/ValidatorRun.md)
 - [Model.Workspace](docs/Workspace.md)
 - [Model.WorkspaceFile](docs/WorkspaceFile.md)
 - [Model.WorkspaceSolution](docs/WorkspaceSolution.md)
 - [Model.WorkspaceUser](docs/WorkspaceUser.md)
 - [Model.WorkspaceWebApp](docs/WorkspaceWebApp.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oAuth2AuthCode"></a>
### oAuth2AuthCode

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://login.microsoftonline.com/common/oauth2/v2.0/authorize
- **Scopes**: 
  - http://dev.api.cosmotech.com/platform: Platform scope

