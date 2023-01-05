/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.1.11-dev
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
    ///  Class for testing ScenarioApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ScenarioApiTests : IDisposable
    {
        private ScenarioApi instance;

        public ScenarioApiTests()
        {
            instance = new ScenarioApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ScenarioApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ScenarioApi
            //Assert.IsType<ScenarioApi>(instance);
        }

        /// <summary>
        /// Test AddOrReplaceScenarioParameterValues
        /// </summary>
        [Fact]
        public void AddOrReplaceScenarioParameterValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //List<ScenarioRunTemplateParameterValue> scenarioRunTemplateParameterValue = null;
            //var response = instance.AddOrReplaceScenarioParameterValues(organizationId, workspaceId, scenarioId, scenarioRunTemplateParameterValue);
            //Assert.IsType<List<ScenarioRunTemplateParameterValue>>(response);
        }

        /// <summary>
        /// Test AddScenarioAccessControl
        /// </summary>
        [Fact]
        public void AddScenarioAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //ScenarioAccessControl scenarioAccessControl = null;
            //var response = instance.AddScenarioAccessControl(organizationId, workspaceId, scenarioId, scenarioAccessControl);
            //Assert.IsType<ScenarioAccessControl>(response);
        }

        /// <summary>
        /// Test CompareScenarios
        /// </summary>
        [Fact]
        public void CompareScenariosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //string comparedScenarioId = null;
            //var response = instance.CompareScenarios(organizationId, workspaceId, scenarioId, comparedScenarioId);
            //Assert.IsType<ScenarioComparisonResult>(response);
        }

        /// <summary>
        /// Test CreateScenario
        /// </summary>
        [Fact]
        public void CreateScenarioTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //Scenario scenario = null;
            //var response = instance.CreateScenario(organizationId, workspaceId, scenario);
            //Assert.IsType<Scenario>(response);
        }

        /// <summary>
        /// Test DeleteAllScenarios
        /// </summary>
        [Fact]
        public void DeleteAllScenariosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //instance.DeleteAllScenarios(organizationId, workspaceId);
        }

        /// <summary>
        /// Test DeleteScenario
        /// </summary>
        [Fact]
        public void DeleteScenarioTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //bool? waitRelationshipPropagation = null;
            //instance.DeleteScenario(organizationId, workspaceId, scenarioId, waitRelationshipPropagation);
        }

        /// <summary>
        /// Test DownloadScenarioData
        /// </summary>
        [Fact]
        public void DownloadScenarioDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //var response = instance.DownloadScenarioData(organizationId, workspaceId, scenarioId);
            //Assert.IsType<ScenarioDataDownloadJob>(response);
        }

        /// <summary>
        /// Test FindAllScenarios
        /// </summary>
        [Fact]
        public void FindAllScenariosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //var response = instance.FindAllScenarios(organizationId, workspaceId);
            //Assert.IsType<List<Scenario>>(response);
        }

        /// <summary>
        /// Test FindAllScenariosByValidationStatus
        /// </summary>
        [Fact]
        public void FindAllScenariosByValidationStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //ScenarioValidationStatus validationStatus = null;
            //var response = instance.FindAllScenariosByValidationStatus(organizationId, workspaceId, validationStatus);
            //Assert.IsType<List<Scenario>>(response);
        }

        /// <summary>
        /// Test FindScenarioById
        /// </summary>
        [Fact]
        public void FindScenarioByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //var response = instance.FindScenarioById(organizationId, workspaceId, scenarioId);
            //Assert.IsType<Scenario>(response);
        }

        /// <summary>
        /// Test GetScenarioAccessControl
        /// </summary>
        [Fact]
        public void GetScenarioAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //string identityId = null;
            //var response = instance.GetScenarioAccessControl(organizationId, workspaceId, scenarioId, identityId);
            //Assert.IsType<ScenarioAccessControl>(response);
        }

        /// <summary>
        /// Test GetScenarioDataDownloadJobInfo
        /// </summary>
        [Fact]
        public void GetScenarioDataDownloadJobInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //string downloadId = null;
            //var response = instance.GetScenarioDataDownloadJobInfo(organizationId, workspaceId, scenarioId, downloadId);
            //Assert.IsType<ScenarioDataDownloadInfo>(response);
        }

        /// <summary>
        /// Test GetScenarioPermissions
        /// </summary>
        [Fact]
        public void GetScenarioPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string role = null;
            //var response = instance.GetScenarioPermissions(organizationId, workspaceId, role);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetScenarioSecurity
        /// </summary>
        [Fact]
        public void GetScenarioSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //var response = instance.GetScenarioSecurity(organizationId, workspaceId, scenarioId);
            //Assert.IsType<ScenarioSecurity>(response);
        }

        /// <summary>
        /// Test GetScenarioSecurityUsers
        /// </summary>
        [Fact]
        public void GetScenarioSecurityUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //var response = instance.GetScenarioSecurityUsers(organizationId, workspaceId, scenarioId);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetScenarioValidationStatusById
        /// </summary>
        [Fact]
        public void GetScenarioValidationStatusByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //var response = instance.GetScenarioValidationStatusById(organizationId, workspaceId, scenarioId);
            //Assert.IsType<ScenarioValidationStatus>(response);
        }

        /// <summary>
        /// Test GetScenariosTree
        /// </summary>
        [Fact]
        public void GetScenariosTreeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //var response = instance.GetScenariosTree(organizationId, workspaceId);
            //Assert.IsType<List<Scenario>>(response);
        }

        /// <summary>
        /// Test RemoveAllScenarioParameterValues
        /// </summary>
        [Fact]
        public void RemoveAllScenarioParameterValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //instance.RemoveAllScenarioParameterValues(organizationId, workspaceId, scenarioId);
        }

        /// <summary>
        /// Test RemoveScenarioAccessControl
        /// </summary>
        [Fact]
        public void RemoveScenarioAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //string identityId = null;
            //instance.RemoveScenarioAccessControl(organizationId, workspaceId, scenarioId, identityId);
        }

        /// <summary>
        /// Test SetScenarioDefaultSecurity
        /// </summary>
        [Fact]
        public void SetScenarioDefaultSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //ScenarioRole scenarioRole = null;
            //var response = instance.SetScenarioDefaultSecurity(organizationId, workspaceId, scenarioId, scenarioRole);
            //Assert.IsType<ScenarioSecurity>(response);
        }

        /// <summary>
        /// Test UpdateScenario
        /// </summary>
        [Fact]
        public void UpdateScenarioTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //Scenario scenario = null;
            //var response = instance.UpdateScenario(organizationId, workspaceId, scenarioId, scenario);
            //Assert.IsType<Scenario>(response);
        }

        /// <summary>
        /// Test UpdateScenarioAccessControl
        /// </summary>
        [Fact]
        public void UpdateScenarioAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string scenarioId = null;
            //string identityId = null;
            //ScenarioRole scenarioRole = null;
            //var response = instance.UpdateScenarioAccessControl(organizationId, workspaceId, scenarioId, identityId, scenarioRole);
            //Assert.IsType<ScenarioAccessControl>(response);
        }
    }
}
