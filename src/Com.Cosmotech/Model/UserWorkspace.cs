/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 1.0.2-dev
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
    /// the list of User roles for a Workspace
    /// </summary>
    [DataContract(Name = "UserWorkspace")]
    public partial class UserWorkspace : IEquatable<UserWorkspace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserWorkspace" /> class.
        /// </summary>
        /// <param name="roles">the roles of the User in the Workspace.</param>
        public UserWorkspace(List<string> roles = default(List<string>))
        {
            this.Roles = roles;
        }

        /// <summary>
        /// the Workspace Id
        /// </summary>
        /// <value>the Workspace Id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// the Workspace name
        /// </summary>
        /// <value>the Workspace name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// the roles of the User in the Workspace
        /// </summary>
        /// <value>the roles of the User in the Workspace</value>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserWorkspace {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as UserWorkspace);
        }

        /// <summary>
        /// Returns true if UserWorkspace instances are equal
        /// </summary>
        /// <param name="input">Instance of UserWorkspace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserWorkspace input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
