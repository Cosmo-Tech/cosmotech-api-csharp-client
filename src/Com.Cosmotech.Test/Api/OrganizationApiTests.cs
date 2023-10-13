/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.0.7-dev
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
        /// Test AddOrganizationAccessControl
        /// </summary>
        [Fact]
        public void AddOrganizationAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //OrganizationAccessControl organizationAccessControl = null;
            //var response = instance.AddOrganizationAccessControl(organizationId, organizationAccessControl);
            //Assert.IsType<OrganizationAccessControl>(response);
        }

        /// <summary>
        /// Test FindAllOrganizations
        /// </summary>
        [Fact]
        public void FindAllOrganizationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //var response = instance.FindAllOrganizations(page, size);
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
        /// Test GetAllPermissions
        /// </summary>
        [Fact]
        public void GetAllPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllPermissions();
            //Assert.IsType<List<ComponentRolePermissions>>(response);
        }

        /// <summary>
        /// Test GetOrganizationAccessControl
        /// </summary>
        [Fact]
        public void GetOrganizationAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string identityId = null;
            //var response = instance.GetOrganizationAccessControl(organizationId, identityId);
            //Assert.IsType<OrganizationAccessControl>(response);
        }

        /// <summary>
        /// Test GetOrganizationPermissions
        /// </summary>
        [Fact]
        public void GetOrganizationPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string role = null;
            //var response = instance.GetOrganizationPermissions(organizationId, role);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetOrganizationSecurity
        /// </summary>
        [Fact]
        public void GetOrganizationSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.GetOrganizationSecurity(organizationId);
            //Assert.IsType<OrganizationSecurity>(response);
        }

        /// <summary>
        /// Test GetOrganizationSecurityUsers
        /// </summary>
        [Fact]
        public void GetOrganizationSecurityUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.GetOrganizationSecurityUsers(organizationId);
            //Assert.IsType<List<string>>(response);
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
        /// Test RemoveOrganizationAccessControl
        /// </summary>
        [Fact]
        public void RemoveOrganizationAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string identityId = null;
            //instance.RemoveOrganizationAccessControl(organizationId, identityId);
        }

        /// <summary>
        /// Test SetOrganizationDefaultSecurity
        /// </summary>
        [Fact]
        public void SetOrganizationDefaultSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //OrganizationRole organizationRole = null;
            //var response = instance.SetOrganizationDefaultSecurity(organizationId, organizationRole);
            //Assert.IsType<OrganizationSecurity>(response);
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
        /// Test UpdateOrganizationAccessControl
        /// </summary>
        [Fact]
        public void UpdateOrganizationAccessControlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string identityId = null;
            //OrganizationRole organizationRole = null;
            //var response = instance.UpdateOrganizationAccessControl(organizationId, identityId, organizationRole);
            //Assert.IsType<OrganizationAccessControl>(response);
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
