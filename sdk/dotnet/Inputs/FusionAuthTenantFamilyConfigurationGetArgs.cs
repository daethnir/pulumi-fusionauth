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

    public sealed class FusionAuthTenantFamilyConfigurationGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to allow child registrations.
        /// </summary>
        [Input("allowChildRegistrations")]
        public Input<bool>? AllowChildRegistrations { get; set; }

        /// <summary>
        /// The unique Id of the email template to use when confirming a child.
        /// </summary>
        [Input("confirmChildEmailTemplateId")]
        public Input<string>? ConfirmChildEmailTemplateId { get; set; }

        /// <summary>
        /// Indicates that child users without parental verification will be permanently deleted after tenant.familyConfiguration.deleteOrphanedAccountsDays days.
        /// </summary>
        [Input("deleteOrphanedAccounts")]
        public Input<bool>? DeleteOrphanedAccounts { get; set; }

        /// <summary>
        /// The number of days from creation child users will be retained before being deleted for not completing parental verification. Value must be greater than 0.
        /// </summary>
        [Input("deleteOrphanedAccountsDays")]
        public Input<int>? DeleteOrphanedAccountsDays { get; set; }

        /// <summary>
        /// Whether family configuration is enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The unique Id of the email template to use when a family request is made.
        /// </summary>
        [Input("familyRequestEmailTemplateId")]
        public Input<string>? FamilyRequestEmailTemplateId { get; set; }

        /// <summary>
        /// The maximum age of a child. Value must be greater than 0.
        /// </summary>
        [Input("maximumChildAge")]
        public Input<int>? MaximumChildAge { get; set; }

        /// <summary>
        /// The minimum age to be an owner. Value must be greater than 0.
        /// </summary>
        [Input("minimumOwnerAge")]
        public Input<int>? MinimumOwnerAge { get; set; }

        /// <summary>
        /// Whether a parent email is required.
        /// </summary>
        [Input("parentEmailRequired")]
        public Input<bool>? ParentEmailRequired { get; set; }

        /// <summary>
        /// The unique Id of the email template to use for parent registration.
        /// </summary>
        [Input("parentRegistrationEmailTemplateId")]
        public Input<string>? ParentRegistrationEmailTemplateId { get; set; }

        public FusionAuthTenantFamilyConfigurationGetArgs()
        {
        }
        public static new FusionAuthTenantFamilyConfigurationGetArgs Empty => new FusionAuthTenantFamilyConfigurationGetArgs();
    }
}
