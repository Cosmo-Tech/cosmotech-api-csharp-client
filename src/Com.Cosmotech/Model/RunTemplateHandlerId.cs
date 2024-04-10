/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.3
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
    /// the Run Template step handler identifier
    /// </summary>
    /// <value>the Run Template step handler identifier</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunTemplateHandlerId
    {
        /// <summary>
        /// Enum ParametersHandler for value: parameters_handler
        /// </summary>
        [EnumMember(Value = "parameters_handler")]
        ParametersHandler = 1,

        /// <summary>
        /// Enum Validator for value: validator
        /// </summary>
        [EnumMember(Value = "validator")]
        Validator = 2,

        /// <summary>
        /// Enum Prerun for value: prerun
        /// </summary>
        [EnumMember(Value = "prerun")]
        Prerun = 3,

        /// <summary>
        /// Enum Engine for value: engine
        /// </summary>
        [EnumMember(Value = "engine")]
        Engine = 4,

        /// <summary>
        /// Enum Postrun for value: postrun
        /// </summary>
        [EnumMember(Value = "postrun")]
        Postrun = 5,

        /// <summary>
        /// Enum ScenariodataTransform for value: scenariodata_transform
        /// </summary>
        [EnumMember(Value = "scenariodata_transform")]
        ScenariodataTransform = 6

    }

}
