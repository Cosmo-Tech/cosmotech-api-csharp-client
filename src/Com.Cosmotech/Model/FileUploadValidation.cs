/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.6
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
    /// files read on upload
    /// </summary>
    [DataContract(Name = "FileUploadValidation")]
    public partial class FileUploadValidation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadValidation" /> class.
        /// </summary>
        /// <param name="nodes">list of filename found on nodes folder.</param>
        /// <param name="edges">list of filename found on edges folder.</param>
        public FileUploadValidation(List<FileUploadMetadata> nodes = default(List<FileUploadMetadata>), List<FileUploadMetadata> edges = default(List<FileUploadMetadata>))
        {
            this.Nodes = nodes;
            this.Edges = edges;
        }

        /// <summary>
        /// list of filename found on nodes folder
        /// </summary>
        /// <value>list of filename found on nodes folder</value>
        [DataMember(Name = "nodes", EmitDefaultValue = false)]
        public List<FileUploadMetadata> Nodes { get; set; }

        /// <summary>
        /// list of filename found on edges folder
        /// </summary>
        /// <value>list of filename found on edges folder</value>
        [DataMember(Name = "edges", EmitDefaultValue = false)]
        public List<FileUploadMetadata> Edges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileUploadValidation {\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  Edges: ").Append(Edges).Append("\n");
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
