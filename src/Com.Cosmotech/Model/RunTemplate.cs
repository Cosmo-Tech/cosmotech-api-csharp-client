/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 1.0.2-dev
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
    /// a Solution Run Template
    /// </summary>
    [DataContract(Name = "RunTemplate")]
    public partial class RunTemplate : IEquatable<RunTemplate>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ParametersHandlerSource
        /// </summary>
        [DataMember(Name = "parametersHandlerSource", EmitDefaultValue = false)]
        public RunTemplateStepSource? ParametersHandlerSource { get; set; }

        /// <summary>
        /// Gets or Sets DatasetValidatorSource
        /// </summary>
        [DataMember(Name = "datasetValidatorSource", EmitDefaultValue = false)]
        public RunTemplateStepSource? DatasetValidatorSource { get; set; }

        /// <summary>
        /// Gets or Sets PreRunSource
        /// </summary>
        [DataMember(Name = "preRunSource", EmitDefaultValue = false)]
        public RunTemplateStepSource? PreRunSource { get; set; }

        /// <summary>
        /// Gets or Sets RunSource
        /// </summary>
        [DataMember(Name = "runSource", EmitDefaultValue = false)]
        public RunTemplateStepSource? RunSource { get; set; }

        /// <summary>
        /// Gets or Sets PostRunSource
        /// </summary>
        [DataMember(Name = "postRunSource", EmitDefaultValue = false)]
        public RunTemplateStepSource? PostRunSource { get; set; }

        /// <summary>
        /// Gets or Sets ScenariodataTransformSource
        /// </summary>
        [DataMember(Name = "scenariodataTransformSource", EmitDefaultValue = false)]
        public RunTemplateStepSource? ScenariodataTransformSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunTemplate" /> class.
        /// </summary>
        /// <param name="id">the Solution Run Template id (required).</param>
        /// <param name="name">the Run Template name.</param>
        /// <param name="description">the Run Template description.</param>
        /// <param name="csmSimulation">the Cosmo Tech simulation name. This information is send to the Engine. Mandatory information if no Engine is defined.</param>
        /// <param name="tags">the list of Run Template tags.</param>
        /// <param name="computeSize">the compute size needed for this Run Template. Standard sizes are basic and highcpu. Default is basic.</param>
        /// <param name="noDataIngestionState">set to true if the run template does not want to check data ingestion state (no probes or not control plane).</param>
        /// <param name="fetchDatasets">whether or not the fetch dataset step is done.</param>
        /// <param name="scenarioDataDownloadTransform">whether or not the scenario data download transform step step is done.</param>
        /// <param name="fetchScenarioParameters">whether or not the fetch parameters step is done.</param>
        /// <param name="applyParameters">whether or not the apply parameter step is done.</param>
        /// <param name="validateData">whether or not the validate step is done.</param>
        /// <param name="sendDatasetsToDataWarehouse">whether or not the Datasets values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting.</param>
        /// <param name="sendInputParametersToDataWarehouse">whether or not the input parameters values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting.</param>
        /// <param name="preRun">whether or not the pre-run step is done.</param>
        /// <param name="run">whether or not the run step is done.</param>
        /// <param name="postRun">whether or not the post-run step is done.</param>
        /// <param name="parametersJson">whether or not to store the scenario parameters in json instead of csv.</param>
        /// <param name="parametersHandlerSource">parametersHandlerSource.</param>
        /// <param name="datasetValidatorSource">datasetValidatorSource.</param>
        /// <param name="preRunSource">preRunSource.</param>
        /// <param name="runSource">runSource.</param>
        /// <param name="postRunSource">postRunSource.</param>
        /// <param name="scenariodataTransformSource">scenariodataTransformSource.</param>
        /// <param name="parameterGroups">the ordered list of parameters groups for the Run Template.</param>
        /// <param name="stackSteps">whether or not to stack adjacent scenario run steps in one container run which will chain steps.</param>
        /// <param name="gitRepositoryUrl">an optional URL to the git repository.</param>
        /// <param name="gitBranchName">an optional git branch name.</param>
        /// <param name="runTemplateSourceDir">an optional directory where to find the run template source.</param>
        /// <param name="executionTimeout">an optional duration in seconds in which a workflow is allowed to run.</param>
        public RunTemplate(string id = default(string), string name = default(string), string description = default(string), string csmSimulation = default(string), List<string> tags = default(List<string>), string computeSize = default(string), bool noDataIngestionState = default(bool), bool fetchDatasets = default(bool), bool scenarioDataDownloadTransform = default(bool), bool fetchScenarioParameters = default(bool), bool applyParameters = default(bool), bool validateData = default(bool), bool sendDatasetsToDataWarehouse = default(bool), bool sendInputParametersToDataWarehouse = default(bool), bool preRun = default(bool), bool run = default(bool), bool postRun = default(bool), bool parametersJson = default(bool), RunTemplateStepSource? parametersHandlerSource = default(RunTemplateStepSource?), RunTemplateStepSource? datasetValidatorSource = default(RunTemplateStepSource?), RunTemplateStepSource? preRunSource = default(RunTemplateStepSource?), RunTemplateStepSource? runSource = default(RunTemplateStepSource?), RunTemplateStepSource? postRunSource = default(RunTemplateStepSource?), RunTemplateStepSource? scenariodataTransformSource = default(RunTemplateStepSource?), List<string> parameterGroups = default(List<string>), bool stackSteps = default(bool), string gitRepositoryUrl = default(string), string gitBranchName = default(string), string runTemplateSourceDir = default(string), int executionTimeout = default(int))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for RunTemplate and cannot be null");
            }
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.CsmSimulation = csmSimulation;
            this.Tags = tags;
            this.ComputeSize = computeSize;
            this.NoDataIngestionState = noDataIngestionState;
            this.FetchDatasets = fetchDatasets;
            this.ScenarioDataDownloadTransform = scenarioDataDownloadTransform;
            this.FetchScenarioParameters = fetchScenarioParameters;
            this.ApplyParameters = applyParameters;
            this.ValidateData = validateData;
            this.SendDatasetsToDataWarehouse = sendDatasetsToDataWarehouse;
            this.SendInputParametersToDataWarehouse = sendInputParametersToDataWarehouse;
            this.PreRun = preRun;
            this.Run = run;
            this.PostRun = postRun;
            this.ParametersJson = parametersJson;
            this.ParametersHandlerSource = parametersHandlerSource;
            this.DatasetValidatorSource = datasetValidatorSource;
            this.PreRunSource = preRunSource;
            this.RunSource = runSource;
            this.PostRunSource = postRunSource;
            this.ScenariodataTransformSource = scenariodataTransformSource;
            this.ParameterGroups = parameterGroups;
            this.StackSteps = stackSteps;
            this.GitRepositoryUrl = gitRepositoryUrl;
            this.GitBranchName = gitBranchName;
            this.RunTemplateSourceDir = runTemplateSourceDir;
            this.ExecutionTimeout = executionTimeout;
        }

        /// <summary>
        /// the Solution Run Template id
        /// </summary>
        /// <value>the Solution Run Template id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the Run Template name
        /// </summary>
        /// <value>the Run Template name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the Run Template description
        /// </summary>
        /// <value>the Run Template description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// the Cosmo Tech simulation name. This information is send to the Engine. Mandatory information if no Engine is defined
        /// </summary>
        /// <value>the Cosmo Tech simulation name. This information is send to the Engine. Mandatory information if no Engine is defined</value>
        [DataMember(Name = "csmSimulation", EmitDefaultValue = false)]
        public string CsmSimulation { get; set; }

        /// <summary>
        /// the list of Run Template tags
        /// </summary>
        /// <value>the list of Run Template tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// the compute size needed for this Run Template. Standard sizes are basic and highcpu. Default is basic
        /// </summary>
        /// <value>the compute size needed for this Run Template. Standard sizes are basic and highcpu. Default is basic</value>
        [DataMember(Name = "computeSize", EmitDefaultValue = false)]
        public string ComputeSize { get; set; }

        /// <summary>
        /// set to true if the run template does not want to check data ingestion state (no probes or not control plane)
        /// </summary>
        /// <value>set to true if the run template does not want to check data ingestion state (no probes or not control plane)</value>
        [DataMember(Name = "noDataIngestionState", EmitDefaultValue = true)]
        public bool NoDataIngestionState { get; set; }

        /// <summary>
        /// whether or not the fetch dataset step is done
        /// </summary>
        /// <value>whether or not the fetch dataset step is done</value>
        [DataMember(Name = "fetchDatasets", EmitDefaultValue = true)]
        public bool FetchDatasets { get; set; }

        /// <summary>
        /// whether or not the scenario data download transform step step is done
        /// </summary>
        /// <value>whether or not the scenario data download transform step step is done</value>
        [DataMember(Name = "scenarioDataDownloadTransform", EmitDefaultValue = true)]
        public bool ScenarioDataDownloadTransform { get; set; }

        /// <summary>
        /// whether or not the fetch parameters step is done
        /// </summary>
        /// <value>whether or not the fetch parameters step is done</value>
        [DataMember(Name = "fetchScenarioParameters", EmitDefaultValue = true)]
        public bool FetchScenarioParameters { get; set; }

        /// <summary>
        /// whether or not the apply parameter step is done
        /// </summary>
        /// <value>whether or not the apply parameter step is done</value>
        [DataMember(Name = "applyParameters", EmitDefaultValue = true)]
        public bool ApplyParameters { get; set; }

        /// <summary>
        /// whether or not the validate step is done
        /// </summary>
        /// <value>whether or not the validate step is done</value>
        [DataMember(Name = "validateData", EmitDefaultValue = true)]
        public bool ValidateData { get; set; }

        /// <summary>
        /// whether or not the Datasets values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting
        /// </summary>
        /// <value>whether or not the Datasets values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting</value>
        [DataMember(Name = "sendDatasetsToDataWarehouse", EmitDefaultValue = true)]
        public bool SendDatasetsToDataWarehouse { get; set; }

        /// <summary>
        /// whether or not the input parameters values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting
        /// </summary>
        /// <value>whether or not the input parameters values are send to the DataWarehouse prior to Simulation Run. If not set follow the Workspace setting</value>
        [DataMember(Name = "sendInputParametersToDataWarehouse", EmitDefaultValue = true)]
        public bool SendInputParametersToDataWarehouse { get; set; }

        /// <summary>
        /// whether or not the pre-run step is done
        /// </summary>
        /// <value>whether or not the pre-run step is done</value>
        [DataMember(Name = "preRun", EmitDefaultValue = true)]
        public bool PreRun { get; set; }

        /// <summary>
        /// whether or not the run step is done
        /// </summary>
        /// <value>whether or not the run step is done</value>
        [DataMember(Name = "run", EmitDefaultValue = true)]
        public bool Run { get; set; }

        /// <summary>
        /// whether or not the post-run step is done
        /// </summary>
        /// <value>whether or not the post-run step is done</value>
        [DataMember(Name = "postRun", EmitDefaultValue = true)]
        public bool PostRun { get; set; }

        /// <summary>
        /// whether or not to store the scenario parameters in json instead of csv
        /// </summary>
        /// <value>whether or not to store the scenario parameters in json instead of csv</value>
        [DataMember(Name = "parametersJson", EmitDefaultValue = true)]
        public bool ParametersJson { get; set; }

        /// <summary>
        /// the ordered list of parameters groups for the Run Template
        /// </summary>
        /// <value>the ordered list of parameters groups for the Run Template</value>
        [DataMember(Name = "parameterGroups", EmitDefaultValue = false)]
        public List<string> ParameterGroups { get; set; }

        /// <summary>
        /// whether or not to stack adjacent scenario run steps in one container run which will chain steps
        /// </summary>
        /// <value>whether or not to stack adjacent scenario run steps in one container run which will chain steps</value>
        [DataMember(Name = "stackSteps", EmitDefaultValue = true)]
        public bool StackSteps { get; set; }

        /// <summary>
        /// an optional URL to the git repository
        /// </summary>
        /// <value>an optional URL to the git repository</value>
        [DataMember(Name = "gitRepositoryUrl", EmitDefaultValue = false)]
        public string GitRepositoryUrl { get; set; }

        /// <summary>
        /// an optional git branch name
        /// </summary>
        /// <value>an optional git branch name</value>
        [DataMember(Name = "gitBranchName", EmitDefaultValue = false)]
        public string GitBranchName { get; set; }

        /// <summary>
        /// an optional directory where to find the run template source
        /// </summary>
        /// <value>an optional directory where to find the run template source</value>
        [DataMember(Name = "runTemplateSourceDir", EmitDefaultValue = false)]
        public string RunTemplateSourceDir { get; set; }

        /// <summary>
        /// an optional duration in seconds in which a workflow is allowed to run
        /// </summary>
        /// <value>an optional duration in seconds in which a workflow is allowed to run</value>
        [DataMember(Name = "executionTimeout", EmitDefaultValue = false)]
        public int ExecutionTimeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RunTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CsmSimulation: ").Append(CsmSimulation).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ComputeSize: ").Append(ComputeSize).Append("\n");
            sb.Append("  NoDataIngestionState: ").Append(NoDataIngestionState).Append("\n");
            sb.Append("  FetchDatasets: ").Append(FetchDatasets).Append("\n");
            sb.Append("  ScenarioDataDownloadTransform: ").Append(ScenarioDataDownloadTransform).Append("\n");
            sb.Append("  FetchScenarioParameters: ").Append(FetchScenarioParameters).Append("\n");
            sb.Append("  ApplyParameters: ").Append(ApplyParameters).Append("\n");
            sb.Append("  ValidateData: ").Append(ValidateData).Append("\n");
            sb.Append("  SendDatasetsToDataWarehouse: ").Append(SendDatasetsToDataWarehouse).Append("\n");
            sb.Append("  SendInputParametersToDataWarehouse: ").Append(SendInputParametersToDataWarehouse).Append("\n");
            sb.Append("  PreRun: ").Append(PreRun).Append("\n");
            sb.Append("  Run: ").Append(Run).Append("\n");
            sb.Append("  PostRun: ").Append(PostRun).Append("\n");
            sb.Append("  ParametersJson: ").Append(ParametersJson).Append("\n");
            sb.Append("  ParametersHandlerSource: ").Append(ParametersHandlerSource).Append("\n");
            sb.Append("  DatasetValidatorSource: ").Append(DatasetValidatorSource).Append("\n");
            sb.Append("  PreRunSource: ").Append(PreRunSource).Append("\n");
            sb.Append("  RunSource: ").Append(RunSource).Append("\n");
            sb.Append("  PostRunSource: ").Append(PostRunSource).Append("\n");
            sb.Append("  ScenariodataTransformSource: ").Append(ScenariodataTransformSource).Append("\n");
            sb.Append("  ParameterGroups: ").Append(ParameterGroups).Append("\n");
            sb.Append("  StackSteps: ").Append(StackSteps).Append("\n");
            sb.Append("  GitRepositoryUrl: ").Append(GitRepositoryUrl).Append("\n");
            sb.Append("  GitBranchName: ").Append(GitBranchName).Append("\n");
            sb.Append("  RunTemplateSourceDir: ").Append(RunTemplateSourceDir).Append("\n");
            sb.Append("  ExecutionTimeout: ").Append(ExecutionTimeout).Append("\n");
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
            return this.Equals(input as RunTemplate);
        }

        /// <summary>
        /// Returns true if RunTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of RunTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunTemplate input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CsmSimulation == input.CsmSimulation ||
                    (this.CsmSimulation != null &&
                    this.CsmSimulation.Equals(input.CsmSimulation))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ComputeSize == input.ComputeSize ||
                    (this.ComputeSize != null &&
                    this.ComputeSize.Equals(input.ComputeSize))
                ) && 
                (
                    this.NoDataIngestionState == input.NoDataIngestionState ||
                    this.NoDataIngestionState.Equals(input.NoDataIngestionState)
                ) && 
                (
                    this.FetchDatasets == input.FetchDatasets ||
                    this.FetchDatasets.Equals(input.FetchDatasets)
                ) && 
                (
                    this.ScenarioDataDownloadTransform == input.ScenarioDataDownloadTransform ||
                    this.ScenarioDataDownloadTransform.Equals(input.ScenarioDataDownloadTransform)
                ) && 
                (
                    this.FetchScenarioParameters == input.FetchScenarioParameters ||
                    this.FetchScenarioParameters.Equals(input.FetchScenarioParameters)
                ) && 
                (
                    this.ApplyParameters == input.ApplyParameters ||
                    this.ApplyParameters.Equals(input.ApplyParameters)
                ) && 
                (
                    this.ValidateData == input.ValidateData ||
                    this.ValidateData.Equals(input.ValidateData)
                ) && 
                (
                    this.SendDatasetsToDataWarehouse == input.SendDatasetsToDataWarehouse ||
                    this.SendDatasetsToDataWarehouse.Equals(input.SendDatasetsToDataWarehouse)
                ) && 
                (
                    this.SendInputParametersToDataWarehouse == input.SendInputParametersToDataWarehouse ||
                    this.SendInputParametersToDataWarehouse.Equals(input.SendInputParametersToDataWarehouse)
                ) && 
                (
                    this.PreRun == input.PreRun ||
                    this.PreRun.Equals(input.PreRun)
                ) && 
                (
                    this.Run == input.Run ||
                    this.Run.Equals(input.Run)
                ) && 
                (
                    this.PostRun == input.PostRun ||
                    this.PostRun.Equals(input.PostRun)
                ) && 
                (
                    this.ParametersJson == input.ParametersJson ||
                    this.ParametersJson.Equals(input.ParametersJson)
                ) && 
                (
                    this.ParametersHandlerSource == input.ParametersHandlerSource ||
                    this.ParametersHandlerSource.Equals(input.ParametersHandlerSource)
                ) && 
                (
                    this.DatasetValidatorSource == input.DatasetValidatorSource ||
                    this.DatasetValidatorSource.Equals(input.DatasetValidatorSource)
                ) && 
                (
                    this.PreRunSource == input.PreRunSource ||
                    this.PreRunSource.Equals(input.PreRunSource)
                ) && 
                (
                    this.RunSource == input.RunSource ||
                    this.RunSource.Equals(input.RunSource)
                ) && 
                (
                    this.PostRunSource == input.PostRunSource ||
                    this.PostRunSource.Equals(input.PostRunSource)
                ) && 
                (
                    this.ScenariodataTransformSource == input.ScenariodataTransformSource ||
                    this.ScenariodataTransformSource.Equals(input.ScenariodataTransformSource)
                ) && 
                (
                    this.ParameterGroups == input.ParameterGroups ||
                    this.ParameterGroups != null &&
                    input.ParameterGroups != null &&
                    this.ParameterGroups.SequenceEqual(input.ParameterGroups)
                ) && 
                (
                    this.StackSteps == input.StackSteps ||
                    this.StackSteps.Equals(input.StackSteps)
                ) && 
                (
                    this.GitRepositoryUrl == input.GitRepositoryUrl ||
                    (this.GitRepositoryUrl != null &&
                    this.GitRepositoryUrl.Equals(input.GitRepositoryUrl))
                ) && 
                (
                    this.GitBranchName == input.GitBranchName ||
                    (this.GitBranchName != null &&
                    this.GitBranchName.Equals(input.GitBranchName))
                ) && 
                (
                    this.RunTemplateSourceDir == input.RunTemplateSourceDir ||
                    (this.RunTemplateSourceDir != null &&
                    this.RunTemplateSourceDir.Equals(input.RunTemplateSourceDir))
                ) && 
                (
                    this.ExecutionTimeout == input.ExecutionTimeout ||
                    this.ExecutionTimeout.Equals(input.ExecutionTimeout)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.CsmSimulation != null)
                {
                    hashCode = (hashCode * 59) + this.CsmSimulation.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.ComputeSize != null)
                {
                    hashCode = (hashCode * 59) + this.ComputeSize.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NoDataIngestionState.GetHashCode();
                hashCode = (hashCode * 59) + this.FetchDatasets.GetHashCode();
                hashCode = (hashCode * 59) + this.ScenarioDataDownloadTransform.GetHashCode();
                hashCode = (hashCode * 59) + this.FetchScenarioParameters.GetHashCode();
                hashCode = (hashCode * 59) + this.ApplyParameters.GetHashCode();
                hashCode = (hashCode * 59) + this.ValidateData.GetHashCode();
                hashCode = (hashCode * 59) + this.SendDatasetsToDataWarehouse.GetHashCode();
                hashCode = (hashCode * 59) + this.SendInputParametersToDataWarehouse.GetHashCode();
                hashCode = (hashCode * 59) + this.PreRun.GetHashCode();
                hashCode = (hashCode * 59) + this.Run.GetHashCode();
                hashCode = (hashCode * 59) + this.PostRun.GetHashCode();
                hashCode = (hashCode * 59) + this.ParametersJson.GetHashCode();
                hashCode = (hashCode * 59) + this.ParametersHandlerSource.GetHashCode();
                hashCode = (hashCode * 59) + this.DatasetValidatorSource.GetHashCode();
                hashCode = (hashCode * 59) + this.PreRunSource.GetHashCode();
                hashCode = (hashCode * 59) + this.RunSource.GetHashCode();
                hashCode = (hashCode * 59) + this.PostRunSource.GetHashCode();
                hashCode = (hashCode * 59) + this.ScenariodataTransformSource.GetHashCode();
                if (this.ParameterGroups != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterGroups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StackSteps.GetHashCode();
                if (this.GitRepositoryUrl != null)
                {
                    hashCode = (hashCode * 59) + this.GitRepositoryUrl.GetHashCode();
                }
                if (this.GitBranchName != null)
                {
                    hashCode = (hashCode * 59) + this.GitBranchName.GetHashCode();
                }
                if (this.RunTemplateSourceDir != null)
                {
                    hashCode = (hashCode * 59) + this.RunTemplateSourceDir.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExecutionTimeout.GetHashCode();
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
