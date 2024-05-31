/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.8
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
        /// Test AddDatasetAccessControl
        /// </summary>
        [Fact]
        public void AddDatasetAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //DatasetAccessControl datasetAccessControl = null;
            //var response = instance.AddDatasetAccessControl(organizationId, datasetId, datasetAccessControl);
            //Assert.IsType<DatasetAccessControl>(response);
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
        /// Test CreateSubDataset
        /// </summary>
        [Fact]
        public void CreateSubDatasetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //SubDatasetGraphQuery subDatasetGraphQuery = null;
            //var response = instance.CreateSubDataset(organizationId, datasetId, subDatasetGraphQuery);
            //Assert.IsType<Dataset>(response);
        }

        /// <summary>
        /// Test CreateTwingraphEntities
        /// </summary>
        [Fact]
        public void CreateTwingraphEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //string type = null;
            //List<GraphProperties> graphProperties = null;
            //var response = instance.CreateTwingraphEntities(organizationId, datasetId, type, graphProperties);
            //Assert.IsType<string>(response);
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
        /// Test DeleteTwingraphEntities
        /// </summary>
        [Fact]
        public void DeleteTwingraphEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //string type = null;
            //List<string> ids = null;
            //instance.DeleteTwingraphEntities(organizationId, datasetId, type, ids);
        }

        /// <summary>
        /// Test DownloadTwingraph
        /// </summary>
        [Fact]
        public void DownloadTwingraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string hash = null;
            //var response = instance.DownloadTwingraph(organizationId, hash);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test FindAllDatasets
        /// </summary>
        [Fact]
        public void FindAllDatasetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.FindAllDatasets(organizationId, page, size);
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
        /// Test GetDatasetAccessControl
        /// </summary>
        [Fact]
        public void GetDatasetAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //string identityId = null;
            //var response = instance.GetDatasetAccessControl(organizationId, datasetId, identityId);
            //Assert.IsType<DatasetAccessControl>(response);
        }

        /// <summary>
        /// Test GetDatasetSecurity
        /// </summary>
        [Fact]
        public void GetDatasetSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //var response = instance.GetDatasetSecurity(organizationId, datasetId);
            //Assert.IsType<DatasetSecurity>(response);
        }

        /// <summary>
        /// Test GetDatasetSecurityUsers
        /// </summary>
        [Fact]
        public void GetDatasetSecurityUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //var response = instance.GetDatasetSecurityUsers(organizationId, datasetId);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetDatasetTwingraphStatus
        /// </summary>
        [Fact]
        public void GetDatasetTwingraphStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //var response = instance.GetDatasetTwingraphStatus(organizationId, datasetId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetTwingraphEntities
        /// </summary>
        [Fact]
        public void GetTwingraphEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //string type = null;
            //List<string> ids = null;
            //var response = instance.GetTwingraphEntities(organizationId, datasetId, type, ids);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test LinkWorkspace
        /// </summary>
        [Fact]
        public void LinkWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //string workspaceId = null;
            //var response = instance.LinkWorkspace(organizationId, datasetId, workspaceId);
            //Assert.IsType<Dataset>(response);
        }

        /// <summary>
        /// Test RefreshDataset
        /// </summary>
        [Fact]
        public void RefreshDatasetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //var response = instance.RefreshDataset(organizationId, datasetId);
            //Assert.IsType<DatasetTwinGraphInfo>(response);
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
        /// Test RemoveDatasetAccessControl
        /// </summary>
        [Fact]
        public void RemoveDatasetAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //string identityId = null;
            //instance.RemoveDatasetAccessControl(organizationId, datasetId, identityId);
        }

        /// <summary>
        /// Test RollbackRefresh
        /// </summary>
        [Fact]
        public void RollbackRefreshTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //var response = instance.RollbackRefresh(organizationId, datasetId);
            //Assert.IsType<string>(response);
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
            //int? page = null;
            //int? size = null;
            //var response = instance.SearchDatasets(organizationId, datasetSearch, page, size);
            //Assert.IsType<List<Dataset>>(response);
        }

        /// <summary>
        /// Test SetDatasetDefaultSecurity
        /// </summary>
        [Fact]
        public void SetDatasetDefaultSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //DatasetRole datasetRole = null;
            //var response = instance.SetDatasetDefaultSecurity(organizationId, datasetId, datasetRole);
            //Assert.IsType<DatasetSecurity>(response);
        }

        /// <summary>
        /// Test TwingraphBatchQuery
        /// </summary>
        [Fact]
        public void TwingraphBatchQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //DatasetTwinGraphQuery datasetTwinGraphQuery = null;
            //var response = instance.TwingraphBatchQuery(organizationId, datasetId, datasetTwinGraphQuery);
            //Assert.IsType<DatasetTwinGraphHash>(response);
        }

        /// <summary>
        /// Test TwingraphBatchUpdate
        /// </summary>
        [Fact]
        public void TwingraphBatchUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //DatasetTwinGraphQuery twinGraphQuery = null;
            //System.IO.Stream body = null;
            //var response = instance.TwingraphBatchUpdate(organizationId, datasetId, twinGraphQuery, body);
            //Assert.IsType<TwinGraphBatchResult>(response);
        }

        /// <summary>
        /// Test TwingraphQuery
        /// </summary>
        [Fact]
        public void TwingraphQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //DatasetTwinGraphQuery datasetTwinGraphQuery = null;
            //var response = instance.TwingraphQuery(organizationId, datasetId, datasetTwinGraphQuery);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test UnlinkWorkspace
        /// </summary>
        [Fact]
        public void UnlinkWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //string workspaceId = null;
            //var response = instance.UnlinkWorkspace(organizationId, datasetId, workspaceId);
            //Assert.IsType<Dataset>(response);
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

        /// <summary>
        /// Test UpdateDatasetAccessControl
        /// </summary>
        [Fact]
        public void UpdateDatasetAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //string identityId = null;
            //DatasetRole datasetRole = null;
            //var response = instance.UpdateDatasetAccessControl(organizationId, datasetId, identityId, datasetRole);
            //Assert.IsType<DatasetAccessControl>(response);
        }

        /// <summary>
        /// Test UpdateTwingraphEntities
        /// </summary>
        [Fact]
        public void UpdateTwingraphEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //string type = null;
            //List<GraphProperties> graphProperties = null;
            //var response = instance.UpdateTwingraphEntities(organizationId, datasetId, type, graphProperties);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test UploadTwingraph
        /// </summary>
        [Fact]
        public void UploadTwingraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string datasetId = null;
            //System.IO.Stream body = null;
            //var response = instance.UploadTwingraph(organizationId, datasetId, body);
            //Assert.IsType<FileUploadValidation>(response);
        }
    }
}
