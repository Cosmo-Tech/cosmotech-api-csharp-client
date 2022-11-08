/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.0.0
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
    /// ScenarioLastRun
    /// </summary>
    [DataContract(Name = "ScenarioLastRun")]
    public partial class ScenarioLastRun : IEquatable<ScenarioLastRun>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioLastRun" /> class.
        /// </summary>
        /// <param name="scenarioRunId">the last Scenario Run id.</param>
        /// <param name="csmSimulationRun">the last Cosmo Tech Simulation Run id.</param>
        /// <param name="workflowId">the last Workflow Id.</param>
        /// <param name="workflowName">the last Workflow name.</param>
        public ScenarioLastRun(string scenarioRunId = default(string), string csmSimulationRun = default(string), string workflowId = default(string), string workflowName = default(string))
        {
            this.ScenarioRunId = scenarioRunId;
            this.CsmSimulationRun = csmSimulationRun;
            this.WorkflowId = workflowId;
            this.WorkflowName = workflowName;
        }

        /// <summary>
        /// the last Scenario Run id
        /// </summary>
        /// <value>the last Scenario Run id</value>
        [DataMember(Name = "scenarioRunId", EmitDefaultValue = false)]
        public string ScenarioRunId { get; set; }

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
            sb.Append("class ScenarioLastRun {\n");
            sb.Append("  ScenarioRunId: ").Append(ScenarioRunId).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScenarioLastRun);
        }

        /// <summary>
        /// Returns true if ScenarioLastRun instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioLastRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioLastRun input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ScenarioRunId == input.ScenarioRunId ||
                    (this.ScenarioRunId != null &&
                    this.ScenarioRunId.Equals(input.ScenarioRunId))
                ) && 
                (
                    this.CsmSimulationRun == input.CsmSimulationRun ||
                    (this.CsmSimulationRun != null &&
                    this.CsmSimulationRun.Equals(input.CsmSimulationRun))
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
                if (this.ScenarioRunId != null)
                {
                    hashCode = (hashCode * 59) + this.ScenarioRunId.GetHashCode();
                }
                if (this.CsmSimulationRun != null)
                {
                    hashCode = (hashCode * 59) + this.CsmSimulationRun.GetHashCode();
                }
                if (this.WorkflowId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowId.GetHashCode();
                }
                if (this.WorkflowName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowName.GetHashCode();
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
