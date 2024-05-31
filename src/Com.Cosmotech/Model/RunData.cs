/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.4
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
    /// Run Data to send
    /// </summary>
    [DataContract(Name = "RunData")]
    public partial class RunData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunData" /> class.
        /// </summary>
        /// <param name="databaseName">Database name.</param>
        /// <param name="tableName">Table name.</param>
        /// <param name="data">data.</param>
        public RunData(string databaseName = default(string), string tableName = default(string), List<Dictionary<string, Object>> data = default(List<Dictionary<string, Object>>))
        {
            this.DatabaseName = databaseName;
            this.TableName = tableName;
            this.Data = data;
        }

        /// <summary>
        /// Database name
        /// </summary>
        /// <value>Database name</value>
        [DataMember(Name = "database_name", EmitDefaultValue = false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Table name
        /// </summary>
        /// <value>Table name</value>
        [DataMember(Name = "table_name", EmitDefaultValue = false)]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<Dictionary<string, Object>> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RunData {\n");
            sb.Append("  DatabaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
