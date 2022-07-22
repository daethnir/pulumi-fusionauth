// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace theogravity.Fusionauth.Inputs
{

    public sealed class FusionAuthApplicationLoginConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates if a JWT may be refreshed using a Refresh Token for this application. This configuration is separate from issuing new Refresh Tokens which is controlled by the generateRefreshTokens parameter. This configuration indicates specifically if an existing Refresh Token may be used to request a new JWT using the Refresh API.
        /// </summary>
        [Input("allowTokenRefresh")]
        public Input<bool>? AllowTokenRefresh { get; set; }

        /// <summary>
        /// Determines if the OAuth 2.0 Token endpoint will generate a refresh token when the offline_access scope is requested.
        /// </summary>
        [Input("generateRefreshTokens")]
        public Input<bool>? GenerateRefreshTokens { get; set; }

        /// <summary>
        /// Indicates if the Login API should require an API key. If you set this value to false and your FusionAuth API is on a public network, anyone may attempt to use the Login API.
        /// </summary>
        [Input("requireAuthentication")]
        public Input<bool>? RequireAuthentication { get; set; }

        public FusionAuthApplicationLoginConfigurationGetArgs()
        {
        }
    }
}