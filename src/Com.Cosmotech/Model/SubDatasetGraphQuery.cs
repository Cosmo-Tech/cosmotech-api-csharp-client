/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.3
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
    /// a twin graph query in cypher language
    /// </summary>
    [DataContract(Name = "SubDatasetGraphQuery")]
    public partial class SubDatasetGraphQuery : IEquatable<SubDatasetGraphQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubDatasetGraphQuery" /> class.
        /// </summary>
        /// <param name="name">the name of the subdataset.</param>
        /// <param name="description">the description of the subdataset.</param>
        /// <param name="queries">the query in cypher language.</param>
        /// <param name="main">is this the main dataset.</param>
        public SubDatasetGraphQuery(string name = default(string), string description = default(string), List<string> queries = default(List<string>), bool main = default(bool))
        {
            this.Name = name;
            this.Description = description;
            this.Queries = queries;
            this.Main = main;
        }

        /// <summary>
        /// the name of the subdataset
        /// </summary>
        /// <value>the name of the subdataset</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the description of the subdataset
        /// </summary>
        /// <value>the description of the subdataset</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// the query in cypher language
        /// </summary>
        /// <value>the query in cypher language</value>
        [DataMember(Name = "queries", EmitDefaultValue = false)]
        public List<string> Queries { get; set; }

        /// <summary>
        /// is this the main dataset
        /// </summary>
        /// <value>is this the main dataset</value>
        [DataMember(Name = "main", EmitDefaultValue = true)]
        public bool Main { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubDatasetGraphQuery {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
            sb.Append("  Main: ").Append(Main).Append("\n");
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
            return this.Equals(input as SubDatasetGraphQuery);
        }

        /// <summary>
        /// Returns true if SubDatasetGraphQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of SubDatasetGraphQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubDatasetGraphQuery input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Queries == input.Queries ||
                    this.Queries != null &&
                    input.Queries != null &&
                    this.Queries.SequenceEqual(input.Queries)
                ) && 
                (
                    this.Main == input.Main ||
                    this.Main.Equals(input.Main)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Queries != null)
                {
                    hashCode = (hashCode * 59) + this.Queries.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Main.GetHashCode();
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
