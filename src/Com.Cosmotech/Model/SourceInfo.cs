/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.4
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
    /// Source job import information
    /// </summary>
    [DataContract(Name = "SourceInfo")]
    public partial class SourceInfo : IEquatable<SourceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SourceInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceInfo" /> class.
        /// </summary>
        /// <param name="name">the source name containing the files to import.</param>
        /// <param name="location">the source location containing the files to import (required).</param>
        /// <param name="path">the source location containing the files to import.</param>
        /// <param name="jobId">indicate the last import jobId.</param>
        public SourceInfo(string name = default(string), string location = default(string), string path = default(string), string jobId = default(string))
        {
            // to ensure "location" is required (not null)
            if (location == null) {
                throw new ArgumentNullException("location is a required property for SourceInfo and cannot be null");
            }
            this.Location = location;
            this.Name = name;
            this.Path = path;
            this.JobId = jobId;
        }

        /// <summary>
        /// the source name containing the files to import
        /// </summary>
        /// <value>the source name containing the files to import</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the source location containing the files to import
        /// </summary>
        /// <value>the source location containing the files to import</value>
        [DataMember(Name = "location", IsRequired = true, EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// the source location containing the files to import
        /// </summary>
        /// <value>the source location containing the files to import</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// indicate the last import jobId
        /// </summary>
        /// <value>indicate the last import jobId</value>
        [DataMember(Name = "jobId", EmitDefaultValue = false)]
        public string JobId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SourceInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
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
            return this.Equals(input as SourceInfo);
        }

        /// <summary>
        /// Returns true if SourceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
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
