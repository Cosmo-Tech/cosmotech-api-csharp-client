/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.4.4-dev
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
    ///  Class for testing SolutionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SolutionApiTests : IDisposable
    {
        private SolutionApi instance;

        public SolutionApiTests()
        {
            instance = new SolutionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SolutionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SolutionApi
            //Assert.IsType<SolutionApi>(instance);
        }

        /// <summary>
        /// Test AddOrReplaceParameterGroups
        /// </summary>
        [Fact]
        public void AddOrReplaceParameterGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //List<RunTemplateParameterGroup> runTemplateParameterGroup = null;
            //var response = instance.AddOrReplaceParameterGroups(organizationId, solutionId, runTemplateParameterGroup);
            //Assert.IsType<List<RunTemplateParameterGroup>>(response);
        }

        /// <summary>
        /// Test AddOrReplaceParameters
        /// </summary>
        [Fact]
        public void AddOrReplaceParametersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //List<RunTemplateParameter> runTemplateParameter = null;
            //var response = instance.AddOrReplaceParameters(organizationId, solutionId, runTemplateParameter);
            //Assert.IsType<List<RunTemplateParameter>>(response);
        }

        /// <summary>
        /// Test AddOrReplaceRunTemplates
        /// </summary>
        [Fact]
        public void AddOrReplaceRunTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //List<RunTemplate> runTemplate = null;
            //var response = instance.AddOrReplaceRunTemplates(organizationId, solutionId, runTemplate);
            //Assert.IsType<List<RunTemplate>>(response);
        }

        /// <summary>
        /// Test CreateSolution
        /// </summary>
        [Fact]
        public void CreateSolutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //Solution solution = null;
            //var response = instance.CreateSolution(organizationId, solution);
            //Assert.IsType<Solution>(response);
        }

        /// <summary>
        /// Test DeleteSolution
        /// </summary>
        [Fact]
        public void DeleteSolutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //instance.DeleteSolution(organizationId, solutionId);
        }

        /// <summary>
        /// Test DeleteSolutionRunTemplate
        /// </summary>
        [Fact]
        public void DeleteSolutionRunTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //string runTemplateId = null;
            //instance.DeleteSolutionRunTemplate(organizationId, solutionId, runTemplateId);
        }

        /// <summary>
        /// Test DownloadRunTemplateHandler
        /// </summary>
        [Fact]
        public void DownloadRunTemplateHandlerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //string runTemplateId = null;
            //RunTemplateHandlerId handlerId = null;
            //var response = instance.DownloadRunTemplateHandler(organizationId, solutionId, runTemplateId, handlerId);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test FindAllSolutions
        /// </summary>
        [Fact]
        public void FindAllSolutionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.FindAllSolutions(organizationId, page, size);
            //Assert.IsType<List<Solution>>(response);
        }

        /// <summary>
        /// Test FindSolutionById
        /// </summary>
        [Fact]
        public void FindSolutionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //var response = instance.FindSolutionById(organizationId, solutionId);
            //Assert.IsType<Solution>(response);
        }

        /// <summary>
        /// Test ImportSolution
        /// </summary>
        [Fact]
        public void ImportSolutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //Solution solution = null;
            //var response = instance.ImportSolution(organizationId, solution);
            //Assert.IsType<Solution>(response);
        }

        /// <summary>
        /// Test RemoveAllRunTemplates
        /// </summary>
        [Fact]
        public void RemoveAllRunTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //instance.RemoveAllRunTemplates(organizationId, solutionId);
        }

        /// <summary>
        /// Test RemoveAllSolutionParameterGroups
        /// </summary>
        [Fact]
        public void RemoveAllSolutionParameterGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //instance.RemoveAllSolutionParameterGroups(organizationId, solutionId);
        }

        /// <summary>
        /// Test RemoveAllSolutionParameters
        /// </summary>
        [Fact]
        public void RemoveAllSolutionParametersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //instance.RemoveAllSolutionParameters(organizationId, solutionId);
        }

        /// <summary>
        /// Test UpdateSolution
        /// </summary>
        [Fact]
        public void UpdateSolutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //Solution solution = null;
            //var response = instance.UpdateSolution(organizationId, solutionId, solution);
            //Assert.IsType<Solution>(response);
        }

        /// <summary>
        /// Test UpdateSolutionRunTemplate
        /// </summary>
        [Fact]
        public void UpdateSolutionRunTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //string runTemplateId = null;
            //RunTemplate runTemplate = null;
            //var response = instance.UpdateSolutionRunTemplate(organizationId, solutionId, runTemplateId, runTemplate);
            //Assert.IsType<List<RunTemplate>>(response);
        }

        /// <summary>
        /// Test UploadRunTemplateHandler
        /// </summary>
        [Fact]
        public void UploadRunTemplateHandlerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string solutionId = null;
            //string runTemplateId = null;
            //RunTemplateHandlerId handlerId = null;
            //System.IO.Stream body = null;
            //bool? overwrite = null;
            //instance.UploadRunTemplateHandler(organizationId, solutionId, runTemplateId, handlerId, body, overwrite);
        }
    }
}
