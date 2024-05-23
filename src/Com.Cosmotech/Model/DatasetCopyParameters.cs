/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.2
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
    /// the Dataset Copy Parameters
    /// </summary>
    [DataContract(Name = "DatasetCopyParameters")]
    public partial class DatasetCopyParameters : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetCopyParameters" /> class.
        /// </summary>
        /// <param name="sourceId">the source Dataset id.</param>
        /// <param name="targetId">the target Dataset id.</param>
        /// <param name="options">freeform options to path to connectors.</param>
        public DatasetCopyParameters(string sourceId = default(string), string targetId = default(string), Dictionary<string, Object> options = default(Dictionary<string, Object>))
        {
            this.SourceId = sourceId;
            this.TargetId = targetId;
            this.Options = options;
        }

        /// <summary>
        /// the source Dataset id
        /// </summary>
        /// <value>the source Dataset id</value>
        [DataMember(Name = "sourceId", EmitDefaultValue = false)]
        public string SourceId { get; set; }

        /// <summary>
        /// the target Dataset id
        /// </summary>
        /// <value>the target Dataset id</value>
        [DataMember(Name = "targetId", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// freeform options to path to connectors
        /// </summary>
        /// <value>freeform options to path to connectors</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public Dictionary<string, Object> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatasetCopyParameters {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
