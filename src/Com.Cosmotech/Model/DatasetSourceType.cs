/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.12-SNAPSHOT
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
    /// the Dataset Source Type
    /// </summary>
    /// <value>the Dataset Source Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DatasetSourceType
    {
        /// <summary>
        /// Enum ADT for value: ADT
        /// </summary>
        [EnumMember(Value = "ADT")]
        ADT = 1,

        /// <summary>
        /// Enum AzureStorage for value: AzureStorage
        /// </summary>
        [EnumMember(Value = "AzureStorage")]
        AzureStorage = 2,

        /// <summary>
        /// Enum File for value: File
        /// </summary>
        [EnumMember(Value = "File")]
        File = 3,

        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 4,

        /// <summary>
        /// Enum Twincache for value: Twincache
        /// </summary>
        [EnumMember(Value = "Twincache")]
        Twincache = 5

    }

}
