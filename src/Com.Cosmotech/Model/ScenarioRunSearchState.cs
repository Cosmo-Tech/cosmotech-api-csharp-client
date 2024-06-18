/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.6
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
    /// the state to search
    /// </summary>
    /// <value>the state to search</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScenarioRunSearchState
    {
        /// <summary>
        /// Enum FetchingDatasets for value: FetchingDatasets
        /// </summary>
        [EnumMember(Value = "FetchingDatasets")]
        FetchingDatasets = 1,

        /// <summary>
        /// Enum FetchingScenarioParameters for value: FetchingScenarioParameters
        /// </summary>
        [EnumMember(Value = "FetchingScenarioParameters")]
        FetchingScenarioParameters = 2,

        /// <summary>
        /// Enum ApplyingScenarioParameters for value: ApplyingScenarioParameters
        /// </summary>
        [EnumMember(Value = "ApplyingScenarioParameters")]
        ApplyingScenarioParameters = 3,

        /// <summary>
        /// Enum ValidatingScenarioData for value: ValidatingScenarioData
        /// </summary>
        [EnumMember(Value = "ValidatingScenarioData")]
        ValidatingScenarioData = 4,

        /// <summary>
        /// Enum SendingScenarioDataToDataWarehouse for value: SendingScenarioDataToDataWarehouse
        /// </summary>
        [EnumMember(Value = "SendingScenarioDataToDataWarehouse")]
        SendingScenarioDataToDataWarehouse = 5,

        /// <summary>
        /// Enum PreRun for value: PreRun
        /// </summary>
        [EnumMember(Value = "PreRun")]
        PreRun = 6,

        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 7,

        /// <summary>
        /// Enum PostRun for value: PostRun
        /// </summary>
        [EnumMember(Value = "PostRun")]
        PostRun = 8,

        /// <summary>
        /// Enum Success for value: Success
        /// </summary>
        [EnumMember(Value = "Success")]
        Success = 9,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 10
    }

}
