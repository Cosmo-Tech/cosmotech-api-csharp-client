/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.8
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
    /// a Runner with base information
    /// </summary>
    [DataContract(Name = "Runner")]
    public partial class Runner : IEquatable<Runner>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ValidationStatus
        /// </summary>
        [DataMember(Name = "validationStatus", EmitDefaultValue = true)]
        public RunnerValidationStatus? ValidationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Runner" /> class.
        /// </summary>
        /// <param name="name">the Runner name.</param>
        /// <param name="description">the Runner description.</param>
        /// <param name="tags">the list of tags.</param>
        /// <param name="parentId">the Runner parent id.</param>
        /// <param name="runTemplateId">the Solution Run Template Id associated with this Runner.</param>
        /// <param name="datasetList">the list of Dataset Id associated to this Runner Run Template.</param>
        /// <param name="runSizing">runSizing.</param>
        /// <param name="parametersValues">the list of Solution Run Template parameters values.</param>
        /// <param name="lastRunId">last run id from current runner.</param>
        /// <param name="validationStatus">validationStatus.</param>
        /// <param name="security">security.</param>
        public Runner(string name = default(string), string description = default(string), List<string> tags = default(List<string>), string parentId = default(string), string runTemplateId = default(string), List<string> datasetList = default(List<string>), RunnerResourceSizing runSizing = default(RunnerResourceSizing), List<RunnerRunTemplateParameterValue> parametersValues = default(List<RunnerRunTemplateParameterValue>), string lastRunId = default(string), RunnerValidationStatus? validationStatus = default(RunnerValidationStatus?), RunnerSecurity security = default(RunnerSecurity))
        {
            this.Name = name;
            this.Description = description;
            this.Tags = tags;
            this.ParentId = parentId;
            this.RunTemplateId = runTemplateId;
            this.DatasetList = datasetList;
            this.RunSizing = runSizing;
            this.ParametersValues = parametersValues;
            this.LastRunId = lastRunId;
            this.ValidationStatus = validationStatus;
            this.Security = security;
        }

        /// <summary>
        /// the Runner unique identifier
        /// </summary>
        /// <value>the Runner unique identifier</value>
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
        /// the Runner name
        /// </summary>
        /// <value>the Runner name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the Runner description
        /// </summary>
        /// <value>the Runner description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// the list of tags
        /// </summary>
        /// <value>the list of tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// the Runner parent id
        /// </summary>
        /// <value>the Runner parent id</value>
        [DataMember(Name = "parentId", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// the user id which own this Runner
        /// </summary>
        /// <value>the user id which own this Runner</value>
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
        /// the runner root id
        /// </summary>
        /// <value>the runner root id</value>
        [DataMember(Name = "rootId", EmitDefaultValue = false)]
        public string RootId { get; private set; }

        /// <summary>
        /// Returns false as RootId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRootId()
        {
            return false;
        }
        /// <summary>
        /// the Solution Id associated with this Runner
        /// </summary>
        /// <value>the Solution Id associated with this Runner</value>
        [DataMember(Name = "solutionId", EmitDefaultValue = false)]
        public string SolutionId { get; private set; }

        /// <summary>
        /// Returns false as SolutionId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSolutionId()
        {
            return false;
        }
        /// <summary>
        /// the Solution Run Template Id associated with this Runner
        /// </summary>
        /// <value>the Solution Run Template Id associated with this Runner</value>
        [DataMember(Name = "runTemplateId", EmitDefaultValue = false)]
        public string RunTemplateId { get; set; }

        /// <summary>
        /// the associated Organization Id
        /// </summary>
        /// <value>the associated Organization Id</value>
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
        /// the associated Workspace Id
        /// </summary>
        /// <value>the associated Workspace Id</value>
        [DataMember(Name = "workspaceId", EmitDefaultValue = false)]
        public string WorkspaceId { get; private set; }

        /// <summary>
        /// Returns false as WorkspaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWorkspaceId()
        {
            return false;
        }
        /// <summary>
        /// the Runner creation date
        /// </summary>
        /// <value>the Runner creation date</value>
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
        /// the last time a Runner was updated
        /// </summary>
        /// <value>the last time a Runner was updated</value>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public long LastUpdate { get; private set; }

        /// <summary>
        /// Returns false as LastUpdate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdate()
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
        /// the Solution name
        /// </summary>
        /// <value>the Solution name</value>
        [DataMember(Name = "solutionName", EmitDefaultValue = false)]
        public string SolutionName { get; private set; }

        /// <summary>
        /// Returns false as SolutionName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSolutionName()
        {
            return false;
        }
        /// <summary>
        /// the Solution Run Template name associated with this Runner
        /// </summary>
        /// <value>the Solution Run Template name associated with this Runner</value>
        [DataMember(Name = "runTemplateName", EmitDefaultValue = false)]
        public string RunTemplateName { get; private set; }

        /// <summary>
        /// Returns false as RunTemplateName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRunTemplateName()
        {
            return false;
        }
        /// <summary>
        /// the list of Dataset Id associated to this Runner Run Template
        /// </summary>
        /// <value>the list of Dataset Id associated to this Runner Run Template</value>
        [DataMember(Name = "datasetList", EmitDefaultValue = false)]
        public List<string> DatasetList { get; set; }

        /// <summary>
        /// Gets or Sets RunSizing
        /// </summary>
        [DataMember(Name = "runSizing", EmitDefaultValue = false)]
        public RunnerResourceSizing RunSizing { get; set; }

        /// <summary>
        /// the list of Solution Run Template parameters values
        /// </summary>
        /// <value>the list of Solution Run Template parameters values</value>
        [DataMember(Name = "parametersValues", EmitDefaultValue = false)]
        public List<RunnerRunTemplateParameterValue> ParametersValues { get; set; }

        /// <summary>
        /// last run id from current runner
        /// </summary>
        /// <value>last run id from current runner</value>
        [DataMember(Name = "lastRunId", EmitDefaultValue = false)]
        public string LastRunId { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = true)]
        public RunnerSecurity Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Runner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  RootId: ").Append(RootId).Append("\n");
            sb.Append("  SolutionId: ").Append(SolutionId).Append("\n");
            sb.Append("  RunTemplateId: ").Append(RunTemplateId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  SolutionName: ").Append(SolutionName).Append("\n");
            sb.Append("  RunTemplateName: ").Append(RunTemplateName).Append("\n");
            sb.Append("  DatasetList: ").Append(DatasetList).Append("\n");
            sb.Append("  RunSizing: ").Append(RunSizing).Append("\n");
            sb.Append("  ParametersValues: ").Append(ParametersValues).Append("\n");
            sb.Append("  LastRunId: ").Append(LastRunId).Append("\n");
            sb.Append("  ValidationStatus: ").Append(ValidationStatus).Append("\n");
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
            return this.Equals(input as Runner);
        }

        /// <summary>
        /// Returns true if Runner instances are equal
        /// </summary>
        /// <param name="input">Instance of Runner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Runner input)
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
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.RootId == input.RootId ||
                    (this.RootId != null &&
                    this.RootId.Equals(input.RootId))
                ) && 
                (
                    this.SolutionId == input.SolutionId ||
                    (this.SolutionId != null &&
                    this.SolutionId.Equals(input.SolutionId))
                ) && 
                (
                    this.RunTemplateId == input.RunTemplateId ||
                    (this.RunTemplateId != null &&
                    this.RunTemplateId.Equals(input.RunTemplateId))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    this.CreationDate.Equals(input.CreationDate)
                ) && 
                (
                    this.LastUpdate == input.LastUpdate ||
                    this.LastUpdate.Equals(input.LastUpdate)
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.SolutionName == input.SolutionName ||
                    (this.SolutionName != null &&
                    this.SolutionName.Equals(input.SolutionName))
                ) && 
                (
                    this.RunTemplateName == input.RunTemplateName ||
                    (this.RunTemplateName != null &&
                    this.RunTemplateName.Equals(input.RunTemplateName))
                ) && 
                (
                    this.DatasetList == input.DatasetList ||
                    this.DatasetList != null &&
                    input.DatasetList != null &&
                    this.DatasetList.SequenceEqual(input.DatasetList)
                ) && 
                (
                    this.RunSizing == input.RunSizing ||
                    (this.RunSizing != null &&
                    this.RunSizing.Equals(input.RunSizing))
                ) && 
                (
                    this.ParametersValues == input.ParametersValues ||
                    this.ParametersValues != null &&
                    input.ParametersValues != null &&
                    this.ParametersValues.SequenceEqual(input.ParametersValues)
                ) && 
                (
                    this.LastRunId == input.LastRunId ||
                    (this.LastRunId != null &&
                    this.LastRunId.Equals(input.LastRunId))
                ) && 
                (
                    this.ValidationStatus == input.ValidationStatus ||
                    this.ValidationStatus.Equals(input.ValidationStatus)
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
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.RootId != null)
                {
                    hashCode = (hashCode * 59) + this.RootId.GetHashCode();
                }
                if (this.SolutionId != null)
                {
                    hashCode = (hashCode * 59) + this.SolutionId.GetHashCode();
                }
                if (this.RunTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.RunTemplateId.GetHashCode();
                }
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                if (this.WorkspaceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkspaceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                hashCode = (hashCode * 59) + this.LastUpdate.GetHashCode();
                if (this.OwnerName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerName.GetHashCode();
                }
                if (this.SolutionName != null)
                {
                    hashCode = (hashCode * 59) + this.SolutionName.GetHashCode();
                }
                if (this.RunTemplateName != null)
                {
                    hashCode = (hashCode * 59) + this.RunTemplateName.GetHashCode();
                }
                if (this.DatasetList != null)
                {
                    hashCode = (hashCode * 59) + this.DatasetList.GetHashCode();
                }
                if (this.RunSizing != null)
                {
                    hashCode = (hashCode * 59) + this.RunSizing.GetHashCode();
                }
                if (this.ParametersValues != null)
                {
                    hashCode = (hashCode * 59) + this.ParametersValues.GetHashCode();
                }
                if (this.LastRunId != null)
                {
                    hashCode = (hashCode * 59) + this.LastRunId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValidationStatus.GetHashCode();
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
