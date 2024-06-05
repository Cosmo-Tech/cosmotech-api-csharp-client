/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.8-adp
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
    /// the validation status of the runner
    /// </summary>
    /// <value>the validation status of the runner</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunnerValidationStatus
    {
        /// <summary>
        /// Enum Draft for value: Draft
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft = 1,

        /// <summary>
        /// Enum Rejected for value: Rejected
        /// </summary>
        [EnumMember(Value = "Rejected")]
        Rejected = 2,

        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 3,

        /// <summary>
        /// Enum Validated for value: Validated
        /// </summary>
        [EnumMember(Value = "Validated")]
        Validated = 4

    }

}
