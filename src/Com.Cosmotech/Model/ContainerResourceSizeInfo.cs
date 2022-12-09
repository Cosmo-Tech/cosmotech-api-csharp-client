/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.1.6-dev
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
    /// define cpus and memory needs
    /// </summary>
    [DataContract(Name = "ContainerResourceSizeInfo")]
    public partial class ContainerResourceSizeInfo : IEquatable<ContainerResourceSizeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResourceSizeInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContainerResourceSizeInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResourceSizeInfo" /> class.
        /// </summary>
        /// <param name="cpu">define cpu needs (required).</param>
        /// <param name="memory">define memory needs (required).</param>
        public ContainerResourceSizeInfo(string cpu = default(string), string memory = default(string))
        {
            // to ensure "cpu" is required (not null)
            if (cpu == null) {
                throw new ArgumentNullException("cpu is a required property for ContainerResourceSizeInfo and cannot be null");
            }
            this.Cpu = cpu;
            // to ensure "memory" is required (not null)
            if (memory == null) {
                throw new ArgumentNullException("memory is a required property for ContainerResourceSizeInfo and cannot be null");
            }
            this.Memory = memory;
        }

        /// <summary>
        /// define cpu needs
        /// </summary>
        /// <value>define cpu needs</value>
        [DataMember(Name = "cpu", IsRequired = true, EmitDefaultValue = false)]
        public string Cpu { get; set; }

        /// <summary>
        /// define memory needs
        /// </summary>
        /// <value>define memory needs</value>
        [DataMember(Name = "memory", IsRequired = true, EmitDefaultValue = false)]
        public string Memory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContainerResourceSizeInfo {\n");
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
            return this.Equals(input as ContainerResourceSizeInfo);
        }

        /// <summary>
        /// Returns true if ContainerResourceSizeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ContainerResourceSizeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContainerResourceSizeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Memory == input.Memory ||
                    (this.Memory != null &&
                    this.Memory.Equals(input.Memory))
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
                if (this.Cpu != null)
                {
                    hashCode = (hashCode * 59) + this.Cpu.GetHashCode();
                }
                if (this.Memory != null)
                {
                    hashCode = (hashCode * 59) + this.Memory.GetHashCode();
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
