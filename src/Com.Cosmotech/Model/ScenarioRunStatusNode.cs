/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.18-SNAPSHOT
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
    /// status of a ScenarioRun Node
    /// </summary>
    [DataContract(Name = "ScenarioRunStatusNode")]
    public partial class ScenarioRunStatusNode : IEquatable<ScenarioRunStatusNode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunStatusNode" /> class.
        /// </summary>
        /// <param name="id">the node id.</param>
        /// <param name="name">the node unique name.</param>
        /// <param name="containerName">the ScenarioRun container name.</param>
        /// <param name="resourcesDuration">resourcesDuration.</param>
        /// <param name="estimatedDuration">estimatedDuration in seconds.</param>
        /// <param name="hostNodeName">HostNodeName name of the Kubernetes node on which the Pod is running, if applicable.</param>
        /// <param name="message">a human readable message indicating details about why the node is in this condition.</param>
        /// <param name="phase">high-level summary of where the node is in its lifecycle.</param>
        /// <param name="progress">progress to completion.</param>
        /// <param name="startTime">the node start time.</param>
        /// <param name="endTime">the node end time.</param>
        public ScenarioRunStatusNode(string id = default(string), string name = default(string), string containerName = default(string), ScenarioRunResourceRequested resourcesDuration = default(ScenarioRunResourceRequested), int estimatedDuration = default(int), string hostNodeName = default(string), string message = default(string), string phase = default(string), string progress = default(string), string startTime = default(string), string endTime = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.ContainerName = containerName;
            this.ResourcesDuration = resourcesDuration;
            this.EstimatedDuration = estimatedDuration;
            this.HostNodeName = hostNodeName;
            this.Message = message;
            this.Phase = phase;
            this.Progress = progress;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// the node id
        /// </summary>
        /// <value>the node id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the node unique name
        /// </summary>
        /// <value>the node unique name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the ScenarioRun container name
        /// </summary>
        /// <value>the ScenarioRun container name</value>
        [DataMember(Name = "containerName", EmitDefaultValue = false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// the list of outbound nodes
        /// </summary>
        /// <value>the list of outbound nodes</value>
        [DataMember(Name = "outboundNodes", EmitDefaultValue = false)]
        public List<string> OutboundNodes { get; private set; }

        /// <summary>
        /// Returns false as OutboundNodes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOutboundNodes()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ResourcesDuration
        /// </summary>
        [DataMember(Name = "resourcesDuration", EmitDefaultValue = false)]
        public ScenarioRunResourceRequested ResourcesDuration { get; set; }

        /// <summary>
        /// estimatedDuration in seconds
        /// </summary>
        /// <value>estimatedDuration in seconds</value>
        [DataMember(Name = "estimatedDuration", EmitDefaultValue = false)]
        public int EstimatedDuration { get; set; }

        /// <summary>
        /// HostNodeName name of the Kubernetes node on which the Pod is running, if applicable
        /// </summary>
        /// <value>HostNodeName name of the Kubernetes node on which the Pod is running, if applicable</value>
        [DataMember(Name = "hostNodeName", EmitDefaultValue = false)]
        public string HostNodeName { get; set; }

        /// <summary>
        /// a human readable message indicating details about why the node is in this condition
        /// </summary>
        /// <value>a human readable message indicating details about why the node is in this condition</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// high-level summary of where the node is in its lifecycle
        /// </summary>
        /// <value>high-level summary of where the node is in its lifecycle</value>
        [DataMember(Name = "phase", EmitDefaultValue = false)]
        public string Phase { get; set; }

        /// <summary>
        /// progress to completion
        /// </summary>
        /// <value>progress to completion</value>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public string Progress { get; set; }

        /// <summary>
        /// the node start time
        /// </summary>
        /// <value>the node start time</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// the node end time
        /// </summary>
        /// <value>the node end time</value>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenarioRunStatusNode {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContainerName: ").Append(ContainerName).Append("\n");
            sb.Append("  OutboundNodes: ").Append(OutboundNodes).Append("\n");
            sb.Append("  ResourcesDuration: ").Append(ResourcesDuration).Append("\n");
            sb.Append("  EstimatedDuration: ").Append(EstimatedDuration).Append("\n");
            sb.Append("  HostNodeName: ").Append(HostNodeName).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
            return this.Equals(input as ScenarioRunStatusNode);
        }

        /// <summary>
        /// Returns true if ScenarioRunStatusNode instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioRunStatusNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioRunStatusNode input)
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
                    this.ContainerName == input.ContainerName ||
                    (this.ContainerName != null &&
                    this.ContainerName.Equals(input.ContainerName))
                ) && 
                (
                    this.OutboundNodes == input.OutboundNodes ||
                    this.OutboundNodes != null &&
                    input.OutboundNodes != null &&
                    this.OutboundNodes.SequenceEqual(input.OutboundNodes)
                ) && 
                (
                    this.ResourcesDuration == input.ResourcesDuration ||
                    (this.ResourcesDuration != null &&
                    this.ResourcesDuration.Equals(input.ResourcesDuration))
                ) && 
                (
                    this.EstimatedDuration == input.EstimatedDuration ||
                    this.EstimatedDuration.Equals(input.EstimatedDuration)
                ) && 
                (
                    this.HostNodeName == input.HostNodeName ||
                    (this.HostNodeName != null &&
                    this.HostNodeName.Equals(input.HostNodeName))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                if (this.ContainerName != null)
                {
                    hashCode = (hashCode * 59) + this.ContainerName.GetHashCode();
                }
                if (this.OutboundNodes != null)
                {
                    hashCode = (hashCode * 59) + this.OutboundNodes.GetHashCode();
                }
                if (this.ResourcesDuration != null)
                {
                    hashCode = (hashCode * 59) + this.ResourcesDuration.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EstimatedDuration.GetHashCode();
                if (this.HostNodeName != null)
                {
                    hashCode = (hashCode * 59) + this.HostNodeName.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Phase != null)
                {
                    hashCode = (hashCode * 59) + this.Phase.GetHashCode();
                }
                if (this.Progress != null)
                {
                    hashCode = (hashCode * 59) + this.Progress.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
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
