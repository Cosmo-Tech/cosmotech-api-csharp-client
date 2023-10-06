/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.4-test
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
    /// a Dataset
    /// </summary>
    [DataContract(Name = "Dataset")]
    public partial class Dataset : IEquatable<Dataset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="name">the Dataset name.</param>
        /// <param name="description">the Dataset description.</param>
        /// <param name="tags">the list of tags.</param>
        /// <param name="connector">connector.</param>
        /// <param name="fragmentsIds">the list of other Datasets ids to compose as fragments.</param>
        /// <param name="validatorId">the validator id.</param>
        /// <param name="compatibility">the list of compatible Solutions versions.</param>
        public Dataset(string name = default(string), string description = default(string), List<string> tags = default(List<string>), DatasetConnector connector = default(DatasetConnector), List<string> fragmentsIds = default(List<string>), string validatorId = default(string), List<DatasetCompatibility> compatibility = default(List<DatasetCompatibility>))
        {
            this.Name = name;
            this.Description = description;
            this.Tags = tags;
            this.Connector = connector;
            this.FragmentsIds = fragmentsIds;
            this.ValidatorId = validatorId;
            this.Compatibility = compatibility;
        }

        /// <summary>
        /// the Dataset unique identifier
        /// </summary>
        /// <value>the Dataset unique identifier</value>
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
        /// the Dataset name
        /// </summary>
        /// <value>the Dataset name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the Dataset description
        /// </summary>
        /// <value>the Dataset description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// the User id which own this Dataset
        /// </summary>
        /// <value>the User id which own this Dataset</value>
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
        /// the Organization Id related to this Dataset
        /// </summary>
        /// <value>the Organization Id related to this Dataset</value>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public string OrganizationId { get; private set; }

        /// <summary>
        /// Returns false as OrganizationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrganizationId()
        {
            return false;
        }
        /// <summary>
        /// the list of tags
        /// </summary>
        /// <value>the list of tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Connector
        /// </summary>
        [DataMember(Name = "connector", EmitDefaultValue = false)]
        public DatasetConnector Connector { get; set; }

        /// <summary>
        /// the list of other Datasets ids to compose as fragments
        /// </summary>
        /// <value>the list of other Datasets ids to compose as fragments</value>
        [DataMember(Name = "fragmentsIds", EmitDefaultValue = false)]
        public List<string> FragmentsIds { get; set; }

        /// <summary>
        /// the validator id
        /// </summary>
        /// <value>the validator id</value>
        [DataMember(Name = "validatorId", EmitDefaultValue = false)]
        public string ValidatorId { get; set; }

        /// <summary>
        /// the list of compatible Solutions versions
        /// </summary>
        /// <value>the list of compatible Solutions versions</value>
        [DataMember(Name = "compatibility", EmitDefaultValue = false)]
        public List<DatasetCompatibility> Compatibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Dataset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Connector: ").Append(Connector).Append("\n");
            sb.Append("  FragmentsIds: ").Append(FragmentsIds).Append("\n");
            sb.Append("  ValidatorId: ").Append(ValidatorId).Append("\n");
            sb.Append("  Compatibility: ").Append(Compatibility).Append("\n");
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
            return this.Equals(input as Dataset);
        }

        /// <summary>
        /// Returns true if Dataset instances are equal
        /// </summary>
        /// <param name="input">Instance of Dataset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dataset input)
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
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Connector == input.Connector ||
                    (this.Connector != null &&
                    this.Connector.Equals(input.Connector))
                ) && 
                (
                    this.FragmentsIds == input.FragmentsIds ||
                    this.FragmentsIds != null &&
                    input.FragmentsIds != null &&
                    this.FragmentsIds.SequenceEqual(input.FragmentsIds)
                ) && 
                (
                    this.ValidatorId == input.ValidatorId ||
                    (this.ValidatorId != null &&
                    this.ValidatorId.Equals(input.ValidatorId))
                ) && 
                (
                    this.Compatibility == input.Compatibility ||
                    this.Compatibility != null &&
                    input.Compatibility != null &&
                    this.Compatibility.SequenceEqual(input.Compatibility)
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
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Connector != null)
                {
                    hashCode = (hashCode * 59) + this.Connector.GetHashCode();
                }
                if (this.FragmentsIds != null)
                {
                    hashCode = (hashCode * 59) + this.FragmentsIds.GetHashCode();
                }
                if (this.ValidatorId != null)
                {
                    hashCode = (hashCode * 59) + this.ValidatorId.GetHashCode();
                }
                if (this.Compatibility != null)
                {
                    hashCode = (hashCode * 59) + this.Compatibility.GetHashCode();
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
