/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.5
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
    [DataContract(Name = "DatasetTwinGraphInfo")]
    public partial class DatasetTwinGraphInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetTwinGraphInfo" /> class.
        /// </summary>
        /// <param name="jobId">the import job id.</param>
        /// <param name="datasetId">the Dataset id.</param>
        /// <param name="status">Twingraph status.</param>
        public DatasetTwinGraphInfo(string jobId = default(string), string datasetId = default(string), string status = default(string))
        {
            this.JobId = jobId;
            this.DatasetId = datasetId;
            this.Status = status;
        }

        /// <summary>
        /// the import job id
        /// </summary>
        /// <value>the import job id</value>
        [DataMember(Name = "jobId", EmitDefaultValue = false)]
        public string JobId { get; set; }

        /// <summary>
        /// the Dataset id
        /// </summary>
        /// <value>the Dataset id</value>
        [DataMember(Name = "datasetId", EmitDefaultValue = false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Twingraph status
        /// </summary>
        /// <value>Twingraph status</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatasetTwinGraphInfo {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  DatasetId: ").Append(DatasetId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
