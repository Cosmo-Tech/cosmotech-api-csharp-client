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
        /// Test BatchQuery
        /// </summary>
        [Fact]
        public void BatchQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //TwinGraphQuery twinGraphQuery = null;
            //var response = instance.BatchQuery(organizationId, graphId, twinGraphQuery);
            //Assert.IsType<TwinGraphHash>(response);
        }

        /// <summary>
        /// Test BatchUploadUpdate
        /// </summary>
        [Fact]
        public void BatchUploadUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //TwinGraphQuery twinGraphQuery = null;
            //System.IO.Stream body = null;
            //var response = instance.BatchUploadUpdate(organizationId, graphId, twinGraphQuery, body);
            //Assert.IsType<TwinGraphBatchResult>(response);
        }

        /// <summary>
        /// Test CreateEntities
        /// </summary>
        [Fact]
        public void CreateEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //string type = null;
            //List<GraphProperties> graphProperties = null;
            //var response = instance.CreateEntities(organizationId, graphId, type, graphProperties);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test CreateGraph
        /// </summary>
        [Fact]
        public void CreateGraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //System.IO.Stream? body = null;
            //instance.CreateGraph(organizationId, graphId, body);
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
        /// Test DeleteEntities
        /// </summary>
        [Fact]
        public void DeleteEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //string type = null;
            //List<string> ids = null;
            //instance.DeleteEntities(organizationId, graphId, type, ids);
        }

        /// <summary>
        /// Test DownloadGraph
        /// </summary>
        [Fact]
        public void DownloadGraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string hash = null;
            //var response = instance.DownloadGraph(organizationId, hash);
            //Assert.IsType<System.IO.Stream>(response);
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
        /// Test GetEntities
        /// </summary>
        [Fact]
        public void GetEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //string type = null;
            //List<string> ids = null;
            //var response = instance.GetEntities(organizationId, graphId, type, ids);
            //Assert.IsType<string>(response);
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

        /// <summary>
        /// Test UpdateEntities
        /// </summary>
        [Fact]
        public void UpdateEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //string type = null;
            //List<GraphProperties> graphProperties = null;
            //var response = instance.UpdateEntities(organizationId, graphId, type, graphProperties);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test UpdateGraphMetaData
        /// </summary>
        [Fact]
        public void UpdateGraphMetaDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string graphId = null;
            //Dictionary<string, string> requestBody = null;
            //var response = instance.UpdateGraphMetaData(organizationId, graphId, requestBody);
            //Assert.IsType<Object>(response);
        }
    }
}
