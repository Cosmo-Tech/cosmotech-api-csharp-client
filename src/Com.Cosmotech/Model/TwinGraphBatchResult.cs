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
    /// Processing result
    /// </summary>
    [DataContract(Name = "TwinGraphBatchResult")]
    public partial class TwinGraphBatchResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwinGraphBatchResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TwinGraphBatchResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwinGraphBatchResult" /> class.
        /// </summary>
        /// <param name="totalLines">totalLines (required).</param>
        /// <param name="processedLines">processedLines (required).</param>
        /// <param name="errors">errors (required).</param>
        public TwinGraphBatchResult(int totalLines = default(int), int processedLines = default(int), List<string> errors = default(List<string>))
        {
            this.TotalLines = totalLines;
            this.ProcessedLines = processedLines;
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new ArgumentNullException("errors is a required property for TwinGraphBatchResult and cannot be null");
            }
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets TotalLines
        /// </summary>
        [DataMember(Name = "totalLines", IsRequired = true, EmitDefaultValue = true)]
        public int TotalLines { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedLines
        /// </summary>
        [DataMember(Name = "processedLines", IsRequired = true, EmitDefaultValue = true)]
        public int ProcessedLines { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TwinGraphBatchResult {\n");
            sb.Append("  TotalLines: ").Append(TotalLines).Append("\n");
            sb.Append("  ProcessedLines: ").Append(ProcessedLines).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
