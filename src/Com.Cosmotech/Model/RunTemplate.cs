/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 0.0.4-SNAPSHOT
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
        /// Initializes a new instance of the <see cref="RunTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunTemplate" /> class.
        /// </summary>
        /// <param name="id">the Solution Run Template id (required).</param>
        /// <param name="name">the Run Template name (required).</param>
        /// <param name="description">the Run Template description.</param>
        /// <param name="csmSimulation">the Cosmo Tech simulation name. This information is send to the Engine. Mandatory information if no Engine is defined.</param>
        /// <param name="tags">the list of Run Template tags.</param>
        /// <param name="computeSize">the compute size needed for this Run Template. Standard sizes are basic and highcpu. Default is basic.</param>
        /// <param name="fetchDatasets">whether or not the fetch dataset step is done.</param>
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
        /// <param name="parameterGroups">the ordered list of parameters groups for the Run Template.</param>
        public RunTemplate(string id = default(string), string name = default(string), string description = default(string), string csmSimulation = default(string), List<string> tags = default(List<string>), string computeSize = default(string), bool fetchDatasets = default(bool), bool fetchScenarioParameters = default(bool), bool applyParameters = default(bool), bool validateData = default(bool), bool sendDatasetsToDataWarehouse = default(bool), bool sendInputParametersToDataWarehouse = default(bool), bool preRun = default(bool), bool run = default(bool), bool postRun = default(bool), bool parametersJson = default(bool), RunTemplateStepSource? parametersHandlerSource = default(RunTemplateStepSource?), RunTemplateStepSource? datasetValidatorSource = default(RunTemplateStepSource?), RunTemplateStepSource? preRunSource = default(RunTemplateStepSource?), RunTemplateStepSource? runSource = default(RunTemplateStepSource?), RunTemplateStepSource? postRunSource = default(RunTemplateStepSource?), List<string> parameterGroups = default(List<string>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for RunTemplate and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for RunTemplate and cannot be null");
            this.Description = description;
            this.CsmSimulation = csmSimulation;
            this.Tags = tags;
            this.ComputeSize = computeSize;
            this.FetchDatasets = fetchDatasets;
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
            this.ParameterGroups = parameterGroups;
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
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
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
        /// whether or not the fetch dataset step is done
        /// </summary>
        /// <value>whether or not the fetch dataset step is done</value>
        [DataMember(Name = "fetchDatasets", EmitDefaultValue = true)]
        public bool FetchDatasets { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CsmSimulation: ").Append(CsmSimulation).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ComputeSize: ").Append(ComputeSize).Append("\n");
            sb.Append("  FetchDatasets: ").Append(FetchDatasets).Append("\n");
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
            sb.Append("  ParameterGroups: ").Append(ParameterGroups).Append("\n");
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
                return false;

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
                    this.FetchDatasets == input.FetchDatasets ||
                    this.FetchDatasets.Equals(input.FetchDatasets)
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
                    this.ParameterGroups == input.ParameterGroups ||
                    this.ParameterGroups != null &&
                    input.ParameterGroups != null &&
                    this.ParameterGroups.SequenceEqual(input.ParameterGroups)
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CsmSimulation != null)
                    hashCode = hashCode * 59 + this.CsmSimulation.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ComputeSize != null)
                    hashCode = hashCode * 59 + this.ComputeSize.GetHashCode();
                hashCode = hashCode * 59 + this.FetchDatasets.GetHashCode();
                hashCode = hashCode * 59 + this.FetchScenarioParameters.GetHashCode();
                hashCode = hashCode * 59 + this.ApplyParameters.GetHashCode();
                hashCode = hashCode * 59 + this.ValidateData.GetHashCode();
                hashCode = hashCode * 59 + this.SendDatasetsToDataWarehouse.GetHashCode();
                hashCode = hashCode * 59 + this.SendInputParametersToDataWarehouse.GetHashCode();
                hashCode = hashCode * 59 + this.PreRun.GetHashCode();
                hashCode = hashCode * 59 + this.Run.GetHashCode();
                hashCode = hashCode * 59 + this.PostRun.GetHashCode();
                hashCode = hashCode * 59 + this.ParametersJson.GetHashCode();
                hashCode = hashCode * 59 + this.ParametersHandlerSource.GetHashCode();
                hashCode = hashCode * 59 + this.DatasetValidatorSource.GetHashCode();
                hashCode = hashCode * 59 + this.PreRunSource.GetHashCode();
                hashCode = hashCode * 59 + this.RunSource.GetHashCode();
                hashCode = hashCode * 59 + this.PostRunSource.GetHashCode();
                if (this.ParameterGroups != null)
                    hashCode = hashCode * 59 + this.ParameterGroups.GetHashCode();
                return hashCode;
            }
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
