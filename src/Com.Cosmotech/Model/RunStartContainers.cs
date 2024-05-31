/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.4
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
    [DataContract(Name = "RunStartContainers")]
    public partial class RunStartContainers : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunStartContainers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunStartContainers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunStartContainers" /> class.
        /// </summary>
        /// <param name="generateName">the base name for workflow name generation.</param>
        /// <param name="csmSimulationId">Cosmo Tech Simulation Run Id (required).</param>
        /// <param name="nodeLabel">the node label request.</param>
        /// <param name="labels">the workflow labels.</param>
        /// <param name="containers">the containerslist (required).</param>
        public RunStartContainers(string generateName = default(string), string csmSimulationId = default(string), string nodeLabel = default(string), Dictionary<string, string> labels = default(Dictionary<string, string>), List<RunContainer> containers = default(List<RunContainer>))
        {
            // to ensure "csmSimulationId" is required (not null)
            if (csmSimulationId == null)
            {
                throw new ArgumentNullException("csmSimulationId is a required property for RunStartContainers and cannot be null");
            }
            this.CsmSimulationId = csmSimulationId;
            // to ensure "containers" is required (not null)
            if (containers == null)
            {
                throw new ArgumentNullException("containers is a required property for RunStartContainers and cannot be null");
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
        [DataMember(Name = "csmSimulationId", IsRequired = true, EmitDefaultValue = true)]
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
        [DataMember(Name = "containers", IsRequired = true, EmitDefaultValue = true)]
        public List<RunContainer> Containers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RunStartContainers {\n");
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
