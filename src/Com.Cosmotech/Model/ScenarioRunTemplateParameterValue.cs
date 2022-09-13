/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 1.0.6-dev
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
    /// the value of a Solution Run Template parameter for a Scenario
    /// </summary>
    [DataContract(Name = "ScenarioRunTemplateParameterValue")]
    public partial class ScenarioRunTemplateParameterValue : IEquatable<ScenarioRunTemplateParameterValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunTemplateParameterValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScenarioRunTemplateParameterValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunTemplateParameterValue" /> class.
        /// </summary>
        /// <param name="parameterId">the parameter Id (required).</param>
        /// <param name="value">the parameter value (required).</param>
        /// <param name="isInherited">whether or not the value is inherited from parent or has been changed.</param>
        public ScenarioRunTemplateParameterValue(string parameterId = default(string), string value = default(string), bool isInherited = default(bool))
        {
            // to ensure "parameterId" is required (not null)
            if (parameterId == null) {
                throw new ArgumentNullException("parameterId is a required property for ScenarioRunTemplateParameterValue and cannot be null");
            }
            this.ParameterId = parameterId;
            // to ensure "value" is required (not null)
            if (value == null) {
                throw new ArgumentNullException("value is a required property for ScenarioRunTemplateParameterValue and cannot be null");
            }
            this.Value = value;
            this.IsInherited = isInherited;
        }

        /// <summary>
        /// the parameter Id
        /// </summary>
        /// <value>the parameter Id</value>
        [DataMember(Name = "parameterId", IsRequired = true, EmitDefaultValue = false)]
        public string ParameterId { get; set; }

        /// <summary>
        /// the parameter value type
        /// </summary>
        /// <value>the parameter value type</value>
        [DataMember(Name = "varType", EmitDefaultValue = false)]
        public string VarType { get; private set; }

        /// <summary>
        /// Returns false as VarType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarType()
        {
            return false;
        }
        /// <summary>
        /// the parameter value
        /// </summary>
        /// <value>the parameter value</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// whether or not the value is inherited from parent or has been changed
        /// </summary>
        /// <value>whether or not the value is inherited from parent or has been changed</value>
        [DataMember(Name = "isInherited", EmitDefaultValue = true)]
        public bool IsInherited { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenarioRunTemplateParameterValue {\n");
            sb.Append("  ParameterId: ").Append(ParameterId).Append("\n");
            sb.Append("  VarType: ").Append(VarType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  IsInherited: ").Append(IsInherited).Append("\n");
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
            return this.Equals(input as ScenarioRunTemplateParameterValue);
        }

        /// <summary>
        /// Returns true if ScenarioRunTemplateParameterValue instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioRunTemplateParameterValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioRunTemplateParameterValue input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ParameterId == input.ParameterId ||
                    (this.ParameterId != null &&
                    this.ParameterId.Equals(input.ParameterId))
                ) && 
                (
                    this.VarType == input.VarType ||
                    (this.VarType != null &&
                    this.VarType.Equals(input.VarType))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.IsInherited == input.IsInherited ||
                    this.IsInherited.Equals(input.IsInherited)
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
                if (this.ParameterId != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterId.GetHashCode();
                }
                if (this.VarType != null)
                {
                    hashCode = (hashCode * 59) + this.VarType.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsInherited.GetHashCode();
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
