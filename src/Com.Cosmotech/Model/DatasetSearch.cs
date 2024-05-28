/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.3
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
    public partial class DatasetSearch : IValidatableObject
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
            if (datasetTags == null)
            {
                throw new ArgumentNullException("datasetTags is a required property for DatasetSearch and cannot be null");
            }
            this.DatasetTags = datasetTags;
        }

        /// <summary>
        /// the dataset tag list to search
        /// </summary>
        /// <value>the dataset tag list to search</value>
        [DataMember(Name = "datasetTags", IsRequired = true, EmitDefaultValue = true)]
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
