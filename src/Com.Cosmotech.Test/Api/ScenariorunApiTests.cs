/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.2.8
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
    ///  Class for testing ScenariorunApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ScenariorunApiTests : IDisposable
    {
        private ScenariorunApi instance;

        public ScenariorunApiTests()
        {
            instance = new ScenariorunApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ScenariorunApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ScenariorunApi
            //Assert.IsType<ScenariorunApi>(instance);
        }

        /// <summary>
        /// Test DeleteHistoricalDataOrganization
        /// </summary>
        [Fact]
        public void DeleteHistoricalDataOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //bool? deleteUnknown = null;
            //instance.DeleteHistoricalDataOrganization(organizationId, deleteUnknown);
        }

        /// <summary>
        /// Test DeleteHistoricalDataScenario
        /// </summary>
        [Fact]
        public void DeleteHistoricalDataScenarioTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //bool? deleteUnknown = null;
            //instance.DeleteHistoricalDataScenario(organizationId, workspaceId, scenarioId, deleteUnknown);
        }

        /// <summary>
        /// Test DeleteHistoricalDataWorkspace
        /// </summary>
        [Fact]
        public void DeleteHistoricalDataWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //bool? deleteUnknown = null;
            //instance.DeleteHistoricalDataWorkspace(organizationId, workspaceId, deleteUnknown);
        }

        /// <summary>
        /// Test DeleteScenarioRun
        /// </summary>
        [Fact]
        public void DeleteScenarioRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string scenariorunId = null;
            //instance.DeleteScenarioRun(organizationId, scenariorunId);
        }

        /// <summary>
        /// Test FindScenarioRunById
        /// </summary>
        [Fact]
        public void FindScenarioRunByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string scenariorunId = null;
            //var response = instance.FindScenarioRunById(organizationId, scenariorunId);
            //Assert.IsType<ScenarioRun>(response);
        }

        /// <summary>
        /// Test GetScenarioRunCumulatedLogs
        /// </summary>
        [Fact]
        public void GetScenarioRunCumulatedLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string scenariorunId = null;
            //var response = instance.GetScenarioRunCumulatedLogs(organizationId, scenariorunId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetScenarioRunLogs
        /// </summary>
        [Fact]
        public void GetScenarioRunLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string scenariorunId = null;
            //var response = instance.GetScenarioRunLogs(organizationId, scenariorunId);
            //Assert.IsType<ScenarioRunLogs>(response);
        }

        /// <summary>
        /// Test GetScenarioRunStatus
        /// </summary>
        [Fact]
        public void GetScenarioRunStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string scenariorunId = null;
            //var response = instance.GetScenarioRunStatus(organizationId, scenariorunId);
            //Assert.IsType<ScenarioRunStatus>(response);
        }

        /// <summary>
        /// Test GetScenarioRuns
        /// </summary>
        [Fact]
        public void GetScenarioRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.GetScenarioRuns(organizationId, workspaceId, scenarioId, page, size);
            //Assert.IsType<List<ScenarioRun>>(response);
        }

        /// <summary>
        /// Test GetWorkspaceScenarioRuns
        /// </summary>
        [Fact]
        public void GetWorkspaceScenarioRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.GetWorkspaceScenarioRuns(organizationId, workspaceId, page, size);
            //Assert.IsType<List<ScenarioRun>>(response);
        }

        /// <summary>
        /// Test RunScenario
        /// </summary>
        [Fact]
        public void RunScenarioTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //var response = instance.RunScenario(organizationId, workspaceId, scenarioId);
            //Assert.IsType<ScenarioRun>(response);
        }

        /// <summary>
        /// Test SearchScenarioRuns
        /// </summary>
        [Fact]
        public void SearchScenarioRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //ScenarioRunSearch scenarioRunSearch = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.SearchScenarioRuns(organizationId, scenarioRunSearch, page, size);
            //Assert.IsType<List<ScenarioRun>>(response);
        }

        /// <summary>
        /// Test StartScenarioRunContainers
        /// </summary>
        [Fact]
        public void StartScenarioRunContainersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //ScenarioRunStartContainers scenarioRunStartContainers = null;
            //var response = instance.StartScenarioRunContainers(organizationId, scenarioRunStartContainers);
            //Assert.IsType<ScenarioRun>(response);
        }

        /// <summary>
        /// Test StopScenarioRun
        /// </summary>
        [Fact]
        public void StopScenarioRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string scenariorunId = null;
            //var response = instance.StopScenarioRun(organizationId, scenariorunId);
            //Assert.IsType<ScenarioRunStatus>(response);
        }
    }
}
