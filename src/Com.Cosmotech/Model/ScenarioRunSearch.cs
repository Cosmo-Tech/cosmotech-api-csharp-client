/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.0
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
    /// the search options
    /// </summary>
    [DataContract(Name = "ScenarioRunSearch")]
    public partial class ScenarioRunSearch : IEquatable<ScenarioRunSearch>, IValidatableObject
    {
        /// <summary>
        /// the state to search
        /// </summary>
        /// <value>the state to search</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum FetchingDatasets for value: FetchingDatasets
            /// </summary>
            [EnumMember(Value = "FetchingDatasets")]
            FetchingDatasets = 1,

            /// <summary>
            /// Enum FetchingScenarioParameters for value: FetchingScenarioParameters
            /// </summary>
            [EnumMember(Value = "FetchingScenarioParameters")]
            FetchingScenarioParameters = 2,

            /// <summary>
            /// Enum ApplyingScenarioParameters for value: ApplyingScenarioParameters
            /// </summary>
            [EnumMember(Value = "ApplyingScenarioParameters")]
            ApplyingScenarioParameters = 3,

            /// <summary>
            /// Enum ValidatingScenarioData for value: ValidatingScenarioData
            /// </summary>
            [EnumMember(Value = "ValidatingScenarioData")]
            ValidatingScenarioData = 4,

            /// <summary>
            /// Enum SendingScenarioDataToDataWarehouse for value: SendingScenarioDataToDataWarehouse
            /// </summary>
            [EnumMember(Value = "SendingScenarioDataToDataWarehouse")]
            SendingScenarioDataToDataWarehouse = 5,

            /// <summary>
            /// Enum PreRun for value: PreRun
            /// </summary>
            [EnumMember(Value = "PreRun")]
            PreRun = 6,

            /// <summary>
            /// Enum Running for value: Running
            /// </summary>
            [EnumMember(Value = "Running")]
            Running = 7,

            /// <summary>
            /// Enum PostRun for value: PostRun
            /// </summary>
            [EnumMember(Value = "PostRun")]
            PostRun = 8,

            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 9,

            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 10

        }


        /// <summary>
        /// the state to search
        /// </summary>
        /// <value>the state to search</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunSearch" /> class.
        /// </summary>
        /// <param name="solutionId">the Solution Id to search.</param>
        /// <param name="runTemplateId">the Solution Analysis Id to search.</param>
        /// <param name="workspaceId">the Workspace Id to search.</param>
        /// <param name="scenarioId">the Scenario Id to search.</param>
        /// <param name="state">the state to search.</param>
        /// <param name="workflowId">the Cosmo Tech compute cluster Argo Workflow Id to search.</param>
        /// <param name="workflowName">the Cosmo Tech compute cluster Argo Workflow Name.</param>
        /// <param name="ownerId">the owner Id to search.</param>
        public ScenarioRunSearch(string solutionId = default(string), string runTemplateId = default(string), string workspaceId = default(string), string scenarioId = default(string), StateEnum? state = default(StateEnum?), string workflowId = default(string), string workflowName = default(string), string ownerId = default(string))
        {
            this.SolutionId = solutionId;
            this.RunTemplateId = runTemplateId;
            this.WorkspaceId = workspaceId;
            this.ScenarioId = scenarioId;
            this.State = state;
            this.WorkflowId = workflowId;
            this.WorkflowName = workflowName;
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// the Solution Id to search
        /// </summary>
        /// <value>the Solution Id to search</value>
        [DataMember(Name = "solutionId", EmitDefaultValue = false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// the Solution Analysis Id to search
        /// </summary>
        /// <value>the Solution Analysis Id to search</value>
        [DataMember(Name = "runTemplateId", EmitDefaultValue = false)]
        public string RunTemplateId { get; set; }

        /// <summary>
        /// the Workspace Id to search
        /// </summary>
        /// <value>the Workspace Id to search</value>
        [DataMember(Name = "workspaceId", EmitDefaultValue = false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// the Scenario Id to search
        /// </summary>
        /// <value>the Scenario Id to search</value>
        [DataMember(Name = "scenarioId", EmitDefaultValue = false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// the Cosmo Tech compute cluster Argo Workflow Id to search
        /// </summary>
        /// <value>the Cosmo Tech compute cluster Argo Workflow Id to search</value>
        [DataMember(Name = "workflowId", EmitDefaultValue = false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// the Cosmo Tech compute cluster Argo Workflow Name
        /// </summary>
        /// <value>the Cosmo Tech compute cluster Argo Workflow Name</value>
        [DataMember(Name = "workflowName", EmitDefaultValue = false)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// the owner Id to search
        /// </summary>
        /// <value>the owner Id to search</value>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenarioRunSearch {\n");
            sb.Append("  SolutionId: ").Append(SolutionId).Append("\n");
            sb.Append("  RunTemplateId: ").Append(RunTemplateId).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  WorkflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
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
            return this.Equals(input as ScenarioRunSearch);
        }

        /// <summary>
        /// Returns true if ScenarioRunSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioRunSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioRunSearch input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
                ) && 
                (
                    this.ScenarioId == input.ScenarioId ||
                    (this.ScenarioId != null &&
                    this.ScenarioId.Equals(input.ScenarioId))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
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
                if (this.SolutionId != null)
                {
                    hashCode = (hashCode * 59) + this.SolutionId.GetHashCode();
                }
                if (this.RunTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.RunTemplateId.GetHashCode();
                }
                if (this.WorkspaceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkspaceId.GetHashCode();
                }
                if (this.ScenarioId != null)
                {
                    hashCode = (hashCode * 59) + this.ScenarioId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.WorkflowId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowId.GetHashCode();
                }
                if (this.WorkflowName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowName.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
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
