/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 0.0.1-SNAPSHOT
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
    /// the parameters to run directly a Simulator
    /// </summary>
    [DataContract(Name = "SimulationStartSimulator")]
    public partial class SimulationStartSimulator : IEquatable<SimulationStartSimulator>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationStartSimulator" /> class.
        /// </summary>
        /// <param name="simulatorId">the Simulator Id.</param>
        /// <param name="simulatorAnalysisId">the Simulator Analysis id.</param>
        /// <param name="datasetList">the list of Dataset Id associated to this Analysis.</param>
        /// <param name="parametersValues">the list of Simulator Analysis parameters values.</param>
        /// <param name="sendInputToDataWarehouse">whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to Simulation Run.</param>
        /// <param name="dataWarehouseDB">the DataWarehouse database name to send data if sendInputToDataWarehouse is set.</param>
        /// <param name="resultsEventBusResourceUri">the event bus which receive Workspace Simulation results messages. Message won&#39;t be send if this is not set.</param>
        /// <param name="simulationEventBusResourceUri">the event bus which receive Workspace Simulation events messages. Message won&#39;t be send if this is not set.</param>
        public SimulationStartSimulator(string simulatorId = default(string), string simulatorAnalysisId = default(string), List<string> datasetList = default(List<string>), List<SimulationAnalysisParameterValue> parametersValues = default(List<SimulationAnalysisParameterValue>), bool sendInputToDataWarehouse = default(bool), string dataWarehouseDB = default(string), string resultsEventBusResourceUri = default(string), string simulationEventBusResourceUri = default(string))
        {
            this.SimulatorId = simulatorId;
            this.SimulatorAnalysisId = simulatorAnalysisId;
            this.DatasetList = datasetList;
            this.ParametersValues = parametersValues;
            this.SendInputToDataWarehouse = sendInputToDataWarehouse;
            this.DataWarehouseDB = dataWarehouseDB;
            this.ResultsEventBusResourceUri = resultsEventBusResourceUri;
            this.SimulationEventBusResourceUri = simulationEventBusResourceUri;
        }

        /// <summary>
        /// the Simulator Id
        /// </summary>
        /// <value>the Simulator Id</value>
        [DataMember(Name = "simulatorId", EmitDefaultValue = false)]
        public string SimulatorId { get; set; }

        /// <summary>
        /// the Simulator Analysis id
        /// </summary>
        /// <value>the Simulator Analysis id</value>
        [DataMember(Name = "simulatorAnalysisId", EmitDefaultValue = false)]
        public string SimulatorAnalysisId { get; set; }

        /// <summary>
        /// the list of Dataset Id associated to this Analysis
        /// </summary>
        /// <value>the list of Dataset Id associated to this Analysis</value>
        [DataMember(Name = "datasetList", EmitDefaultValue = false)]
        public List<string> DatasetList { get; set; }

        /// <summary>
        /// the list of Simulator Analysis parameters values
        /// </summary>
        /// <value>the list of Simulator Analysis parameters values</value>
        [DataMember(Name = "parametersValues", EmitDefaultValue = false)]
        public List<SimulationAnalysisParameterValue> ParametersValues { get; set; }

        /// <summary>
        /// whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to Simulation Run
        /// </summary>
        /// <value>whether or not the Dataset values and the input parameters values are send to the DataWarehouse prior to Simulation Run</value>
        [DataMember(Name = "sendInputToDataWarehouse", EmitDefaultValue = false)]
        public bool SendInputToDataWarehouse { get; set; }

        /// <summary>
        /// the DataWarehouse database name to send data if sendInputToDataWarehouse is set
        /// </summary>
        /// <value>the DataWarehouse database name to send data if sendInputToDataWarehouse is set</value>
        [DataMember(Name = "dataWarehouseDB", EmitDefaultValue = false)]
        public string DataWarehouseDB { get; set; }

        /// <summary>
        /// the event bus which receive Workspace Simulation results messages. Message won&#39;t be send if this is not set
        /// </summary>
        /// <value>the event bus which receive Workspace Simulation results messages. Message won&#39;t be send if this is not set</value>
        [DataMember(Name = "resultsEventBusResourceUri", EmitDefaultValue = false)]
        public string ResultsEventBusResourceUri { get; set; }

        /// <summary>
        /// the event bus which receive Workspace Simulation events messages. Message won&#39;t be send if this is not set
        /// </summary>
        /// <value>the event bus which receive Workspace Simulation events messages. Message won&#39;t be send if this is not set</value>
        [DataMember(Name = "simulationEventBusResourceUri", EmitDefaultValue = false)]
        public string SimulationEventBusResourceUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimulationStartSimulator {\n");
            sb.Append("  SimulatorId: ").Append(SimulatorId).Append("\n");
            sb.Append("  SimulatorAnalysisId: ").Append(SimulatorAnalysisId).Append("\n");
            sb.Append("  DatasetList: ").Append(DatasetList).Append("\n");
            sb.Append("  ParametersValues: ").Append(ParametersValues).Append("\n");
            sb.Append("  SendInputToDataWarehouse: ").Append(SendInputToDataWarehouse).Append("\n");
            sb.Append("  DataWarehouseDB: ").Append(DataWarehouseDB).Append("\n");
            sb.Append("  ResultsEventBusResourceUri: ").Append(ResultsEventBusResourceUri).Append("\n");
            sb.Append("  SimulationEventBusResourceUri: ").Append(SimulationEventBusResourceUri).Append("\n");
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
            return this.Equals(input as SimulationStartSimulator);
        }

        /// <summary>
        /// Returns true if SimulationStartSimulator instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationStartSimulator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationStartSimulator input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SimulatorId == input.SimulatorId ||
                    (this.SimulatorId != null &&
                    this.SimulatorId.Equals(input.SimulatorId))
                ) && 
                (
                    this.SimulatorAnalysisId == input.SimulatorAnalysisId ||
                    (this.SimulatorAnalysisId != null &&
                    this.SimulatorAnalysisId.Equals(input.SimulatorAnalysisId))
                ) && 
                (
                    this.DatasetList == input.DatasetList ||
                    this.DatasetList != null &&
                    input.DatasetList != null &&
                    this.DatasetList.SequenceEqual(input.DatasetList)
                ) && 
                (
                    this.ParametersValues == input.ParametersValues ||
                    this.ParametersValues != null &&
                    input.ParametersValues != null &&
                    this.ParametersValues.SequenceEqual(input.ParametersValues)
                ) && 
                (
                    this.SendInputToDataWarehouse == input.SendInputToDataWarehouse ||
                    this.SendInputToDataWarehouse.Equals(input.SendInputToDataWarehouse)
                ) && 
                (
                    this.DataWarehouseDB == input.DataWarehouseDB ||
                    (this.DataWarehouseDB != null &&
                    this.DataWarehouseDB.Equals(input.DataWarehouseDB))
                ) && 
                (
                    this.ResultsEventBusResourceUri == input.ResultsEventBusResourceUri ||
                    (this.ResultsEventBusResourceUri != null &&
                    this.ResultsEventBusResourceUri.Equals(input.ResultsEventBusResourceUri))
                ) && 
                (
                    this.SimulationEventBusResourceUri == input.SimulationEventBusResourceUri ||
                    (this.SimulationEventBusResourceUri != null &&
                    this.SimulationEventBusResourceUri.Equals(input.SimulationEventBusResourceUri))
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
                if (this.SimulatorId != null)
                    hashCode = hashCode * 59 + this.SimulatorId.GetHashCode();
                if (this.SimulatorAnalysisId != null)
                    hashCode = hashCode * 59 + this.SimulatorAnalysisId.GetHashCode();
                if (this.DatasetList != null)
                    hashCode = hashCode * 59 + this.DatasetList.GetHashCode();
                if (this.ParametersValues != null)
                    hashCode = hashCode * 59 + this.ParametersValues.GetHashCode();
                hashCode = hashCode * 59 + this.SendInputToDataWarehouse.GetHashCode();
                if (this.DataWarehouseDB != null)
                    hashCode = hashCode * 59 + this.DataWarehouseDB.GetHashCode();
                if (this.ResultsEventBusResourceUri != null)
                    hashCode = hashCode * 59 + this.ResultsEventBusResourceUri.GetHashCode();
                if (this.SimulationEventBusResourceUri != null)
                    hashCode = hashCode * 59 + this.SimulationEventBusResourceUri.GetHashCode();
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
