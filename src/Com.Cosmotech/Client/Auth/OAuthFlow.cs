/*
 * Cosmo Tech Platform API
 *
 * Cosmo Tech Platform API
 *
 * The version of the OpenAPI document: 4.0.3-SNAPSHOT
 * Contact: platform@cosmotech.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


namespace Com.Cosmotech.Client.Auth
{
    /// <summary>
    /// Available flows for OAuth2 authentication
    /// </summary>
    public enum OAuthFlow
    {
        /// <summary>Authorization code flow</summary>
        ACCESS_CODE,
        /// <summary>Implicit flow</summary>
        IMPLICIT,
        /// <summary>Password flow</summary>
        PASSWORD,
        /// <summary>Client credentials flow</summary>
        APPLICATION
    }
}