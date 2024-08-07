/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 4.0.3-SNAPSHOT
 * Contact: platform@cosmotech.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Cosmotech.Client.OpenAPIDateConverter;

namespace Com.Cosmotech.Model
{
    /// <summary>
    /// a Workspace
    /// </summary>
    [DataContract(Name = "Workspace")]
    public partial class Workspace : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Workspace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Workspace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Workspace" /> class.
        /// </summary>
        /// <param name="key">technical key for resource name convention and version grouping. Must be unique (required).</param>
        /// <param name="name">Workspace name. This name is display in the sample webApp (required).</param>
        /// <param name="description">the Workspace description.</param>
        /// <param name="linkedDatasetIdList">list of dataset linked to this dataset.</param>
        /// <param name="varVersion">the Workspace version MAJOR.MINOR.PATCH..</param>
        /// <param name="tags">the list of tags.</param>
        /// <param name="solution">solution (required).</param>
        /// <param name="webApp">webApp.</param>
        /// <param name="sendInputToDataWarehouse">default setting for all Scenarios and Run Templates to set whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to the ScenarioRun.</param>
        /// <param name="useDedicatedEventHubNamespace">Set this property to true to use a dedicated Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;probesmeasures\\&#39; and \\&#39;scenariorun\\&#39;. (default to false).</param>
        /// <param name="dedicatedEventHubSasKeyName">the Dedicated Event Hub SAS key name, default to RootManageSharedAccessKey. Use the /secret endpoint to set the key value.</param>
        /// <param name="dedicatedEventHubAuthenticationStrategy">the Event Hub authentication strategy, SHARED_ACCESS_POLICY or TENANT_CLIENT_CREDENTIALS. Default to the one defined for the tenant..</param>
        /// <param name="sendScenarioRunToEventHub">default setting for all Scenarios and Run Templates to set whether or not the ScenarioRun is send to the Event Hub (default to true).</param>
        /// <param name="sendScenarioMetadataToEventHub">Set this property to false to not send scenario metada to Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;scenariometadata\\&#39; and \\&#39;scenariorunmetadata\\&#39;. (default to false).</param>
        /// <param name="datasetCopy">Activate the copy of dataset on scenario creation, meaning that each scenario created in this workspace will make this copy. when false, scenario use directly the dataset specified. (default to true).</param>
        /// <param name="security">security.</param>
        public Workspace(string key = default(string), string name = default(string), string description = default(string), List<string> linkedDatasetIdList = default(List<string>), string varVersion = default(string), List<string> tags = default(List<string>), WorkspaceSolution solution = default(WorkspaceSolution), WorkspaceWebApp webApp = default(WorkspaceWebApp), bool sendInputToDataWarehouse = default(bool), bool useDedicatedEventHubNamespace = false, string dedicatedEventHubSasKeyName = default(string), string dedicatedEventHubAuthenticationStrategy = default(string), bool sendScenarioRunToEventHub = true, bool sendScenarioMetadataToEventHub = false, bool datasetCopy = true, WorkspaceSecurity security = default(WorkspaceSecurity))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for Workspace and cannot be null");
            }
            this.Key = key;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Workspace and cannot be null");
            }
            this.Name = name;
            // to ensure "solution" is required (not null)
            if (solution == null)
            {
                throw new ArgumentNullException("solution is a required property for Workspace and cannot be null");
            }
            this.Solution = solution;
            this.Description = description;
            this.LinkedDatasetIdList = linkedDatasetIdList;
            this.VarVersion = varVersion;
            this.Tags = tags;
            this.WebApp = webApp;
            this.SendInputToDataWarehouse = sendInputToDataWarehouse;
            this.UseDedicatedEventHubNamespace = useDedicatedEventHubNamespace;
            this.DedicatedEventHubSasKeyName = dedicatedEventHubSasKeyName;
            this.DedicatedEventHubAuthenticationStrategy = dedicatedEventHubAuthenticationStrategy;
            this.SendScenarioRunToEventHub = sendScenarioRunToEventHub;
            this.SendScenarioMetadataToEventHub = sendScenarioMetadataToEventHub;
            this.DatasetCopy = datasetCopy;
            this.Security = security;
        }

        /// <summary>
        /// Workspace unique identifier generated by the API
        /// </summary>
        /// <value>Workspace unique identifier generated by the API</value>
        /// <example>w-0123456789ab</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Organization unique identifier under which the workspace resides
        /// </summary>
        /// <value>Organization unique identifier under which the workspace resides</value>
        /// <example>o-0123456789ab</example>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public string OrganizationId { get; private set; }

        /// <summary>
        /// Returns false as OrganizationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrganizationId()
        {
            return false;
        }
        /// <summary>
        /// technical key for resource name convention and version grouping. Must be unique
        /// </summary>
        /// <value>technical key for resource name convention and version grouping. Must be unique</value>
        /// <example>MyKey</example>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Workspace name. This name is display in the sample webApp
        /// </summary>
        /// <value>Workspace name. This name is display in the sample webApp</value>
        /// <example>FranceOffice</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// the Workspace description
        /// </summary>
        /// <value>the Workspace description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// list of dataset linked to this dataset
        /// </summary>
        /// <value>list of dataset linked to this dataset</value>
        [DataMember(Name = "linkedDatasetIdList", EmitDefaultValue = false)]
        public List<string> LinkedDatasetIdList { get; set; }

        /// <summary>
        /// the Workspace version MAJOR.MINOR.PATCH.
        /// </summary>
        /// <value>the Workspace version MAJOR.MINOR.PATCH.</value>
        /// <example>1.0.0</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

        /// <summary>
        /// the list of tags
        /// </summary>
        /// <value>the list of tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// the user id which own this workspace. set by the API from Authentification service receved id
        /// </summary>
        /// <value>the user id which own this workspace. set by the API from Authentification service receved id</value>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Returns false as OwnerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOwnerId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Solution
        /// </summary>
        [DataMember(Name = "solution", IsRequired = true, EmitDefaultValue = true)]
        public WorkspaceSolution Solution { get; set; }

        /// <summary>
        /// Gets or Sets WebApp
        /// </summary>
        [DataMember(Name = "webApp", EmitDefaultValue = false)]
        public WorkspaceWebApp WebApp { get; set; }

        /// <summary>
        /// default setting for all Scenarios and Run Templates to set whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to the ScenarioRun
        /// </summary>
        /// <value>default setting for all Scenarios and Run Templates to set whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to the ScenarioRun</value>
        [DataMember(Name = "sendInputToDataWarehouse", EmitDefaultValue = true)]
        public bool SendInputToDataWarehouse { get; set; }

        /// <summary>
        /// Set this property to true to use a dedicated Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;probesmeasures\\&#39; and \\&#39;scenariorun\\&#39;.
        /// </summary>
        /// <value>Set this property to true to use a dedicated Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;probesmeasures\\&#39; and \\&#39;scenariorun\\&#39;.</value>
        [DataMember(Name = "useDedicatedEventHubNamespace", EmitDefaultValue = true)]
        public bool UseDedicatedEventHubNamespace { get; set; }

        /// <summary>
        /// the Dedicated Event Hub SAS key name, default to RootManageSharedAccessKey. Use the /secret endpoint to set the key value
        /// </summary>
        /// <value>the Dedicated Event Hub SAS key name, default to RootManageSharedAccessKey. Use the /secret endpoint to set the key value</value>
        [DataMember(Name = "dedicatedEventHubSasKeyName", EmitDefaultValue = false)]
        public string DedicatedEventHubSasKeyName { get; set; }

        /// <summary>
        /// the Event Hub authentication strategy, SHARED_ACCESS_POLICY or TENANT_CLIENT_CREDENTIALS. Default to the one defined for the tenant.
        /// </summary>
        /// <value>the Event Hub authentication strategy, SHARED_ACCESS_POLICY or TENANT_CLIENT_CREDENTIALS. Default to the one defined for the tenant.</value>
        [DataMember(Name = "dedicatedEventHubAuthenticationStrategy", EmitDefaultValue = false)]
        public string DedicatedEventHubAuthenticationStrategy { get; set; }

        /// <summary>
        /// default setting for all Scenarios and Run Templates to set whether or not the ScenarioRun is send to the Event Hub
        /// </summary>
        /// <value>default setting for all Scenarios and Run Templates to set whether or not the ScenarioRun is send to the Event Hub</value>
        [DataMember(Name = "sendScenarioRunToEventHub", EmitDefaultValue = true)]
        public bool SendScenarioRunToEventHub { get; set; }

        /// <summary>
        /// Set this property to false to not send scenario metada to Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;scenariometadata\\&#39; and \\&#39;scenariorunmetadata\\&#39;.
        /// </summary>
        /// <value>Set this property to false to not send scenario metada to Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;scenariometadata\\&#39; and \\&#39;scenariorunmetadata\\&#39;.</value>
        [DataMember(Name = "sendScenarioMetadataToEventHub", EmitDefaultValue = true)]
        public bool SendScenarioMetadataToEventHub { get; set; }

        /// <summary>
        /// Activate the copy of dataset on scenario creation, meaning that each scenario created in this workspace will make this copy. when false, scenario use directly the dataset specified.
        /// </summary>
        /// <value>Activate the copy of dataset on scenario creation, meaning that each scenario created in this workspace will make this copy. when false, scenario use directly the dataset specified.</value>
        [DataMember(Name = "datasetCopy", EmitDefaultValue = true)]
        public bool DatasetCopy { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = false)]
        public WorkspaceSecurity Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Workspace {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LinkedDatasetIdList: ").Append(LinkedDatasetIdList).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Solution: ").Append(Solution).Append("\n");
            sb.Append("  WebApp: ").Append(WebApp).Append("\n");
            sb.Append("  SendInputToDataWarehouse: ").Append(SendInputToDataWarehouse).Append("\n");
            sb.Append("  UseDedicatedEventHubNamespace: ").Append(UseDedicatedEventHubNamespace).Append("\n");
            sb.Append("  DedicatedEventHubSasKeyName: ").Append(DedicatedEventHubSasKeyName).Append("\n");
            sb.Append("  DedicatedEventHubAuthenticationStrategy: ").Append(DedicatedEventHubAuthenticationStrategy).Append("\n");
            sb.Append("  SendScenarioRunToEventHub: ").Append(SendScenarioRunToEventHub).Append("\n");
            sb.Append("  SendScenarioMetadataToEventHub: ").Append(SendScenarioMetadataToEventHub).Append("\n");
            sb.Append("  DatasetCopy: ").Append(DatasetCopy).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
