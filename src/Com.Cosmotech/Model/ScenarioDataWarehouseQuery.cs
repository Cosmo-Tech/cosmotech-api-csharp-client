/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 0.0.1-SNAPSHOT
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
    /// a DataWarehouse Query for the scenario
    /// </summary>
    [DataContract(Name = "ScenarioDataWarehouseQuery")]
    public partial class ScenarioDataWarehouseQuery : IEquatable<ScenarioDataWarehouseQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioDataWarehouseQuery" /> class.
        /// </summary>
        /// <param name="simulationId">the simulationId to get the result for.</param>
        /// <param name="query">the DataWarehouse query expressed in native DataWarehouse query language.</param>
        public ScenarioDataWarehouseQuery(string simulationId = default(string), string query = default(string))
        {
            this.SimulationId = simulationId;
            this.Query = query;
        }

        /// <summary>
        /// the simulationId to get the result for
        /// </summary>
        /// <value>the simulationId to get the result for</value>
        [DataMember(Name = "simulationId", EmitDefaultValue = false)]
        public string SimulationId { get; set; }

        /// <summary>
        /// the DataWarehouse query expressed in native DataWarehouse query language
        /// </summary>
        /// <value>the DataWarehouse query expressed in native DataWarehouse query language</value>
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public string Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScenarioDataWarehouseQuery {\n");
            sb.Append("  SimulationId: ").Append(SimulationId).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(input as ScenarioDataWarehouseQuery);
        }

        /// <summary>
        /// Returns true if ScenarioDataWarehouseQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioDataWarehouseQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioDataWarehouseQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SimulationId == input.SimulationId ||
                    (this.SimulationId != null &&
                    this.SimulationId.Equals(input.SimulationId))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
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
                if (this.SimulationId != null)
                    hashCode = hashCode * 59 + this.SimulationId.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                return hashCode;
            }
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
