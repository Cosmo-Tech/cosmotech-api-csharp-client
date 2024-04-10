/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.3
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
    /// the Runner Role
    /// </summary>
    [DataContract(Name = "RunnerRole")]
    public partial class RunnerRole : IEquatable<RunnerRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunnerRole" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunnerRole() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunnerRole" /> class.
        /// </summary>
        /// <param name="role">the Runner Role (required).</param>
        public RunnerRole(string role = default(string))
        {
            // to ensure "role" is required (not null)
            if (role == null) {
                throw new ArgumentNullException("role is a required property for RunnerRole and cannot be null");
            }
            this.Role = role;
        }

        /// <summary>
        /// the Runner Role
        /// </summary>
        /// <value>the Runner Role</value>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RunnerRole {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as RunnerRole);
        }

        /// <summary>
        /// Returns true if RunnerRole instances are equal
        /// </summary>
        /// <param name="input">Instance of RunnerRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunnerRole input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
