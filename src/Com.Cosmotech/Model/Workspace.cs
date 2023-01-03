/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.1.8-dev
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
    public partial class Workspace : IEquatable<Workspace>, IValidatableObject
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
        /// <param name="name">the Workspace name (required).</param>
        /// <param name="description">the Workspace description.</param>
        /// <param name="version">the Workspace version MAJOR.MINOR.PATCH..</param>
        /// <param name="tags">the list of tags.</param>
        /// <param name="solution">solution (required).</param>
        /// <param name="users">the list of users Id with their role.</param>
        /// <param name="webApp">webApp.</param>
        /// <param name="sendInputToDataWarehouse">default setting for all Scenarios and Run Templates to set whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to the ScenarioRun.</param>
        /// <param name="useDedicatedEventHubNamespace">Set this property to true to use a dedicated Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;probesmeasures\\&#39; and \\&#39;scenariorun\\&#39;. (default to false).</param>
        /// <param name="dedicatedEventHubSasKeyName">the Dedicated Event Hub SAS key name, default to RootManageSharedAccessKey. Use the /secret endpoint to set the key value.</param>
        /// <param name="dedicatedEventHubAuthenticationStrategy">the Event Hub authentication strategy, SHARED_ACCESS_POLICY or TENANT_CLIENT_CREDENTIALS. Default to the one defined for the tenant..</param>
        /// <param name="sendScenarioRunToEventHub">default setting for all Scenarios and Run Templates to set whether or not the ScenarioRun is send to the Event Hub (default to true).</param>
        /// <param name="sendScenarioMetadataToEventHub">Set this property to false to not send scenario metada to Azure Event Hub Namespace for this Workspace. The Event Hub Namespace must be named \\&#39;&lt;organization_id\\&gt;-&lt;workspace_id\\&gt;\\&#39; (in lower case). This Namespace must also contain two Event Hubs named \\&#39;scenariometadata\\&#39; and \\&#39;scenariorunmetadata\\&#39;. (default to false).</param>
        public Workspace(string key = default(string), string name = default(string), string description = default(string), string version = default(string), List<string> tags = default(List<string>), WorkspaceSolution solution = default(WorkspaceSolution), List<WorkspaceUser> users = default(List<WorkspaceUser>), WorkspaceWebApp webApp = default(WorkspaceWebApp), bool sendInputToDataWarehouse = default(bool), bool useDedicatedEventHubNamespace = false, string dedicatedEventHubSasKeyName = default(string), string dedicatedEventHubAuthenticationStrategy = default(string), bool sendScenarioRunToEventHub = true, bool sendScenarioMetadataToEventHub = false)
        {
            // to ensure "key" is required (not null)
            if (key == null) {
                throw new ArgumentNullException("key is a required property for Workspace and cannot be null");
            }
            this.Key = key;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Workspace and cannot be null");
            }
            this.Name = name;
            // to ensure "solution" is required (not null)
            if (solution == null) {
                throw new ArgumentNullException("solution is a required property for Workspace and cannot be null");
            }
            this.Solution = solution;
            this.Description = description;
            this._Version = version;
            this.Tags = tags;
            this.Users = users;
            this.WebApp = webApp;
            this.SendInputToDataWarehouse = sendInputToDataWarehouse;
            this.UseDedicatedEventHubNamespace = useDedicatedEventHubNamespace;
            this.DedicatedEventHubSasKeyName = dedicatedEventHubSasKeyName;
            this.DedicatedEventHubAuthenticationStrategy = dedicatedEventHubAuthenticationStrategy;
            this.SendScenarioRunToEventHub = sendScenarioRunToEventHub;
            this.SendScenarioMetadataToEventHub = sendScenarioMetadataToEventHub;
        }

        /// <summary>
        /// the Workspace version unique identifier
        /// </summary>
        /// <value>the Workspace version unique identifier</value>
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
        /// technical key for resource name convention and version grouping. Must be unique
        /// </summary>
        /// <value>technical key for resource name convention and version grouping. Must be unique</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// the Workspace name
        /// </summary>
        /// <value>the Workspace name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the Workspace description
        /// </summary>
        /// <value>the Workspace description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// the Workspace version MAJOR.MINOR.PATCH.
        /// </summary>
        /// <value>the Workspace version MAJOR.MINOR.PATCH.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// the list of tags
        /// </summary>
        /// <value>the list of tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// the user id which own this workspace
        /// </summary>
        /// <value>the user id which own this workspace</value>
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
        [DataMember(Name = "solution", IsRequired = true, EmitDefaultValue = false)]
        public WorkspaceSolution Solution { get; set; }

        /// <summary>
        /// the list of users Id with their role
        /// </summary>
        /// <value>the list of users Id with their role</value>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public List<WorkspaceUser> Users { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Workspace {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Solution: ").Append(Solution).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  WebApp: ").Append(WebApp).Append("\n");
            sb.Append("  SendInputToDataWarehouse: ").Append(SendInputToDataWarehouse).Append("\n");
            sb.Append("  UseDedicatedEventHubNamespace: ").Append(UseDedicatedEventHubNamespace).Append("\n");
            sb.Append("  DedicatedEventHubSasKeyName: ").Append(DedicatedEventHubSasKeyName).Append("\n");
            sb.Append("  DedicatedEventHubAuthenticationStrategy: ").Append(DedicatedEventHubAuthenticationStrategy).Append("\n");
            sb.Append("  SendScenarioRunToEventHub: ").Append(SendScenarioRunToEventHub).Append("\n");
            sb.Append("  SendScenarioMetadataToEventHub: ").Append(SendScenarioMetadataToEventHub).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Workspace);
        }

        /// <summary>
        /// Returns true if Workspace instances are equal
        /// </summary>
        /// <param name="input">Instance of Workspace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Workspace input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Solution == input.Solution ||
                    (this.Solution != null &&
                    this.Solution.Equals(input.Solution))
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.WebApp == input.WebApp ||
                    (this.WebApp != null &&
                    this.WebApp.Equals(input.WebApp))
                ) && 
                (
                    this.SendInputToDataWarehouse == input.SendInputToDataWarehouse ||
                    this.SendInputToDataWarehouse.Equals(input.SendInputToDataWarehouse)
                ) && 
                (
                    this.UseDedicatedEventHubNamespace == input.UseDedicatedEventHubNamespace ||
                    this.UseDedicatedEventHubNamespace.Equals(input.UseDedicatedEventHubNamespace)
                ) && 
                (
                    this.DedicatedEventHubSasKeyName == input.DedicatedEventHubSasKeyName ||
                    (this.DedicatedEventHubSasKeyName != null &&
                    this.DedicatedEventHubSasKeyName.Equals(input.DedicatedEventHubSasKeyName))
                ) && 
                (
                    this.DedicatedEventHubAuthenticationStrategy == input.DedicatedEventHubAuthenticationStrategy ||
                    (this.DedicatedEventHubAuthenticationStrategy != null &&
                    this.DedicatedEventHubAuthenticationStrategy.Equals(input.DedicatedEventHubAuthenticationStrategy))
                ) && 
                (
                    this.SendScenarioRunToEventHub == input.SendScenarioRunToEventHub ||
                    this.SendScenarioRunToEventHub.Equals(input.SendScenarioRunToEventHub)
                ) && 
                (
                    this.SendScenarioMetadataToEventHub == input.SendScenarioMetadataToEventHub ||
                    this.SendScenarioMetadataToEventHub.Equals(input.SendScenarioMetadataToEventHub)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.Solution != null)
                {
                    hashCode = (hashCode * 59) + this.Solution.GetHashCode();
                }
                if (this.Users != null)
                {
                    hashCode = (hashCode * 59) + this.Users.GetHashCode();
                }
                if (this.WebApp != null)
                {
                    hashCode = (hashCode * 59) + this.WebApp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SendInputToDataWarehouse.GetHashCode();
                hashCode = (hashCode * 59) + this.UseDedicatedEventHubNamespace.GetHashCode();
                if (this.DedicatedEventHubSasKeyName != null)
                {
                    hashCode = (hashCode * 59) + this.DedicatedEventHubSasKeyName.GetHashCode();
                }
                if (this.DedicatedEventHubAuthenticationStrategy != null)
                {
                    hashCode = (hashCode * 59) + this.DedicatedEventHubAuthenticationStrategy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SendScenarioRunToEventHub.GetHashCode();
                hashCode = (hashCode * 59) + this.SendScenarioMetadataToEventHub.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
