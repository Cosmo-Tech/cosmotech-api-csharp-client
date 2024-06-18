/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.6
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
    /// the memory and CPU requested by the pod
    /// </summary>
    [DataContract(Name = "ScenarioRunResourceRequested")]
    public partial class ScenarioRunResourceRequested : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioRunResourceRequested" /> class.
        /// </summary>
        /// <param name="cpu">the cpu requested.</param>
        /// <param name="memory">the memory requested.</param>
        public ScenarioRunResourceRequested(long cpu = default(long), long memory = default(long))
        {
            this.Cpu = cpu;
            this.Memory = memory;
        }

        /// <summary>
        /// the cpu requested
        /// </summary>
        /// <value>the cpu requested</value>
        [DataMember(Name = "cpu", EmitDefaultValue = false)]
        public long Cpu { get; set; }

        /// <summary>
        /// the memory requested
        /// </summary>
        /// <value>the memory requested</value>
        [DataMember(Name = "memory", EmitDefaultValue = false)]
        public long Memory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenarioRunResourceRequested {\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
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
