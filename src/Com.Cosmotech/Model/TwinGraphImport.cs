/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.1.3-dev
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
        /// <param name="storagePath">the storage path containing the files to import (required).</param>
        /// <param name="graphName">the graph name to import to (required).</param>
        /// <param name="version">The version of the graph to import to.  When not set, the last version before import is upgraded by 1. When set, the targeted graph is replaced .</param>
        public TwinGraphImport(string storagePath = default(string), string graphName = default(string), string version = default(string))
        {
            // to ensure "storagePath" is required (not null)
            if (storagePath == null) {
                throw new ArgumentNullException("storagePath is a required property for TwinGraphImport and cannot be null");
            }
            this.StoragePath = storagePath;
            // to ensure "graphName" is required (not null)
            if (graphName == null) {
                throw new ArgumentNullException("graphName is a required property for TwinGraphImport and cannot be null");
            }
            this.GraphName = graphName;
            this._Version = version;
        }

        /// <summary>
        /// the storage path containing the files to import
        /// </summary>
        /// <value>the storage path containing the files to import</value>
        [DataMember(Name = "storagePath", IsRequired = true, EmitDefaultValue = false)]
        public string StoragePath { get; set; }

        /// <summary>
        /// the graph name to import to
        /// </summary>
        /// <value>the graph name to import to</value>
        [DataMember(Name = "graphName", IsRequired = true, EmitDefaultValue = false)]
        public string GraphName { get; set; }

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
            sb.Append("  StoragePath: ").Append(StoragePath).Append("\n");
            sb.Append("  GraphName: ").Append(GraphName).Append("\n");
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
                    this.StoragePath == input.StoragePath ||
                    (this.StoragePath != null &&
                    this.StoragePath.Equals(input.StoragePath))
                ) && 
                (
                    this.GraphName == input.GraphName ||
                    (this.GraphName != null &&
                    this.GraphName.Equals(input.GraphName))
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
                if (this.StoragePath != null)
                {
                    hashCode = (hashCode * 59) + this.StoragePath.GetHashCode();
                }
                if (this.GraphName != null)
                {
                    hashCode = (hashCode * 59) + this.GraphName.GetHashCode();
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
