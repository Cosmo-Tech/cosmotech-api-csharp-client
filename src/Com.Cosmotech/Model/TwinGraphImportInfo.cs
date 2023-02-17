/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.2-dev
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
    [DataContract(Name = "TwinGraphImportInfo")]
    public partial class TwinGraphImportInfo : IEquatable<TwinGraphImportInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwinGraphImportInfo" /> class.
        /// </summary>
        /// <param name="jobId">the import job id.</param>
        /// <param name="graphName">the twin graph name.</param>
        public TwinGraphImportInfo(string jobId = default(string), string graphName = default(string))
        {
            this.JobId = jobId;
            this.GraphName = graphName;
        }

        /// <summary>
        /// the import job id
        /// </summary>
        /// <value>the import job id</value>
        [DataMember(Name = "jobId", EmitDefaultValue = false)]
        public string JobId { get; set; }

        /// <summary>
        /// the twin graph name
        /// </summary>
        /// <value>the twin graph name</value>
        [DataMember(Name = "graphName", EmitDefaultValue = false)]
        public string GraphName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TwinGraphImportInfo {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  GraphName: ").Append(GraphName).Append("\n");
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
            return this.Equals(input as TwinGraphImportInfo);
        }

        /// <summary>
        /// Returns true if TwinGraphImportInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TwinGraphImportInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwinGraphImportInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.GraphName == input.GraphName ||
                    (this.GraphName != null &&
                    this.GraphName.Equals(input.GraphName))
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
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
                }
                if (this.GraphName != null)
                {
                    hashCode = (hashCode * 59) + this.GraphName.GetHashCode();
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
