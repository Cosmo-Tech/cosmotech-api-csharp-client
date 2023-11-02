/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.10-SNAPSHOT
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
    /// the parameters to run directly containers
    /// </summary>
    [DataContract(Name = "ScenarioRunStartContainers")]
    public partial class ScenarioRunStartContainers : IEquatable<ScenarioRunStartContainers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunStartContainers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScenarioRunStartContainers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunStartContainers" /> class.
        /// </summary>
        /// <param name="generateName">the base name for workflow name generation.</param>
        /// <param name="csmSimulationId">Cosmo Tech Simulation Run Id (required).</param>
        /// <param name="nodeLabel">the node label request.</param>
        /// <param name="labels">the workflow labels.</param>
        /// <param name="containers">the containerslist (required).</param>
        public ScenarioRunStartContainers(string generateName = default(string), string csmSimulationId = default(string), string nodeLabel = default(string), Dictionary<string, string> labels = default(Dictionary<string, string>), List<ScenarioRunContainer> containers = default(List<ScenarioRunContainer>))
        {
            // to ensure "csmSimulationId" is required (not null)
            if (csmSimulationId == null) {
                throw new ArgumentNullException("csmSimulationId is a required property for ScenarioRunStartContainers and cannot be null");
            }
            this.CsmSimulationId = csmSimulationId;
            // to ensure "containers" is required (not null)
            if (containers == null) {
                throw new ArgumentNullException("containers is a required property for ScenarioRunStartContainers and cannot be null");
            }
            this.Containers = containers;
            this.GenerateName = generateName;
            this.NodeLabel = nodeLabel;
            this.Labels = labels;
        }

        /// <summary>
        /// the base name for workflow name generation
        /// </summary>
        /// <value>the base name for workflow name generation</value>
        [DataMember(Name = "generateName", EmitDefaultValue = false)]
        public string GenerateName { get; set; }

        /// <summary>
        /// Cosmo Tech Simulation Run Id
        /// </summary>
        /// <value>Cosmo Tech Simulation Run Id</value>
        [DataMember(Name = "csmSimulationId", IsRequired = true, EmitDefaultValue = false)]
        public string CsmSimulationId { get; set; }

        /// <summary>
        /// the node label request
        /// </summary>
        /// <value>the node label request</value>
        [DataMember(Name = "nodeLabel", EmitDefaultValue = false)]
        public string NodeLabel { get; set; }

        /// <summary>
        /// the workflow labels
        /// </summary>
        /// <value>the workflow labels</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// the containerslist
        /// </summary>
        /// <value>the containerslist</value>
        [DataMember(Name = "containers", IsRequired = true, EmitDefaultValue = false)]
        public List<ScenarioRunContainer> Containers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenarioRunStartContainers {\n");
            sb.Append("  GenerateName: ").Append(GenerateName).Append("\n");
            sb.Append("  CsmSimulationId: ").Append(CsmSimulationId).Append("\n");
            sb.Append("  NodeLabel: ").Append(NodeLabel).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
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
            return this.Equals(input as ScenarioRunStartContainers);
        }

        /// <summary>
        /// Returns true if ScenarioRunStartContainers instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioRunStartContainers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioRunStartContainers input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GenerateName == input.GenerateName ||
                    (this.GenerateName != null &&
                    this.GenerateName.Equals(input.GenerateName))
                ) && 
                (
                    this.CsmSimulationId == input.CsmSimulationId ||
                    (this.CsmSimulationId != null &&
                    this.CsmSimulationId.Equals(input.CsmSimulationId))
                ) && 
                (
                    this.NodeLabel == input.NodeLabel ||
                    (this.NodeLabel != null &&
                    this.NodeLabel.Equals(input.NodeLabel))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
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
                if (this.GenerateName != null)
                {
                    hashCode = (hashCode * 59) + this.GenerateName.GetHashCode();
                }
                if (this.CsmSimulationId != null)
                {
                    hashCode = (hashCode * 59) + this.CsmSimulationId.GetHashCode();
                }
                if (this.NodeLabel != null)
                {
                    hashCode = (hashCode * 59) + this.NodeLabel.GetHashCode();
                }
                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
                }
                if (this.Containers != null)
                {
                    hashCode = (hashCode * 59) + this.Containers.GetHashCode();
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
