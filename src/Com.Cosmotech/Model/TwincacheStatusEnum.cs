/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 4.0.3-SNAPSHOT
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
    /// the twincache data status
    /// </summary>
    /// <value>the twincache data status</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TwincacheStatusEnum
    {
        /// <summary>
        /// Enum EMPTY for value: EMPTY
        /// </summary>
        [EnumMember(Value = "EMPTY")]
        EMPTY = 1,

        /// <summary>
        /// Enum FULL for value: FULL
        /// </summary>
        [EnumMember(Value = "FULL")]
        FULL = 2
    }

}
