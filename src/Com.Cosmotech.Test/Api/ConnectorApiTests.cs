/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 3.1.1
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
    ///  Class for testing ConnectorApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConnectorApiTests : IDisposable
    {
        private ConnectorApi instance;

        public ConnectorApiTests()
        {
            instance = new ConnectorApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConnectorApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConnectorApi
            //Assert.IsType<ConnectorApi>(instance);
        }

        /// <summary>
        /// Test FindAllConnectors
        /// </summary>
        [Fact]
        public void FindAllConnectorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //var response = instance.FindAllConnectors(page, size);
            //Assert.IsType<List<Connector>>(response);
        }

        /// <summary>
        /// Test FindConnectorById
        /// </summary>
        [Fact]
        public void FindConnectorByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string connectorId = null;
            //var response = instance.FindConnectorById(connectorId);
            //Assert.IsType<Connector>(response);
        }

        /// <summary>
        /// Test FindConnectorByName
        /// </summary>
        [Fact]
        public void FindConnectorByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string connectorName = null;
            //var response = instance.FindConnectorByName(connectorName);
            //Assert.IsType<Connector>(response);
        }

        /// <summary>
        /// Test RegisterConnector
        /// </summary>
        [Fact]
        public void RegisterConnectorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Connector connector = null;
            //var response = instance.RegisterConnector(connector);
            //Assert.IsType<Connector>(response);
        }

        /// <summary>
        /// Test UnregisterConnector
        /// </summary>
        [Fact]
        public void UnregisterConnectorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string connectorId = null;
            //instance.UnregisterConnector(connectorId);
        }
    }
}
