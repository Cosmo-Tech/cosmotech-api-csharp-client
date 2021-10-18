/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 0.1.0-SNAPSHOT
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
        /// Test AddOrReplaceUsersInOrganizationWorkspace
        /// </summary>
        [Fact]
        public void AddOrReplaceUsersInOrganizationWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //List<WorkspaceUser> workspaceUser = null;
            //var response = instance.AddOrReplaceUsersInOrganizationWorkspace(organizationId, workspaceId, workspaceUser);
            //Assert.IsType<List<WorkspaceUser>>(response);
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
            //var response = instance.FindAllWorkspaces(organizationId);
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
        /// Test RemoveAllUsersOfWorkspace
        /// </summary>
        [Fact]
        public void RemoveAllUsersOfWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //instance.RemoveAllUsersOfWorkspace(organizationId, workspaceId);
        }

        /// <summary>
        /// Test RemoveUserFromOrganizationWorkspace
        /// </summary>
        [Fact]
        public void RemoveUserFromOrganizationWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //string userId = null;
            //instance.RemoveUserFromOrganizationWorkspace(organizationId, workspaceId, userId);
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
