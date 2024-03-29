/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.1-SNAPSHOT
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
    /// the secret definition
    /// </summary>
    [DataContract(Name = "WorkspaceSecret")]
    public partial class WorkspaceSecret : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSecret" /> class.
        /// </summary>
        /// <param name="dedicatedEventHubKey">the dedicated event hub shared access key.</param>
        public WorkspaceSecret(string dedicatedEventHubKey = default(string))
        {
            this.DedicatedEventHubKey = dedicatedEventHubKey;
        }

        /// <summary>
        /// the dedicated event hub shared access key
        /// </summary>
        /// <value>the dedicated event hub shared access key</value>
        [DataMember(Name = "dedicatedEventHubKey", EmitDefaultValue = false)]
        public string DedicatedEventHubKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkspaceSecret {\n");
            sb.Append("  DedicatedEventHubKey: ").Append(DedicatedEventHubKey).Append("\n");
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
