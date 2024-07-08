/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 4.0.2-SNAPSHOT
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
    ///  Class for testing RunnerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RunnerApiTests : IDisposable
    {
        private RunnerApi instance;

        public RunnerApiTests()
        {
            instance = new RunnerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RunnerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RunnerApi
            //Assert.IsType<RunnerApi>(instance);
        }

        /// <summary>
        /// Test AddRunnerAccessControl
        /// </summary>
        [Fact]
        public void AddRunnerAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //RunnerAccessControl runnerAccessControl = null;
            //var response = instance.AddRunnerAccessControl(organizationId, workspaceId, runnerId, runnerAccessControl);
            //Assert.IsType<RunnerAccessControl>(response);
        }

        /// <summary>
        /// Test CreateRunner
        /// </summary>
        [Fact]
        public void CreateRunnerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //Runner runner = null;
            //var response = instance.CreateRunner(organizationId, workspaceId, runner);
            //Assert.IsType<Runner>(response);
        }

        /// <summary>
        /// Test DeleteRunner
        /// </summary>
        [Fact]
        public void DeleteRunnerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //instance.DeleteRunner(organizationId, workspaceId, runnerId);
        }

        /// <summary>
        /// Test GetRunner
        /// </summary>
        [Fact]
        public void GetRunnerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //var response = instance.GetRunner(organizationId, workspaceId, runnerId);
            //Assert.IsType<Runner>(response);
        }

        /// <summary>
        /// Test GetRunnerAccessControl
        /// </summary>
        [Fact]
        public void GetRunnerAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //string identityId = null;
            //var response = instance.GetRunnerAccessControl(organizationId, workspaceId, runnerId, identityId);
            //Assert.IsType<RunnerAccessControl>(response);
        }

        /// <summary>
        /// Test GetRunnerPermissions
        /// </summary>
        [Fact]
        public void GetRunnerPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //string role = null;
            //var response = instance.GetRunnerPermissions(organizationId, workspaceId, runnerId, role);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetRunnerSecurity
        /// </summary>
        [Fact]
        public void GetRunnerSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //var response = instance.GetRunnerSecurity(organizationId, workspaceId, runnerId);
            //Assert.IsType<RunnerSecurity>(response);
        }

        /// <summary>
        /// Test GetRunnerSecurityUsers
        /// </summary>
        [Fact]
        public void GetRunnerSecurityUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //var response = instance.GetRunnerSecurityUsers(organizationId, workspaceId, runnerId);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test ListRunners
        /// </summary>
        [Fact]
        public void ListRunnersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.ListRunners(organizationId, workspaceId, page, size);
            //Assert.IsType<List<Runner>>(response);
        }

        /// <summary>
        /// Test RemoveRunnerAccessControl
        /// </summary>
        [Fact]
        public void RemoveRunnerAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //string identityId = null;
            //instance.RemoveRunnerAccessControl(organizationId, workspaceId, runnerId, identityId);
        }

        /// <summary>
        /// Test SetRunnerDefaultSecurity
        /// </summary>
        [Fact]
        public void SetRunnerDefaultSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //RunnerRole runnerRole = null;
            //var response = instance.SetRunnerDefaultSecurity(organizationId, workspaceId, runnerId, runnerRole);
            //Assert.IsType<RunnerSecurity>(response);
        }

        /// <summary>
        /// Test StartRun
        /// </summary>
        [Fact]
        public void StartRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //var response = instance.StartRun(organizationId, workspaceId, runnerId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test StopRun
        /// </summary>
        [Fact]
        public void StopRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //instance.StopRun(organizationId, workspaceId, runnerId);
        }

        /// <summary>
        /// Test UpdateRunner
        /// </summary>
        [Fact]
        public void UpdateRunnerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //Runner runner = null;
            //var response = instance.UpdateRunner(organizationId, workspaceId, runnerId, runner);
            //Assert.IsType<Runner>(response);
        }

        /// <summary>
        /// Test UpdateRunnerAccessControl
        /// </summary>
        [Fact]
        public void UpdateRunnerAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string runnerId = null;
            //string identityId = null;
            //RunnerRole runnerRole = null;
            //var response = instance.UpdateRunnerAccessControl(organizationId, workspaceId, runnerId, identityId, runnerRole);
            //Assert.IsType<RunnerAccessControl>(response);
        }
    }
}
