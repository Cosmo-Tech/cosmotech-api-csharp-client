/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.0.0-dev
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
    /// a Validator Run
    /// </summary>
    [DataContract(Name = "ValidatorRun")]
    public partial class ValidatorRun : IEquatable<ValidatorRun>, IValidatableObject
    {
        /// <summary>
        /// the Validator Run state
        /// </summary>
        /// <value>the Validator Run state</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Running for value: Running
            /// </summary>
            [EnumMember(Value = "Running")]
            Running = 1,

            /// <summary>
            /// Enum Finished for value: Finished
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished = 2,

            /// <summary>
            /// Enum OnError for value: OnError
            /// </summary>
            [EnumMember(Value = "OnError")]
            OnError = 3

        }


        /// <summary>
        /// the Validator Run state
        /// </summary>
        /// <value>the Validator Run state</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Returns false as State should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeState()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatorRun" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidatorRun() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatorRun" /> class.
        /// </summary>
        /// <param name="datasetId">the Dataset id to run the validator on (required).</param>
        public ValidatorRun(string datasetId = default(string))
        {
            // to ensure "datasetId" is required (not null)
            if (datasetId == null) {
                throw new ArgumentNullException("datasetId is a required property for ValidatorRun and cannot be null");
            }
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// the Validator Run id
        /// </summary>
        /// <value>the Validator Run id</value>
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
        /// the Validator id
        /// </summary>
        /// <value>the Validator id</value>
        [DataMember(Name = "validatorId", EmitDefaultValue = false)]
        public string ValidatorId { get; private set; }

        /// <summary>
        /// Returns false as ValidatorId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidatorId()
        {
            return false;
        }
        /// <summary>
        /// the validator name
        /// </summary>
        /// <value>the validator name</value>
        [DataMember(Name = "validatorName", EmitDefaultValue = false)]
        public string ValidatorName { get; private set; }

        /// <summary>
        /// Returns false as ValidatorName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidatorName()
        {
            return false;
        }
        /// <summary>
        /// the Dataset id to run the validator on
        /// </summary>
        /// <value>the Dataset id to run the validator on</value>
        [DataMember(Name = "datasetId", IsRequired = true, EmitDefaultValue = false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// the Dataset name
        /// </summary>
        /// <value>the Dataset name</value>
        [DataMember(Name = "datasetName", EmitDefaultValue = false)]
        public string DatasetName { get; private set; }

        /// <summary>
        /// Returns false as DatasetName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDatasetName()
        {
            return false;
        }
        /// <summary>
        /// the Validator Run container id
        /// </summary>
        /// <value>the Validator Run container id</value>
        [DataMember(Name = "containerId", EmitDefaultValue = false)]
        public string ContainerId { get; private set; }

        /// <summary>
        /// Returns false as ContainerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContainerId()
        {
            return false;
        }
        /// <summary>
        /// the Validator Run logs
        /// </summary>
        /// <value>the Validator Run logs</value>
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
            sb.Append("class ValidatorRun {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ValidatorId: ").Append(ValidatorId).Append("\n");
            sb.Append("  ValidatorName: ").Append(ValidatorName).Append("\n");
            sb.Append("  DatasetId: ").Append(DatasetId).Append("\n");
            sb.Append("  DatasetName: ").Append(DatasetName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
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
            return this.Equals(input as ValidatorRun);
        }

        /// <summary>
        /// Returns true if ValidatorRun instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidatorRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidatorRun input)
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
                    this.ValidatorId == input.ValidatorId ||
                    (this.ValidatorId != null &&
                    this.ValidatorId.Equals(input.ValidatorId))
                ) && 
                (
                    this.ValidatorName == input.ValidatorName ||
                    (this.ValidatorName != null &&
                    this.ValidatorName.Equals(input.ValidatorName))
                ) && 
                (
                    this.DatasetId == input.DatasetId ||
                    (this.DatasetId != null &&
                    this.DatasetId.Equals(input.DatasetId))
                ) && 
                (
                    this.DatasetName == input.DatasetName ||
                    (this.DatasetName != null &&
                    this.DatasetName.Equals(input.DatasetName))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.ContainerId == input.ContainerId ||
                    (this.ContainerId != null &&
                    this.ContainerId.Equals(input.ContainerId))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ValidatorId != null)
                {
                    hashCode = (hashCode * 59) + this.ValidatorId.GetHashCode();
                }
                if (this.ValidatorName != null)
                {
                    hashCode = (hashCode * 59) + this.ValidatorName.GetHashCode();
                }
                if (this.DatasetId != null)
                {
                    hashCode = (hashCode * 59) + this.DatasetId.GetHashCode();
                }
                if (this.DatasetName != null)
                {
                    hashCode = (hashCode * 59) + this.DatasetName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.ContainerId != null)
                {
                    hashCode = (hashCode * 59) + this.ContainerId.GetHashCode();
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
