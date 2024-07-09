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

    public sealed class FusionAuthTenantExternalIdentifierConfigurationDeviceUserCodeIdGeneratorGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The length of the secure generator used for generating the change password Id.
        /// </summary>
        [Input("length", required: true)]
        public Input<int> Length { get; set; } = null!;

        /// <summary>
        /// The type of the secure generator used for generating the change password Id.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public FusionAuthTenantExternalIdentifierConfigurationDeviceUserCodeIdGeneratorGetArgs()
        {
        }
        public static new FusionAuthTenantExternalIdentifierConfigurationDeviceUserCodeIdGeneratorGetArgs Empty => new FusionAuthTenantExternalIdentifierConfigurationDeviceUserCodeIdGeneratorGetArgs();
    }
}
