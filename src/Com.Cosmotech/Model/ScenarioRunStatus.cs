/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 1.0.7
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
    /// a ScenarioRun status
    /// </summary>
    [DataContract(Name = "ScenarioRunStatus")]
    public partial class ScenarioRunStatus : IEquatable<ScenarioRunStatus>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public ScenarioRunState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunStatus" /> class.
        /// </summary>
        /// <param name="id">the ScenarioRun id.</param>
        /// <param name="organizationId">the ScenarioRun id.</param>
        /// <param name="workflowId">the Cosmo Tech compute cluster Argo Workflow Id to search.</param>
        /// <param name="workflowName">the Cosmo Tech compute cluster Argo Workflow Name.</param>
        /// <param name="startTime">the ScenarioRun start Date Time.</param>
        /// <param name="endTime">the ScenarioRun end Date Time.</param>
        /// <param name="phase">high-level summary of where the workflow is in its lifecycle.</param>
        /// <param name="progress">progress to completion.</param>
        /// <param name="message">a  human readable message indicating details about why the workflow is in this condition.</param>
        /// <param name="estimatedDuration">estimatedDuration in seconds.</param>
        /// <param name="nodes">status of ScenarioRun nodes.</param>
        /// <param name="state">state.</param>
        public ScenarioRunStatus(string id = default(string), string organizationId = default(string), string workflowId = default(string), string workflowName = default(string), string startTime = default(string), string endTime = default(string), string phase = default(string), string progress = default(string), string message = default(string), int estimatedDuration = default(int), List<ScenarioRunStatusNode> nodes = default(List<ScenarioRunStatusNode>), ScenarioRunState? state = default(ScenarioRunState?))
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.WorkflowId = workflowId;
            this.WorkflowName = workflowName;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Phase = phase;
            this.Progress = progress;
            this.Message = message;
            this.EstimatedDuration = estimatedDuration;
            this.Nodes = nodes;
            this.State = state;
        }

        /// <summary>
        /// the ScenarioRun id
        /// </summary>
        /// <value>the ScenarioRun id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the ScenarioRun id
        /// </summary>
        /// <value>the ScenarioRun id</value>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public string OrganizationId { get; set; }

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
        /// the ScenarioRun start Date Time
        /// </summary>
        /// <value>the ScenarioRun start Date Time</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// the ScenarioRun end Date Time
        /// </summary>
        /// <value>the ScenarioRun end Date Time</value>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// high-level summary of where the workflow is in its lifecycle
        /// </summary>
        /// <value>high-level summary of where the workflow is in its lifecycle</value>
        [DataMember(Name = "phase", EmitDefaultValue = false)]
        public string Phase { get; set; }

        /// <summary>
        /// progress to completion
        /// </summary>
        /// <value>progress to completion</value>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public string Progress { get; set; }

        /// <summary>
        /// a  human readable message indicating details about why the workflow is in this condition
        /// </summary>
        /// <value>a  human readable message indicating details about why the workflow is in this condition</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// estimatedDuration in seconds
        /// </summary>
        /// <value>estimatedDuration in seconds</value>
        [DataMember(Name = "estimatedDuration", EmitDefaultValue = false)]
        public int EstimatedDuration { get; set; }

        /// <summary>
        /// status of ScenarioRun nodes
        /// </summary>
        /// <value>status of ScenarioRun nodes</value>
        [DataMember(Name = "nodes", EmitDefaultValue = false)]
        public List<ScenarioRunStatusNode> Nodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenarioRunStatus {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  WorkflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  EstimatedDuration: ").Append(EstimatedDuration).Append("\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as ScenarioRunStatus);
        }

        /// <summary>
        /// Returns true if ScenarioRunStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioRunStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioRunStatus input)
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
                    this.WorkflowName == input.WorkflowName ||
                    (this.WorkflowName != null &&
                    this.WorkflowName.Equals(input.WorkflowName))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.EstimatedDuration == input.EstimatedDuration ||
                    this.EstimatedDuration.Equals(input.EstimatedDuration)
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    input.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                if (this.WorkflowId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowId.GetHashCode();
                }
                if (this.WorkflowName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowName.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.Phase != null)
                {
                    hashCode = (hashCode * 59) + this.Phase.GetHashCode();
                }
                if (this.Progress != null)
                {
                    hashCode = (hashCode * 59) + this.Progress.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EstimatedDuration.GetHashCode();
                if (this.Nodes != null)
                {
                    hashCode = (hashCode * 59) + this.Nodes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
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
