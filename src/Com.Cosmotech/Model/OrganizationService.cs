/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 0.0.10-rc
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
    /// a cloud service resource
    /// </summary>
    [DataContract(Name = "OrganizationService")]
    public partial class OrganizationService : IEquatable<OrganizationService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationService" /> class.
        /// </summary>
        /// <param name="cloudService">the cloud service name.</param>
        /// <param name="baseUri">the platform base uri for this service.</param>
        /// <param name="platformService">the Platform service associated to the resource.</param>
        /// <param name="resourceUri">the Organization specific uri for this service resource.</param>
        /// <param name="credentials">a freeform credentials object. Structure depends on service.</param>
        public OrganizationService(string cloudService = default(string), string baseUri = default(string), string platformService = default(string), string resourceUri = default(string), Dictionary<string, Object> credentials = default(Dictionary<string, Object>))
        {
            this.CloudService = cloudService;
            this.BaseUri = baseUri;
            this.PlatformService = platformService;
            this.ResourceUri = resourceUri;
            this.Credentials = credentials;
        }

        /// <summary>
        /// the cloud service name
        /// </summary>
        /// <value>the cloud service name</value>
        [DataMember(Name = "cloudService", EmitDefaultValue = false)]
        public string CloudService { get; set; }

        /// <summary>
        /// the platform base uri for this service
        /// </summary>
        /// <value>the platform base uri for this service</value>
        [DataMember(Name = "baseUri", EmitDefaultValue = false)]
        public string BaseUri { get; set; }

        /// <summary>
        /// the Platform service associated to the resource
        /// </summary>
        /// <value>the Platform service associated to the resource</value>
        [DataMember(Name = "platformService", EmitDefaultValue = false)]
        public string PlatformService { get; set; }

        /// <summary>
        /// the Organization specific uri for this service resource
        /// </summary>
        /// <value>the Organization specific uri for this service resource</value>
        [DataMember(Name = "resourceUri", EmitDefaultValue = false)]
        public string ResourceUri { get; set; }

        /// <summary>
        /// a freeform credentials object. Structure depends on service
        /// </summary>
        /// <value>a freeform credentials object. Structure depends on service</value>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        public Dictionary<string, Object> Credentials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationService {\n");
            sb.Append("  CloudService: ").Append(CloudService).Append("\n");
            sb.Append("  BaseUri: ").Append(BaseUri).Append("\n");
            sb.Append("  PlatformService: ").Append(PlatformService).Append("\n");
            sb.Append("  ResourceUri: ").Append(ResourceUri).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
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
            return this.Equals(input as OrganizationService);
        }

        /// <summary>
        /// Returns true if OrganizationService instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudService == input.CloudService ||
                    (this.CloudService != null &&
                    this.CloudService.Equals(input.CloudService))
                ) && 
                (
                    this.BaseUri == input.BaseUri ||
                    (this.BaseUri != null &&
                    this.BaseUri.Equals(input.BaseUri))
                ) && 
                (
                    this.PlatformService == input.PlatformService ||
                    (this.PlatformService != null &&
                    this.PlatformService.Equals(input.PlatformService))
                ) && 
                (
                    this.ResourceUri == input.ResourceUri ||
                    (this.ResourceUri != null &&
                    this.ResourceUri.Equals(input.ResourceUri))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    this.Credentials != null &&
                    input.Credentials != null &&
                    this.Credentials.SequenceEqual(input.Credentials)
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
                if (this.CloudService != null)
                    hashCode = hashCode * 59 + this.CloudService.GetHashCode();
                if (this.BaseUri != null)
                    hashCode = hashCode * 59 + this.BaseUri.GetHashCode();
                if (this.PlatformService != null)
                    hashCode = hashCode * 59 + this.PlatformService.GetHashCode();
                if (this.ResourceUri != null)
                    hashCode = hashCode * 59 + this.ResourceUri.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
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
