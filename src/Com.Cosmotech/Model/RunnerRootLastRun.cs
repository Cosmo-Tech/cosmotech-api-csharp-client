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
    /// RunnerRootLastRun
    /// </summary>
    [DataContract(Name = "Runner_rootLastRun")]
    public partial class RunnerRootLastRun : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunnerRootLastRun" /> class.
        /// </summary>
        /// <param name="runnerRunId">the last Runner Run id.</param>
        /// <param name="csmSimulationRun">the last Cosmo Tech Simulation Run id.</param>
        /// <param name="workflowId">the last Workflow Id.</param>
        /// <param name="workflowName">the last Workflow name.</param>
        public RunnerRootLastRun(string runnerRunId = default(string), string csmSimulationRun = default(string), string workflowId = default(string), string workflowName = default(string))
        {
            this.RunnerRunId = runnerRunId;
            this.CsmSimulationRun = csmSimulationRun;
            this.WorkflowId = workflowId;
            this.WorkflowName = workflowName;
        }

        /// <summary>
        /// the last Runner Run id
        /// </summary>
        /// <value>the last Runner Run id</value>
        [DataMember(Name = "runnerRunId", EmitDefaultValue = false)]
        public string RunnerRunId { get; set; }

        /// <summary>
        /// the last Cosmo Tech Simulation Run id
        /// </summary>
        /// <value>the last Cosmo Tech Simulation Run id</value>
        [DataMember(Name = "csmSimulationRun", EmitDefaultValue = false)]
        public string CsmSimulationRun { get; set; }

        /// <summary>
        /// the last Workflow Id
        /// </summary>
        /// <value>the last Workflow Id</value>
        [DataMember(Name = "workflowId", EmitDefaultValue = false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// the last Workflow name
        /// </summary>
        /// <value>the last Workflow name</value>
        [DataMember(Name = "workflowName", EmitDefaultValue = false)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RunnerRootLastRun {\n");
            sb.Append("  RunnerRunId: ").Append(RunnerRunId).Append("\n");
            sb.Append("  CsmSimulationRun: ").Append(CsmSimulationRun).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  WorkflowName: ").Append(WorkflowName).Append("\n");
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
