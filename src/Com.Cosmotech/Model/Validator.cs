/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.3.6-SNAPSHOT
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
    /// a Validator to validate a Dataset
    /// </summary>
    [DataContract(Name = "Validator")]
    public partial class Validator : IEquatable<Validator>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Validator" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Validator() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Validator" /> class.
        /// </summary>
        /// <param name="name">the Validator name (required).</param>
        /// <param name="description">the Validator description.</param>
        /// <param name="repository">the registry repository containing the Validator image (required).</param>
        /// <param name="version">the Validator version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag (required).</param>
        /// <param name="url">an optional URL link to Validator page.</param>
        /// <param name="tags">the list of tags.</param>
        public Validator(string name = default(string), string description = default(string), string repository = default(string), string version = default(string), string url = default(string), List<string> tags = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Validator and cannot be null");
            }
            this.Name = name;
            // to ensure "repository" is required (not null)
            if (repository == null) {
                throw new ArgumentNullException("repository is a required property for Validator and cannot be null");
            }
            this.Repository = repository;
            // to ensure "version" is required (not null)
            if (version == null) {
                throw new ArgumentNullException("version is a required property for Validator and cannot be null");
            }
            this._Version = version;
            this.Description = description;
            this.Url = url;
            this.Tags = tags;
        }

        /// <summary>
        /// the Validator id
        /// </summary>
        /// <value>the Validator id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// the Validator name
        /// </summary>
        /// <value>the Validator name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the Validator description
        /// </summary>
        /// <value>the Validator description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// the registry repository containing the Validator image
        /// </summary>
        /// <value>the registry repository containing the Validator image</value>
        [DataMember(Name = "repository", IsRequired = true, EmitDefaultValue = false)]
        public string Repository { get; set; }

        /// <summary>
        /// the Validator version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag
        /// </summary>
        /// <value>the Validator version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// the User id which own this Validator
        /// </summary>
        /// <value>the User id which own this Validator</value>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Returns false as OwnerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOwnerId()
        {
            return false;
        }
        /// <summary>
        /// an optional URL link to Validator page
        /// </summary>
        /// <value>an optional URL link to Validator page</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// the list of tags
        /// </summary>
        /// <value>the list of tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Validator {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as Validator);
        }

        /// <summary>
        /// Returns true if Validator instances are equal
        /// </summary>
        /// <param name="input">Instance of Validator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Validator input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Repository == input.Repository ||
                    (this.Repository != null &&
                    this.Repository.Equals(input.Repository))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Repository != null)
                {
                    hashCode = (hashCode * 59) + this.Repository.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
