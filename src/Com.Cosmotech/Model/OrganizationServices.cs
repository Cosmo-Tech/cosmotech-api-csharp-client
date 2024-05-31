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
    /// the cloud service resources of the Organization
    /// </summary>
    [DataContract(Name = "OrganizationServices")]
    public partial class OrganizationServices : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationServices" /> class.
        /// </summary>
        /// <param name="tenantCredentials">a freeform credentials object for the Organization tenant. Structure depends on cloud provider.</param>
        /// <param name="storage">storage.</param>
        /// <param name="solutionsContainerRegistry">solutionsContainerRegistry.</param>
        public OrganizationServices(Dictionary<string, Object> tenantCredentials = default(Dictionary<string, Object>), OrganizationService storage = default(OrganizationService), OrganizationService solutionsContainerRegistry = default(OrganizationService))
        {
            this.TenantCredentials = tenantCredentials;
            this.Storage = storage;
            this.SolutionsContainerRegistry = solutionsContainerRegistry;
        }

        /// <summary>
        /// a freeform credentials object for the Organization tenant. Structure depends on cloud provider
        /// </summary>
        /// <value>a freeform credentials object for the Organization tenant. Structure depends on cloud provider</value>
        [DataMember(Name = "tenantCredentials", EmitDefaultValue = false)]
        public Dictionary<string, Object> TenantCredentials { get; set; }

        /// <summary>
        /// Gets or Sets Storage
        /// </summary>
        [DataMember(Name = "storage", EmitDefaultValue = false)]
        public OrganizationService Storage { get; set; }

        /// <summary>
        /// Gets or Sets SolutionsContainerRegistry
        /// </summary>
        [DataMember(Name = "solutionsContainerRegistry", EmitDefaultValue = false)]
        public OrganizationService SolutionsContainerRegistry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganizationServices {\n");
            sb.Append("  TenantCredentials: ").Append(TenantCredentials).Append("\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("  SolutionsContainerRegistry: ").Append(SolutionsContainerRegistry).Append("\n");
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
