/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.1
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
    /// the run logs returned by all containers
    /// </summary>
    [DataContract(Name = "RunLogs")]
    public partial class RunLogs : IEquatable<RunLogs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunLogs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RunLogs()
        {
        }

        /// <summary>
        /// the Run Id
        /// </summary>
        /// <value>the Run Id</value>
        [DataMember(Name = "runId", EmitDefaultValue = false)]
        public string RunId { get; private set; }

        /// <summary>
        /// Returns false as RunId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRunId()
        {
            return false;
        }
        /// <summary>
        /// the container map of logs
        /// </summary>
        /// <value>the container map of logs</value>
        [DataMember(Name = "containers", EmitDefaultValue = false)]
        public Dictionary<string, RunContainerLogs> Containers { get; private set; }

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
            sb.Append("class RunLogs {\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
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
            return this.Equals(input as RunLogs);
        }

        /// <summary>
        /// Returns true if RunLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of RunLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunLogs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RunId == input.RunId ||
                    (this.RunId != null &&
                    this.RunId.Equals(input.RunId))
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
                if (this.RunId != null)
                {
                    hashCode = (hashCode * 59) + this.RunId.GetHashCode();
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