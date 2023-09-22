/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.4.9
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
    /// a connector parameter
    /// </summary>
    [DataContract(Name = "ConnectorParameter")]
    public partial class ConnectorParameter : IEquatable<ConnectorParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectorParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorParameter" /> class.
        /// </summary>
        /// <param name="id">the connector parameter id (required).</param>
        /// <param name="label">the list of translated parameter group labels (required).</param>
        /// <param name="valueType">the parameter value type.</param>
        /// <param name="options">the list of available and valid values for the parameter.</param>
        /// <param name="_default">the default value.</param>
        /// <param name="envVar">associated environment variable in connector image.</param>
        public ConnectorParameter(string id = default(string), string label = default(string), string valueType = default(string), List<string> options = default(List<string>), string _default = default(string), string envVar = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ConnectorParameter and cannot be null");
            }
            this.Id = id;
            // to ensure "label" is required (not null)
            if (label == null) {
                throw new ArgumentNullException("label is a required property for ConnectorParameter and cannot be null");
            }
            this.Label = label;
            this.ValueType = valueType;
            this.Options = options;
            this.Default = _default;
            this.EnvVar = envVar;
        }

        /// <summary>
        /// the connector parameter id
        /// </summary>
        /// <value>the connector parameter id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the list of translated parameter group labels
        /// </summary>
        /// <value>the list of translated parameter group labels</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// the parameter value type
        /// </summary>
        /// <value>the parameter value type</value>
        [DataMember(Name = "valueType", EmitDefaultValue = false)]
        public string ValueType { get; set; }

        /// <summary>
        /// the list of available and valid values for the parameter
        /// </summary>
        /// <value>the list of available and valid values for the parameter</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<string> Options { get; set; }

        /// <summary>
        /// the default value
        /// </summary>
        /// <value>the default value</value>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public string Default { get; set; }

        /// <summary>
        /// associated environment variable in connector image
        /// </summary>
        /// <value>associated environment variable in connector image</value>
        [DataMember(Name = "envVar", EmitDefaultValue = false)]
        public string EnvVar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorParameter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  EnvVar: ").Append(EnvVar).Append("\n");
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
            return this.Equals(input as ConnectorParameter);
        }

        /// <summary>
        /// Returns true if ConnectorParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorParameter input)
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
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.EnvVar == input.EnvVar ||
                    (this.EnvVar != null &&
                    this.EnvVar.Equals(input.EnvVar))
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
                if (this.ValueType != null)
                {
                    hashCode = (hashCode * 59) + this.ValueType.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.Default != null)
                {
                    hashCode = (hashCode * 59) + this.Default.GetHashCode();
                }
                if (this.EnvVar != null)
                {
                    hashCode = (hashCode * 59) + this.EnvVar.GetHashCode();
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
