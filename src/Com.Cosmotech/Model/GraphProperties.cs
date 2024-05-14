/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.0
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
    /// GraphProperties
    /// </summary>
    [DataContract(Name = "GraphProperties")]
    public partial class GraphProperties : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphProperties" /> class.
        /// </summary>
        /// <param name="type">the type of the relationship.</param>
        /// <param name="source">the source node of the relationship.</param>
        /// <param name="target">the target node of the relationship.</param>
        /// <param name="name">the name of the graph data object.</param>
        /// <param name="varParams">the parameters of the graph data object.</param>
        public GraphProperties(string type = default(string), string source = default(string), string target = default(string), string name = default(string), string varParams = default(string))
        {
            this.Type = type;
            this.Source = source;
            this.Target = target;
            this.Name = name;
            this.VarParams = varParams;
        }

        /// <summary>
        /// the type of the relationship
        /// </summary>
        /// <value>the type of the relationship</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// the source node of the relationship
        /// </summary>
        /// <value>the source node of the relationship</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// the target node of the relationship
        /// </summary>
        /// <value>the target node of the relationship</value>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public string Target { get; set; }

        /// <summary>
        /// the name of the graph data object
        /// </summary>
        /// <value>the name of the graph data object</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the parameters of the graph data object
        /// </summary>
        /// <value>the parameters of the graph data object</value>
        [DataMember(Name = "params", EmitDefaultValue = false)]
        public string VarParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GraphProperties {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VarParams: ").Append(VarParams).Append("\n");
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
