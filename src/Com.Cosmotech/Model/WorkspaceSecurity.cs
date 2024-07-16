/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.8
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
    /// the workspace security information
    /// </summary>
    [DataContract(Name = "WorkspaceSecurity")]
    public partial class WorkspaceSecurity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSecurity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkspaceSecurity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSecurity" /> class.
        /// </summary>
        /// <param name="varDefault">the role by default (required).</param>
        /// <param name="accessControlList">the list which can access this Workspace with detailed access control information (required).</param>
        public WorkspaceSecurity(string varDefault = default(string), List<WorkspaceAccessControl> accessControlList = default(List<WorkspaceAccessControl>))
        {
            // to ensure "varDefault" is required (not null)
            if (varDefault == null)
            {
                throw new ArgumentNullException("varDefault is a required property for WorkspaceSecurity and cannot be null");
            }
            this.VarDefault = varDefault;
            // to ensure "accessControlList" is required (not null)
            if (accessControlList == null)
            {
                throw new ArgumentNullException("accessControlList is a required property for WorkspaceSecurity and cannot be null");
            }
            this.AccessControlList = accessControlList;
        }

        /// <summary>
        /// the role by default
        /// </summary>
        /// <value>the role by default</value>
        [DataMember(Name = "default", IsRequired = true, EmitDefaultValue = true)]
        public string VarDefault { get; set; }

        /// <summary>
        /// the list which can access this Workspace with detailed access control information
        /// </summary>
        /// <value>the list which can access this Workspace with detailed access control information</value>
        [DataMember(Name = "accessControlList", IsRequired = true, EmitDefaultValue = true)]
        public List<WorkspaceAccessControl> AccessControlList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkspaceSecurity {\n");
            sb.Append("  VarDefault: ").Append(VarDefault).Append("\n");
            sb.Append("  AccessControlList: ").Append(AccessControlList).Append("\n");
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
