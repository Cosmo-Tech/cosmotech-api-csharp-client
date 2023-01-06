/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.2.0-dev
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
    /// a Workspace Web Application
    /// </summary>
    [DataContract(Name = "WorkspaceWebApp")]
    public partial class WorkspaceWebApp : IEquatable<WorkspaceWebApp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWebApp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkspaceWebApp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWebApp" /> class.
        /// </summary>
        /// <param name="url">the Workspace Web Application URL (required).</param>
        /// <param name="iframes">a map of iframeKey/iframeURL.</param>
        /// <param name="options">free form options for Web Application.</param>
        public WorkspaceWebApp(string url = default(string), Dictionary<string, Object> iframes = default(Dictionary<string, Object>), Dictionary<string, Object> options = default(Dictionary<string, Object>))
        {
            // to ensure "url" is required (not null)
            if (url == null) {
                throw new ArgumentNullException("url is a required property for WorkspaceWebApp and cannot be null");
            }
            this.Url = url;
            this.Iframes = iframes;
            this.Options = options;
        }

        /// <summary>
        /// the Workspace Web Application URL
        /// </summary>
        /// <value>the Workspace Web Application URL</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// a map of iframeKey/iframeURL
        /// </summary>
        /// <value>a map of iframeKey/iframeURL</value>
        [DataMember(Name = "iframes", EmitDefaultValue = false)]
        public Dictionary<string, Object> Iframes { get; set; }

        /// <summary>
        /// free form options for Web Application
        /// </summary>
        /// <value>free form options for Web Application</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public Dictionary<string, Object> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkspaceWebApp {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Iframes: ").Append(Iframes).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as WorkspaceWebApp);
        }

        /// <summary>
        /// Returns true if WorkspaceWebApp instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceWebApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceWebApp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Iframes == input.Iframes ||
                    this.Iframes != null &&
                    input.Iframes != null &&
                    this.Iframes.SequenceEqual(input.Iframes)
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Iframes != null)
                {
                    hashCode = (hashCode * 59) + this.Iframes.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
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
