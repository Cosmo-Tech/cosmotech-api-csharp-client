/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 4.0.3-SNAPSHOT
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
    /// the result of the comparison of two runners
    /// </summary>
    [DataContract(Name = "RunnerComparisonResult")]
    public partial class RunnerComparisonResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunnerComparisonResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RunnerComparisonResult()
        {
        }

        /// <summary>
        /// the Runner Id which is the reference for the comparison
        /// </summary>
        /// <value>the Runner Id which is the reference for the comparison</value>
        [DataMember(Name = "runnerId", EmitDefaultValue = false)]
        public string RunnerId { get; private set; }

        /// <summary>
        /// Returns false as RunnerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRunnerId()
        {
            return false;
        }
        /// <summary>
        /// the Runner Id the reference Runner is compared to
        /// </summary>
        /// <value>the Runner Id the reference Runner is compared to</value>
        [DataMember(Name = "comparedRunnerId", EmitDefaultValue = false)]
        public string ComparedRunnerId { get; private set; }

        /// <summary>
        /// Returns false as ComparedRunnerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComparedRunnerId()
        {
            return false;
        }
        /// <summary>
        /// the list of changed values for parameters
        /// </summary>
        /// <value>the list of changed values for parameters</value>
        [DataMember(Name = "changedValues", EmitDefaultValue = false)]
        public List<RunnerChangedParameterValue> ChangedValues { get; private set; }

        /// <summary>
        /// Returns false as ChangedValues should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChangedValues()
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
            sb.Append("class RunnerComparisonResult {\n");
            sb.Append("  RunnerId: ").Append(RunnerId).Append("\n");
            sb.Append("  ComparedRunnerId: ").Append(ComparedRunnerId).Append("\n");
            sb.Append("  ChangedValues: ").Append(ChangedValues).Append("\n");
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
