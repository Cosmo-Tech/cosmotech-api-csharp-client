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
    /// a Parameter Group for a Run Template
    /// </summary>
    [DataContract(Name = "RunTemplateParameterGroup")]
    public partial class RunTemplateParameterGroup : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunTemplateParameterGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunTemplateParameterGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunTemplateParameterGroup" /> class.
        /// </summary>
        /// <param name="id">the Parameter Group id (required).</param>
        /// <param name="labels">a translated label with key as ISO 639-1 code.</param>
        /// <param name="isTable">does the group define a table.</param>
        /// <param name="options">freeform options.</param>
        /// <param name="parentId">the Run Template Group parent Id.</param>
        /// <param name="parameters">an ordered list of Run Template Parameters.</param>
        public RunTemplateParameterGroup(string id = default(string), Dictionary<string, string> labels = default(Dictionary<string, string>), bool isTable = default(bool), Dictionary<string, Object> options = default(Dictionary<string, Object>), string parentId = default(string), List<string> parameters = default(List<string>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for RunTemplateParameterGroup and cannot be null");
            }
            this.Id = id;
            this.Labels = labels;
            this.IsTable = isTable;
            this.Options = options;
            this.ParentId = parentId;
            this.Parameters = parameters;
        }

        /// <summary>
        /// the Parameter Group id
        /// </summary>
        /// <value>the Parameter Group id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// a translated label with key as ISO 639-1 code
        /// </summary>
        /// <value>a translated label with key as ISO 639-1 code</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// does the group define a table
        /// </summary>
        /// <value>does the group define a table</value>
        [DataMember(Name = "isTable", EmitDefaultValue = true)]
        public bool IsTable { get; set; }

        /// <summary>
        /// freeform options
        /// </summary>
        /// <value>freeform options</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public Dictionary<string, Object> Options { get; set; }

        /// <summary>
        /// the Run Template Group parent Id
        /// </summary>
        /// <value>the Run Template Group parent Id</value>
        [DataMember(Name = "parentId", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// an ordered list of Run Template Parameters
        /// </summary>
        /// <value>an ordered list of Run Template Parameters</value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<string> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RunTemplateParameterGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  IsTable: ").Append(IsTable).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
