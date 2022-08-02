/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 1.0.3-SNAPSHOT
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
    /// a Connector setup
    /// </summary>
    [DataContract(Name = "DatasetConnector")]
    public partial class DatasetConnector : IEquatable<DatasetConnector>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetConnector" /> class.
        /// </summary>
        /// <param name="id">the Connector id.</param>
        /// <param name="name">the Connector name.</param>
        /// <param name="version">the Connector version.</param>
        /// <param name="parametersValues">parametersValues.</param>
        public DatasetConnector(string id = default(string), string name = default(string), string version = default(string), Dictionary<string, string> parametersValues = default(Dictionary<string, string>))
        {
            this.Id = id;
            this.Name = name;
            this._Version = version;
            this.ParametersValues = parametersValues;
        }

        /// <summary>
        /// the Connector id
        /// </summary>
        /// <value>the Connector id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the Connector name
        /// </summary>
        /// <value>the Connector name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the Connector version
        /// </summary>
        /// <value>the Connector version</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets ParametersValues
        /// </summary>
        [DataMember(Name = "parametersValues", EmitDefaultValue = false)]
        public Dictionary<string, string> ParametersValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatasetConnector {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  ParametersValues: ").Append(ParametersValues).Append("\n");
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
            return this.Equals(input as DatasetConnector);
        }

        /// <summary>
        /// Returns true if DatasetConnector instances are equal
        /// </summary>
        /// <param name="input">Instance of DatasetConnector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetConnector input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.ParametersValues == input.ParametersValues ||
                    this.ParametersValues != null &&
                    input.ParametersValues != null &&
                    this.ParametersValues.SequenceEqual(input.ParametersValues)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.ParametersValues != null)
                {
                    hashCode = (hashCode * 59) + this.ParametersValues.GetHashCode();
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
