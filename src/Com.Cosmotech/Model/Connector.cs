/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 1.0.1-dev
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
    /// a version of a Connector
    /// </summary>
    [DataContract(Name = "Connector")]
    public partial class Connector : IEquatable<Connector>, IValidatableObject
    {
        /// <summary>
        /// The read and write capabilities of connector
        /// </summary>
        /// <value>The read and write capabilities of connector</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IoTypesEnum
        {
            /// <summary>
            /// Enum Read for value: read
            /// </summary>
            [EnumMember(Value = "read")]
            Read = 1,

            /// <summary>
            /// Enum Write for value: write
            /// </summary>
            [EnumMember(Value = "write")]
            Write = 2

        }



        /// <summary>
        /// Gets or Sets IoTypes
        /// </summary>
        [DataMember(Name = "ioTypes", IsRequired = true, EmitDefaultValue = false)]
        public List<IoTypesEnum> IoTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Connector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Connector() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Connector" /> class.
        /// </summary>
        /// <param name="key">the Connector key which group Connector versions (required).</param>
        /// <param name="name">the Connector name (required).</param>
        /// <param name="description">the Connector description.</param>
        /// <param name="repository">the registry repository containing the image (required).</param>
        /// <param name="version">the Connector version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag (required).</param>
        /// <param name="tags">the list of tags.</param>
        /// <param name="url">an optional URL link to connector page.</param>
        /// <param name="azureManagedIdentity">whether or not the connector uses Azure Managed Identity.</param>
        /// <param name="azureAuthenticationWithCustomerAppRegistration">whether to authenticate against Azure using the app registration credentials provided by the customer.</param>
        /// <param name="ioTypes">ioTypes (required).</param>
        /// <param name="parameterGroups">the list of connector parameters groups.</param>
        public Connector(string key = default(string), string name = default(string), string description = default(string), string repository = default(string), string version = default(string), List<string> tags = default(List<string>), string url = default(string), bool azureManagedIdentity = default(bool), bool azureAuthenticationWithCustomerAppRegistration = default(bool), List<IoTypesEnum> ioTypes = default(List<IoTypesEnum>), List<ConnectorParameterGroup> parameterGroups = default(List<ConnectorParameterGroup>))
        {
            // to ensure "key" is required (not null)
            if (key == null) {
                throw new ArgumentNullException("key is a required property for Connector and cannot be null");
            }
            this.Key = key;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Connector and cannot be null");
            }
            this.Name = name;
            // to ensure "repository" is required (not null)
            if (repository == null) {
                throw new ArgumentNullException("repository is a required property for Connector and cannot be null");
            }
            this.Repository = repository;
            // to ensure "version" is required (not null)
            if (version == null) {
                throw new ArgumentNullException("version is a required property for Connector and cannot be null");
            }
            this._Version = version;
            // to ensure "ioTypes" is required (not null)
            if (ioTypes == null) {
                throw new ArgumentNullException("ioTypes is a required property for Connector and cannot be null");
            }
            this.IoTypes = ioTypes;
            this.Description = description;
            this.Tags = tags;
            this.Url = url;
            this.AzureManagedIdentity = azureManagedIdentity;
            this.AzureAuthenticationWithCustomerAppRegistration = azureAuthenticationWithCustomerAppRegistration;
            this.ParameterGroups = parameterGroups;
        }

        /// <summary>
        /// the Connector version unique identifier
        /// </summary>
        /// <value>the Connector version unique identifier</value>
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
        /// the Connector key which group Connector versions
        /// </summary>
        /// <value>the Connector key which group Connector versions</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// the Connector name
        /// </summary>
        /// <value>the Connector name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the Connector description
        /// </summary>
        /// <value>the Connector description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// the registry repository containing the image
        /// </summary>
        /// <value>the registry repository containing the image</value>
        [DataMember(Name = "repository", IsRequired = true, EmitDefaultValue = false)]
        public string Repository { get; set; }

        /// <summary>
        /// the Connector version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag
        /// </summary>
        /// <value>the Connector version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// the list of tags
        /// </summary>
        /// <value>the list of tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// the user id which own this connector version
        /// </summary>
        /// <value>the user id which own this connector version</value>
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
        /// an optional URL link to connector page
        /// </summary>
        /// <value>an optional URL link to connector page</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// whether or not the connector uses Azure Managed Identity
        /// </summary>
        /// <value>whether or not the connector uses Azure Managed Identity</value>
        [DataMember(Name = "azureManagedIdentity", EmitDefaultValue = true)]
        public bool AzureManagedIdentity { get; set; }

        /// <summary>
        /// whether to authenticate against Azure using the app registration credentials provided by the customer
        /// </summary>
        /// <value>whether to authenticate against Azure using the app registration credentials provided by the customer</value>
        [DataMember(Name = "azureAuthenticationWithCustomerAppRegistration", EmitDefaultValue = true)]
        public bool AzureAuthenticationWithCustomerAppRegistration { get; set; }

        /// <summary>
        /// the list of connector parameters groups
        /// </summary>
        /// <value>the list of connector parameters groups</value>
        [DataMember(Name = "parameterGroups", EmitDefaultValue = false)]
        public List<ConnectorParameterGroup> ParameterGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Connector {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AzureManagedIdentity: ").Append(AzureManagedIdentity).Append("\n");
            sb.Append("  AzureAuthenticationWithCustomerAppRegistration: ").Append(AzureAuthenticationWithCustomerAppRegistration).Append("\n");
            sb.Append("  IoTypes: ").Append(IoTypes).Append("\n");
            sb.Append("  ParameterGroups: ").Append(ParameterGroups).Append("\n");
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
            return this.Equals(input as Connector);
        }

        /// <summary>
        /// Returns true if Connector instances are equal
        /// </summary>
        /// <param name="input">Instance of Connector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Connector input)
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
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                    this.AzureManagedIdentity == input.AzureManagedIdentity ||
                    this.AzureManagedIdentity.Equals(input.AzureManagedIdentity)
                ) && 
                (
                    this.AzureAuthenticationWithCustomerAppRegistration == input.AzureAuthenticationWithCustomerAppRegistration ||
                    this.AzureAuthenticationWithCustomerAppRegistration.Equals(input.AzureAuthenticationWithCustomerAppRegistration)
                ) && 
                (
                    this.IoTypes == input.IoTypes ||
                    this.IoTypes.SequenceEqual(input.IoTypes)
                ) && 
                (
                    this.ParameterGroups == input.ParameterGroups ||
                    this.ParameterGroups != null &&
                    input.ParameterGroups != null &&
                    this.ParameterGroups.SequenceEqual(input.ParameterGroups)
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
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AzureManagedIdentity.GetHashCode();
                hashCode = (hashCode * 59) + this.AzureAuthenticationWithCustomerAppRegistration.GetHashCode();
                hashCode = (hashCode * 59) + this.IoTypes.GetHashCode();
                if (this.ParameterGroups != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterGroups.GetHashCode();
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
