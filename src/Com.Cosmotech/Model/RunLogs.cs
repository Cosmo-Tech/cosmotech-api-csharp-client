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
    /// the run logs returned by all containers
    /// </summary>
    [DataContract(Name = "RunLogs")]
    public partial class RunLogs : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunLogs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RunLogs()
        {
        }

        /// <summary>
        /// the Run Id
        /// </summary>
        /// <value>the Run Id</value>
        [DataMember(Name = "runId", EmitDefaultValue = false)]
        public string RunId { get; private set; }

        /// <summary>
        /// Returns false as RunId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRunId()
        {
            return false;
        }
        /// <summary>
        /// the container map of logs
        /// </summary>
        /// <value>the container map of logs</value>
        [DataMember(Name = "containers", EmitDefaultValue = false)]
        public Dictionary<string, RunContainerLogs> Containers { get; private set; }

        /// <summary>
        /// Returns false as Containers should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContainers()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RunLogs {\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
            sb.Append("  Containers: ").Append(Containers).Append("\n");
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
