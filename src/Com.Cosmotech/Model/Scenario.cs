/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.3
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
    /// a Scenario with base information
    /// </summary>
    [DataContract(Name = "Scenario")]
    public partial class Scenario : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public ScenarioJobState? State { get; set; }

        /// <summary>
        /// Gets or Sets ValidationStatus
        /// </summary>
        [DataMember(Name = "validationStatus", EmitDefaultValue = false)]
        public ScenarioValidationStatus? ValidationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Scenario" /> class.
        /// </summary>
        /// <param name="name">the Scenario name.</param>
        /// <param name="description">the Scenario description.</param>
        /// <param name="tags">the list of tags.</param>
        /// <param name="parentId">the Scenario parent id.</param>
        /// <param name="runTemplateId">the Solution Run Template Id associated with this Scenario.</param>
        /// <param name="state">state.</param>
        /// <param name="datasetList">the list of Dataset Id associated to this Scenario Run Template.</param>
        /// <param name="runSizing">runSizing.</param>
        /// <param name="parametersValues">the list of Solution Run Template parameters values.</param>
        /// <param name="lastRun">lastRun.</param>
        /// <param name="parentLastRun">parentLastRun.</param>
        /// <param name="rootLastRun">rootLastRun.</param>
        /// <param name="validationStatus">validationStatus.</param>
        /// <param name="security">security.</param>
        public Scenario(string name = default(string), string description = default(string), List<string> tags = default(List<string>), string parentId = default(string), string runTemplateId = default(string), ScenarioJobState? state = default(ScenarioJobState?), List<string> datasetList = default(List<string>), ScenarioResourceSizing runSizing = default(ScenarioResourceSizing), List<ScenarioRunTemplateParameterValue> parametersValues = default(List<ScenarioRunTemplateParameterValue>), ScenarioLastRun lastRun = default(ScenarioLastRun), ScenarioLastRun parentLastRun = default(ScenarioLastRun), ScenarioLastRun rootLastRun = default(ScenarioLastRun), ScenarioValidationStatus? validationStatus = default(ScenarioValidationStatus?), ScenarioSecurity security = default(ScenarioSecurity))
        {
            this.Name = name;
            this.Description = description;
            this.Tags = tags;
            this.ParentId = parentId;
            this.RunTemplateId = runTemplateId;
            this.State = state;
            this.DatasetList = datasetList;
            this.RunSizing = runSizing;
            this.ParametersValues = parametersValues;
            this.LastRun = lastRun;
            this.ParentLastRun = parentLastRun;
            this.RootLastRun = rootLastRun;
            this.ValidationStatus = validationStatus;
            this.Security = security;
        }

        /// <summary>
        /// the Scenario unique identifier
        /// </summary>
        /// <value>the Scenario unique identifier</value>
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
        /// the Scenario name
        /// </summary>
        /// <value>the Scenario name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the Scenario description
        /// </summary>
        /// <value>the Scenario description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// the list of tags
        /// </summary>
        /// <value>the list of tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// the Scenario parent id
        /// </summary>
        /// <value>the Scenario parent id</value>
        [DataMember(Name = "parentId", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// the user id which own this Scenario
        /// </summary>
        /// <value>the user id which own this Scenario</value>
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
        /// the scenario root id
        /// </summary>
        /// <value>the scenario root id</value>
        [DataMember(Name = "rootId", EmitDefaultValue = false)]
        public string RootId { get; private set; }

        /// <summary>
        /// Returns false as RootId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRootId()
        {
            return false;
        }
        /// <summary>
        /// the Solution Id associated with this Scenario
        /// </summary>
        /// <value>the Solution Id associated with this Scenario</value>
        [DataMember(Name = "solutionId", EmitDefaultValue = false)]
        public string SolutionId { get; private set; }

        /// <summary>
        /// Returns false as SolutionId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSolutionId()
        {
            return false;
        }
        /// <summary>
        /// the Solution Run Template Id associated with this Scenario
        /// </summary>
        /// <value>the Solution Run Template Id associated with this Scenario</value>
        [DataMember(Name = "runTemplateId", EmitDefaultValue = false)]
        public string RunTemplateId { get; set; }

        /// <summary>
        /// the associated Organization Id
        /// </summary>
        /// <value>the associated Organization Id</value>
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
        /// the associated Workspace Id
        /// </summary>
        /// <value>the associated Workspace Id</value>
        [DataMember(Name = "workspaceId", EmitDefaultValue = false)]
        public string WorkspaceId { get; private set; }

        /// <summary>
        /// Returns false as WorkspaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWorkspaceId()
        {
            return false;
        }
        /// <summary>
        /// the Scenario creation date
        /// </summary>
        /// <value>the Scenario creation date</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public long CreationDate { get; private set; }

        /// <summary>
        /// Returns false as CreationDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreationDate()
        {
            return false;
        }
        /// <summary>
        /// the last time a Scenario was updated
        /// </summary>
        /// <value>the last time a Scenario was updated</value>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public long LastUpdate { get; private set; }

        /// <summary>
        /// Returns false as LastUpdate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdate()
        {
            return false;
        }
        /// <summary>
        /// the name of the owner
        /// </summary>
        /// <value>the name of the owner</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; private set; }

        /// <summary>
        /// Returns false as OwnerName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOwnerName()
        {
            return false;
        }
        /// <summary>
        /// the Solution name
        /// </summary>
        /// <value>the Solution name</value>
        [DataMember(Name = "solutionName", EmitDefaultValue = false)]
        public string SolutionName { get; private set; }

        /// <summary>
        /// Returns false as SolutionName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSolutionName()
        {
            return false;
        }
        /// <summary>
        /// the Solution Run Template name associated with this Scenario
        /// </summary>
        /// <value>the Solution Run Template name associated with this Scenario</value>
        [DataMember(Name = "runTemplateName", EmitDefaultValue = false)]
        public string RunTemplateName { get; private set; }

        /// <summary>
        /// Returns false as RunTemplateName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRunTemplateName()
        {
            return false;
        }
        /// <summary>
        /// the list of Dataset Id associated to this Scenario Run Template
        /// </summary>
        /// <value>the list of Dataset Id associated to this Scenario Run Template</value>
        [DataMember(Name = "datasetList", EmitDefaultValue = false)]
        public List<string> DatasetList { get; set; }

        /// <summary>
        /// Gets or Sets RunSizing
        /// </summary>
        [DataMember(Name = "runSizing", EmitDefaultValue = false)]
        public ScenarioResourceSizing RunSizing { get; set; }

        /// <summary>
        /// the list of Solution Run Template parameters values
        /// </summary>
        /// <value>the list of Solution Run Template parameters values</value>
        [DataMember(Name = "parametersValues", EmitDefaultValue = false)]
        public List<ScenarioRunTemplateParameterValue> ParametersValues { get; set; }

        /// <summary>
        /// Gets or Sets LastRun
        /// </summary>
        [DataMember(Name = "lastRun", EmitDefaultValue = false)]
        public ScenarioLastRun LastRun { get; set; }

        /// <summary>
        /// Gets or Sets ParentLastRun
        /// </summary>
        [DataMember(Name = "parentLastRun", EmitDefaultValue = false)]
        public ScenarioLastRun ParentLastRun { get; set; }

        /// <summary>
        /// Gets or Sets RootLastRun
        /// </summary>
        [DataMember(Name = "rootLastRun", EmitDefaultValue = false)]
        public ScenarioLastRun RootLastRun { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = false)]
        public ScenarioSecurity Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Scenario {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  RootId: ").Append(RootId).Append("\n");
            sb.Append("  SolutionId: ").Append(SolutionId).Append("\n");
            sb.Append("  RunTemplateId: ").Append(RunTemplateId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  SolutionName: ").Append(SolutionName).Append("\n");
            sb.Append("  RunTemplateName: ").Append(RunTemplateName).Append("\n");
            sb.Append("  DatasetList: ").Append(DatasetList).Append("\n");
            sb.Append("  RunSizing: ").Append(RunSizing).Append("\n");
            sb.Append("  ParametersValues: ").Append(ParametersValues).Append("\n");
            sb.Append("  LastRun: ").Append(LastRun).Append("\n");
            sb.Append("  ParentLastRun: ").Append(ParentLastRun).Append("\n");
            sb.Append("  RootLastRun: ").Append(RootLastRun).Append("\n");
            sb.Append("  ValidationStatus: ").Append(ValidationStatus).Append("\n");
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
