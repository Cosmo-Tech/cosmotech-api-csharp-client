/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 0.1.0-SNAPSHOT
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
    /// the source local or cloud
    /// </summary>
    /// <value>the source local or cloud</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunTemplateStepSource
    {
        /// <summary>
        /// Enum Local for value: local
        /// </summary>
        [EnumMember(Value = "local")]
        Local = 1,

        /// <summary>
        /// Enum Cloud for value: cloud
        /// </summary>
        [EnumMember(Value = "cloud")]
        Cloud = 2

    }

}
