/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 4.0.3-SNAPSHOT
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
    public partial class WorkspaceSolution : IValidatableObject
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
