/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.1-dev
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
    /// a version of a Solution
    /// </summary>
    [DataContract(Name = "Solution")]
    public partial class Solution : IEquatable<Solution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Solution" /> class.
        /// </summary>
        /// <param name="key">the Solution key which group Solution versions.</param>
        /// <param name="name">the Solution name.</param>
        /// <param name="description">the Solution description.</param>
        /// <param name="repository">the registry repository containing the image.</param>
        /// <param name="csmSimulator">the main Cosmo Tech simulator name used in standard Run Template.</param>
        /// <param name="version">the Solution version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag.</param>
        /// <param name="sdkVersion">the MAJOR.MINOR version used to build this solution.</param>
        /// <param name="url">an optional URL link to solution page.</param>
        /// <param name="tags">the list of tags.</param>
        /// <param name="parameters">the list of Run Template Parameters.</param>
        /// <param name="parameterGroups">the list of parameters groups for the Run Templates.</param>
        /// <param name="runTemplates">list of Run Template.</param>
        public Solution(string key = default(string), string name = default(string), string description = default(string), string repository = default(string), string csmSimulator = default(string), string version = default(string), string sdkVersion = default(string), string url = default(string), List<string> tags = default(List<string>), List<RunTemplateParameter> parameters = default(List<RunTemplateParameter>), List<RunTemplateParameterGroup> parameterGroups = default(List<RunTemplateParameterGroup>), List<RunTemplate> runTemplates = default(List<RunTemplate>))
        {
            this.Key = key;
            this.Name = name;
            this.Description = description;
            this.Repository = repository;
            this.CsmSimulator = csmSimulator;
            this._Version = version;
            this.SdkVersion = sdkVersion;
            this.Url = url;
            this.Tags = tags;
            this.Parameters = parameters;
            this.ParameterGroups = parameterGroups;
            this.RunTemplates = runTemplates;
        }

        /// <summary>
        /// the Solution version unique identifier
        /// </summary>
        /// <value>the Solution version unique identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
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
        /// the Solution key which group Solution versions
        /// </summary>
        /// <value>the Solution key which group Solution versions</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// the Solution name
        /// </summary>
        /// <value>the Solution name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the Solution description
        /// </summary>
        /// <value>the Solution description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// the registry repository containing the image
        /// </summary>
        /// <value>the registry repository containing the image</value>
        [DataMember(Name = "repository", EmitDefaultValue = false)]
        public string Repository { get; set; }

        /// <summary>
        /// the main Cosmo Tech simulator name used in standard Run Template
        /// </summary>
        /// <value>the main Cosmo Tech simulator name used in standard Run Template</value>
        [DataMember(Name = "csmSimulator", EmitDefaultValue = false)]
        public string CsmSimulator { get; set; }

        /// <summary>
        /// the Solution version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag
        /// </summary>
        /// <value>the Solution version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// the User id which own this Solution
        /// </summary>
        /// <value>the User id which own this Solution</value>
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
        /// the MAJOR.MINOR version used to build this solution
        /// </summary>
        /// <value>the MAJOR.MINOR version used to build this solution</value>
        [DataMember(Name = "sdkVersion", EmitDefaultValue = false)]
        public string SdkVersion { get; set; }

        /// <summary>
        /// an optional URL link to solution page
        /// </summary>
        /// <value>an optional URL link to solution page</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// the list of tags
        /// </summary>
        /// <value>the list of tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// the list of Run Template Parameters
        /// </summary>
        /// <value>the list of Run Template Parameters</value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<RunTemplateParameter> Parameters { get; set; }

        /// <summary>
        /// the list of parameters groups for the Run Templates
        /// </summary>
        /// <value>the list of parameters groups for the Run Templates</value>
        [DataMember(Name = "parameterGroups", EmitDefaultValue = false)]
        public List<RunTemplateParameterGroup> ParameterGroups { get; set; }

        /// <summary>
        /// list of Run Template
        /// </summary>
        /// <value>list of Run Template</value>
        [DataMember(Name = "runTemplates", EmitDefaultValue = false)]
        public List<RunTemplate> RunTemplates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Solution {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
            sb.Append("  CsmSimulator: ").Append(CsmSimulator).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  SdkVersion: ").Append(SdkVersion).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  ParameterGroups: ").Append(ParameterGroups).Append("\n");
            sb.Append("  RunTemplates: ").Append(RunTemplates).Append("\n");
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
            return this.Equals(input as Solution);
        }

        /// <summary>
        /// Returns true if Solution instances are equal
        /// </summary>
        /// <param name="input">Instance of Solution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Solution input)
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
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                    this.CsmSimulator == input.CsmSimulator ||
                    (this.CsmSimulator != null &&
                    this.CsmSimulator.Equals(input.CsmSimulator))
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
                    this.SdkVersion == input.SdkVersion ||
                    (this.SdkVersion != null &&
                    this.SdkVersion.Equals(input.SdkVersion))
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
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.ParameterGroups == input.ParameterGroups ||
                    this.ParameterGroups != null &&
                    input.ParameterGroups != null &&
                    this.ParameterGroups.SequenceEqual(input.ParameterGroups)
                ) && 
                (
                    this.RunTemplates == input.RunTemplates ||
                    this.RunTemplates != null &&
                    input.RunTemplates != null &&
                    this.RunTemplates.SequenceEqual(input.RunTemplates)
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
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
                if (this.CsmSimulator != null)
                {
                    hashCode = (hashCode * 59) + this.CsmSimulator.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.SdkVersion != null)
                {
                    hashCode = (hashCode * 59) + this.SdkVersion.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.ParameterGroups != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterGroups.GetHashCode();
                }
                if (this.RunTemplates != null)
                {
                    hashCode = (hashCode * 59) + this.RunTemplates.GetHashCode();
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
