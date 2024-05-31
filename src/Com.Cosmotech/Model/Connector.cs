/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.4
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
    public partial class Connector : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Connector" /> class.
        /// </summary>
        /// <param name="key">the Connector key which group Connector versions.</param>
        /// <param name="name">the Connector name.</param>
        /// <param name="description">the Connector description.</param>
        /// <param name="repository">the registry repository containing the image.</param>
        /// <param name="varVersion">the Connector version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag.</param>
        /// <param name="tags">the list of tags.</param>
        /// <param name="url">an optional URL link to connector page.</param>
        /// <param name="azureManagedIdentity">whether or not the connector uses Azure Managed Identity.</param>
        /// <param name="azureAuthenticationWithCustomerAppRegistration">whether to authenticate against Azure using the app registration credentials provided by the customer.</param>
        /// <param name="ioTypes">ioTypes.</param>
        /// <param name="parameterGroups">the list of connector parameters groups.</param>
        public Connector(string key = default(string), string name = default(string), string description = default(string), string repository = default(string), string varVersion = default(string), List<string> tags = default(List<string>), string url = default(string), bool azureManagedIdentity = default(bool), bool azureAuthenticationWithCustomerAppRegistration = default(bool), List<IoTypesEnum> ioTypes = default(List<IoTypesEnum>), List<ConnectorParameterGroup> parameterGroups = default(List<ConnectorParameterGroup>))
        {
            this.Key = key;
            this.Name = name;
            this.Description = description;
            this.Repository = repository;
            this.VarVersion = varVersion;
            this.Tags = tags;
            this.Url = url;
            this.AzureManagedIdentity = azureManagedIdentity;
            this.AzureAuthenticationWithCustomerAppRegistration = azureAuthenticationWithCustomerAppRegistration;
            this.IoTypes = ioTypes;
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
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// the Connector name
        /// </summary>
        /// <value>the Connector name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
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
        [DataMember(Name = "repository", EmitDefaultValue = false)]
        public string Repository { get; set; }

        /// <summary>
        /// the Connector version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag
        /// </summary>
        /// <value>the Connector version MAJOR.MINOR.PATCH. Must be aligned with an existing repository tag</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

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
        /// Gets or Sets IoTypes
        /// </summary>
        [DataMember(Name = "ioTypes", EmitDefaultValue = false)]
        public List<IoTypesEnum> IoTypes { get; set; }

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
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
