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

    public sealed class FusionAuthFormStepArgs : Pulumi.ResourceArgs
    {
        [Input("fields", required: true)]
        private InputList<string>? _fields;

        /// <summary>
        /// An ordered list of Form Field Ids assigned to this step.
        /// </summary>
        public InputList<string> Fields
        {
            get => _fields ?? (_fields = new InputList<string>());
            set => _fields = value;
        }

        public FusionAuthFormStepArgs()
        {
        }
    }
}