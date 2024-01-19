/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.1-SNAPSHOT
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
    /// the search options
    /// </summary>
    [DataContract(Name = "DatasetSearch")]
    public partial class DatasetSearch : IEquatable<DatasetSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSearch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DatasetSearch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSearch" /> class.
        /// </summary>
        /// <param name="datasetTags">the dataset tag list to search (required).</param>
        public DatasetSearch(List<string> datasetTags = default(List<string>))
        {
            // to ensure "datasetTags" is required (not null)
            if (datasetTags == null) {
                throw new ArgumentNullException("datasetTags is a required property for DatasetSearch and cannot be null");
            }
            this.DatasetTags = datasetTags;
        }

        /// <summary>
        /// the dataset tag list to search
        /// </summary>
        /// <value>the dataset tag list to search</value>
        [DataMember(Name = "datasetTags", IsRequired = true, EmitDefaultValue = false)]
        public List<string> DatasetTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatasetSearch {\n");
            sb.Append("  DatasetTags: ").Append(DatasetTags).Append("\n");
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
            return this.Equals(input as DatasetSearch);
        }

        /// <summary>
        /// Returns true if DatasetSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of DatasetSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetSearch input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DatasetTags == input.DatasetTags ||
                    this.DatasetTags != null &&
                    input.DatasetTags != null &&
                    this.DatasetTags.SequenceEqual(input.DatasetTags)
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
                if (this.DatasetTags != null)
                {
                    hashCode = (hashCode * 59) + this.DatasetTags.GetHashCode();
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
