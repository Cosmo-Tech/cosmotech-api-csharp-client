/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 1.0.0
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
    ///  Class for testing DatasetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DatasetApiTests : IDisposable
    {
        private DatasetApi instance;

        public DatasetApiTests()
        {
            instance = new DatasetApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatasetApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DatasetApi
            //Assert.IsType<DatasetApi>(instance);
        }

        /// <summary>
        /// Test AddOrReplaceDatasetCompatibilityElements
        /// </summary>
        [Fact]
        public void AddOrReplaceDatasetCompatibilityElementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //List<DatasetCompatibility> datasetCompatibility = null;
            //var response = instance.AddOrReplaceDatasetCompatibilityElements(organizationId, datasetId, datasetCompatibility);
            //Assert.IsType<List<DatasetCompatibility>>(response);
        }

        /// <summary>
        /// Test CopyDataset
        /// </summary>
        [Fact]
        public void CopyDatasetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //DatasetCopyParameters datasetCopyParameters = null;
            //var response = instance.CopyDataset(organizationId, datasetCopyParameters);
            //Assert.IsType<DatasetCopyParameters>(response);
        }

        /// <summary>
        /// Test CreateDataset
        /// </summary>
        [Fact]
        public void CreateDatasetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //Dataset dataset = null;
            //var response = instance.CreateDataset(organizationId, dataset);
            //Assert.IsType<Dataset>(response);
        }

        /// <summary>
        /// Test DeleteDataset
        /// </summary>
        [Fact]
        public void DeleteDatasetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //instance.DeleteDataset(organizationId, datasetId);
        }

        /// <summary>
        /// Test FindAllDatasets
        /// </summary>
        [Fact]
        public void FindAllDatasetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.FindAllDatasets(organizationId);
            //Assert.IsType<List<Dataset>>(response);
        }

        /// <summary>
        /// Test FindDatasetById
        /// </summary>
        [Fact]
        public void FindDatasetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //var response = instance.FindDatasetById(organizationId, datasetId);
            //Assert.IsType<Dataset>(response);
        }

        /// <summary>
        /// Test RemoveAllDatasetCompatibilityElements
        /// </summary>
        [Fact]
        public void RemoveAllDatasetCompatibilityElementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //instance.RemoveAllDatasetCompatibilityElements(organizationId, datasetId);
        }

        /// <summary>
        /// Test SearchDatasets
        /// </summary>
        [Fact]
        public void SearchDatasetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //DatasetSearch datasetSearch = null;
            //var response = instance.SearchDatasets(organizationId, datasetSearch);
            //Assert.IsType<List<Dataset>>(response);
        }

        /// <summary>
        /// Test UpdateDataset
        /// </summary>
        [Fact]
        public void UpdateDatasetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //Dataset dataset = null;
            //var response = instance.UpdateDataset(organizationId, datasetId, dataset);
            //Assert.IsType<Dataset>(response);
        }
    }
}
