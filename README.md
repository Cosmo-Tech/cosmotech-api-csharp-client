# Com.Cosmotech - the C# library for the Cosmo Tech Platform API

Cosmo Tech Platform API

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2.3.12-SNAPSHOT
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

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
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

All URIs are relative to *https://dev.api.cosmotech.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ConnectorApi* | [**FindAllConnectors**](docs/ConnectorApi.md#findallconnectors) | **GET** /connectors | List all Connectors
*ConnectorApi* | [**FindConnectorById**](docs/ConnectorApi.md#findconnectorbyid) | **GET** /connectors/{connector_id} | Get the details of a connector
*ConnectorApi* | [**ImportConnector**](docs/ConnectorApi.md#importconnector) | **POST** /connectors/import | Import existing connector
*ConnectorApi* | [**RegisterConnector**](docs/ConnectorApi.md#registerconnector) | **POST** /connectors | Register a new connector
*ConnectorApi* | [**UnregisterConnector**](docs/ConnectorApi.md#unregisterconnector) | **DELETE** /connectors/{connector_id} | Unregister a connector
*DatasetApi* | [**AddOrReplaceDatasetCompatibilityElements**](docs/DatasetApi.md#addorreplacedatasetcompatibilityelements) | **POST** /organizations/{organization_id}/datasets/{dataset_id}/compatibility | Add Dataset Compatibility elements.
*DatasetApi* | [**CopyDataset**](docs/DatasetApi.md#copydataset) | **POST** /organizations/{organization_id}/datasets/copy | Copy a Dataset to another Dataset. Source must have a read capable connector and Target a write capable connector.
*DatasetApi* | [**CreateDataset**](docs/DatasetApi.md#createdataset) | **POST** /organizations/{organization_id}/datasets | Create a new Dataset
*DatasetApi* | [**DeleteDataset**](docs/DatasetApi.md#deletedataset) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id} | Delete a dataset
*DatasetApi* | [**FindAllDatasets**](docs/DatasetApi.md#findalldatasets) | **GET** /organizations/{organization_id}/datasets | List all Datasets
*DatasetApi* | [**FindDatasetById**](docs/DatasetApi.md#finddatasetbyid) | **GET** /organizations/{organization_id}/datasets/{dataset_id} | Get the details of a Dataset
*DatasetApi* | [**ImportDataset**](docs/DatasetApi.md#importdataset) | **POST** /organizations/{organization_id}/datasets/import | Import a new Dataset
*DatasetApi* | [**RemoveAllDatasetCompatibilityElements**](docs/DatasetApi.md#removealldatasetcompatibilityelements) | **DELETE** /organizations/{organization_id}/datasets/{dataset_id}/compatibility | Remove all Dataset Compatibility elements from the Dataset specified
*DatasetApi* | [**SearchDatasets**](docs/DatasetApi.md#searchdatasets) | **POST** /organizations/{organization_id}/datasets/search | Search Datasets
*DatasetApi* | [**UpdateDataset**](docs/DatasetApi.md#updatedataset) | **PATCH** /organizations/{organization_id}/datasets/{dataset_id} | Update a dataset
*OrganizationApi* | [**AddOrganizationAccessControl**](docs/OrganizationApi.md#addorganizationaccesscontrol) | **POST** /organizations/{organization_id}/security/access | Add a control access to the Organization
*OrganizationApi* | [**FindAllOrganizations**](docs/OrganizationApi.md#findallorganizations) | **GET** /organizations | List all Organizations
*OrganizationApi* | [**FindOrganizationById**](docs/OrganizationApi.md#findorganizationbyid) | **GET** /organizations/{organization_id} | Get the details of an Organization
*OrganizationApi* | [**GetAllPermissions**](docs/OrganizationApi.md#getallpermissions) | **GET** /organizations/permissions | Get all permissions per components
*OrganizationApi* | [**GetOrganizationAccessControl**](docs/OrganizationApi.md#getorganizationaccesscontrol) | **GET** /organizations/{organization_id}/security/access/{identity_id} | Get a control access for the Organization
*OrganizationApi* | [**GetOrganizationPermissions**](docs/OrganizationApi.md#getorganizationpermissions) | **GET** /organizations/{organization_id}/permissions/{role} | Get the Organization permissions by given role
*OrganizationApi* | [**GetOrganizationSecurity**](docs/OrganizationApi.md#getorganizationsecurity) | **GET** /organizations/{organization_id}/security | Get the Organization security information
*OrganizationApi* | [**GetOrganizationSecurityUsers**](docs/OrganizationApi.md#getorganizationsecurityusers) | **GET** /organizations/{organization_id}/security/users | Get the Organization security users list
*OrganizationApi* | [**ImportOrganization**](docs/OrganizationApi.md#importorganization) | **POST** /organizations/import | Import an organization
*OrganizationApi* | [**RegisterOrganization**](docs/OrganizationApi.md#registerorganization) | **POST** /organizations | Register a new organization
*OrganizationApi* | [**RemoveOrganizationAccessControl**](docs/OrganizationApi.md#removeorganizationaccesscontrol) | **DELETE** /organizations/{organization_id}/security/access/{identity_id} | Remove the specified access from the given Organization
*OrganizationApi* | [**SetOrganizationDefaultSecurity**](docs/OrganizationApi.md#setorganizationdefaultsecurity) | **POST** /organizations/{organization_id}/security/default | Set the Organization default security
*OrganizationApi* | [**UnregisterOrganization**](docs/OrganizationApi.md#unregisterorganization) | **DELETE** /organizations/{organization_id} | Unregister an organization
*OrganizationApi* | [**UpdateOrganization**](docs/OrganizationApi.md#updateorganization) | **PATCH** /organizations/{organization_id} | Update an Organization
*OrganizationApi* | [**UpdateOrganizationAccessControl**](docs/OrganizationApi.md#updateorganizationaccesscontrol) | **PATCH** /organizations/{organization_id}/security/access/{identity_id} | Update the specified access to User for an Organization
*OrganizationApi* | [**UpdateSolutionsContainerRegistryByOrganizationId**](docs/OrganizationApi.md#updatesolutionscontainerregistrybyorganizationid) | **PATCH** /organizations/{organization_id}/services/solutionsContainerRegistry | Update the solutions container registry configuration for the Organization specified
*OrganizationApi* | [**UpdateStorageByOrganizationId**](docs/OrganizationApi.md#updatestoragebyorganizationid) | **PATCH** /organizations/{organization_id}/services/storage | Update storage configuration for the Organization specified
*OrganizationApi* | [**UpdateTenantCredentialsByOrganizationId**](docs/OrganizationApi.md#updatetenantcredentialsbyorganizationid) | **PATCH** /organizations/{organization_id}/services/tenantCredentials | Update tenant credentials for the Organization specified
*ScenarioApi* | [**AddOrReplaceScenarioParameterValues**](docs/ScenarioApi.md#addorreplacescenarioparametervalues) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/parameterValues | Add (or replace) Parameter Values for the Scenario specified
*ScenarioApi* | [**AddScenarioAccessControl**](docs/ScenarioApi.md#addscenarioaccesscontrol) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/security/access | Add a control access to the Scenario
*ScenarioApi* | [**CompareScenarios**](docs/ScenarioApi.md#comparescenarios) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/compare/{compared_scenario_id} | Compare the Scenario with another one and returns the difference for parameters values
*ScenarioApi* | [**CreateScenario**](docs/ScenarioApi.md#createscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios | Create a new Scenario
*ScenarioApi* | [**DeleteAllScenarios**](docs/ScenarioApi.md#deleteallscenarios) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios | Delete all Scenarios of the Workspace
*ScenarioApi* | [**DeleteScenario**](docs/ScenarioApi.md#deletescenario) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Delete a scenario
*ScenarioApi* | [**DownloadScenarioData**](docs/ScenarioApi.md#downloadscenariodata) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/downloads | Download Scenario data
*ScenarioApi* | [**FindAllScenarios**](docs/ScenarioApi.md#findallscenarios) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios | List all Scenarios
*ScenarioApi* | [**FindAllScenariosByValidationStatus**](docs/ScenarioApi.md#findallscenariosbyvalidationstatus) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/{validationStatus} | List all Scenarios by validation status
*ScenarioApi* | [**FindScenarioById**](docs/ScenarioApi.md#findscenariobyid) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Get the details of an scenario
*ScenarioApi* | [**GetScenarioAccessControl**](docs/ScenarioApi.md#getscenarioaccesscontrol) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/security/access/{identity_id} | Get a control access for the Scenario
*ScenarioApi* | [**GetScenarioDataDownloadJobInfo**](docs/ScenarioApi.md#getscenariodatadownloadjobinfo) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/downloads/{download_id} | Get Scenario data download URL
*ScenarioApi* | [**GetScenarioPermissions**](docs/ScenarioApi.md#getscenariopermissions) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/permissions/{role} | Get the Scenario permission by given role
*ScenarioApi* | [**GetScenarioSecurity**](docs/ScenarioApi.md#getscenariosecurity) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/security | Get the Scenario security information
*ScenarioApi* | [**GetScenarioSecurityUsers**](docs/ScenarioApi.md#getscenariosecurityusers) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/security/users | Get the Scenario security users list
*ScenarioApi* | [**GetScenarioValidationStatusById**](docs/ScenarioApi.md#getscenariovalidationstatusbyid) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/ValidationStatus | Get the validation status of an scenario
*ScenarioApi* | [**GetScenariosTree**](docs/ScenarioApi.md#getscenariostree) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/tree | Get the Scenarios Tree
*ScenarioApi* | [**ImportScenario**](docs/ScenarioApi.md#importscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/import | Import Scenario
*ScenarioApi* | [**RemoveAllScenarioParameterValues**](docs/ScenarioApi.md#removeallscenarioparametervalues) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/parameterValues | Remove all Parameter Values from the Scenario specified
*ScenarioApi* | [**RemoveScenarioAccessControl**](docs/ScenarioApi.md#removescenarioaccesscontrol) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/security/access/{identity_id} | Remove the specified access from the given Organization Scenario
*ScenarioApi* | [**SetScenarioDefaultSecurity**](docs/ScenarioApi.md#setscenariodefaultsecurity) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/security/default | Set the Scenario default security
*ScenarioApi* | [**UpdateScenario**](docs/ScenarioApi.md#updatescenario) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id} | Update a scenario
*ScenarioApi* | [**UpdateScenarioAccessControl**](docs/ScenarioApi.md#updatescenarioaccesscontrol) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/security/access/{identity_id} | Update the specified access to User for a Scenario
*ScenariorunApi* | [**DeleteHistoricalDataOrganization**](docs/ScenariorunApi.md#deletehistoricaldataorganization) | **DELETE** /organizations/{organization_id}/scenarioruns/historicaldata | Delete all historical ScenarioRuns in the Organization
*ScenariorunApi* | [**DeleteHistoricalDataScenario**](docs/ScenariorunApi.md#deletehistoricaldatascenario) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns/historicaldata | Delete all historical ScenarioRuns in the Scenario
*ScenariorunApi* | [**DeleteHistoricalDataWorkspace**](docs/ScenariorunApi.md#deletehistoricaldataworkspace) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/scenarioruns/historicaldata | Delete all historical ScenarioRuns in the Workspace
*ScenariorunApi* | [**DeleteScenarioRun**](docs/ScenariorunApi.md#deletescenariorun) | **DELETE** /organizations/{organization_id}/scenarioruns/{scenariorun_id} | Delete a scenariorun
*ScenariorunApi* | [**FindScenarioRunById**](docs/ScenariorunApi.md#findscenariorunbyid) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id} | Get the details of a scenariorun
*ScenariorunApi* | [**GetScenarioRunCumulatedLogs**](docs/ScenariorunApi.md#getscenarioruncumulatedlogs) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/cumulatedlogs | Get the cumulated logs of a scenariorun
*ScenariorunApi* | [**GetScenarioRunLogs**](docs/ScenariorunApi.md#getscenariorunlogs) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/logs | get the logs for the ScenarioRun
*ScenariorunApi* | [**GetScenarioRunStatus**](docs/ScenariorunApi.md#getscenariorunstatus) | **GET** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/status | get the status for the ScenarioRun
*ScenariorunApi* | [**GetScenarioRuns**](docs/ScenariorunApi.md#getscenarioruns) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns | get the list of ScenarioRuns for the Scenario
*ScenariorunApi* | [**GetWorkspaceScenarioRuns**](docs/ScenariorunApi.md#getworkspacescenarioruns) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarioruns | get the list of ScenarioRuns for the Workspace
*ScenariorunApi* | [**ImportScenarioRun**](docs/ScenariorunApi.md#importscenariorun) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/run/import | import a ScenarioRun for the Scenario
*ScenariorunApi* | [**RunScenario**](docs/ScenariorunApi.md#runscenario) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/run | run a ScenarioRun for the Scenario
*ScenariorunApi* | [**SearchScenarioRuns**](docs/ScenariorunApi.md#searchscenarioruns) | **POST** /organizations/{organization_id}/scenarioruns/search | Search ScenarioRuns
*ScenariorunApi* | [**StartScenarioRunContainers**](docs/ScenariorunApi.md#startscenarioruncontainers) | **POST** /organizations/{organization_id}/scenarioruns/startcontainers | Start a new scenariorun with raw containers definition
*ScenariorunApi* | [**StopScenarioRun**](docs/ScenariorunApi.md#stopscenariorun) | **POST** /organizations/{organization_id}/scenarioruns/{scenariorun_id}/stop | stop a ScenarioRun for the Scenario
*ScenariorunresultApi* | [**GetScenarioRunResult**](docs/ScenariorunresultApi.md#getscenariorunresult) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns/{scenariorun_id}/probes/{probe_id} | Get a ScenarioRunResult in the Organization
*ScenariorunresultApi* | [**SendScenarioRunResult**](docs/ScenariorunresultApi.md#sendscenariorunresult) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/scenarios/{scenario_id}/scenarioruns/{scenariorun_id}/probes/{probe_id} | Create a new ScenarioRunResult in the Organization
*SolutionApi* | [**AddOrReplaceParameterGroups**](docs/SolutionApi.md#addorreplaceparametergroups) | **POST** /organizations/{organization_id}/solutions/{solution_id}/parameterGroups | Add Parameter Groups. Any item with the same ID will be overwritten
*SolutionApi* | [**AddOrReplaceParameters**](docs/SolutionApi.md#addorreplaceparameters) | **POST** /organizations/{organization_id}/solutions/{solution_id}/parameters | Add Parameters. Any item with the same ID will be overwritten
*SolutionApi* | [**AddOrReplaceRunTemplates**](docs/SolutionApi.md#addorreplaceruntemplates) | **POST** /organizations/{organization_id}/solutions/{solution_id}/runTemplates | Add Run Templates. Any item with the same ID will be overwritten
*SolutionApi* | [**CreateSolution**](docs/SolutionApi.md#createsolution) | **POST** /organizations/{organization_id}/solutions | Register a new solution
*SolutionApi* | [**DeleteSolution**](docs/SolutionApi.md#deletesolution) | **DELETE** /organizations/{organization_id}/solutions/{solution_id} | Delete a solution
*SolutionApi* | [**DeleteSolutionRunTemplate**](docs/SolutionApi.md#deletesolutionruntemplate) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/runTemplates/{run_template_id} | Remove the specified Solution Run Template
*SolutionApi* | [**DownloadRunTemplateHandler**](docs/SolutionApi.md#downloadruntemplatehandler) | **GET** /organizations/{organization_id}/solutions/{solution_id}/runtemplates/{run_template_id}/handlers/{handler_id}/download | Download a Run Template step handler zip file
*SolutionApi* | [**FindAllSolutions**](docs/SolutionApi.md#findallsolutions) | **GET** /organizations/{organization_id}/solutions | List all Solutions
*SolutionApi* | [**FindSolutionById**](docs/SolutionApi.md#findsolutionbyid) | **GET** /organizations/{organization_id}/solutions/{solution_id} | Get the details of a solution
*SolutionApi* | [**ImportSolution**](docs/SolutionApi.md#importsolution) | **POST** /organizations/{organization_id}/solutions/import | Import a solution
*SolutionApi* | [**RemoveAllRunTemplates**](docs/SolutionApi.md#removeallruntemplates) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/runTemplates | Remove all Run Templates from the Solution specified
*SolutionApi* | [**RemoveAllSolutionParameterGroups**](docs/SolutionApi.md#removeallsolutionparametergroups) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/parameterGroups | Remove all Parameter Groups from the Solution specified
*SolutionApi* | [**RemoveAllSolutionParameters**](docs/SolutionApi.md#removeallsolutionparameters) | **DELETE** /organizations/{organization_id}/solutions/{solution_id}/parameters | Remove all Parameters from the Solution specified
*SolutionApi* | [**UpdateSolution**](docs/SolutionApi.md#updatesolution) | **PATCH** /organizations/{organization_id}/solutions/{solution_id} | Update a solution
*SolutionApi* | [**UpdateSolutionRunTemplate**](docs/SolutionApi.md#updatesolutionruntemplate) | **PATCH** /organizations/{organization_id}/solutions/{solution_id}/runTemplates/{run_template_id} | Update the specified Solution Run Template
*SolutionApi* | [**UploadRunTemplateHandler**](docs/SolutionApi.md#uploadruntemplatehandler) | **POST** /organizations/{organization_id}/solutions/{solution_id}/runtemplates/{run_template_id}/handlers/{handler_id}/upload | Upload a Run Template step handler zip file
*TwingraphApi* | [**BatchQuery**](docs/TwingraphApi.md#batchquery) | **POST** /organizations/{organization_id}/twingraph/{graph_id}/batch-query | Run a query on a graph instance and return the result as a zip file in async mode
*TwingraphApi* | [**BatchUploadUpdate**](docs/TwingraphApi.md#batchuploadupdate) | **POST** /organizations/{organization_id}/twingraph/{graph_id}/batch | Async batch update by loading a CSV file on a graph instance 
*TwingraphApi* | [**CreateEntities**](docs/TwingraphApi.md#createentities) | **POST** /organizations/{organization_id}/twingraph/{graph_id}/entity/{type} | Create new entities in a graph instance
*TwingraphApi* | [**CreateGraph**](docs/TwingraphApi.md#creategraph) | **POST** /organizations/{organization_id}/twingraph/{graph_id} | Create a new graph
*TwingraphApi* | [**Delete**](docs/TwingraphApi.md#delete) | **DELETE** /organizations/{organization_id}/twingraph/{graph_id} | Delete all versions of a graph and his metadatas
*TwingraphApi* | [**DeleteEntities**](docs/TwingraphApi.md#deleteentities) | **DELETE** /organizations/{organization_id}/twingraph/{graph_id}/entity/{type} | Delete entities in a graph instance
*TwingraphApi* | [**DownloadGraph**](docs/TwingraphApi.md#downloadgraph) | **GET** /organizations/{organization_id}/twingraph/download/{hash} | Download a graph compressed in a zip file
*TwingraphApi* | [**FindAllTwingraphs**](docs/TwingraphApi.md#findalltwingraphs) | **GET** /organizations/{organization_id}/twingraphs | Return the list of all graphs stored in the organization
*TwingraphApi* | [**GetEntities**](docs/TwingraphApi.md#getentities) | **GET** /organizations/{organization_id}/twingraph/{graph_id}/entity/{type} | Get entities in a graph instance
*TwingraphApi* | [**GetGraphMetaData**](docs/TwingraphApi.md#getgraphmetadata) | **GET** /organizations/{organization_id}/twingraph/{graph_id}/metadata | Return the metaData of the specified graph
*TwingraphApi* | [**ImportGraph**](docs/TwingraphApi.md#importgraph) | **POST** /organizations/{organization_id}/twingraph/import | Import a new version of a twin graph
*TwingraphApi* | [**JobStatus**](docs/TwingraphApi.md#jobstatus) | **GET** /organizations/{organization_id}/job/{job_id}/status | Get the status of a job
*TwingraphApi* | [**Query**](docs/TwingraphApi.md#query) | **POST** /organizations/{organization_id}/twingraph/{graph_id}/query | Run a query on a graph instance
*TwingraphApi* | [**UpdateEntities**](docs/TwingraphApi.md#updateentities) | **PATCH** /organizations/{organization_id}/twingraph/{graph_id}/entity/{type} | Update entities in a graph instance
*TwingraphApi* | [**UpdateGraphMetaData**](docs/TwingraphApi.md#updategraphmetadata) | **PATCH** /organizations/{organization_id}/twingraph/{graph_id}/metadata | Update the metaData of the specified graph
*ValidatorApi* | [**CreateValidator**](docs/ValidatorApi.md#createvalidator) | **POST** /organizations/{organization_id}/datasets/validators | Register a new validator
*ValidatorApi* | [**CreateValidatorRun**](docs/ValidatorApi.md#createvalidatorrun) | **POST** /organizations/{organization_id}/datasets/validators/{validator_id}/history | Register a new validator run
*ValidatorApi* | [**DeleteValidator**](docs/ValidatorApi.md#deletevalidator) | **DELETE** /organizations/{organization_id}/datasets/validators/{validator_id} | Delete a validator
*ValidatorApi* | [**DeleteValidatorRun**](docs/ValidatorApi.md#deletevalidatorrun) | **DELETE** /organizations/{organization_id}/datasets/validators/{validator_id}/history/{validatorrun_id} | Delete a validator run
*ValidatorApi* | [**FindAllValidatorRuns**](docs/ValidatorApi.md#findallvalidatorruns) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id}/history | List all Validator Runs
*ValidatorApi* | [**FindAllValidators**](docs/ValidatorApi.md#findallvalidators) | **GET** /organizations/{organization_id}/datasets/validators | List all Validators
*ValidatorApi* | [**FindValidatorById**](docs/ValidatorApi.md#findvalidatorbyid) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id} | Get the details of a validator
*ValidatorApi* | [**FindValidatorRunById**](docs/ValidatorApi.md#findvalidatorrunbyid) | **GET** /organizations/{organization_id}/datasets/validators/{validator_id}/history/{validatorrun_id} | Get the details of a validator run
*ValidatorApi* | [**RunValidator**](docs/ValidatorApi.md#runvalidator) | **POST** /organizations/{organization_id}/datasets/validators/{validator_id}/run | Run a Validator
*WorkspaceApi* | [**AddWorkspaceAccessControl**](docs/WorkspaceApi.md#addworkspaceaccesscontrol) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/security/access | Add a control access to the Workspace
*WorkspaceApi* | [**CreateSecret**](docs/WorkspaceApi.md#createsecret) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/secret | Create a secret for the Workspace
*WorkspaceApi* | [**CreateWorkspace**](docs/WorkspaceApi.md#createworkspace) | **POST** /organizations/{organization_id}/workspaces | Create a new workspace
*WorkspaceApi* | [**DeleteAllWorkspaceFiles**](docs/WorkspaceApi.md#deleteallworkspacefiles) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/files | Delete all Workspace files
*WorkspaceApi* | [**DeleteWorkspace**](docs/WorkspaceApi.md#deleteworkspace) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id} | Delete a workspace
*WorkspaceApi* | [**DeleteWorkspaceFile**](docs/WorkspaceApi.md#deleteworkspacefile) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/files/delete | Delete a workspace file
*WorkspaceApi* | [**DownloadWorkspaceFile**](docs/WorkspaceApi.md#downloadworkspacefile) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/files/download | Download the Workspace File specified
*WorkspaceApi* | [**FindAllWorkspaceFiles**](docs/WorkspaceApi.md#findallworkspacefiles) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/files | List all Workspace files
*WorkspaceApi* | [**FindAllWorkspaces**](docs/WorkspaceApi.md#findallworkspaces) | **GET** /organizations/{organization_id}/workspaces | List all Workspaces
*WorkspaceApi* | [**FindWorkspaceById**](docs/WorkspaceApi.md#findworkspacebyid) | **GET** /organizations/{organization_id}/workspaces/{workspace_id} | Get the details of an workspace
*WorkspaceApi* | [**GetWorkspaceAccessControl**](docs/WorkspaceApi.md#getworkspaceaccesscontrol) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/security/access/{identity_id} | Get a control access for the Workspace
*WorkspaceApi* | [**GetWorkspacePermissions**](docs/WorkspaceApi.md#getworkspacepermissions) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/permissions/{role} | Get the Workspace permission by given role
*WorkspaceApi* | [**GetWorkspaceSecurity**](docs/WorkspaceApi.md#getworkspacesecurity) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/security | Get the Workspace security information
*WorkspaceApi* | [**GetWorkspaceSecurityUsers**](docs/WorkspaceApi.md#getworkspacesecurityusers) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/security/users | Get the Workspace security users list
*WorkspaceApi* | [**ImportWorkspace**](docs/WorkspaceApi.md#importworkspace) | **POST** /organizations/{organization_id}/workspaces/import | Import a workspace
*WorkspaceApi* | [**RemoveWorkspaceAccessControl**](docs/WorkspaceApi.md#removeworkspaceaccesscontrol) | **DELETE** /organizations/{organization_id}/workspaces/{workspace_id}/security/access/{identity_id} | Remove the specified access from the given Organization Workspace
*WorkspaceApi* | [**SetWorkspaceDefaultSecurity**](docs/WorkspaceApi.md#setworkspacedefaultsecurity) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/security/default | Set the Workspace default security
*WorkspaceApi* | [**UpdateWorkspace**](docs/WorkspaceApi.md#updateworkspace) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id} | Update a workspace
*WorkspaceApi* | [**UpdateWorkspaceAccessControl**](docs/WorkspaceApi.md#updateworkspaceaccesscontrol) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/security/access/{identity_id} | Update the specified access to User for a Workspace
*WorkspaceApi* | [**UploadWorkspaceFile**](docs/WorkspaceApi.md#uploadworkspacefile) | **POST** /organizations/{organization_id}/workspaces/{workspace_id}/files | Upload a file for the Workspace


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ComponentRolePermissions](docs/ComponentRolePermissions.md)
 - [Model.Connector](docs/Connector.md)
 - [Model.ConnectorParameter](docs/ConnectorParameter.md)
 - [Model.ConnectorParameterGroup](docs/ConnectorParameterGroup.md)
 - [Model.ContainerResourceSizeInfo](docs/ContainerResourceSizeInfo.md)
 - [Model.ContainerResourceSizing](docs/ContainerResourceSizing.md)
 - [Model.Dataset](docs/Dataset.md)
 - [Model.DatasetCompatibility](docs/DatasetCompatibility.md)
 - [Model.DatasetConnector](docs/DatasetConnector.md)
 - [Model.DatasetCopyParameters](docs/DatasetCopyParameters.md)
 - [Model.DatasetSearch](docs/DatasetSearch.md)
 - [Model.DeleteHistoricalData](docs/DeleteHistoricalData.md)
 - [Model.GraphProperties](docs/GraphProperties.md)
 - [Model.Organization](docs/Organization.md)
 - [Model.OrganizationAccessControl](docs/OrganizationAccessControl.md)
 - [Model.OrganizationRole](docs/OrganizationRole.md)
 - [Model.OrganizationSecurity](docs/OrganizationSecurity.md)
 - [Model.OrganizationService](docs/OrganizationService.md)
 - [Model.OrganizationServices](docs/OrganizationServices.md)
 - [Model.ResourceSizeInfo](docs/ResourceSizeInfo.md)
 - [Model.RunTemplate](docs/RunTemplate.md)
 - [Model.RunTemplateHandlerId](docs/RunTemplateHandlerId.md)
 - [Model.RunTemplateOrchestrator](docs/RunTemplateOrchestrator.md)
 - [Model.RunTemplateParameter](docs/RunTemplateParameter.md)
 - [Model.RunTemplateParameterGroup](docs/RunTemplateParameterGroup.md)
 - [Model.RunTemplateParameterValue](docs/RunTemplateParameterValue.md)
 - [Model.RunTemplateResourceSizing](docs/RunTemplateResourceSizing.md)
 - [Model.RunTemplateStepSource](docs/RunTemplateStepSource.md)
 - [Model.Scenario](docs/Scenario.md)
 - [Model.ScenarioAccessControl](docs/ScenarioAccessControl.md)
 - [Model.ScenarioChangedParameterValue](docs/ScenarioChangedParameterValue.md)
 - [Model.ScenarioComparisonResult](docs/ScenarioComparisonResult.md)
 - [Model.ScenarioDataDownloadInfo](docs/ScenarioDataDownloadInfo.md)
 - [Model.ScenarioDataDownloadJob](docs/ScenarioDataDownloadJob.md)
 - [Model.ScenarioJobState](docs/ScenarioJobState.md)
 - [Model.ScenarioLastRun](docs/ScenarioLastRun.md)
 - [Model.ScenarioResourceSizing](docs/ScenarioResourceSizing.md)
 - [Model.ScenarioRole](docs/ScenarioRole.md)
 - [Model.ScenarioRun](docs/ScenarioRun.md)
 - [Model.ScenarioRunContainer](docs/ScenarioRunContainer.md)
 - [Model.ScenarioRunContainerArtifact](docs/ScenarioRunContainerArtifact.md)
 - [Model.ScenarioRunContainerLogs](docs/ScenarioRunContainerLogs.md)
 - [Model.ScenarioRunLogs](docs/ScenarioRunLogs.md)
 - [Model.ScenarioRunResourceRequested](docs/ScenarioRunResourceRequested.md)
 - [Model.ScenarioRunResult](docs/ScenarioRunResult.md)
 - [Model.ScenarioRunSearch](docs/ScenarioRunSearch.md)
 - [Model.ScenarioRunStartContainers](docs/ScenarioRunStartContainers.md)
 - [Model.ScenarioRunState](docs/ScenarioRunState.md)
 - [Model.ScenarioRunStatus](docs/ScenarioRunStatus.md)
 - [Model.ScenarioRunStatusNode](docs/ScenarioRunStatusNode.md)
 - [Model.ScenarioRunTemplateParameterValue](docs/ScenarioRunTemplateParameterValue.md)
 - [Model.ScenarioSecurity](docs/ScenarioSecurity.md)
 - [Model.ScenarioValidationStatus](docs/ScenarioValidationStatus.md)
 - [Model.Solution](docs/Solution.md)
 - [Model.SourceInfo](docs/SourceInfo.md)
 - [Model.TwinGraphBatchResult](docs/TwinGraphBatchResult.md)
 - [Model.TwinGraphHash](docs/TwinGraphHash.md)
 - [Model.TwinGraphImport](docs/TwinGraphImport.md)
 - [Model.TwinGraphImportInfo](docs/TwinGraphImportInfo.md)
 - [Model.TwinGraphQuery](docs/TwinGraphQuery.md)
 - [Model.Validator](docs/Validator.md)
 - [Model.ValidatorRun](docs/ValidatorRun.md)
 - [Model.Workspace](docs/Workspace.md)
 - [Model.WorkspaceAccessControl](docs/WorkspaceAccessControl.md)
 - [Model.WorkspaceFile](docs/WorkspaceFile.md)
 - [Model.WorkspaceRole](docs/WorkspaceRole.md)
 - [Model.WorkspaceSecret](docs/WorkspaceSecret.md)
 - [Model.WorkspaceSecurity](docs/WorkspaceSecurity.md)
 - [Model.WorkspaceSolution](docs/WorkspaceSolution.md)
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

