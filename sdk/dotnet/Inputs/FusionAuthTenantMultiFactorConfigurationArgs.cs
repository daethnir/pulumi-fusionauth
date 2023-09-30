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

    public sealed class FusionAuthTenantMultiFactorConfigurationArgs : global::Pulumi.ResourceArgs
    {
        [Input("authenticator")]
        public Input<Inputs.FusionAuthTenantMultiFactorConfigurationAuthenticatorArgs>? Authenticator { get; set; }

        [Input("email")]
        public Input<Inputs.FusionAuthTenantMultiFactorConfigurationEmailArgs>? Email { get; set; }

        /// <summary>
        /// When set to `Enabled` and a user has one or more two-factor methods configured, the user will be required to complete a two-factor challenge during login. When set to `Disabled`, even when a user has configured one or more two-factor methods, the user will not be required to complete a two-factor challenge during login. When the login policy is to `Required`, a two-factor challenge will be required during login. If a user does not have configured two-factor methods, they will not be able to log in.
        /// </summary>
        [Input("loginPolicy")]
        public Input<string>? LoginPolicy { get; set; }

        [Input("sms")]
        public Input<Inputs.FusionAuthTenantMultiFactorConfigurationSmsArgs>? Sms { get; set; }

        public FusionAuthTenantMultiFactorConfigurationArgs()
        {
        }
        public static new FusionAuthTenantMultiFactorConfigurationArgs Empty => new FusionAuthTenantMultiFactorConfigurationArgs();
    }
}
