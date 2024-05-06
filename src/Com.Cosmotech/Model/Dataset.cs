/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.5
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
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name = "sourceType", EmitDefaultValue = false)]
        public DatasetSourceType? SourceType { get; set; }
        /// <summary>
        /// the Dataset ingestion status
        /// </summary>
        /// <value>the Dataset ingestion status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IngestionStatusEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 1,

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 2,

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 3,

            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 4

        }


        /// <summary>
        /// the Dataset ingestion status
        /// </summary>
        /// <value>the Dataset ingestion status</value>
        [DataMember(Name = "ingestionStatus", EmitDefaultValue = true)]
        public IngestionStatusEnum? IngestionStatus { get; set; }
        /// <summary>
        /// the twincache data status
        /// </summary>
        /// <value>the twincache data status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TwincacheStatusEnum
        {
            /// <summary>
            /// Enum EMPTY for value: EMPTY
            /// </summary>
            [EnumMember(Value = "EMPTY")]
            EMPTY = 1,

            /// <summary>
            /// Enum FULL for value: FULL
            /// </summary>
            [EnumMember(Value = "FULL")]
            FULL = 2

        }


        /// <summary>
        /// the twincache data status
        /// </summary>
        /// <value>the twincache data status</value>
        [DataMember(Name = "twincacheStatus", EmitDefaultValue = true)]
        public TwincacheStatusEnum? TwincacheStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="name">the Dataset name.</param>
        /// <param name="description">the Dataset description.</param>
        /// <param name="parentId">the Dataset id which is the parent of this Dataset.</param>
        /// <param name="linkedWorkspaceIdList">list of workspace linked to this dataset.</param>
        /// <param name="twingraphId">the twin graph id.</param>
        /// <param name="main">is this the main dataset.</param>
        /// <param name="sourceType">sourceType.</param>
        /// <param name="source">source.</param>
        /// <param name="ingestionStatus">the Dataset ingestion status.</param>
        /// <param name="twincacheStatus">the twincache data status.</param>
        /// <param name="queries">the list of queries.</param>
        /// <param name="tags">the list of tags.</param>
        /// <param name="connector">connector.</param>
        /// <param name="fragmentsIds">the list of other Datasets ids to compose as fragments.</param>
        /// <param name="validatorId">the validator id.</param>
        /// <param name="compatibility">the list of compatible Solutions versions.</param>
        /// <param name="security">security.</param>
        public Dataset(string name = default(string), string description = default(string), string parentId = default(string), List<string> linkedWorkspaceIdList = default(List<string>), string twingraphId = default(string), bool main = default(bool), DatasetSourceType? sourceType = default(DatasetSourceType?), SourceInfo source = default(SourceInfo), IngestionStatusEnum? ingestionStatus = default(IngestionStatusEnum?), TwincacheStatusEnum? twincacheStatus = default(TwincacheStatusEnum?), List<string> queries = default(List<string>), List<string> tags = default(List<string>), DatasetConnector connector = default(DatasetConnector), List<string> fragmentsIds = default(List<string>), string validatorId = default(string), List<DatasetCompatibility> compatibility = default(List<DatasetCompatibility>), DatasetSecurity security = default(DatasetSecurity))
        {
            this.Name = name;
            this.Description = description;
            this.ParentId = parentId;
            this.LinkedWorkspaceIdList = linkedWorkspaceIdList;
            this.TwingraphId = twingraphId;
            this.Main = main;
            this.SourceType = sourceType;
            this.Source = source;
            this.IngestionStatus = ingestionStatus;
            this.TwincacheStatus = twincacheStatus;
            this.Queries = queries;
            this.Tags = tags;
            this.Connector = connector;
            this.FragmentsIds = fragmentsIds;
            this.ValidatorId = validatorId;
            this.Compatibility = compatibility;
            this.Security = security;
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
        /// the name of the owner
        /// </summary>
        /// <value>the name of the owner</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; private set; }

        /// <summary>
        /// Returns false as OwnerName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOwnerName()
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
        /// the Dataset id which is the parent of this Dataset
        /// </summary>
        /// <value>the Dataset id which is the parent of this Dataset</value>
        [DataMember(Name = "parentId", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// list of workspace linked to this dataset
        /// </summary>
        /// <value>list of workspace linked to this dataset</value>
        [DataMember(Name = "linkedWorkspaceIdList", EmitDefaultValue = false)]
        public List<string> LinkedWorkspaceIdList { get; set; }

        /// <summary>
        /// the twin graph id
        /// </summary>
        /// <value>the twin graph id</value>
        [DataMember(Name = "twingraphId", EmitDefaultValue = false)]
        public string TwingraphId { get; set; }

        /// <summary>
        /// is this the main dataset
        /// </summary>
        /// <value>is this the main dataset</value>
        [DataMember(Name = "main", EmitDefaultValue = true)]
        public bool Main { get; set; }

        /// <summary>
        /// the Dataset creation date
        /// </summary>
        /// <value>the Dataset creation date</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public long CreationDate { get; private set; }

        /// <summary>
        /// Returns false as CreationDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreationDate()
        {
            return false;
        }
        /// <summary>
        /// the last time a refresh was done
        /// </summary>
        /// <value>the last time a refresh was done</value>
        [DataMember(Name = "refreshDate", EmitDefaultValue = false)]
        public long RefreshDate { get; private set; }

        /// <summary>
        /// Returns false as RefreshDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRefreshDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public SourceInfo Source { get; set; }

        /// <summary>
        /// the list of queries
        /// </summary>
        /// <value>the list of queries</value>
        [DataMember(Name = "queries", EmitDefaultValue = false)]
        public List<string> Queries { get; set; }

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
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = true)]
        public DatasetSecurity Security { get; set; }

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
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  LinkedWorkspaceIdList: ").Append(LinkedWorkspaceIdList).Append("\n");
            sb.Append("  TwingraphId: ").Append(TwingraphId).Append("\n");
            sb.Append("  Main: ").Append(Main).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  RefreshDate: ").Append(RefreshDate).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  IngestionStatus: ").Append(IngestionStatus).Append("\n");
            sb.Append("  TwincacheStatus: ").Append(TwincacheStatus).Append("\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Connector: ").Append(Connector).Append("\n");
            sb.Append("  FragmentsIds: ").Append(FragmentsIds).Append("\n");
            sb.Append("  ValidatorId: ").Append(ValidatorId).Append("\n");
            sb.Append("  Compatibility: ").Append(Compatibility).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.LinkedWorkspaceIdList == input.LinkedWorkspaceIdList ||
                    this.LinkedWorkspaceIdList != null &&
                    input.LinkedWorkspaceIdList != null &&
                    this.LinkedWorkspaceIdList.SequenceEqual(input.LinkedWorkspaceIdList)
                ) && 
                (
                    this.TwingraphId == input.TwingraphId ||
                    (this.TwingraphId != null &&
                    this.TwingraphId.Equals(input.TwingraphId))
                ) && 
                (
                    this.Main == input.Main ||
                    this.Main.Equals(input.Main)
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    this.CreationDate.Equals(input.CreationDate)
                ) && 
                (
                    this.RefreshDate == input.RefreshDate ||
                    this.RefreshDate.Equals(input.RefreshDate)
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    this.SourceType.Equals(input.SourceType)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.IngestionStatus == input.IngestionStatus ||
                    this.IngestionStatus.Equals(input.IngestionStatus)
                ) && 
                (
                    this.TwincacheStatus == input.TwincacheStatus ||
                    this.TwincacheStatus.Equals(input.TwincacheStatus)
                ) && 
                (
                    this.Queries == input.Queries ||
                    this.Queries != null &&
                    input.Queries != null &&
                    this.Queries.SequenceEqual(input.Queries)
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
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.OwnerName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerName.GetHashCode();
                }
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.LinkedWorkspaceIdList != null)
                {
                    hashCode = (hashCode * 59) + this.LinkedWorkspaceIdList.GetHashCode();
                }
                if (this.TwingraphId != null)
                {
                    hashCode = (hashCode * 59) + this.TwingraphId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Main.GetHashCode();
                hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                hashCode = (hashCode * 59) + this.RefreshDate.GetHashCode();
                hashCode = (hashCode * 59) + this.SourceType.GetHashCode();
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IngestionStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.TwincacheStatus.GetHashCode();
                if (this.Queries != null)
                {
                    hashCode = (hashCode * 59) + this.Queries.GetHashCode();
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
                if (this.Security != null)
                {
                    hashCode = (hashCode * 59) + this.Security.GetHashCode();
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
