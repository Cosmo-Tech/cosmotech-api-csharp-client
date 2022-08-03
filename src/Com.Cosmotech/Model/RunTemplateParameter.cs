/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 1.0.5-SNAPSHOT
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
    /// a Run Template Parameter
    /// </summary>
    [DataContract(Name = "RunTemplateParameter")]
    public partial class RunTemplateParameter : IEquatable<RunTemplateParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunTemplateParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunTemplateParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunTemplateParameter" /> class.
        /// </summary>
        /// <param name="id">the Parameter id (required).</param>
        /// <param name="labels">a translated label with key as ISO 639-1 code.</param>
        /// <param name="varType">the variable type for the parameter. Basic types or special type %DATASETID%.</param>
        /// <param name="defaultValue">the default value for this parameter.</param>
        /// <param name="minValue">the minimum value for this parameter.</param>
        /// <param name="maxValue">the maximum value for this parameter.</param>
        /// <param name="regexValidation">a regex to validate the value.</param>
        /// <param name="options">freeform options.</param>
        public RunTemplateParameter(string id = default(string), Dictionary<string, string> labels = default(Dictionary<string, string>), string varType = default(string), string defaultValue = default(string), string minValue = default(string), string maxValue = default(string), string regexValidation = default(string), Dictionary<string, Object> options = default(Dictionary<string, Object>))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for RunTemplateParameter and cannot be null");
            }
            this.Id = id;
            this.Labels = labels;
            this.VarType = varType;
            this.DefaultValue = defaultValue;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.RegexValidation = regexValidation;
            this.Options = options;
        }

        /// <summary>
        /// the Parameter id
        /// </summary>
        /// <value>the Parameter id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// a translated label with key as ISO 639-1 code
        /// </summary>
        /// <value>a translated label with key as ISO 639-1 code</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// the variable type for the parameter. Basic types or special type %DATASETID%
        /// </summary>
        /// <value>the variable type for the parameter. Basic types or special type %DATASETID%</value>
        [DataMember(Name = "varType", EmitDefaultValue = false)]
        public string VarType { get; set; }

        /// <summary>
        /// the default value for this parameter
        /// </summary>
        /// <value>the default value for this parameter</value>
        [DataMember(Name = "defaultValue", EmitDefaultValue = false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// the minimum value for this parameter
        /// </summary>
        /// <value>the minimum value for this parameter</value>
        [DataMember(Name = "minValue", EmitDefaultValue = false)]
        public string MinValue { get; set; }

        /// <summary>
        /// the maximum value for this parameter
        /// </summary>
        /// <value>the maximum value for this parameter</value>
        [DataMember(Name = "maxValue", EmitDefaultValue = false)]
        public string MaxValue { get; set; }

        /// <summary>
        /// a regex to validate the value
        /// </summary>
        /// <value>a regex to validate the value</value>
        [DataMember(Name = "regexValidation", EmitDefaultValue = false)]
        public string RegexValidation { get; set; }

        /// <summary>
        /// freeform options
        /// </summary>
        /// <value>freeform options</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public Dictionary<string, Object> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RunTemplateParameter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  VarType: ").Append(VarType).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  RegexValidation: ").Append(RegexValidation).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as RunTemplateParameter);
        }

        /// <summary>
        /// Returns true if RunTemplateParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of RunTemplateParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunTemplateParameter input)
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
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.VarType == input.VarType ||
                    (this.VarType != null &&
                    this.VarType.Equals(input.VarType))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.MinValue == input.MinValue ||
                    (this.MinValue != null &&
                    this.MinValue.Equals(input.MinValue))
                ) && 
                (
                    this.MaxValue == input.MaxValue ||
                    (this.MaxValue != null &&
                    this.MaxValue.Equals(input.MaxValue))
                ) && 
                (
                    this.RegexValidation == input.RegexValidation ||
                    (this.RegexValidation != null &&
                    this.RegexValidation.Equals(input.RegexValidation))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
                }
                if (this.VarType != null)
                {
                    hashCode = (hashCode * 59) + this.VarType.GetHashCode();
                }
                if (this.DefaultValue != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultValue.GetHashCode();
                }
                if (this.MinValue != null)
                {
                    hashCode = (hashCode * 59) + this.MinValue.GetHashCode();
                }
                if (this.MaxValue != null)
                {
                    hashCode = (hashCode * 59) + this.MaxValue.GetHashCode();
                }
                if (this.RegexValidation != null)
                {
                    hashCode = (hashCode * 59) + this.RegexValidation.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
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
