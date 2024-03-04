/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.2-SNAPSHOT
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
    ///  Class for testing RunApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RunApiTests : IDisposable
    {
        private RunApi instance;

        public RunApiTests()
        {
            instance = new RunApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RunApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RunApi
            //Assert.IsType<RunApi>(instance);
        }

        /// <summary>
        /// Test DeleteRun
        /// </summary>
        [Fact]
        public void DeleteRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //string runId = null;
            //instance.DeleteRun(organizationId, workspaceId, runnerId, runId);
        }

        /// <summary>
        /// Test GetRun
        /// </summary>
        [Fact]
        public void GetRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //string runId = null;
            //var response = instance.GetRun(organizationId, workspaceId, runnerId, runId);
            //Assert.IsType<Run>(response);
        }

        /// <summary>
        /// Test GetRunLogs
        /// </summary>
        [Fact]
        public void GetRunLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //string runId = null;
            //var response = instance.GetRunLogs(organizationId, workspaceId, runnerId, runId);
            //Assert.IsType<RunLogs>(response);
        }

        /// <summary>
        /// Test GetRunStatus
        /// </summary>
        [Fact]
        public void GetRunStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //string runId = null;
            //var response = instance.GetRunStatus(organizationId, workspaceId, runnerId, runId);
            //Assert.IsType<RunStatus>(response);
        }

        /// <summary>
        /// Test ListRuns
        /// </summary>
        [Fact]
        public void ListRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.ListRuns(organizationId, workspaceId, runnerId, page, size);
            //Assert.IsType<List<Run>>(response);
        }
    }
}
