/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.0.3-dev
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
    ///  Class for testing OrganizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrganizationApiTests : IDisposable
    {
        private OrganizationApi instance;

        public OrganizationApiTests()
        {
            instance = new OrganizationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrganizationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OrganizationApi
            //Assert.IsType<OrganizationApi>(instance);
        }

        /// <summary>
        /// Test AddOrReplaceUsersInOrganization
        /// </summary>
        [Fact]
        public void AddOrReplaceUsersInOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //List<OrganizationUser> organizationUser = null;
            //var response = instance.AddOrReplaceUsersInOrganization(organizationId, organizationUser);
            //Assert.IsType<List<OrganizationUser>>(response);
        }

        /// <summary>
        /// Test FindAllOrganizations
        /// </summary>
        [Fact]
        public void FindAllOrganizationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.FindAllOrganizations();
            //Assert.IsType<List<Organization>>(response);
        }

        /// <summary>
        /// Test FindOrganizationById
        /// </summary>
        [Fact]
        public void FindOrganizationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.FindOrganizationById(organizationId);
            //Assert.IsType<Organization>(response);
        }

        /// <summary>
        /// Test RegisterOrganization
        /// </summary>
        [Fact]
        public void RegisterOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Organization organization = null;
            //var response = instance.RegisterOrganization(organization);
            //Assert.IsType<Organization>(response);
        }

        /// <summary>
        /// Test RemoveAllUsersInOrganization
        /// </summary>
        [Fact]
        public void RemoveAllUsersInOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //instance.RemoveAllUsersInOrganization(organizationId);
        }

        /// <summary>
        /// Test RemoveUserFromOrganization
        /// </summary>
        [Fact]
        public void RemoveUserFromOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string userId = null;
            //instance.RemoveUserFromOrganization(organizationId, userId);
        }

        /// <summary>
        /// Test UnregisterOrganization
        /// </summary>
        [Fact]
        public void UnregisterOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //instance.UnregisterOrganization(organizationId);
        }

        /// <summary>
        /// Test UpdateOrganization
        /// </summary>
        [Fact]
        public void UpdateOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //Organization organization = null;
            //var response = instance.UpdateOrganization(organizationId, organization);
            //Assert.IsType<Organization>(response);
        }

        /// <summary>
        /// Test UpdateSolutionsContainerRegistryByOrganizationId
        /// </summary>
        [Fact]
        public void UpdateSolutionsContainerRegistryByOrganizationIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //OrganizationService organizationService = null;
            //var response = instance.UpdateSolutionsContainerRegistryByOrganizationId(organizationId, organizationService);
            //Assert.IsType<OrganizationService>(response);
        }

        /// <summary>
        /// Test UpdateStorageByOrganizationId
        /// </summary>
        [Fact]
        public void UpdateStorageByOrganizationIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //OrganizationService organizationService = null;
            //var response = instance.UpdateStorageByOrganizationId(organizationId, organizationService);
            //Assert.IsType<OrganizationService>(response);
        }

        /// <summary>
        /// Test UpdateTenantCredentialsByOrganizationId
        /// </summary>
        [Fact]
        public void UpdateTenantCredentialsByOrganizationIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //Dictionary<string, Object> requestBody = null;
            //var response = instance.UpdateTenantCredentialsByOrganizationId(organizationId, requestBody);
            //Assert.IsType<Dictionary<string, Object>>(response);
        }
    }
}
