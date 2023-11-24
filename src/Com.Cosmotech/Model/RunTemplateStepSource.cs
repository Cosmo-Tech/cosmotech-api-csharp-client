/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.15-SNAPSHOT
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
    /// the source local, cloud or git repository
    /// </summary>
    /// <value>the source local, cloud or git repository</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunTemplateStepSource
    {
        /// <summary>
        /// Enum Cloud for value: cloud
        /// </summary>
        [EnumMember(Value = "cloud")]
        Cloud = 1,

        /// <summary>
        /// Enum Git for value: git
        /// </summary>
        [EnumMember(Value = "git")]
        Git = 2,

        /// <summary>
        /// Enum Local for value: local
        /// </summary>
        [EnumMember(Value = "local")]
        Local = 3,

        /// <summary>
        /// Enum Platform for value: platform
        /// </summary>
        [EnumMember(Value = "platform")]
        Platform = 4

    }

}
