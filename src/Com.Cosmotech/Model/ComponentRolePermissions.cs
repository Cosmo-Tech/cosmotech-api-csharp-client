/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.4.3-preview
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
    /// a RBAC by component
    /// </summary>
    [DataContract(Name = "ComponentRolePermissions")]
    public partial class ComponentRolePermissions : IEquatable<ComponentRolePermissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentRolePermissions" /> class.
        /// </summary>
        /// <param name="component">component.</param>
        /// <param name="roles">roles.</param>
        public ComponentRolePermissions(string component = default(string), Dictionary<string, List<string>> roles = default(Dictionary<string, List<string>>))
        {
            this.Component = component;
            this.Roles = roles;
        }

        /// <summary>
        /// Gets or Sets Component
        /// </summary>
        [DataMember(Name = "component", EmitDefaultValue = false)]
        public string Component { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        public Dictionary<string, List<string>> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComponentRolePermissions {\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as ComponentRolePermissions);
        }

        /// <summary>
        /// Returns true if ComponentRolePermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of ComponentRolePermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComponentRolePermissions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Component == input.Component ||
                    (this.Component != null &&
                    this.Component.Equals(input.Component))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.Component != null)
                {
                    hashCode = (hashCode * 59) + this.Component.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
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
