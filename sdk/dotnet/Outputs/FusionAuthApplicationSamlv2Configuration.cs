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
    public sealed class FusionAuthApplicationSamlv2Configuration
    {
        /// <summary>
        /// The audience for the SAML response sent to back to the service provider from FusionAuth. Some service providers require different audience values than the issuer and this configuration option lets you change the audience in the response.
        /// </summary>
        public readonly string? Audience;
        /// <summary>
        /// An array of URLs that are the authorized redirect URLs for FusionAuth OAuth.
        /// </summary>
        public readonly ImmutableArray<string> AuthorizedRedirectUrls;
        /// <summary>
        /// The URL of the callback (sometimes called the Assertion Consumer Service or ACS). This is where FusionAuth sends the browser after the user logs in via SAML.
        /// </summary>
        public readonly string? CallbackUrl;
        /// <summary>
        /// Whether or not FusionAuth will log SAML debug messages to the event log. This is useful for debugging purposes.
        /// </summary>
        public readonly bool? Debug;
        /// <summary>
        /// The unique Id of the Key used to verify the signature if the public key cannot be determined by the KeyInfo element when using POST bindings, or the key used to verify the signature when using HTTP Redirect bindings.
        /// </summary>
        public readonly string? DefaultVerificationKeyId;
        /// <summary>
        /// Whether or not SAML Single Logout for this SAML IdP is enabled.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// The issuer that identifies the service provider and allows FusionAuth to load the correct Application and SAML configuration. If you don’t know the issuer, you can often times put in anything here and FusionAuth will display an error message with the issuer from the service provider when you test the SAML login.
        /// </summary>
        public readonly string Issuer;
        /// <summary>
        /// The unique Id of the Key used to sign the SAML Single Logout response.
        /// </summary>
        public readonly string? KeyId;
        public readonly Outputs.FusionAuthApplicationSamlv2ConfigurationLogout? Logout;
        /// <summary>
        /// The URL that the browser is taken to after the user logs out of the SAML service provider. Often service providers need this URL in order to correctly hook up single-logout. Note that FusionAuth does not support the SAML single-logout profile because most service providers to not support it properly.
        /// </summary>
        public readonly string? LogoutUrl;
        /// <summary>
        /// If set to true, will force verification through the key store.
        /// </summary>
        public readonly bool? RequiredSignedRequests;
        /// <summary>
        /// The XML signature canonicalization method used when digesting and signing the SAML response. Unfortunately, many service providers do not correctly implement the XML signature specifications and force a specific canonicalization method. This setting allows you to change the canonicalization method to match the service provider. Often, service providers don’t even document their required method. You might need to contact enterprise support at the service provider to figure out what method they use.
        /// </summary>
        public readonly string? XmlSignatureCanonicalizationMethod;
        /// <summary>
        /// The location to place the XML signature when signing a successful SAML response.
        /// </summary>
        public readonly string? XmlSignatureLocation;

        [OutputConstructor]
        private FusionAuthApplicationSamlv2Configuration(
            string? audience,

            ImmutableArray<string> authorizedRedirectUrls,

            string? callbackUrl,

            bool? debug,

            string? defaultVerificationKeyId,

            bool? enabled,

            string issuer,

            string? keyId,

            Outputs.FusionAuthApplicationSamlv2ConfigurationLogout? logout,

            string? logoutUrl,

            bool? requiredSignedRequests,

            string? xmlSignatureCanonicalizationMethod,

            string? xmlSignatureLocation)
        {
            Audience = audience;
            AuthorizedRedirectUrls = authorizedRedirectUrls;
            CallbackUrl = callbackUrl;
            Debug = debug;
            DefaultVerificationKeyId = defaultVerificationKeyId;
            Enabled = enabled;
            Issuer = issuer;
            KeyId = keyId;
            Logout = logout;
            LogoutUrl = logoutUrl;
            RequiredSignedRequests = requiredSignedRequests;
            XmlSignatureCanonicalizationMethod = xmlSignatureCanonicalizationMethod;
            XmlSignatureLocation = xmlSignatureLocation;
        }
    }
}