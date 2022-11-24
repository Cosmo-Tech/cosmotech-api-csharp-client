/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 1.0.8
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
    /// a connector parameters group
    /// </summary>
    [DataContract(Name = "ConnectorParameterGroup")]
    public partial class ConnectorParameterGroup : IEquatable<ConnectorParameterGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorParameterGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectorParameterGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorParameterGroup" /> class.
        /// </summary>
        /// <param name="id">the connector parameter group id (required).</param>
        /// <param name="label">the list of translated parameter group labels (required).</param>
        /// <param name="parameters">the list of parameters (required).</param>
        public ConnectorParameterGroup(string id = default(string), string label = default(string), List<ConnectorParameter> parameters = default(List<ConnectorParameter>))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ConnectorParameterGroup and cannot be null");
            }
            this.Id = id;
            // to ensure "label" is required (not null)
            if (label == null) {
                throw new ArgumentNullException("label is a required property for ConnectorParameterGroup and cannot be null");
            }
            this.Label = label;
            // to ensure "parameters" is required (not null)
            if (parameters == null) {
                throw new ArgumentNullException("parameters is a required property for ConnectorParameterGroup and cannot be null");
            }
            this.Parameters = parameters;
        }

        /// <summary>
        /// the connector parameter group id
        /// </summary>
        /// <value>the connector parameter group id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the list of translated parameter group labels
        /// </summary>
        /// <value>the list of translated parameter group labels</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// the list of parameters
        /// </summary>
        /// <value>the list of parameters</value>
        [DataMember(Name = "parameters", IsRequired = true, EmitDefaultValue = false)]
        public List<ConnectorParameter> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorParameterGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(input as ConnectorParameterGroup);
        }

        /// <summary>
        /// Returns true if ConnectorParameterGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorParameterGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorParameterGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
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
