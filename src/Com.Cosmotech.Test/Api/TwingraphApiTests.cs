/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.3.10
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
    ///  Class for testing TwingraphApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TwingraphApiTests : IDisposable
    {
        private TwingraphApi instance;

        public TwingraphApiTests()
        {
            instance = new TwingraphApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TwingraphApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TwingraphApi
            //Assert.IsType<TwingraphApi>(instance);
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //instance.Delete(organizationId, graphId);
        }

        /// <summary>
        /// Test FindAllTwingraphs
        /// </summary>
        [Fact]
        public void FindAllTwingraphsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.FindAllTwingraphs(organizationId);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetGraphMetaData
        /// </summary>
        [Fact]
        public void GetGraphMetaDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //var response = instance.GetGraphMetaData(organizationId, graphId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ImportGraph
        /// </summary>
        [Fact]
        public void ImportGraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //TwinGraphImport twinGraphImport = null;
            //var response = instance.ImportGraph(organizationId, twinGraphImport);
            //Assert.IsType<TwinGraphImportInfo>(response);
        }

        /// <summary>
        /// Test JobStatus
        /// </summary>
        [Fact]
        public void JobStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string jobId = null;
            //var response = instance.JobStatus(organizationId, jobId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test Query
        /// </summary>
        [Fact]
        public void QueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //TwinGraphQuery twinGraphQuery = null;
            //var response = instance.Query(organizationId, graphId, twinGraphQuery);
            //Assert.IsType<string>(response);
        }
    }
}
