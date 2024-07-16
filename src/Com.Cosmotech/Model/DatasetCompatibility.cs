/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.8
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
    /// a Dataset compatibility constraint to a Solution version open range
    /// </summary>
    [DataContract(Name = "DatasetCompatibility")]
    public partial class DatasetCompatibility : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetCompatibility" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DatasetCompatibility() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetCompatibility" /> class.
        /// </summary>
        /// <param name="solutionKey">the Solution key which group Solution versions (required).</param>
        /// <param name="minimumVersion">the Solution minimum version compatibility (version included).</param>
        /// <param name="maximumVersion">the Solution maximum version compatibility (version included).</param>
        public DatasetCompatibility(string solutionKey = default(string), string minimumVersion = default(string), string maximumVersion = default(string))
        {
            // to ensure "solutionKey" is required (not null)
            if (solutionKey == null)
            {
                throw new ArgumentNullException("solutionKey is a required property for DatasetCompatibility and cannot be null");
            }
            this.SolutionKey = solutionKey;
            this.MinimumVersion = minimumVersion;
            this.MaximumVersion = maximumVersion;
        }

        /// <summary>
        /// the Solution key which group Solution versions
        /// </summary>
        /// <value>the Solution key which group Solution versions</value>
        [DataMember(Name = "solutionKey", IsRequired = true, EmitDefaultValue = true)]
        public string SolutionKey { get; set; }

        /// <summary>
        /// the Solution minimum version compatibility (version included)
        /// </summary>
        /// <value>the Solution minimum version compatibility (version included)</value>
        [DataMember(Name = "minimumVersion", EmitDefaultValue = false)]
        public string MinimumVersion { get; set; }

        /// <summary>
        /// the Solution maximum version compatibility (version included)
        /// </summary>
        /// <value>the Solution maximum version compatibility (version included)</value>
        [DataMember(Name = "maximumVersion", EmitDefaultValue = false)]
        public string MaximumVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatasetCompatibility {\n");
            sb.Append("  SolutionKey: ").Append(SolutionKey).Append("\n");
            sb.Append("  MinimumVersion: ").Append(MinimumVersion).Append("\n");
            sb.Append("  MaximumVersion: ").Append(MaximumVersion).Append("\n");
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
