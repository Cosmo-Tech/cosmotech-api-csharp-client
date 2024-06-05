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
    /// the Orchestrator to use for the Run Template
    /// </summary>
    /// <value>the Orchestrator to use for the Run Template</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunTemplateOrchestrator
    {
        /// <summary>
        /// Enum ArgoWorkflow for value: argoWorkflow
        /// </summary>
        [EnumMember(Value = "argoWorkflow")]
        ArgoWorkflow = 1,

        /// <summary>
        /// Enum CsmOrc for value: csmOrc
        /// </summary>
        [EnumMember(Value = "csmOrc")]
        CsmOrc = 2

    }

}
