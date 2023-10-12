/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.6-SNAPSHOT
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
    /// a twin graph query in cypher language
    /// </summary>
    [DataContract(Name = "DatasetTwinGraphQuery")]
    public partial class DatasetTwinGraphQuery : IEquatable<DatasetTwinGraphQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetTwinGraphQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DatasetTwinGraphQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetTwinGraphQuery" /> class.
        /// </summary>
        /// <param name="query">the query in cypher language (required).</param>
        public DatasetTwinGraphQuery(string query = default(string))
        {
            // to ensure "query" is required (not null)
            if (query == null) {
                throw new ArgumentNullException("query is a required property for DatasetTwinGraphQuery and cannot be null");
            }
            this.Query = query;
        }

        /// <summary>
        /// the query in cypher language
        /// </summary>
        /// <value>the query in cypher language</value>
        [DataMember(Name = "query", IsRequired = true, EmitDefaultValue = false)]
        public string Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatasetTwinGraphQuery {\n");
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
            return this.Equals(input as DatasetTwinGraphQuery);
        }

        /// <summary>
        /// Returns true if DatasetTwinGraphQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of DatasetTwinGraphQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetTwinGraphQuery input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                if (this.Query != null)
                {
                    hashCode = (hashCode * 59) + this.Query.GetHashCode();
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
