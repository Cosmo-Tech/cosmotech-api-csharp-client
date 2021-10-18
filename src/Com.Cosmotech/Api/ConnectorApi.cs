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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Com.Cosmotech.Client;
using Com.Cosmotech.Model;

namespace Com.Cosmotech.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectorApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List all Connectors
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Connector&gt;</returns>
        List<Connector> FindAllConnectors();

        /// <summary>
        /// List all Connectors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Connector&gt;</returns>
        ApiResponse<List<Connector>> FindAllConnectorsWithHttpInfo();
        /// <summary>
        /// Get the details of a connector
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <returns>Connector</returns>
        Connector FindConnectorById(string connectorId);

        /// <summary>
        /// Get the details of a connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <returns>ApiResponse of Connector</returns>
        ApiResponse<Connector> FindConnectorByIdWithHttpInfo(string connectorId);
        /// <summary>
        /// Register a new connector
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">the Connector to register</param>
        /// <returns>Connector</returns>
        Connector RegisterConnector(Connector connector);

        /// <summary>
        /// Register a new connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">the Connector to register</param>
        /// <returns>ApiResponse of Connector</returns>
        ApiResponse<Connector> RegisterConnectorWithHttpInfo(Connector connector);
        /// <summary>
        /// Unregister a connector
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <returns></returns>
        void UnregisterConnector(string connectorId);

        /// <summary>
        /// Unregister a connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UnregisterConnectorWithHttpInfo(string connectorId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectorApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List all Connectors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Connector&gt;</returns>
        System.Threading.Tasks.Task<List<Connector>> FindAllConnectorsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all Connectors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Connector&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Connector>>> FindAllConnectorsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get the details of a connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connector</returns>
        System.Threading.Tasks.Task<Connector> FindConnectorByIdAsync(string connectorId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the details of a connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connector)</returns>
        System.Threading.Tasks.Task<ApiResponse<Connector>> FindConnectorByIdWithHttpInfoAsync(string connectorId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Register a new connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">the Connector to register</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connector</returns>
        System.Threading.Tasks.Task<Connector> RegisterConnectorAsync(Connector connector, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Register a new connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">the Connector to register</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connector)</returns>
        System.Threading.Tasks.Task<ApiResponse<Connector>> RegisterConnectorWithHttpInfoAsync(Connector connector, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Unregister a connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UnregisterConnectorAsync(string connectorId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Unregister a connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UnregisterConnectorWithHttpInfoAsync(string connectorId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectorApi : IConnectorApiSync, IConnectorApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConnectorApi : IConnectorApi
    {
        private Com.Cosmotech.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectorApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectorApi(string basePath)
        {
            this.Configuration = Com.Cosmotech.Client.Configuration.MergeConfigurations(
                Com.Cosmotech.Client.GlobalConfiguration.Instance,
                new Com.Cosmotech.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Com.Cosmotech.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Cosmotech.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Com.Cosmotech.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConnectorApi(Com.Cosmotech.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Com.Cosmotech.Client.Configuration.MergeConfigurations(
                Com.Cosmotech.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Com.Cosmotech.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Cosmotech.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Com.Cosmotech.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ConnectorApi(Com.Cosmotech.Client.ISynchronousClient client, Com.Cosmotech.Client.IAsynchronousClient asyncClient, Com.Cosmotech.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Com.Cosmotech.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Com.Cosmotech.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Com.Cosmotech.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Com.Cosmotech.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Com.Cosmotech.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// List all Connectors 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Connector&gt;</returns>
        public List<Connector> FindAllConnectors()
        {
            Com.Cosmotech.Client.ApiResponse<List<Connector>> localVarResponse = FindAllConnectorsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all Connectors 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Connector&gt;</returns>
        public Com.Cosmotech.Client.ApiResponse<List<Connector>> FindAllConnectorsWithHttpInfo()
        {
            Com.Cosmotech.Client.RequestOptions localVarRequestOptions = new Com.Cosmotech.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Cosmotech.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Connector>>("/connectors", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FindAllConnectors", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all Connectors 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Connector&gt;</returns>
        public async System.Threading.Tasks.Task<List<Connector>> FindAllConnectorsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Cosmotech.Client.ApiResponse<List<Connector>> localVarResponse = await FindAllConnectorsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all Connectors 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Connector&gt;)</returns>
        public async System.Threading.Tasks.Task<Com.Cosmotech.Client.ApiResponse<List<Connector>>> FindAllConnectorsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Com.Cosmotech.Client.RequestOptions localVarRequestOptions = new Com.Cosmotech.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Com.Cosmotech.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Connector>>("/connectors", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FindAllConnectors", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the details of a connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <returns>Connector</returns>
        public Connector FindConnectorById(string connectorId)
        {
            Com.Cosmotech.Client.ApiResponse<Connector> localVarResponse = FindConnectorByIdWithHttpInfo(connectorId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the details of a connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <returns>ApiResponse of Connector</returns>
        public Com.Cosmotech.Client.ApiResponse<Connector> FindConnectorByIdWithHttpInfo(string connectorId)
        {
            // verify the required parameter 'connectorId' is set
            if (connectorId == null)
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'connectorId' when calling ConnectorApi->FindConnectorById");

            Com.Cosmotech.Client.RequestOptions localVarRequestOptions = new Com.Cosmotech.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Cosmotech.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("connector_id", Com.Cosmotech.Client.ClientUtils.ParameterToString(connectorId)); // path parameter

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Connector>("/connectors/{connector_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FindConnectorById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the details of a connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connector</returns>
        public async System.Threading.Tasks.Task<Connector> FindConnectorByIdAsync(string connectorId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Cosmotech.Client.ApiResponse<Connector> localVarResponse = await FindConnectorByIdWithHttpInfoAsync(connectorId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the details of a connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connector)</returns>
        public async System.Threading.Tasks.Task<Com.Cosmotech.Client.ApiResponse<Connector>> FindConnectorByIdWithHttpInfoAsync(string connectorId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'connectorId' is set
            if (connectorId == null)
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'connectorId' when calling ConnectorApi->FindConnectorById");


            Com.Cosmotech.Client.RequestOptions localVarRequestOptions = new Com.Cosmotech.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Com.Cosmotech.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("connector_id", Com.Cosmotech.Client.ClientUtils.ParameterToString(connectorId)); // path parameter

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Connector>("/connectors/{connector_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FindConnectorById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Register a new connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">the Connector to register</param>
        /// <returns>Connector</returns>
        public Connector RegisterConnector(Connector connector)
        {
            Com.Cosmotech.Client.ApiResponse<Connector> localVarResponse = RegisterConnectorWithHttpInfo(connector);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Register a new connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">the Connector to register</param>
        /// <returns>ApiResponse of Connector</returns>
        public Com.Cosmotech.Client.ApiResponse<Connector> RegisterConnectorWithHttpInfo(Connector connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'connector' when calling ConnectorApi->RegisterConnector");

            Com.Cosmotech.Client.RequestOptions localVarRequestOptions = new Com.Cosmotech.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "application/yaml"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Cosmotech.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = connector;

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Connector>("/connectors", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RegisterConnector", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Register a new connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">the Connector to register</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connector</returns>
        public async System.Threading.Tasks.Task<Connector> RegisterConnectorAsync(Connector connector, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Cosmotech.Client.ApiResponse<Connector> localVarResponse = await RegisterConnectorWithHttpInfoAsync(connector, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Register a new connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">the Connector to register</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connector)</returns>
        public async System.Threading.Tasks.Task<Com.Cosmotech.Client.ApiResponse<Connector>> RegisterConnectorWithHttpInfoAsync(Connector connector, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'connector' when calling ConnectorApi->RegisterConnector");


            Com.Cosmotech.Client.RequestOptions localVarRequestOptions = new Com.Cosmotech.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "application/yaml"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Com.Cosmotech.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = connector;

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Connector>("/connectors", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RegisterConnector", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unregister a connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <returns></returns>
        public void UnregisterConnector(string connectorId)
        {
            UnregisterConnectorWithHttpInfo(connectorId);
        }

        /// <summary>
        /// Unregister a connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Com.Cosmotech.Client.ApiResponse<Object> UnregisterConnectorWithHttpInfo(string connectorId)
        {
            // verify the required parameter 'connectorId' is set
            if (connectorId == null)
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'connectorId' when calling ConnectorApi->UnregisterConnector");

            Com.Cosmotech.Client.RequestOptions localVarRequestOptions = new Com.Cosmotech.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Com.Cosmotech.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("connector_id", Com.Cosmotech.Client.ClientUtils.ParameterToString(connectorId)); // path parameter

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/connectors/{connector_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UnregisterConnector", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unregister a connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UnregisterConnectorAsync(string connectorId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await UnregisterConnectorWithHttpInfoAsync(connectorId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Unregister a connector 
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorId">the Connector identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Com.Cosmotech.Client.ApiResponse<Object>> UnregisterConnectorWithHttpInfoAsync(string connectorId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'connectorId' is set
            if (connectorId == null)
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'connectorId' when calling ConnectorApi->UnregisterConnector");


            Com.Cosmotech.Client.RequestOptions localVarRequestOptions = new Com.Cosmotech.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Com.Cosmotech.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("connector_id", Com.Cosmotech.Client.ClientUtils.ParameterToString(connectorId)); // path parameter

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/connectors/{connector_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UnregisterConnector", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
