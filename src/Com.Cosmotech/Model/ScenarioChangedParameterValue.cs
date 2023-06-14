/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.4.4-SNAPSHOT
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
    /// the difference between the values of a parameter
    /// </summary>
    [DataContract(Name = "ScenarioChangedParameterValue")]
    public partial class ScenarioChangedParameterValue : IEquatable<ScenarioChangedParameterValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioChangedParameterValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ScenarioChangedParameterValue()
        {
        }

        /// <summary>
        /// the parameter id the values refer to
        /// </summary>
        /// <value>the parameter id the values refer to</value>
        [DataMember(Name = "parameterId", EmitDefaultValue = false)]
        public string ParameterId { get; private set; }

        /// <summary>
        /// Returns false as ParameterId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParameterId()
        {
            return false;
        }
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
        /// the parameter value for the reference Scenario
        /// </summary>
        /// <value>the parameter value for the reference Scenario</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; private set; }

        /// <summary>
        /// Returns false as Value should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValue()
        {
            return false;
        }
        /// <summary>
        /// the parameter value for the compared Scenario
        /// </summary>
        /// <value>the parameter value for the compared Scenario</value>
        [DataMember(Name = "comparedValue", EmitDefaultValue = false)]
        public string ComparedValue { get; private set; }

        /// <summary>
        /// Returns false as ComparedValue should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComparedValue()
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
            sb.Append("class ScenarioChangedParameterValue {\n");
            sb.Append("  ParameterId: ").Append(ParameterId).Append("\n");
            sb.Append("  VarType: ").Append(VarType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ComparedValue: ").Append(ComparedValue).Append("\n");
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
            return this.Equals(input as ScenarioChangedParameterValue);
        }

        /// <summary>
        /// Returns true if ScenarioChangedParameterValue instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioChangedParameterValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioChangedParameterValue input)
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
                    this.ComparedValue == input.ComparedValue ||
                    (this.ComparedValue != null &&
                    this.ComparedValue.Equals(input.ComparedValue))
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
                if (this.ComparedValue != null)
                {
                    hashCode = (hashCode * 59) + this.ComparedValue.GetHashCode();
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
