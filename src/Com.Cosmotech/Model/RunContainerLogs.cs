/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.0-dev
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
    [DataContract(Name = "RunContainerLogs")]
    public partial class RunContainerLogs : IEquatable<RunContainerLogs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunContainerLogs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RunContainerLogs()
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
            sb.Append("class RunContainerLogs {\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunContainerLogs);
        }

        /// <summary>
        /// Returns true if RunContainerLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of RunContainerLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunContainerLogs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.ContainerName == input.ContainerName ||
                    (this.ContainerName != null &&
                    this.ContainerName.Equals(input.ContainerName))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.Logs == input.Logs ||
                    (this.Logs != null &&
                    this.Logs.Equals(input.Logs))
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
                if (this.NodeId != null)
                {
                    hashCode = (hashCode * 59) + this.NodeId.GetHashCode();
                }
                if (this.ContainerName != null)
                {
                    hashCode = (hashCode * 59) + this.ContainerName.GetHashCode();
                }
                if (this.Children != null)
                {
                    hashCode = (hashCode * 59) + this.Children.GetHashCode();
                }
                if (this.Logs != null)
                {
                    hashCode = (hashCode * 59) + this.Logs.GetHashCode();
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
