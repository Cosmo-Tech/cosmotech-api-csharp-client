/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.6
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
    /// a Run status
    /// </summary>
    [DataContract(Name = "RunStatus")]
    public partial class RunStatus : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public RunState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatus" /> class.
        /// </summary>
        /// <param name="id">the Run id.</param>
        /// <param name="organizationId">the Organization id.</param>
        /// <param name="workspaceId">the Workspace id.</param>
        /// <param name="runnerId">the Runner id.</param>
        /// <param name="workflowId">the Cosmo Tech compute cluster Argo Workflow Id to search.</param>
        /// <param name="workflowName">the Cosmo Tech compute cluster Argo Workflow Name.</param>
        /// <param name="startTime">the Run start Date Time.</param>
        /// <param name="endTime">the Run end Date Time.</param>
        /// <param name="phase">high-level summary of where the workflow is in its lifecycle.</param>
        /// <param name="progress">progress to completion.</param>
        /// <param name="message">a  human readable message indicating details about why the workflow is in this condition.</param>
        /// <param name="estimatedDuration">estimatedDuration in seconds.</param>
        /// <param name="nodes">status of Run nodes.</param>
        /// <param name="state">state.</param>
        public RunStatus(string id = default(string), string organizationId = default(string), string workspaceId = default(string), string runnerId = default(string), string workflowId = default(string), string workflowName = default(string), string startTime = default(string), string endTime = default(string), string phase = default(string), string progress = default(string), string message = default(string), int estimatedDuration = default(int), List<RunStatusNode> nodes = default(List<RunStatusNode>), RunState? state = default(RunState?))
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.WorkspaceId = workspaceId;
            this.RunnerId = runnerId;
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
        /// the Run id
        /// </summary>
        /// <value>the Run id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the Organization id
        /// </summary>
        /// <value>the Organization id</value>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// the Workspace id
        /// </summary>
        /// <value>the Workspace id</value>
        [DataMember(Name = "workspaceId", EmitDefaultValue = false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// the Runner id
        /// </summary>
        /// <value>the Runner id</value>
        [DataMember(Name = "runnerId", EmitDefaultValue = false)]
        public string RunnerId { get; set; }

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
        /// the Run start Date Time
        /// </summary>
        /// <value>the Run start Date Time</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// the Run end Date Time
        /// </summary>
        /// <value>the Run end Date Time</value>
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
        /// status of Run nodes
        /// </summary>
        /// <value>status of Run nodes</value>
        [DataMember(Name = "nodes", EmitDefaultValue = false)]
        public List<RunStatusNode> Nodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RunStatus {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  RunnerId: ").Append(RunnerId).Append("\n");
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
