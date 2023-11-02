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
    /// a description object for resource requests and limits (default same configuration as basic sizing)
    /// </summary>
    [DataContract(Name = "ContainerResourceSizing")]
    public partial class ContainerResourceSizing : IEquatable<ContainerResourceSizing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResourceSizing" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContainerResourceSizing() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResourceSizing" /> class.
        /// </summary>
        /// <param name="requests">requests (required).</param>
        /// <param name="limits">limits (required).</param>
        public ContainerResourceSizing(ContainerResourceSizeInfo requests = default(ContainerResourceSizeInfo), ContainerResourceSizeInfo limits = default(ContainerResourceSizeInfo))
        {
            // to ensure "requests" is required (not null)
            if (requests == null) {
                throw new ArgumentNullException("requests is a required property for ContainerResourceSizing and cannot be null");
            }
            this.Requests = requests;
            // to ensure "limits" is required (not null)
            if (limits == null) {
                throw new ArgumentNullException("limits is a required property for ContainerResourceSizing and cannot be null");
            }
            this.Limits = limits;
        }

        /// <summary>
        /// Gets or Sets Requests
        /// </summary>
        [DataMember(Name = "requests", IsRequired = true, EmitDefaultValue = false)]
        public ContainerResourceSizeInfo Requests { get; set; }

        /// <summary>
        /// Gets or Sets Limits
        /// </summary>
        [DataMember(Name = "limits", IsRequired = true, EmitDefaultValue = false)]
        public ContainerResourceSizeInfo Limits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContainerResourceSizing {\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
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
            return this.Equals(input as ContainerResourceSizing);
        }

        /// <summary>
        /// Returns true if ContainerResourceSizing instances are equal
        /// </summary>
        /// <param name="input">Instance of ContainerResourceSizing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContainerResourceSizing input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Requests == input.Requests ||
                    (this.Requests != null &&
                    this.Requests.Equals(input.Requests))
                ) && 
                (
                    this.Limits == input.Limits ||
                    (this.Limits != null &&
                    this.Limits.Equals(input.Limits))
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
                if (this.Requests != null)
                {
                    hashCode = (hashCode * 59) + this.Requests.GetHashCode();
                }
                if (this.Limits != null)
                {
                    hashCode = (hashCode * 59) + this.Limits.GetHashCode();
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
