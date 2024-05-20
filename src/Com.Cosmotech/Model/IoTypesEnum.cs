/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.1
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
    /// The read and write capabilities of connector
    /// </summary>
    /// <value>The read and write capabilities of connector</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IoTypesEnum
    {
        /// <summary>
        /// Enum Read for value: read
        /// </summary>
        [EnumMember(Value = "read")]
        Read = 1,

        /// <summary>
        /// Enum Write for value: write
        /// </summary>
        [EnumMember(Value = "write")]
        Write = 2
    }

}
