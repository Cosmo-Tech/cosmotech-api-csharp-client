/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.4-test
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
    /// the Organization security information
    /// </summary>
    [DataContract(Name = "OrganizationSecurity")]
    public partial class OrganizationSecurity : IEquatable<OrganizationSecurity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSecurity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationSecurity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSecurity" /> class.
        /// </summary>
        /// <param name="_default">the role by default (required).</param>
        /// <param name="accessControlList">the list which can access this Organization with detailed access control information (required).</param>
        public OrganizationSecurity(string _default = default(string), List<OrganizationAccessControl> accessControlList = default(List<OrganizationAccessControl>))
        {
            // to ensure "_default" is required (not null)
            if (_default == null) {
                throw new ArgumentNullException("_default is a required property for OrganizationSecurity and cannot be null");
            }
            this.Default = _default;
            // to ensure "accessControlList" is required (not null)
            if (accessControlList == null) {
                throw new ArgumentNullException("accessControlList is a required property for OrganizationSecurity and cannot be null");
            }
            this.AccessControlList = accessControlList;
        }

        /// <summary>
        /// the role by default
        /// </summary>
        /// <value>the role by default</value>
        [DataMember(Name = "default", IsRequired = true, EmitDefaultValue = false)]
        public string Default { get; set; }

        /// <summary>
        /// the list which can access this Organization with detailed access control information
        /// </summary>
        /// <value>the list which can access this Organization with detailed access control information</value>
        [DataMember(Name = "accessControlList", IsRequired = true, EmitDefaultValue = false)]
        public List<OrganizationAccessControl> AccessControlList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganizationSecurity {\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrganizationSecurity);
        }

        /// <summary>
        /// Returns true if OrganizationSecurity instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationSecurity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationSecurity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.AccessControlList == input.AccessControlList ||
                    this.AccessControlList != null &&
                    input.AccessControlList != null &&
                    this.AccessControlList.SequenceEqual(input.AccessControlList)
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
                if (this.Default != null)
                {
                    hashCode = (hashCode * 59) + this.Default.GetHashCode();
                }
                if (this.AccessControlList != null)
                {
                    hashCode = (hashCode * 59) + this.AccessControlList.GetHashCode();
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
