/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.1.6
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
        /// the source type containing the files to import
        /// </summary>
        /// <value>the source type containing the files to import</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ADT for value: ADT
            /// </summary>
            [EnumMember(Value = "ADT")]
            ADT = 1,

            /// <summary>
            /// Enum Storage for value: Storage
            /// </summary>
            [EnumMember(Value = "Storage")]
            Storage = 2

        }


        /// <summary>
        /// the source type containing the files to import
        /// </summary>
        /// <value>the source type containing the files to import</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
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
        /// <param name="type">the source type containing the files to import (required).</param>
        public SourceInfo(string name = default(string), string location = default(string), string path = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "location" is required (not null)
            if (location == null) {
                throw new ArgumentNullException("location is a required property for SourceInfo and cannot be null");
            }
            this.Location = location;
            this.Type = type;
            this.Name = name;
            this.Path = path;
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
            sb.Append("  Type: ").Append(Type).Append("\n");
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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