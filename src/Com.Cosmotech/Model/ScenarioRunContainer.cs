/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.5
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
    public partial class ScenarioRunContainer : IValidatableObject
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
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ScenarioRunContainer and cannot be null");
            }
            this.Name = name;
            // to ensure "image" is required (not null)
            if (image == null)
            {
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
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
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
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
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
