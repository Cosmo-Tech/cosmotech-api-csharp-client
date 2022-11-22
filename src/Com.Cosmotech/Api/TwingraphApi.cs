/*
 * Cosmo Tech Plaform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 2.1.0
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
    public interface ITwingraphApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Launch a mass delete job
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="graphId">the Graph Identifier</param>
        /// <returns></returns>
        void Delete(string organizationId, string graphId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Launch a mass delete job
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="graphId">the Graph Identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo(string organizationId, string graphId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Import a new version of a twin graph
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphImport">the graph to import</param>
        /// <returns>TwinGraphImportInfo</returns>
        TwinGraphImportInfo ImportGraph(string organizationId, TwinGraphImport twinGraphImport);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Import a new version of a twin graph
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphImport">the graph to import</param>
        /// <returns>ApiResponse of TwinGraphImportInfo</returns>
        ApiResponse<TwinGraphImportInfo> ImportGraphWithHttpInfo(string organizationId, TwinGraphImport twinGraphImport);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Run a query on a graph instance
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphQuery">the query to run</param>
        /// <returns>string</returns>
        string Query(string organizationId, TwinGraphQuery twinGraphQuery);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Run a query on a graph instance
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphQuery">the query to run</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> QueryWithHttpInfo(string organizationId, TwinGraphQuery twinGraphQuery);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITwingraphApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Launch a mass delete job
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="graphId">the Graph Identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAsync(string organizationId, string graphId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Launch a mass delete job
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="graphId">the Graph Identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWithHttpInfoAsync(string organizationId, string graphId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Import a new version of a twin graph
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphImport">the graph to import</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TwinGraphImportInfo</returns>
        System.Threading.Tasks.Task<TwinGraphImportInfo> ImportGraphAsync(string organizationId, TwinGraphImport twinGraphImport, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Import a new version of a twin graph
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphImport">the graph to import</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TwinGraphImportInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<TwinGraphImportInfo>> ImportGraphWithHttpInfoAsync(string organizationId, TwinGraphImport twinGraphImport, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Run a query on a graph instance
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphQuery">the query to run</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> QueryAsync(string organizationId, TwinGraphQuery twinGraphQuery, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Run a query on a graph instance
        /// </remarks>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphQuery">the query to run</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> QueryWithHttpInfoAsync(string organizationId, TwinGraphQuery twinGraphQuery, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITwingraphApi : ITwingraphApiSync, ITwingraphApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TwingraphApi : ITwingraphApi
    {
        private Com.Cosmotech.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TwingraphApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TwingraphApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwingraphApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TwingraphApi(string basePath)
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
        /// Initializes a new instance of the <see cref="TwingraphApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TwingraphApi(Com.Cosmotech.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TwingraphApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TwingraphApi(Com.Cosmotech.Client.ISynchronousClient client, Com.Cosmotech.Client.IAsynchronousClient asyncClient, Com.Cosmotech.Client.IReadableConfiguration configuration)
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
        ///  Launch a mass delete job
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="graphId">the Graph Identifier</param>
        /// <returns></returns>
        public void Delete(string organizationId, string graphId)
        {
            DeleteWithHttpInfo(organizationId, graphId);
        }

        /// <summary>
        ///  Launch a mass delete job
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="graphId">the Graph Identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Com.Cosmotech.Client.ApiResponse<Object> DeleteWithHttpInfo(string organizationId, string graphId)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'organizationId' when calling TwingraphApi->Delete");
            }

            // verify the required parameter 'graphId' is set
            if (graphId == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'graphId' when calling TwingraphApi->Delete");
            }

            Com.Cosmotech.Client.RequestOptions localVarRequestOptions = new Com.Cosmotech.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Com.Cosmotech.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("organization_id", Com.Cosmotech.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("graphId", Com.Cosmotech.Client.ClientUtils.ParameterToString(graphId)); // path parameter

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/organizations/{organization_id}/delete/{graphId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Launch a mass delete job
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="graphId">the Graph Identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAsync(string organizationId, string graphId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteWithHttpInfoAsync(organizationId, graphId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  Launch a mass delete job
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="graphId">the Graph Identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Com.Cosmotech.Client.ApiResponse<Object>> DeleteWithHttpInfoAsync(string organizationId, string graphId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'organizationId' when calling TwingraphApi->Delete");
            }

            // verify the required parameter 'graphId' is set
            if (graphId == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'graphId' when calling TwingraphApi->Delete");
            }


            Com.Cosmotech.Client.RequestOptions localVarRequestOptions = new Com.Cosmotech.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Com.Cosmotech.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("organization_id", Com.Cosmotech.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("graphId", Com.Cosmotech.Client.ClientUtils.ParameterToString(graphId)); // path parameter

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/organizations/{organization_id}/delete/{graphId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Import a new version of a twin graph
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphImport">the graph to import</param>
        /// <returns>TwinGraphImportInfo</returns>
        public TwinGraphImportInfo ImportGraph(string organizationId, TwinGraphImport twinGraphImport)
        {
            Com.Cosmotech.Client.ApiResponse<TwinGraphImportInfo> localVarResponse = ImportGraphWithHttpInfo(organizationId, twinGraphImport);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Import a new version of a twin graph
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphImport">the graph to import</param>
        /// <returns>ApiResponse of TwinGraphImportInfo</returns>
        public Com.Cosmotech.Client.ApiResponse<TwinGraphImportInfo> ImportGraphWithHttpInfo(string organizationId, TwinGraphImport twinGraphImport)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'organizationId' when calling TwingraphApi->ImportGraph");
            }

            // verify the required parameter 'twinGraphImport' is set
            if (twinGraphImport == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'twinGraphImport' when calling TwingraphApi->ImportGraph");
            }

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
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("organization_id", Com.Cosmotech.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
            localVarRequestOptions.Data = twinGraphImport;

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<TwinGraphImportInfo>("/organizations/{organization_id}/import", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ImportGraph", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Import a new version of a twin graph
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphImport">the graph to import</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TwinGraphImportInfo</returns>
        public async System.Threading.Tasks.Task<TwinGraphImportInfo> ImportGraphAsync(string organizationId, TwinGraphImport twinGraphImport, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Cosmotech.Client.ApiResponse<TwinGraphImportInfo> localVarResponse = await ImportGraphWithHttpInfoAsync(organizationId, twinGraphImport, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Import a new version of a twin graph
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphImport">the graph to import</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TwinGraphImportInfo)</returns>
        public async System.Threading.Tasks.Task<Com.Cosmotech.Client.ApiResponse<TwinGraphImportInfo>> ImportGraphWithHttpInfoAsync(string organizationId, TwinGraphImport twinGraphImport, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'organizationId' when calling TwingraphApi->ImportGraph");
            }

            // verify the required parameter 'twinGraphImport' is set
            if (twinGraphImport == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'twinGraphImport' when calling TwingraphApi->ImportGraph");
            }


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
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("organization_id", Com.Cosmotech.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
            localVarRequestOptions.Data = twinGraphImport;

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<TwinGraphImportInfo>("/organizations/{organization_id}/import", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ImportGraph", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Run a query on a graph instance
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphQuery">the query to run</param>
        /// <returns>string</returns>
        public string Query(string organizationId, TwinGraphQuery twinGraphQuery)
        {
            Com.Cosmotech.Client.ApiResponse<string> localVarResponse = QueryWithHttpInfo(organizationId, twinGraphQuery);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Run a query on a graph instance
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphQuery">the query to run</param>
        /// <returns>ApiResponse of string</returns>
        public Com.Cosmotech.Client.ApiResponse<string> QueryWithHttpInfo(string organizationId, TwinGraphQuery twinGraphQuery)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'organizationId' when calling TwingraphApi->Query");
            }

            // verify the required parameter 'twinGraphQuery' is set
            if (twinGraphQuery == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'twinGraphQuery' when calling TwingraphApi->Query");
            }

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
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("organization_id", Com.Cosmotech.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
            localVarRequestOptions.Data = twinGraphQuery;

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<string>("/organizations/{organization_id}/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Run a query on a graph instance
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphQuery">the query to run</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> QueryAsync(string organizationId, TwinGraphQuery twinGraphQuery, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Cosmotech.Client.ApiResponse<string> localVarResponse = await QueryWithHttpInfoAsync(organizationId, twinGraphQuery, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Run a query on a graph instance
        /// </summary>
        /// <exception cref="Com.Cosmotech.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">the Organization identifier</param>
        /// <param name="twinGraphQuery">the query to run</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Com.Cosmotech.Client.ApiResponse<string>> QueryWithHttpInfoAsync(string organizationId, TwinGraphQuery twinGraphQuery, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'organizationId' when calling TwingraphApi->Query");
            }

            // verify the required parameter 'twinGraphQuery' is set
            if (twinGraphQuery == null)
            {
                throw new Com.Cosmotech.Client.ApiException(400, "Missing required parameter 'twinGraphQuery' when calling TwingraphApi->Query");
            }


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
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Cosmotech.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("organization_id", Com.Cosmotech.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
            localVarRequestOptions.Data = twinGraphQuery;

            // authentication (oAuth2AuthCode) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<string>("/organizations/{organization_id}/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
