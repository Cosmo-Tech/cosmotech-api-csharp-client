/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.2-SNAPSHOT
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
    /// a Run with only base properties
    /// </summary>
    [DataContract(Name = "Run")]
    public partial class Run : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public RunState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="organizationId">the Organization id.</param>
        /// <param name="workflowId">the Cosmo Tech compute cluster Argo Workflow Id to search.</param>
        /// <param name="generateName">the base name for workflow name generation.</param>
        /// <param name="workflowName">the Cosmo Tech compute cluster Argo Workflow Name.</param>
        /// <param name="containers">the containers list. This information is not returned by the API..</param>
        public Run(RunState? state = default(RunState?), string organizationId = default(string), string workflowId = default(string), string generateName = default(string), string workflowName = default(string), List<RunContainer> containers = default(List<RunContainer>))
        {
            this.State = state;
            this.OrganizationId = organizationId;
            this.WorkflowId = workflowId;
            this.GenerateName = generateName;
            this.WorkflowName = workflowName;
            this.Containers = containers;
        }

        /// <summary>
        /// the Run
        /// </summary>
        /// <value>the Run</value>
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
        /// the Organization id
        /// </summary>
        /// <value>the Organization id</value>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// the Cosmo Tech compute cluster Argo Workflow Id to search
        /// </summary>
        /// <value>the Cosmo Tech compute cluster Argo Workflow Id to search</value>
        [DataMember(Name = "workflowId", EmitDefaultValue = false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// the Cosmo Tech Simulation Run Id
        /// </summary>
        /// <value>the Cosmo Tech Simulation Run Id</value>
        [DataMember(Name = "csmSimulationRun", EmitDefaultValue = false)]
        public string CsmSimulationRun { get; private set; }

        /// <summary>
        /// Returns false as CsmSimulationRun should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCsmSimulationRun()
        {
            return false;
        }
        /// <summary>
        /// the base name for workflow name generation
        /// </summary>
        /// <value>the base name for workflow name generation</value>
        [DataMember(Name = "generateName", EmitDefaultValue = false)]
        public string GenerateName { get; set; }

        /// <summary>
        /// the Cosmo Tech compute cluster Argo Workflow Name
        /// </summary>
        /// <value>the Cosmo Tech compute cluster Argo Workflow Name</value>
        [DataMember(Name = "workflowName", EmitDefaultValue = false)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// the user id which own this run
        /// </summary>
        /// <value>the user id which own this run</value>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Returns false as OwnerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOwnerId()
        {
            return false;
        }
        /// <summary>
        /// the Workspace Id
        /// </summary>
        /// <value>the Workspace Id</value>
        [DataMember(Name = "workspaceId", EmitDefaultValue = false)]
        public string WorkspaceId { get; private set; }

        /// <summary>
        /// Returns false as WorkspaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWorkspaceId()
        {
            return false;
        }
        /// <summary>
        /// technical key for resource name convention and version grouping. Must be unique
        /// </summary>
        /// <value>technical key for resource name convention and version grouping. Must be unique</value>
        [DataMember(Name = "workspaceKey", EmitDefaultValue = false)]
        public string WorkspaceKey { get; private set; }

        /// <summary>
        /// Returns false as WorkspaceKey should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWorkspaceKey()
        {
            return false;
        }
        /// <summary>
        /// the Runner Id
        /// </summary>
        /// <value>the Runner Id</value>
        [DataMember(Name = "runnerId", EmitDefaultValue = false)]
        public string RunnerId { get; private set; }

        /// <summary>
        /// Returns false as RunnerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRunnerId()
        {
            return false;
        }
        /// <summary>
        /// the Solution Id
        /// </summary>
        /// <value>the Solution Id</value>
        [DataMember(Name = "solutionId", EmitDefaultValue = false)]
        public string SolutionId { get; private set; }

        /// <summary>
        /// Returns false as SolutionId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSolutionId()
        {
            return false;
        }
        /// <summary>
        /// the Solution Run Template id
        /// </summary>
        /// <value>the Solution Run Template id</value>
        [DataMember(Name = "runTemplateId", EmitDefaultValue = false)]
        public string RunTemplateId { get; private set; }

        /// <summary>
        /// Returns false as RunTemplateId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRunTemplateId()
        {
            return false;
        }
        /// <summary>
        /// the compute size needed for this Analysis. Standard sizes are basic and highcpu. Default is basic
        /// </summary>
        /// <value>the compute size needed for this Analysis. Standard sizes are basic and highcpu. Default is basic</value>
        [DataMember(Name = "computeSize", EmitDefaultValue = false)]
        public string ComputeSize { get; private set; }

        /// <summary>
        /// Returns false as ComputeSize should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComputeSize()
        {
            return false;
        }
        /// <summary>
        /// the Run creation date
        /// </summary>
        /// <value>the Run creation date</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// the list of Dataset Id associated to this Run
        /// </summary>
        /// <value>the list of Dataset Id associated to this Run</value>
        [DataMember(Name = "datasetList", EmitDefaultValue = false)]
        public List<string> DatasetList { get; private set; }

        /// <summary>
        /// Returns false as DatasetList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDatasetList()
        {
            return false;
        }
        /// <summary>
        /// the list of Run Template parameters values
        /// </summary>
        /// <value>the list of Run Template parameters values</value>
        [DataMember(Name = "parametersValues", EmitDefaultValue = false)]
        public List<RunTemplateParameterValue> ParametersValues { get; private set; }

        /// <summary>
        /// Returns false as ParametersValues should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParametersValues()
        {
            return false;
        }
        /// <summary>
        /// the node label request
        /// </summary>
        /// <value>the node label request</value>
        [DataMember(Name = "nodeLabel", EmitDefaultValue = false)]
        public string NodeLabel { get; private set; }

        /// <summary>
        /// Returns false as NodeLabel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNodeLabel()
        {
            return false;
        }
        /// <summary>
        /// the containers list. This information is not returned by the API.
        /// </summary>
        /// <value>the containers list. This information is not returned by the API.</value>
        [DataMember(Name = "containers", EmitDefaultValue = false)]
        public List<RunContainer> Containers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Run {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  CsmSimulationRun: ").Append(CsmSimulationRun).Append("\n");
            sb.Append("  GenerateName: ").Append(GenerateName).Append("\n");
            sb.Append("  WorkflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  WorkspaceKey: ").Append(WorkspaceKey).Append("\n");
            sb.Append("  RunnerId: ").Append(RunnerId).Append("\n");
            sb.Append("  SolutionId: ").Append(SolutionId).Append("\n");
            sb.Append("  RunTemplateId: ").Append(RunTemplateId).Append("\n");
            sb.Append("  ComputeSize: ").Append(ComputeSize).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DatasetList: ").Append(DatasetList).Append("\n");
            sb.Append("  ParametersValues: ").Append(ParametersValues).Append("\n");
            sb.Append("  NodeLabel: ").Append(NodeLabel).Append("\n");
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
