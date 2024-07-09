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
    public sealed class FusionAuthTenantExternalIdentifierConfigurationSetupPasswordIdGenerator
    {
        /// <summary>
        /// The length of the secure generator used for generating the change password Id.
        /// </summary>
        public readonly int Length;
        /// <summary>
        /// The type of the secure generator used for generating the change password Id.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private FusionAuthTenantExternalIdentifierConfigurationSetupPasswordIdGenerator(
            int length,

            string type)
        {
            Length = length;
            Type = type;
        }
    }
}
