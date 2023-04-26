/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.3.7-SNAPSHOT
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
    /// a twin graph import info
    /// </summary>
    [DataContract(Name = "TwinGraphImport")]
    public partial class TwinGraphImport : IEquatable<TwinGraphImport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwinGraphImport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TwinGraphImport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwinGraphImport" /> class.
        /// </summary>
        /// <param name="source">source (required).</param>
        /// <param name="graphId">the graph id to import to (required).</param>
        /// <param name="version">The version of the graph to import to.  When not set, the last version before import is upgraded by 1. When set, the targeted graph is replaced .</param>
        public TwinGraphImport(SourceInfo source = default(SourceInfo), string graphId = default(string), string version = default(string))
        {
            // to ensure "source" is required (not null)
            if (source == null) {
                throw new ArgumentNullException("source is a required property for TwinGraphImport and cannot be null");
            }
            this.Source = source;
            // to ensure "graphId" is required (not null)
            if (graphId == null) {
                throw new ArgumentNullException("graphId is a required property for TwinGraphImport and cannot be null");
            }
            this.GraphId = graphId;
            this._Version = version;
        }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = false)]
        public SourceInfo Source { get; set; }

        /// <summary>
        /// the graph id to import to
        /// </summary>
        /// <value>the graph id to import to</value>
        [DataMember(Name = "graphId", IsRequired = true, EmitDefaultValue = false)]
        public string GraphId { get; set; }

        /// <summary>
        /// The version of the graph to import to.  When not set, the last version before import is upgraded by 1. When set, the targeted graph is replaced 
        /// </summary>
        /// <value>The version of the graph to import to.  When not set, the last version before import is upgraded by 1. When set, the targeted graph is replaced </value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TwinGraphImport {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  GraphId: ").Append(GraphId).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as TwinGraphImport);
        }

        /// <summary>
        /// Returns true if TwinGraphImport instances are equal
        /// </summary>
        /// <param name="input">Instance of TwinGraphImport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwinGraphImport input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.GraphId == input.GraphId ||
                    (this.GraphId != null &&
                    this.GraphId.Equals(input.GraphId))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.GraphId != null)
                {
                    hashCode = (hashCode * 59) + this.GraphId.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
