/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.1-SNAPSHOT
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
    public partial class OrganizationService : IValidatableObject
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
            StringBuilder sb = new StringBuilder();
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
