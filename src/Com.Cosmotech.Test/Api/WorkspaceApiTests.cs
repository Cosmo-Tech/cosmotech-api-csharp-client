/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.1-SNAPSHOT
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
    ///  Class for testing WorkspaceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorkspaceApiTests : IDisposable
    {
        private WorkspaceApi instance;

        public WorkspaceApiTests()
        {
            instance = new WorkspaceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WorkspaceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WorkspaceApi
            //Assert.IsType<WorkspaceApi>(instance);
        }

        /// <summary>
        /// Test AddWorkspaceAccessControl
        /// </summary>
        [Fact]
        public void AddWorkspaceAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //WorkspaceAccessControl workspaceAccessControl = null;
            //var response = instance.AddWorkspaceAccessControl(organizationId, workspaceId, workspaceAccessControl);
            //Assert.IsType<WorkspaceAccessControl>(response);
        }

        /// <summary>
        /// Test CreateSecret
        /// </summary>
        [Fact]
        public void CreateSecretTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //WorkspaceSecret workspaceSecret = null;
            //instance.CreateSecret(organizationId, workspaceId, workspaceSecret);
        }

        /// <summary>
        /// Test CreateWorkspace
        /// </summary>
        [Fact]
        public void CreateWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //Workspace workspace = null;
            //var response = instance.CreateWorkspace(organizationId, workspace);
            //Assert.IsType<Workspace>(response);
        }

        /// <summary>
        /// Test DeleteAllWorkspaceFiles
        /// </summary>
        [Fact]
        public void DeleteAllWorkspaceFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //instance.DeleteAllWorkspaceFiles(organizationId, workspaceId);
        }

        /// <summary>
        /// Test DeleteWorkspace
        /// </summary>
        [Fact]
        public void DeleteWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //var response = instance.DeleteWorkspace(organizationId, workspaceId);
            //Assert.IsType<Workspace>(response);
        }

        /// <summary>
        /// Test DeleteWorkspaceFile
        /// </summary>
        [Fact]
        public void DeleteWorkspaceFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string fileName = null;
            //instance.DeleteWorkspaceFile(organizationId, workspaceId, fileName);
        }

        /// <summary>
        /// Test DownloadWorkspaceFile
        /// </summary>
        [Fact]
        public void DownloadWorkspaceFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string fileName = null;
            //var response = instance.DownloadWorkspaceFile(organizationId, workspaceId, fileName);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test FindAllWorkspaceFiles
        /// </summary>
        [Fact]
        public void FindAllWorkspaceFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //var response = instance.FindAllWorkspaceFiles(organizationId, workspaceId);
            //Assert.IsType<List<WorkspaceFile>>(response);
        }

        /// <summary>
        /// Test FindAllWorkspaces
        /// </summary>
        [Fact]
        public void FindAllWorkspacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.FindAllWorkspaces(organizationId, page, size);
            //Assert.IsType<List<Workspace>>(response);
        }

        /// <summary>
        /// Test FindWorkspaceById
        /// </summary>
        [Fact]
        public void FindWorkspaceByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //var response = instance.FindWorkspaceById(organizationId, workspaceId);
            //Assert.IsType<Workspace>(response);
        }

        /// <summary>
        /// Test GetWorkspaceAccessControl
        /// </summary>
        [Fact]
        public void GetWorkspaceAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string identityId = null;
            //var response = instance.GetWorkspaceAccessControl(organizationId, workspaceId, identityId);
            //Assert.IsType<WorkspaceAccessControl>(response);
        }

        /// <summary>
        /// Test GetWorkspacePermissions
        /// </summary>
        [Fact]
        public void GetWorkspacePermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string role = null;
            //var response = instance.GetWorkspacePermissions(organizationId, workspaceId, role);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetWorkspaceSecurity
        /// </summary>
        [Fact]
        public void GetWorkspaceSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //var response = instance.GetWorkspaceSecurity(organizationId, workspaceId);
            //Assert.IsType<WorkspaceSecurity>(response);
        }

        /// <summary>
        /// Test GetWorkspaceSecurityUsers
        /// </summary>
        [Fact]
        public void GetWorkspaceSecurityUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //var response = instance.GetWorkspaceSecurityUsers(organizationId, workspaceId);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test LinkDataset
        /// </summary>
        [Fact]
        public void LinkDatasetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string datasetId = null;
            //var response = instance.LinkDataset(organizationId, workspaceId, datasetId);
            //Assert.IsType<Workspace>(response);
        }

        /// <summary>
        /// Test RemoveWorkspaceAccessControl
        /// </summary>
        [Fact]
        public void RemoveWorkspaceAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string identityId = null;
            //instance.RemoveWorkspaceAccessControl(organizationId, workspaceId, identityId);
        }

        /// <summary>
        /// Test SetWorkspaceDefaultSecurity
        /// </summary>
        [Fact]
        public void SetWorkspaceDefaultSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //WorkspaceRole workspaceRole = null;
            //var response = instance.SetWorkspaceDefaultSecurity(organizationId, workspaceId, workspaceRole);
            //Assert.IsType<WorkspaceSecurity>(response);
        }

        /// <summary>
        /// Test UnlinkDataset
        /// </summary>
        [Fact]
        public void UnlinkDatasetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string datasetId = null;
            //var response = instance.UnlinkDataset(organizationId, workspaceId, datasetId);
            //Assert.IsType<Workspace>(response);
        }

        /// <summary>
        /// Test UpdateWorkspace
        /// </summary>
        [Fact]
        public void UpdateWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //Workspace workspace = null;
            //var response = instance.UpdateWorkspace(organizationId, workspaceId, workspace);
            //Assert.IsType<Workspace>(response);
        }

        /// <summary>
        /// Test UpdateWorkspaceAccessControl
        /// </summary>
        [Fact]
        public void UpdateWorkspaceAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string identityId = null;
            //WorkspaceRole workspaceRole = null;
            //var response = instance.UpdateWorkspaceAccessControl(organizationId, workspaceId, identityId, workspaceRole);
            //Assert.IsType<WorkspaceAccessControl>(response);
        }

        /// <summary>
        /// Test UploadWorkspaceFile
        /// </summary>
        [Fact]
        public void UploadWorkspaceFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //System.IO.Stream file = null;
            //bool? overwrite = null;
            //string destination = null;
            //var response = instance.UploadWorkspaceFile(organizationId, workspaceId, file, overwrite, destination);
            //Assert.IsType<WorkspaceFile>(response);
        }
    }
}
