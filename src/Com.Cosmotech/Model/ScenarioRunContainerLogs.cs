/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.8
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
    /// logs for a given container
    /// </summary>
    [DataContract(Name = "ScenarioRunContainerLogs")]
    public partial class ScenarioRunContainerLogs : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunContainerLogs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ScenarioRunContainerLogs()
        {
        }

        /// <summary>
        /// the node Id which has executed this log
        /// </summary>
        /// <value>the node Id which has executed this log</value>
        [DataMember(Name = "nodeId", EmitDefaultValue = false)]
        public string NodeId { get; private set; }

        /// <summary>
        /// Returns false as NodeId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNodeId()
        {
            return false;
        }
        /// <summary>
        /// the container name
        /// </summary>
        /// <value>the container name</value>
        [DataMember(Name = "containerName", EmitDefaultValue = false)]
        public string ContainerName { get; private set; }

        /// <summary>
        /// Returns false as ContainerName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContainerName()
        {
            return false;
        }
        /// <summary>
        /// the list of children node id
        /// </summary>
        /// <value>the list of children node id</value>
        [DataMember(Name = "children", EmitDefaultValue = false)]
        public List<string> Children { get; private set; }

        /// <summary>
        /// Returns false as Children should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChildren()
        {
            return false;
        }
        /// <summary>
        /// the node logs in plain text
        /// </summary>
        /// <value>the node logs in plain text</value>
        [DataMember(Name = "logs", EmitDefaultValue = false)]
        public string Logs { get; private set; }

        /// <summary>
        /// Returns false as Logs should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLogs()
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
            sb.Append("class ScenarioRunContainerLogs {\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  ContainerName: ").Append(ContainerName).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
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
