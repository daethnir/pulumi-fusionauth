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

    public sealed class FusionAuthIdpSamlV2IdpInitiatedTenantConfigurationGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// When enabled, the number of identity provider links a user may create is enforced by maximumLinks
        /// </summary>
        [Input("limitUserLinkCountEnabled")]
        public Input<bool>? LimitUserLinkCountEnabled { get; set; }

        /// <summary>
        /// Determines if this provider is enabled. If it is false then it will be disabled globally.
        /// </summary>
        [Input("limitUserLinkCountMaximumLinks")]
        public Input<int>? LimitUserLinkCountMaximumLinks { get; set; }

        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        public FusionAuthIdpSamlV2IdpInitiatedTenantConfigurationGetArgs()
        {
        }
        public static new FusionAuthIdpSamlV2IdpInitiatedTenantConfigurationGetArgs Empty => new FusionAuthIdpSamlV2IdpInitiatedTenantConfigurationGetArgs();
    }
}
