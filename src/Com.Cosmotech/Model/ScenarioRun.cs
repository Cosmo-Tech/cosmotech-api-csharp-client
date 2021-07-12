/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 0.0.8-SNAPSHOT
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
    /// a ScenarioRun with only base properties
    /// </summary>
    [DataContract(Name = "ScenarioRun")]
    public partial class ScenarioRun : IEquatable<ScenarioRun>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRun" /> class.
        /// </summary>
        /// <param name="organizationId">the Organization id.</param>
        /// <param name="workflowId">the Cosmo Tech compute cluster Argo Workflow Id to search.</param>
        /// <param name="generateName">the base name for workflow name generation.</param>
        /// <param name="workflowName">the Cosmo Tech compute cluster Argo Workflow Name.</param>
        /// <param name="containers">the containers list.</param>
        public ScenarioRun(string organizationId = default(string), string workflowId = default(string), string generateName = default(string), string workflowName = default(string), List<ScenarioRunContainer> containers = default(List<ScenarioRunContainer>))
        {
            this.OrganizationId = organizationId;
            this.WorkflowId = workflowId;
            this.GenerateName = generateName;
            this.WorkflowName = workflowName;
            this.Containers = containers;
        }

        /// <summary>
        /// the ScenarioRun
        /// </summary>
        /// <value>the ScenarioRun</value>
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
        /// the Organization id
        /// </summary>
        /// <value>the Organization id</value>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// the Cosmo Tech compute cluster Argo Workflow Id to search
        /// </summary>
        /// <value>the Cosmo Tech compute cluster Argo Workflow Id to search</value>
        [DataMember(Name = "workflowId", EmitDefaultValue = false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// the Cosmo Tech Simulation Run Id
        /// </summary>
        /// <value>the Cosmo Tech Simulation Run Id</value>
        [DataMember(Name = "csmSimulationRun", EmitDefaultValue = false)]
        public string CsmSimulationRun { get; private set; }

        /// <summary>
        /// Returns false as CsmSimulationRun should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCsmSimulationRun()
        {
            return false;
        }

        /// <summary>
        /// the base name for workflow name generation
        /// </summary>
        /// <value>the base name for workflow name generation</value>
        [DataMember(Name = "generateName", EmitDefaultValue = false)]
        public string GenerateName { get; set; }

        /// <summary>
        /// the Cosmo Tech compute cluster Argo Workflow Name
        /// </summary>
        /// <value>the Cosmo Tech compute cluster Argo Workflow Name</value>
        [DataMember(Name = "workflowName", EmitDefaultValue = false)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// the user id which own this scenariorun
        /// </summary>
        /// <value>the user id which own this scenariorun</value>
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
        /// the Workspace Id
        /// </summary>
        /// <value>the Workspace Id</value>
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
        /// technical key for resource name convention and version grouping. Must be unique
        /// </summary>
        /// <value>technical key for resource name convention and version grouping. Must be unique</value>
        [DataMember(Name = "workspaceKey", EmitDefaultValue = false)]
        public string WorkspaceKey { get; private set; }

        /// <summary>
        /// Returns false as WorkspaceKey should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWorkspaceKey()
        {
            return false;
        }

        /// <summary>
        /// the Scenario Id
        /// </summary>
        /// <value>the Scenario Id</value>
        [DataMember(Name = "scenarioId", EmitDefaultValue = false)]
        public string ScenarioId { get; private set; }

        /// <summary>
        /// Returns false as ScenarioId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScenarioId()
        {
            return false;
        }

        /// <summary>
        /// the Solution Id
        /// </summary>
        /// <value>the Solution Id</value>
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
        /// the Solution Run Template id
        /// </summary>
        /// <value>the Solution Run Template id</value>
        [DataMember(Name = "runTemplateId", EmitDefaultValue = false)]
        public string RunTemplateId { get; private set; }

        /// <summary>
        /// Returns false as RunTemplateId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRunTemplateId()
        {
            return false;
        }

        /// <summary>
        /// the compute size needed for this Analysis. Standard sizes are basic and highcpu. Default is basic
        /// </summary>
        /// <value>the compute size needed for this Analysis. Standard sizes are basic and highcpu. Default is basic</value>
        [DataMember(Name = "computeSize", EmitDefaultValue = false)]
        public string ComputeSize { get; private set; }

        /// <summary>
        /// Returns false as ComputeSize should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComputeSize()
        {
            return false;
        }

        /// <summary>
        /// the list of Dataset Id associated to this Analysis
        /// </summary>
        /// <value>the list of Dataset Id associated to this Analysis</value>
        [DataMember(Name = "datasetList", EmitDefaultValue = false)]
        public List<string> DatasetList { get; private set; }

        /// <summary>
        /// Returns false as DatasetList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDatasetList()
        {
            return false;
        }

        /// <summary>
        /// the list of Run Template parameters values
        /// </summary>
        /// <value>the list of Run Template parameters values</value>
        [DataMember(Name = "parametersValues", EmitDefaultValue = false)]
        public List<RunTemplateParameterValue> ParametersValues { get; private set; }

        /// <summary>
        /// Returns false as ParametersValues should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParametersValues()
        {
            return false;
        }

        /// <summary>
        /// whether or not the Datasets values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting
        /// </summary>
        /// <value>whether or not the Datasets values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting</value>
        [DataMember(Name = "sendDatasetsToDataWarehouse", EmitDefaultValue = true)]
        public bool SendDatasetsToDataWarehouse { get; private set; }

        /// <summary>
        /// Returns false as SendDatasetsToDataWarehouse should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSendDatasetsToDataWarehouse()
        {
            return false;
        }

        /// <summary>
        /// whether or not the input parameters values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting
        /// </summary>
        /// <value>whether or not the input parameters values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting</value>
        [DataMember(Name = "sendInputParametersToDataWarehouse", EmitDefaultValue = true)]
        public bool SendInputParametersToDataWarehouse { get; private set; }

        /// <summary>
        /// Returns false as SendInputParametersToDataWarehouse should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSendInputParametersToDataWarehouse()
        {
            return false;
        }

        /// <summary>
        /// the node label request
        /// </summary>
        /// <value>the node label request</value>
        [DataMember(Name = "nodeLabel", EmitDefaultValue = false)]
        public string NodeLabel { get; private set; }

        /// <summary>
        /// Returns false as NodeLabel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNodeLabel()
        {
            return false;
        }

        /// <summary>
        /// the containers list
        /// </summary>
        /// <value>the containers list</value>
        [DataMember(Name = "containers", EmitDefaultValue = false)]
        public List<ScenarioRunContainer> Containers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScenarioRun {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  CsmSimulationRun: ").Append(CsmSimulationRun).Append("\n");
            sb.Append("  GenerateName: ").Append(GenerateName).Append("\n");
            sb.Append("  WorkflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  WorkspaceKey: ").Append(WorkspaceKey).Append("\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  SolutionId: ").Append(SolutionId).Append("\n");
            sb.Append("  RunTemplateId: ").Append(RunTemplateId).Append("\n");
            sb.Append("  ComputeSize: ").Append(ComputeSize).Append("\n");
            sb.Append("  DatasetList: ").Append(DatasetList).Append("\n");
            sb.Append("  ParametersValues: ").Append(ParametersValues).Append("\n");
            sb.Append("  SendDatasetsToDataWarehouse: ").Append(SendDatasetsToDataWarehouse).Append("\n");
            sb.Append("  SendInputParametersToDataWarehouse: ").Append(SendInputParametersToDataWarehouse).Append("\n");
            sb.Append("  NodeLabel: ").Append(NodeLabel).Append("\n");
            sb.Append("  Containers: ").Append(Containers).Append("\n");
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
            return this.Equals(input as ScenarioRun);
        }

        /// <summary>
        /// Returns true if ScenarioRun instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) && 
                (
                    this.CsmSimulationRun == input.CsmSimulationRun ||
                    (this.CsmSimulationRun != null &&
                    this.CsmSimulationRun.Equals(input.CsmSimulationRun))
                ) && 
                (
                    this.GenerateName == input.GenerateName ||
                    (this.GenerateName != null &&
                    this.GenerateName.Equals(input.GenerateName))
                ) && 
                (
                    this.WorkflowName == input.WorkflowName ||
                    (this.WorkflowName != null &&
                    this.WorkflowName.Equals(input.WorkflowName))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
                ) && 
                (
                    this.WorkspaceKey == input.WorkspaceKey ||
                    (this.WorkspaceKey != null &&
                    this.WorkspaceKey.Equals(input.WorkspaceKey))
                ) && 
                (
                    this.ScenarioId == input.ScenarioId ||
                    (this.ScenarioId != null &&
                    this.ScenarioId.Equals(input.ScenarioId))
                ) && 
                (
                    this.SolutionId == input.SolutionId ||
                    (this.SolutionId != null &&
                    this.SolutionId.Equals(input.SolutionId))
                ) && 
                (
                    this.RunTemplateId == input.RunTemplateId ||
                    (this.RunTemplateId != null &&
                    this.RunTemplateId.Equals(input.RunTemplateId))
                ) && 
                (
                    this.ComputeSize == input.ComputeSize ||
                    (this.ComputeSize != null &&
                    this.ComputeSize.Equals(input.ComputeSize))
                ) && 
                (
                    this.DatasetList == input.DatasetList ||
                    this.DatasetList != null &&
                    input.DatasetList != null &&
                    this.DatasetList.SequenceEqual(input.DatasetList)
                ) && 
                (
                    this.ParametersValues == input.ParametersValues ||
                    this.ParametersValues != null &&
                    input.ParametersValues != null &&
                    this.ParametersValues.SequenceEqual(input.ParametersValues)
                ) && 
                (
                    this.SendDatasetsToDataWarehouse == input.SendDatasetsToDataWarehouse ||
                    this.SendDatasetsToDataWarehouse.Equals(input.SendDatasetsToDataWarehouse)
                ) && 
                (
                    this.SendInputParametersToDataWarehouse == input.SendInputParametersToDataWarehouse ||
                    this.SendInputParametersToDataWarehouse.Equals(input.SendInputParametersToDataWarehouse)
                ) && 
                (
                    this.NodeLabel == input.NodeLabel ||
                    (this.NodeLabel != null &&
                    this.NodeLabel.Equals(input.NodeLabel))
                ) && 
                (
                    this.Containers == input.Containers ||
                    this.Containers != null &&
                    input.Containers != null &&
                    this.Containers.SequenceEqual(input.Containers)
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.CsmSimulationRun != null)
                    hashCode = hashCode * 59 + this.CsmSimulationRun.GetHashCode();
                if (this.GenerateName != null)
                    hashCode = hashCode * 59 + this.GenerateName.GetHashCode();
                if (this.WorkflowName != null)
                    hashCode = hashCode * 59 + this.WorkflowName.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.WorkspaceId != null)
                    hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.WorkspaceKey != null)
                    hashCode = hashCode * 59 + this.WorkspaceKey.GetHashCode();
                if (this.ScenarioId != null)
                    hashCode = hashCode * 59 + this.ScenarioId.GetHashCode();
                if (this.SolutionId != null)
                    hashCode = hashCode * 59 + this.SolutionId.GetHashCode();
                if (this.RunTemplateId != null)
                    hashCode = hashCode * 59 + this.RunTemplateId.GetHashCode();
                if (this.ComputeSize != null)
                    hashCode = hashCode * 59 + this.ComputeSize.GetHashCode();
                if (this.DatasetList != null)
                    hashCode = hashCode * 59 + this.DatasetList.GetHashCode();
                if (this.ParametersValues != null)
                    hashCode = hashCode * 59 + this.ParametersValues.GetHashCode();
                hashCode = hashCode * 59 + this.SendDatasetsToDataWarehouse.GetHashCode();
                hashCode = hashCode * 59 + this.SendInputParametersToDataWarehouse.GetHashCode();
                if (this.NodeLabel != null)
                    hashCode = hashCode * 59 + this.NodeLabel.GetHashCode();
                if (this.Containers != null)
                    hashCode = hashCode * 59 + this.Containers.GetHashCode();
                return hashCode;
            }
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
