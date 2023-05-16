/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.3.9-rc
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
    /// a ScenarioRun container description
    /// </summary>
    [DataContract(Name = "ScenarioRunContainer")]
    public partial class ScenarioRunContainer : IEquatable<ScenarioRunContainer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunContainer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScenarioRunContainer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunContainer" /> class.
        /// </summary>
        /// <param name="name">the container name (required).</param>
        /// <param name="labels">the metadata labels.</param>
        /// <param name="envVars">environment variable map.</param>
        /// <param name="image">the container image URI (required).</param>
        /// <param name="entrypoint">the container entry point.</param>
        /// <param name="runArgs">the list of run arguments for the container.</param>
        /// <param name="dependencies">the list of dependencies container name to run this container.</param>
        /// <param name="nodeLabel">the node label request.</param>
        /// <param name="runSizing">runSizing.</param>
        /// <param name="artifacts">the list of artifacts.</param>
        public ScenarioRunContainer(string name = default(string), Dictionary<string, string> labels = default(Dictionary<string, string>), Dictionary<string, string> envVars = default(Dictionary<string, string>), string image = default(string), string entrypoint = default(string), List<string> runArgs = default(List<string>), List<string> dependencies = default(List<string>), string nodeLabel = default(string), ContainerResourceSizing runSizing = default(ContainerResourceSizing), List<ScenarioRunContainerArtifact> artifacts = default(List<ScenarioRunContainerArtifact>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ScenarioRunContainer and cannot be null");
            }
            this.Name = name;
            // to ensure "image" is required (not null)
            if (image == null) {
                throw new ArgumentNullException("image is a required property for ScenarioRunContainer and cannot be null");
            }
            this.Image = image;
            this.Labels = labels;
            this.EnvVars = envVars;
            this.Entrypoint = entrypoint;
            this.RunArgs = runArgs;
            this.Dependencies = dependencies;
            this.NodeLabel = nodeLabel;
            this.RunSizing = runSizing;
            this.Artifacts = artifacts;
        }

        /// <summary>
        /// the container Id
        /// </summary>
        /// <value>the container Id</value>
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
        /// the container name
        /// </summary>
        /// <value>the container name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the metadata labels
        /// </summary>
        /// <value>the metadata labels</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// environment variable map
        /// </summary>
        /// <value>environment variable map</value>
        [DataMember(Name = "envVars", EmitDefaultValue = false)]
        public Dictionary<string, string> EnvVars { get; set; }

        /// <summary>
        /// the container image URI
        /// </summary>
        /// <value>the container image URI</value>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// the container entry point
        /// </summary>
        /// <value>the container entry point</value>
        [DataMember(Name = "entrypoint", EmitDefaultValue = false)]
        public string Entrypoint { get; set; }

        /// <summary>
        /// the list of run arguments for the container
        /// </summary>
        /// <value>the list of run arguments for the container</value>
        [DataMember(Name = "runArgs", EmitDefaultValue = false)]
        public List<string> RunArgs { get; set; }

        /// <summary>
        /// the list of dependencies container name to run this container
        /// </summary>
        /// <value>the list of dependencies container name to run this container</value>
        [DataMember(Name = "dependencies", EmitDefaultValue = false)]
        public List<string> Dependencies { get; set; }

        /// <summary>
        /// whether or not this container is a Cosmo Tech solution container
        /// </summary>
        /// <value>whether or not this container is a Cosmo Tech solution container</value>
        [DataMember(Name = "solutionContainer", EmitDefaultValue = true)]
        public bool SolutionContainer { get; private set; }

        /// <summary>
        /// Returns false as SolutionContainer should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSolutionContainer()
        {
            return false;
        }
        /// <summary>
        /// the node label request
        /// </summary>
        /// <value>the node label request</value>
        [DataMember(Name = "nodeLabel", EmitDefaultValue = false)]
        public string NodeLabel { get; set; }

        /// <summary>
        /// Gets or Sets RunSizing
        /// </summary>
        [DataMember(Name = "runSizing", EmitDefaultValue = false)]
        public ContainerResourceSizing RunSizing { get; set; }

        /// <summary>
        /// the list of artifacts
        /// </summary>
        /// <value>the list of artifacts</value>
        [DataMember(Name = "artifacts", EmitDefaultValue = false)]
        public List<ScenarioRunContainerArtifact> Artifacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenarioRunContainer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  EnvVars: ").Append(EnvVars).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Entrypoint: ").Append(Entrypoint).Append("\n");
            sb.Append("  RunArgs: ").Append(RunArgs).Append("\n");
            sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("  SolutionContainer: ").Append(SolutionContainer).Append("\n");
            sb.Append("  NodeLabel: ").Append(NodeLabel).Append("\n");
            sb.Append("  RunSizing: ").Append(RunSizing).Append("\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
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
            return this.Equals(input as ScenarioRunContainer);
        }

        /// <summary>
        /// Returns true if ScenarioRunContainer instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioRunContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioRunContainer input)
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
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.EnvVars == input.EnvVars ||
                    this.EnvVars != null &&
                    input.EnvVars != null &&
                    this.EnvVars.SequenceEqual(input.EnvVars)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Entrypoint == input.Entrypoint ||
                    (this.Entrypoint != null &&
                    this.Entrypoint.Equals(input.Entrypoint))
                ) && 
                (
                    this.RunArgs == input.RunArgs ||
                    this.RunArgs != null &&
                    input.RunArgs != null &&
                    this.RunArgs.SequenceEqual(input.RunArgs)
                ) && 
                (
                    this.Dependencies == input.Dependencies ||
                    this.Dependencies != null &&
                    input.Dependencies != null &&
                    this.Dependencies.SequenceEqual(input.Dependencies)
                ) && 
                (
                    this.SolutionContainer == input.SolutionContainer ||
                    this.SolutionContainer.Equals(input.SolutionContainer)
                ) && 
                (
                    this.NodeLabel == input.NodeLabel ||
                    (this.NodeLabel != null &&
                    this.NodeLabel.Equals(input.NodeLabel))
                ) && 
                (
                    this.RunSizing == input.RunSizing ||
                    (this.RunSizing != null &&
                    this.RunSizing.Equals(input.RunSizing))
                ) && 
                (
                    this.Artifacts == input.Artifacts ||
                    this.Artifacts != null &&
                    input.Artifacts != null &&
                    this.Artifacts.SequenceEqual(input.Artifacts)
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
                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
                }
                if (this.EnvVars != null)
                {
                    hashCode = (hashCode * 59) + this.EnvVars.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Entrypoint != null)
                {
                    hashCode = (hashCode * 59) + this.Entrypoint.GetHashCode();
                }
                if (this.RunArgs != null)
                {
                    hashCode = (hashCode * 59) + this.RunArgs.GetHashCode();
                }
                if (this.Dependencies != null)
                {
                    hashCode = (hashCode * 59) + this.Dependencies.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SolutionContainer.GetHashCode();
                if (this.NodeLabel != null)
                {
                    hashCode = (hashCode * 59) + this.NodeLabel.GetHashCode();
                }
                if (this.RunSizing != null)
                {
                    hashCode = (hashCode * 59) + this.RunSizing.GetHashCode();
                }
                if (this.Artifacts != null)
                {
                    hashCode = (hashCode * 59) + this.Artifacts.GetHashCode();
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
