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
    /// the memory and CPU requested by the pod
    /// </summary>
    [DataContract(Name = "ScenarioRunResourceRequested")]
    public partial class ScenarioRunResourceRequested : IEquatable<ScenarioRunResourceRequested>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunResourceRequested" /> class.
        /// </summary>
        /// <param name="cpu">the cpu requested.</param>
        /// <param name="memory">the memory requested.</param>
        public ScenarioRunResourceRequested(long cpu = default(long), long memory = default(long))
        {
            this.Cpu = cpu;
            this.Memory = memory;
        }

        /// <summary>
        /// the cpu requested
        /// </summary>
        /// <value>the cpu requested</value>
        [DataMember(Name = "cpu", EmitDefaultValue = false)]
        public long Cpu { get; set; }

        /// <summary>
        /// the memory requested
        /// </summary>
        /// <value>the memory requested</value>
        [DataMember(Name = "memory", EmitDefaultValue = false)]
        public long Memory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenarioRunResourceRequested {\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
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
            return this.Equals(input as ScenarioRunResourceRequested);
        }

        /// <summary>
        /// Returns true if ScenarioRunResourceRequested instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioRunResourceRequested to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioRunResourceRequested input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cpu == input.Cpu ||
                    this.Cpu.Equals(input.Cpu)
                ) && 
                (
                    this.Memory == input.Memory ||
                    this.Memory.Equals(input.Memory)
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
                hashCode = (hashCode * 59) + this.Cpu.GetHashCode();
                hashCode = (hashCode * 59) + this.Memory.GetHashCode();
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
