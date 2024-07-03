/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 4.0.1-onprem
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
    public partial class RunTemplateParameter : IValidatableObject
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
            if (id == null)
            {
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
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
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
