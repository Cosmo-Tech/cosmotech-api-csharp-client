/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.0.1-dev
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
    ///  Class for testing ValidatorApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ValidatorApiTests : IDisposable
    {
        private ValidatorApi instance;

        public ValidatorApiTests()
        {
            instance = new ValidatorApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ValidatorApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ValidatorApi
            //Assert.IsType<ValidatorApi>(instance);
        }

        /// <summary>
        /// Test CreateValidator
        /// </summary>
        [Fact]
        public void CreateValidatorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //Validator validator = null;
            //var response = instance.CreateValidator(organizationId, validator);
            //Assert.IsType<Validator>(response);
        }

        /// <summary>
        /// Test CreateValidatorRun
        /// </summary>
        [Fact]
        public void CreateValidatorRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string validatorId = null;
            //ValidatorRun validatorRun = null;
            //var response = instance.CreateValidatorRun(organizationId, validatorId, validatorRun);
            //Assert.IsType<ValidatorRun>(response);
        }

        /// <summary>
        /// Test DeleteValidator
        /// </summary>
        [Fact]
        public void DeleteValidatorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string validatorId = null;
            //instance.DeleteValidator(organizationId, validatorId);
        }

        /// <summary>
        /// Test DeleteValidatorRun
        /// </summary>
        [Fact]
        public void DeleteValidatorRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string validatorId = null;
            //string validatorrunId = null;
            //instance.DeleteValidatorRun(organizationId, validatorId, validatorrunId);
        }

        /// <summary>
        /// Test FindAllValidatorRuns
        /// </summary>
        [Fact]
        public void FindAllValidatorRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string validatorId = null;
            //var response = instance.FindAllValidatorRuns(organizationId, validatorId);
            //Assert.IsType<List<ValidatorRun>>(response);
        }

        /// <summary>
        /// Test FindAllValidators
        /// </summary>
        [Fact]
        public void FindAllValidatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.FindAllValidators(organizationId);
            //Assert.IsType<List<Validator>>(response);
        }

        /// <summary>
        /// Test FindValidatorById
        /// </summary>
        [Fact]
        public void FindValidatorByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string validatorId = null;
            //var response = instance.FindValidatorById(organizationId, validatorId);
            //Assert.IsType<Validator>(response);
        }

        /// <summary>
        /// Test FindValidatorRunById
        /// </summary>
        [Fact]
        public void FindValidatorRunByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string validatorId = null;
            //string validatorrunId = null;
            //var response = instance.FindValidatorRunById(organizationId, validatorId, validatorrunId);
            //Assert.IsType<ValidatorRun>(response);
        }

        /// <summary>
        /// Test RunValidator
        /// </summary>
        [Fact]
        public void RunValidatorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string validatorId = null;
            //ValidatorRun validatorRun = null;
            //var response = instance.RunValidator(organizationId, validatorId, validatorRun);
            //Assert.IsType<ValidatorRun>(response);
        }
    }
}
