// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace theogravity.Fusionauth
{
    /// <summary>
    /// ## # Facebook Identity Provider Resource
    /// 
    /// The Facebook identity provider type will use the Facebook OAuth login API. It will provide a `Login with Facebook` button on FusionAuth’s login page that will leverage the Facebook login pop-up dialog. Additionally, this identity provider will call Facebook’s Graph API to load additional details about the user and store them in FusionAuth.
    /// 
    /// The email address returned by the Facebook Graph API will be used to create or lookup the existing user. Additional claims returned by Facebook can be used to reconcile the User to FusionAuth by using a Facebook Reconcile Lambda. Unless you assign a reconcile lambda to this provider, on the `email` address will be used from the available claims returned by Facebook.
    /// 
    /// When the `picture` field is not requested FusionAuth will also call Facebook’s `/me/picture` API to load the user’s profile image and store it as the `imageUrl` in FusionAuth. When the `picture` field is requested, the user’s profile image will be returned by the `/me` API and a second request to the `/me/picture` endpoint will not be required.
    /// 
    /// Finally, FusionAuth will call Facebook’s `/oauth/access_token` API to exchange the login token for a long-lived Facebook token. This token is stored in the `UserRegistration` object inside the `tokens` Map. This Map stores the tokens from the various identity providers so that you can use them in your application to call their APIs.
    /// 
    /// Please note if an `idp_hint` is appended to the OAuth Authorize endpoint, then the interaction behavior will be defaulted to `redirect`, even if popup interaction is explicitly configured.
    /// 
    /// [Facebook Identity Providers API](https://fusionauth.io/docs/v1/tech/apis/identity-providers/facebook)
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Fusionauth = theogravity.Fusionauth;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var facebook = new Fusionauth.FusionAuthIdpFacebook("facebook", new()
    ///     {
    ///         ApplicationConfigurations = new[]
    ///         {
    ///             new Fusionauth.Inputs.FusionAuthIdpFacebookApplicationConfigurationArgs
    ///             {
    ///                 ApplicationId = fusionauth_application.Myapp.Id,
    ///                 CreateRegistration = true,
    ///                 Enabled = true,
    ///             },
    ///         },
    ///         ButtonText = "Login with Facebook",
    ///         Debug = false,
    ///         Enabled = true,
    ///         AppId = "9876543210",
    ///         ClientSecret = "716a572f917640698cdb99e9d7e64115",
    ///         Fields = "email",
    ///         Permissions = "email",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [FusionauthResourceType("fusionauth:index/fusionAuthIdpFacebook:FusionAuthIdpFacebook")]
    public partial class FusionAuthIdpFacebook : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The top-level Facebook `appId` for your Application. This value is retrieved from the Facebook developer website when you setup your Facebook developer account.
        /// </summary>
        [Output("appId")]
        public Output<string> AppId { get; private set; } = null!;

        /// <summary>
        /// The configuration for each Application that the identity provider is enabled for.
        /// </summary>
        [Output("applicationConfigurations")]
        public Output<ImmutableArray<Outputs.FusionAuthIdpFacebookApplicationConfiguration>> ApplicationConfigurations { get; private set; } = null!;

        /// <summary>
        /// The top-level button text to use on the FusionAuth login page for this Identity Provider.
        /// </summary>
        [Output("buttonText")]
        public Output<string> ButtonText { get; private set; } = null!;

        /// <summary>
        /// The top-level client secret, also known as 'App Secret', to use with the Facebook Identity Provider when retrieving the long-lived token. This value is retrieved from the Facebook developer website when you setup your Facebook developer account.
        /// </summary>
        [Output("clientSecret")]
        public Output<string> ClientSecret { get; private set; } = null!;

        /// <summary>
        /// Determines if debug is enabled for this provider. When enabled, an Event Log is created each time this provider is invoked to reconcile a login.
        /// </summary>
        [Output("debug")]
        public Output<bool?> Debug { get; private set; } = null!;

        /// <summary>
        /// Determines if this provider is enabled. If it is false then it will be disabled globally.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// The top-level fields that you are requesting from Facebook.
        /// Field values are documented at [Facebook Graph API](https://developers.facebook.com/docs/graph-api/using-graph-api/)
        /// </summary>
        [Output("fields")]
        public Output<string?> Fields { get; private set; } = null!;

        /// <summary>
        /// The unique Id of the lambda to used during the user reconcile process to map custom claims from the external identity provider to the FusionAuth user.
        /// </summary>
        [Output("lambdaReconcileId")]
        public Output<string> LambdaReconcileId { get; private set; } = null!;

        /// <summary>
        /// The linking strategy to use when creating the link between the Facebook Identity Provider and the user.
        /// The valid values are:
        /// </summary>
        [Output("linkingStrategy")]
        public Output<string> LinkingStrategy { get; private set; } = null!;

        /// <summary>
        /// The login method to use for this Identity Provider.
        /// The valid values are:
        /// </summary>
        [Output("loginMethod")]
        public Output<string?> LoginMethod { get; private set; } = null!;

        /// <summary>
        /// The top-level permissions that your application is asking of the user’s Facebook account.
        /// Permission values are documented at [Facebook Login API](https://developers.facebook.com/docs/permissions/reference)
        /// </summary>
        [Output("permissions")]
        public Output<string?> Permissions { get; private set; } = null!;

        /// <summary>
        /// The configuration for each Tenant that limits the number of links a user may have for a particular identity provider.
        /// </summary>
        [Output("tenantConfigurations")]
        public Output<ImmutableArray<Outputs.FusionAuthIdpFacebookTenantConfiguration>> TenantConfigurations { get; private set; } = null!;


        /// <summary>
        /// Create a FusionAuthIdpFacebook resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FusionAuthIdpFacebook(string name, FusionAuthIdpFacebookArgs args, CustomResourceOptions? options = null)
            : base("fusionauth:index/fusionAuthIdpFacebook:FusionAuthIdpFacebook", name, args ?? new FusionAuthIdpFacebookArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FusionAuthIdpFacebook(string name, Input<string> id, FusionAuthIdpFacebookState? state = null, CustomResourceOptions? options = null)
            : base("fusionauth:index/fusionAuthIdpFacebook:FusionAuthIdpFacebook", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/theogravity/pulumi-fusionauth/releases/download/v${VERSION}",
                AdditionalSecretOutputs =
                {
                    "clientSecret",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing FusionAuthIdpFacebook resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FusionAuthIdpFacebook Get(string name, Input<string> id, FusionAuthIdpFacebookState? state = null, CustomResourceOptions? options = null)
        {
            return new FusionAuthIdpFacebook(name, id, state, options);
        }
    }

    public sealed class FusionAuthIdpFacebookArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The top-level Facebook `appId` for your Application. This value is retrieved from the Facebook developer website when you setup your Facebook developer account.
        /// </summary>
        [Input("appId", required: true)]
        public Input<string> AppId { get; set; } = null!;

        [Input("applicationConfigurations")]
        private InputList<Inputs.FusionAuthIdpFacebookApplicationConfigurationArgs>? _applicationConfigurations;

        /// <summary>
        /// The configuration for each Application that the identity provider is enabled for.
        /// </summary>
        public InputList<Inputs.FusionAuthIdpFacebookApplicationConfigurationArgs> ApplicationConfigurations
        {
            get => _applicationConfigurations ?? (_applicationConfigurations = new InputList<Inputs.FusionAuthIdpFacebookApplicationConfigurationArgs>());
            set => _applicationConfigurations = value;
        }

        /// <summary>
        /// The top-level button text to use on the FusionAuth login page for this Identity Provider.
        /// </summary>
        [Input("buttonText", required: true)]
        public Input<string> ButtonText { get; set; } = null!;

        [Input("clientSecret", required: true)]
        private Input<string>? _clientSecret;

        /// <summary>
        /// The top-level client secret, also known as 'App Secret', to use with the Facebook Identity Provider when retrieving the long-lived token. This value is retrieved from the Facebook developer website when you setup your Facebook developer account.
        /// </summary>
        public Input<string>? ClientSecret
        {
            get => _clientSecret;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _clientSecret = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Determines if debug is enabled for this provider. When enabled, an Event Log is created each time this provider is invoked to reconcile a login.
        /// </summary>
        [Input("debug")]
        public Input<bool>? Debug { get; set; }

        /// <summary>
        /// Determines if this provider is enabled. If it is false then it will be disabled globally.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The top-level fields that you are requesting from Facebook.
        /// Field values are documented at [Facebook Graph API](https://developers.facebook.com/docs/graph-api/using-graph-api/)
        /// </summary>
        [Input("fields")]
        public Input<string>? Fields { get; set; }

        /// <summary>
        /// The unique Id of the lambda to used during the user reconcile process to map custom claims from the external identity provider to the FusionAuth user.
        /// </summary>
        [Input("lambdaReconcileId")]
        public Input<string>? LambdaReconcileId { get; set; }

        /// <summary>
        /// The linking strategy to use when creating the link between the Facebook Identity Provider and the user.
        /// The valid values are:
        /// </summary>
        [Input("linkingStrategy")]
        public Input<string>? LinkingStrategy { get; set; }

        /// <summary>
        /// The login method to use for this Identity Provider.
        /// The valid values are:
        /// </summary>
        [Input("loginMethod")]
        public Input<string>? LoginMethod { get; set; }

        /// <summary>
        /// The top-level permissions that your application is asking of the user’s Facebook account.
        /// Permission values are documented at [Facebook Login API](https://developers.facebook.com/docs/permissions/reference)
        /// </summary>
        [Input("permissions")]
        public Input<string>? Permissions { get; set; }

        [Input("tenantConfigurations")]
        private InputList<Inputs.FusionAuthIdpFacebookTenantConfigurationArgs>? _tenantConfigurations;

        /// <summary>
        /// The configuration for each Tenant that limits the number of links a user may have for a particular identity provider.
        /// </summary>
        public InputList<Inputs.FusionAuthIdpFacebookTenantConfigurationArgs> TenantConfigurations
        {
            get => _tenantConfigurations ?? (_tenantConfigurations = new InputList<Inputs.FusionAuthIdpFacebookTenantConfigurationArgs>());
            set => _tenantConfigurations = value;
        }

        public FusionAuthIdpFacebookArgs()
        {
        }
        public static new FusionAuthIdpFacebookArgs Empty => new FusionAuthIdpFacebookArgs();
    }

    public sealed class FusionAuthIdpFacebookState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The top-level Facebook `appId` for your Application. This value is retrieved from the Facebook developer website when you setup your Facebook developer account.
        /// </summary>
        [Input("appId")]
        public Input<string>? AppId { get; set; }

        [Input("applicationConfigurations")]
        private InputList<Inputs.FusionAuthIdpFacebookApplicationConfigurationGetArgs>? _applicationConfigurations;

        /// <summary>
        /// The configuration for each Application that the identity provider is enabled for.
        /// </summary>
        public InputList<Inputs.FusionAuthIdpFacebookApplicationConfigurationGetArgs> ApplicationConfigurations
        {
            get => _applicationConfigurations ?? (_applicationConfigurations = new InputList<Inputs.FusionAuthIdpFacebookApplicationConfigurationGetArgs>());
            set => _applicationConfigurations = value;
        }

        /// <summary>
        /// The top-level button text to use on the FusionAuth login page for this Identity Provider.
        /// </summary>
        [Input("buttonText")]
        public Input<string>? ButtonText { get; set; }

        [Input("clientSecret")]
        private Input<string>? _clientSecret;

        /// <summary>
        /// The top-level client secret, also known as 'App Secret', to use with the Facebook Identity Provider when retrieving the long-lived token. This value is retrieved from the Facebook developer website when you setup your Facebook developer account.
        /// </summary>
        public Input<string>? ClientSecret
        {
            get => _clientSecret;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _clientSecret = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Determines if debug is enabled for this provider. When enabled, an Event Log is created each time this provider is invoked to reconcile a login.
        /// </summary>
        [Input("debug")]
        public Input<bool>? Debug { get; set; }

        /// <summary>
        /// Determines if this provider is enabled. If it is false then it will be disabled globally.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The top-level fields that you are requesting from Facebook.
        /// Field values are documented at [Facebook Graph API](https://developers.facebook.com/docs/graph-api/using-graph-api/)
        /// </summary>
        [Input("fields")]
        public Input<string>? Fields { get; set; }

        /// <summary>
        /// The unique Id of the lambda to used during the user reconcile process to map custom claims from the external identity provider to the FusionAuth user.
        /// </summary>
        [Input("lambdaReconcileId")]
        public Input<string>? LambdaReconcileId { get; set; }

        /// <summary>
        /// The linking strategy to use when creating the link between the Facebook Identity Provider and the user.
        /// The valid values are:
        /// </summary>
        [Input("linkingStrategy")]
        public Input<string>? LinkingStrategy { get; set; }

        /// <summary>
        /// The login method to use for this Identity Provider.
        /// The valid values are:
        /// </summary>
        [Input("loginMethod")]
        public Input<string>? LoginMethod { get; set; }

        /// <summary>
        /// The top-level permissions that your application is asking of the user’s Facebook account.
        /// Permission values are documented at [Facebook Login API](https://developers.facebook.com/docs/permissions/reference)
        /// </summary>
        [Input("permissions")]
        public Input<string>? Permissions { get; set; }

        [Input("tenantConfigurations")]
        private InputList<Inputs.FusionAuthIdpFacebookTenantConfigurationGetArgs>? _tenantConfigurations;

        /// <summary>
        /// The configuration for each Tenant that limits the number of links a user may have for a particular identity provider.
        /// </summary>
        public InputList<Inputs.FusionAuthIdpFacebookTenantConfigurationGetArgs> TenantConfigurations
        {
            get => _tenantConfigurations ?? (_tenantConfigurations = new InputList<Inputs.FusionAuthIdpFacebookTenantConfigurationGetArgs>());
            set => _tenantConfigurations = value;
        }

        public FusionAuthIdpFacebookState()
        {
        }
        public static new FusionAuthIdpFacebookState Empty => new FusionAuthIdpFacebookState();
    }
}
