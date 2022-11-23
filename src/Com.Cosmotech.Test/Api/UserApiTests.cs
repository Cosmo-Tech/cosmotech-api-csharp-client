/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.0.4-SNAPSHOT
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
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserApiTests : IDisposable
    {
        private UserApi instance;

        public UserApiTests()
        {
            instance = new UserApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserApi
            //Assert.IsType<UserApi>(instance);
        }

        /// <summary>
        /// Test AuthorizeUser
        /// </summary>
        [Fact]
        public void AuthorizeUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.AuthorizeUser();
        }

        /// <summary>
        /// Test FindAllUsers
        /// </summary>
        [Fact]
        public void FindAllUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.FindAllUsers();
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test FindUserById
        /// </summary>
        [Fact]
        public void FindUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.FindUserById(userId);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test GetCurrentUser
        /// </summary>
        [Fact]
        public void GetCurrentUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCurrentUser();
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test GetOrganizationCurrentUser
        /// </summary>
        [Fact]
        public void GetOrganizationCurrentUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.GetOrganizationCurrentUser(organizationId);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test GetWorkspaceCurrentUser
        /// </summary>
        [Fact]
        public void GetWorkspaceCurrentUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string workspaceId = null;
            //var response = instance.GetWorkspaceCurrentUser(organizationId, workspaceId);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test RegisterUser
        /// </summary>
        [Fact]
        public void RegisterUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //User user = null;
            //var response = instance.RegisterUser(user);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test TestPlatform
        /// </summary>
        [Fact]
        public void TestPlatformTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TestPlatform();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test UnregisterUser
        /// </summary>
        [Fact]
        public void UnregisterUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //instance.UnregisterUser(userId);
        }

        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Fact]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //User user = null;
            //var response = instance.UpdateUser(userId, user);
            //Assert.IsType<User>(response);
        }
    }
}
