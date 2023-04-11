/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.3.6
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
    /// the scenariorun logs returned by all containers
    /// </summary>
    [DataContract(Name = "ScenarioRunLogs")]
    public partial class ScenarioRunLogs : IEquatable<ScenarioRunLogs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunLogs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ScenarioRunLogs()
        {
        }

        /// <summary>
        /// the ScenarioRun Id
        /// </summary>
        /// <value>the ScenarioRun Id</value>
        [DataMember(Name = "scenariorunId", EmitDefaultValue = false)]
        public string ScenariorunId { get; private set; }

        /// <summary>
        /// Returns false as ScenariorunId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScenariorunId()
        {
            return false;
        }
        /// <summary>
        /// the container map of logs
        /// </summary>
        /// <value>the container map of logs</value>
        [DataMember(Name = "containers", EmitDefaultValue = false)]
        public Dictionary<string, ScenarioRunContainerLogs> Containers { get; private set; }

        /// <summary>
        /// Returns false as Containers should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContainers()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenarioRunLogs {\n");
            sb.Append("  ScenariorunId: ").Append(ScenariorunId).Append("\n");
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
            return this.Equals(input as ScenarioRunLogs);
        }

        /// <summary>
        /// Returns true if ScenarioRunLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioRunLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioRunLogs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ScenariorunId == input.ScenariorunId ||
                    (this.ScenariorunId != null &&
                    this.ScenariorunId.Equals(input.ScenariorunId))
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
                if (this.ScenariorunId != null)
                {
                    hashCode = (hashCode * 59) + this.ScenariorunId.GetHashCode();
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
