/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.3.5-dev
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
    /// Configuration of scenario runs deletion automatic mecanism
    /// </summary>
    [DataContract(Name = "DeleteHistoricalData")]
    public partial class DeleteHistoricalData : IEquatable<DeleteHistoricalData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteHistoricalData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteHistoricalData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteHistoricalData" /> class.
        /// </summary>
        /// <param name="enable">Activate or Deactivate historical data deletion (required) (default to true).</param>
        /// <param name="pollFrequency">define the polling frequency of scenario run status (in millis) (default to 10000).</param>
        /// <param name="timeOut">define the polling timeout (default to 28800).</param>
        public DeleteHistoricalData(bool enable = true, int pollFrequency = 10000, int timeOut = 28800)
        {
            this.Enable = enable;
            this.PollFrequency = pollFrequency;
            this.TimeOut = timeOut;
        }

        /// <summary>
        /// Activate or Deactivate historical data deletion
        /// </summary>
        /// <value>Activate or Deactivate historical data deletion</value>
        [DataMember(Name = "enable", IsRequired = true, EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// define the polling frequency of scenario run status (in millis)
        /// </summary>
        /// <value>define the polling frequency of scenario run status (in millis)</value>
        [DataMember(Name = "pollFrequency", EmitDefaultValue = false)]
        public int PollFrequency { get; set; }

        /// <summary>
        /// define the polling timeout
        /// </summary>
        /// <value>define the polling timeout</value>
        [DataMember(Name = "timeOut", EmitDefaultValue = false)]
        public int TimeOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteHistoricalData {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  PollFrequency: ").Append(PollFrequency).Append("\n");
            sb.Append("  TimeOut: ").Append(TimeOut).Append("\n");
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
            return this.Equals(input as DeleteHistoricalData);
        }

        /// <summary>
        /// Returns true if DeleteHistoricalData instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteHistoricalData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteHistoricalData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.PollFrequency == input.PollFrequency ||
                    this.PollFrequency.Equals(input.PollFrequency)
                ) && 
                (
                    this.TimeOut == input.TimeOut ||
                    this.TimeOut.Equals(input.TimeOut)
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                hashCode = (hashCode * 59) + this.PollFrequency.GetHashCode();
                hashCode = (hashCode * 59) + this.TimeOut.GetHashCode();
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
