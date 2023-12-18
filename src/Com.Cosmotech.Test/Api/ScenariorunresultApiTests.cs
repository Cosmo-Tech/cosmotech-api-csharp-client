/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.16-SNAPSHOT
 * Contact: platform@cosmotech.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Com.Cosmotech.Client;
using Com.Cosmotech.Api;
// uncomment below to import models
//using Com.Cosmotech.Model;

namespace Com.Cosmotech.Test.Api
{
    /// <summary>
    ///  Class for testing ScenariorunresultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ScenariorunresultApiTests : IDisposable
    {
        private ScenariorunresultApi instance;

        public ScenariorunresultApiTests()
        {
            instance = new ScenariorunresultApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ScenariorunresultApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ScenariorunresultApi
            //Assert.IsType<ScenariorunresultApi>(instance);
        }

        /// <summary>
        /// Test GetScenarioRunResult
        /// </summary>
        [Fact]
        public void GetScenarioRunResultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //string scenariorunId = null;
            //string probeId = null;
            //var response = instance.GetScenarioRunResult(organizationId, workspaceId, scenarioId, scenariorunId, probeId);
            //Assert.IsType<ScenarioRunResult>(response);
        }

        /// <summary>
        /// Test SendScenarioRunResult
        /// </summary>
        [Fact]
        public void SendScenarioRunResultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //string scenariorunId = null;
            //string probeId = null;
            //Dictionary<string, string> requestBody = null;
            //var response = instance.SendScenarioRunResult(organizationId, workspaceId, scenarioId, scenariorunId, probeId, requestBody);
            //Assert.IsType<ScenarioRunResult>(response);
        }
    }
}
