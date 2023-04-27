/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.3.8-SNAPSHOT
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
    /// the ScenarioRun end-to-end state
    /// </summary>
    /// <value>the ScenarioRun end-to-end state</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScenarioRunState
    {
        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 1,

        /// <summary>
        /// Enum Successful for value: Successful
        /// </summary>
        [EnumMember(Value = "Successful")]
        Successful = 2,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 3,

        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 4,

        /// <summary>
        /// Enum DataIngestionInProgress for value: DataIngestionInProgress
        /// </summary>
        [EnumMember(Value = "DataIngestionInProgress")]
        DataIngestionInProgress = 5,

        /// <summary>
        /// Enum DataIngestionFailure for value: DataIngestionFailure
        /// </summary>
        [EnumMember(Value = "DataIngestionFailure")]
        DataIngestionFailure = 6

    }

}
