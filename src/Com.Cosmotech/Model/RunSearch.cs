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
    /// the search options
    /// </summary>
    [DataContract(Name = "RunSearch")]
    public partial class RunSearch : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public RunSearchState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunSearch" /> class.
        /// </summary>
        /// <param name="solutionId">the Solution Id to search.</param>
        /// <param name="runTemplateId">the Solution Analysis Id to search.</param>
        /// <param name="workspaceId">the Workspace Id to search.</param>
        /// <param name="runnerId">the Runner Id to search.</param>
        /// <param name="state">state.</param>
        /// <param name="workflowId">the Cosmo Tech compute cluster Argo Workflow Id to search.</param>
        /// <param name="workflowName">the Cosmo Tech compute cluster Argo Workflow Name.</param>
        /// <param name="ownerId">the owner Id to search.</param>
        public RunSearch(string solutionId = default(string), string runTemplateId = default(string), string workspaceId = default(string), string runnerId = default(string), RunSearchState? state = default(RunSearchState?), string workflowId = default(string), string workflowName = default(string), string ownerId = default(string))
        {
            this.SolutionId = solutionId;
            this.RunTemplateId = runTemplateId;
            this.WorkspaceId = workspaceId;
            this.RunnerId = runnerId;
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
        /// the Runner Id to search
        /// </summary>
        /// <value>the Runner Id to search</value>
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
            sb.Append("class RunSearch {\n");
            sb.Append("  SolutionId: ").Append(SolutionId).Append("\n");
            sb.Append("  RunTemplateId: ").Append(RunTemplateId).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  RunnerId: ").Append(RunnerId).Append("\n");
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
