/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.1.1-dev
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
    /// the Workspace Solution configuration
    /// </summary>
    [DataContract(Name = "WorkspaceSolution")]
    public partial class WorkspaceSolution : IEquatable<WorkspaceSolution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSolution" /> class.
        /// </summary>
        /// <param name="solutionId">the Solution Id attached to this workspace.</param>
        /// <param name="runTemplateFilter">the list of Solution Run Template Id to filter.</param>
        /// <param name="defaultRunTemplateDataset">a map of RunTemplateId/DatasetId to set a default dataset for a Run Template.</param>
        public WorkspaceSolution(string solutionId = default(string), List<string> runTemplateFilter = default(List<string>), Dictionary<string, Object> defaultRunTemplateDataset = default(Dictionary<string, Object>))
        {
            this.SolutionId = solutionId;
            this.RunTemplateFilter = runTemplateFilter;
            this.DefaultRunTemplateDataset = defaultRunTemplateDataset;
        }

        /// <summary>
        /// the Solution Id attached to this workspace
        /// </summary>
        /// <value>the Solution Id attached to this workspace</value>
        [DataMember(Name = "solutionId", EmitDefaultValue = false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// the list of Solution Run Template Id to filter
        /// </summary>
        /// <value>the list of Solution Run Template Id to filter</value>
        [DataMember(Name = "runTemplateFilter", EmitDefaultValue = false)]
        public List<string> RunTemplateFilter { get; set; }

        /// <summary>
        /// a map of RunTemplateId/DatasetId to set a default dataset for a Run Template
        /// </summary>
        /// <value>a map of RunTemplateId/DatasetId to set a default dataset for a Run Template</value>
        [DataMember(Name = "defaultRunTemplateDataset", EmitDefaultValue = false)]
        public Dictionary<string, Object> DefaultRunTemplateDataset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkspaceSolution {\n");
            sb.Append("  SolutionId: ").Append(SolutionId).Append("\n");
            sb.Append("  RunTemplateFilter: ").Append(RunTemplateFilter).Append("\n");
            sb.Append("  DefaultRunTemplateDataset: ").Append(DefaultRunTemplateDataset).Append("\n");
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
            return this.Equals(input as WorkspaceSolution);
        }

        /// <summary>
        /// Returns true if WorkspaceSolution instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceSolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceSolution input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SolutionId == input.SolutionId ||
                    (this.SolutionId != null &&
                    this.SolutionId.Equals(input.SolutionId))
                ) && 
                (
                    this.RunTemplateFilter == input.RunTemplateFilter ||
                    this.RunTemplateFilter != null &&
                    input.RunTemplateFilter != null &&
                    this.RunTemplateFilter.SequenceEqual(input.RunTemplateFilter)
                ) && 
                (
                    this.DefaultRunTemplateDataset == input.DefaultRunTemplateDataset ||
                    this.DefaultRunTemplateDataset != null &&
                    input.DefaultRunTemplateDataset != null &&
                    this.DefaultRunTemplateDataset.SequenceEqual(input.DefaultRunTemplateDataset)
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
                if (this.SolutionId != null)
                {
                    hashCode = (hashCode * 59) + this.SolutionId.GetHashCode();
                }
                if (this.RunTemplateFilter != null)
                {
                    hashCode = (hashCode * 59) + this.RunTemplateFilter.GetHashCode();
                }
                if (this.DefaultRunTemplateDataset != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultRunTemplateDataset.GetHashCode();
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
