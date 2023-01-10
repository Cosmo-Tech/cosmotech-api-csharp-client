/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 1.1.2
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
    /// a Scenario user with roles
    /// </summary>
    [DataContract(Name = "ScenarioUser")]
    public partial class ScenarioUser : IEquatable<ScenarioUser>, IValidatableObject
    {
        /// <summary>
        /// Defines Roles
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RolesEnum
        {
            /// <summary>
            /// Enum Viewer for value: Viewer
            /// </summary>
            [EnumMember(Value = "Viewer")]
            Viewer = 1,

            /// <summary>
            /// Enum Editor for value: Editor
            /// </summary>
            [EnumMember(Value = "Editor")]
            Editor = 2

        }



        /// <summary>
        /// the User role
        /// </summary>
        /// <value>the User role</value>
        [DataMember(Name = "roles", IsRequired = true, EmitDefaultValue = false)]
        public List<RolesEnum> Roles { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScenarioUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioUser" /> class.
        /// </summary>
        /// <param name="id">the User id (required).</param>
        /// <param name="roles">the User role (required).</param>
        public ScenarioUser(string id = default(string), List<RolesEnum> roles = default(List<RolesEnum>))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ScenarioUser and cannot be null");
            }
            this.Id = id;
            // to ensure "roles" is required (not null)
            if (roles == null) {
                throw new ArgumentNullException("roles is a required property for ScenarioUser and cannot be null");
            }
            this.Roles = roles;
        }

        /// <summary>
        /// the User id
        /// </summary>
        /// <value>the User id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// the User name
        /// </summary>
        /// <value>the User name</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenarioUser {\n");
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
            return this.Equals(input as ScenarioUser);
        }

        /// <summary>
        /// Returns true if ScenarioUser instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioUser input)
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
                hashCode = (hashCode * 59) + this.Roles.GetHashCode();
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
