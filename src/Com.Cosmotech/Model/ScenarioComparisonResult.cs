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
    /// the result of the comparison of two scenarios
    /// </summary>
    [DataContract(Name = "ScenarioComparisonResult")]
    public partial class ScenarioComparisonResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioComparisonResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ScenarioComparisonResult()
        {
        }

        /// <summary>
        /// the Scenario Id which is the reference for the comparison
        /// </summary>
        /// <value>the Scenario Id which is the reference for the comparison</value>
        [DataMember(Name = "scenarioId", EmitDefaultValue = false)]
        public string ScenarioId { get; private set; }

        /// <summary>
        /// Returns false as ScenarioId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScenarioId()
        {
            return false;
        }
        /// <summary>
        /// the Scenario Id the reference Scenario is compared to
        /// </summary>
        /// <value>the Scenario Id the reference Scenario is compared to</value>
        [DataMember(Name = "comparedScenarioId", EmitDefaultValue = false)]
        public string ComparedScenarioId { get; private set; }

        /// <summary>
        /// Returns false as ComparedScenarioId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComparedScenarioId()
        {
            return false;
        }
        /// <summary>
        /// the list of changed values for parameters
        /// </summary>
        /// <value>the list of changed values for parameters</value>
        [DataMember(Name = "changedValues", EmitDefaultValue = false)]
        public List<ScenarioChangedParameterValue> ChangedValues { get; private set; }

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
            sb.Append("class ScenarioComparisonResult {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  ComparedScenarioId: ").Append(ComparedScenarioId).Append("\n");
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
