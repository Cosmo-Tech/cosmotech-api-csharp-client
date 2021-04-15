/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 0.0.1-SNAPSHOT
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
    [DataContract(Name = "SimulationStartContainers")]
    public partial class SimulationStartContainers : IEquatable<SimulationStartContainers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationStartContainers" /> class.
        /// </summary>
        /// <param name="nodeLabel">the node label request.</param>
        /// <param name="initContainers">the list of init containers.</param>
        /// <param name="mainContainer">mainContainer.</param>
        public SimulationStartContainers(string nodeLabel = default(string), List<SimulationContainers> initContainers = default(List<SimulationContainers>), SimulationContainers mainContainer = default(SimulationContainers))
        {
            this.NodeLabel = nodeLabel;
            this.InitContainers = initContainers;
            this.MainContainer = mainContainer;
        }

        /// <summary>
        /// the node label request
        /// </summary>
        /// <value>the node label request</value>
        [DataMember(Name = "nodeLabel", EmitDefaultValue = false)]
        public string NodeLabel { get; set; }

        /// <summary>
        /// the list of init containers
        /// </summary>
        /// <value>the list of init containers</value>
        [DataMember(Name = "initContainers", EmitDefaultValue = false)]
        public List<SimulationContainers> InitContainers { get; set; }

        /// <summary>
        /// Gets or Sets MainContainer
        /// </summary>
        [DataMember(Name = "mainContainer", EmitDefaultValue = false)]
        public SimulationContainers MainContainer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimulationStartContainers {\n");
            sb.Append("  NodeLabel: ").Append(NodeLabel).Append("\n");
            sb.Append("  InitContainers: ").Append(InitContainers).Append("\n");
            sb.Append("  MainContainer: ").Append(MainContainer).Append("\n");
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
            return this.Equals(input as SimulationStartContainers);
        }

        /// <summary>
        /// Returns true if SimulationStartContainers instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationStartContainers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationStartContainers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeLabel == input.NodeLabel ||
                    (this.NodeLabel != null &&
                    this.NodeLabel.Equals(input.NodeLabel))
                ) && 
                (
                    this.InitContainers == input.InitContainers ||
                    this.InitContainers != null &&
                    input.InitContainers != null &&
                    this.InitContainers.SequenceEqual(input.InitContainers)
                ) && 
                (
                    this.MainContainer == input.MainContainer ||
                    (this.MainContainer != null &&
                    this.MainContainer.Equals(input.MainContainer))
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
                if (this.NodeLabel != null)
                    hashCode = hashCode * 59 + this.NodeLabel.GetHashCode();
                if (this.InitContainers != null)
                    hashCode = hashCode * 59 + this.InitContainers.GetHashCode();
                if (this.MainContainer != null)
                    hashCode = hashCode * 59 + this.MainContainer.GetHashCode();
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
