// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace theogravity.Fusionauth.Outputs
{

    [OutputType]
    public sealed class FusionAuthIdpSamlv2ApplicationConfiguration
    {
        /// <summary>
        /// ID of the Application to apply this configuration to.
        /// </summary>
        public readonly string? ApplicationId;
        /// <summary>
        /// This is an optional Application specific override for the top level button image URL.
        /// </summary>
        public readonly string? ButtonImageUrl;
        /// <summary>
        /// This is an optional Application specific override for the top level button text.
        /// </summary>
        public readonly string? ButtonText;
        /// <summary>
        /// Determines if a UserRegistration is created for the User automatically or not. If a user doesn’t exist in FusionAuth and logs in through an identity provider, this boolean controls whether or not FusionAuth creates a registration for the User in the Application they are logging into.
        /// </summary>
        public readonly bool? CreateRegistration;
        /// <summary>
        /// Determines if this identity provider is enabled for the Application specified by the applicationId key.
        /// </summary>
        public readonly bool? Enabled;

        [OutputConstructor]
        private FusionAuthIdpSamlv2ApplicationConfiguration(
            string? applicationId,

            string? buttonImageUrl,

            string? buttonText,

            bool? createRegistration,

            bool? enabled)
        {
            ApplicationId = applicationId;
            ButtonImageUrl = buttonImageUrl;
            ButtonText = buttonText;
            CreateRegistration = createRegistration;
            Enabled = enabled;
        }
    }
}
