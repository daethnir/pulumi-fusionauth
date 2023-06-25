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
    public static class GetUser
    {
        /// <summary>
        /// ## # User Data Source
        /// 
        /// This data source can be used to fetch information about a specific user.
        /// 
        /// [Users API](https://fusionauth.io/docs/v1/tech/apis/users)
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Fusionauth = Pulumi.Fusionauth;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var example = Fusionauth.GetUser.Invoke(new()
        ///     {
        ///         Username = "foo@example.com",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetUserResult> InvokeAsync(GetUserArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetUserResult>("fusionauth:index/getUser:getUser", args ?? new GetUserArgs(), options.WithDefaults());

        /// <summary>
        /// ## # User Data Source
        /// 
        /// This data source can be used to fetch information about a specific user.
        /// 
        /// [Users API](https://fusionauth.io/docs/v1/tech/apis/users)
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Fusionauth = Pulumi.Fusionauth;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var example = Fusionauth.GetUser.Invoke(new()
        ///     {
        ///         Username = "foo@example.com",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetUserResult> Invoke(GetUserInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetUserResult>("fusionauth:index/getUser:getUser", args ?? new GetUserInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetUserArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Id of the tenant used to scope this API request.
        /// </summary>
        [Input("tenantId")]
        public string? TenantId { get; set; }

        /// <summary>
        /// The Id of the user. Either `user_id` or `username` must be specified.
        /// </summary>
        [Input("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The username of the user. Either `user_id` or `username` must be specified.
        /// </summary>
        [Input("username")]
        public string? Username { get; set; }

        public GetUserArgs()
        {
        }
        public static new GetUserArgs Empty => new GetUserArgs();
    }

    public sealed class GetUserInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Id of the tenant used to scope this API request.
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        /// <summary>
        /// The Id of the user. Either `user_id` or `username` must be specified.
        /// </summary>
        [Input("userId")]
        public Input<string>? UserId { get; set; }

        /// <summary>
        /// The username of the user. Either `user_id` or `username` must be specified.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public GetUserInvokeArgs()
        {
        }
        public static new GetUserInvokeArgs Empty => new GetUserInvokeArgs();
    }


    [OutputType]
    public sealed class GetUserResult
    {
        /// <summary>
        /// True if the user is active. False if the user has been deactivated. Deactivated users will not be able to login.
        /// </summary>
        public readonly bool Active;
        /// <summary>
        /// An ISO-8601 formatted date of the user’s birthdate such as YYYY-MM-DD.
        /// </summary>
        public readonly string BirthDate;
        /// <summary>
        /// A JSON serialised string that can hold any information about the user.
        /// </summary>
        public readonly string Data;
        /// <summary>
        /// The user’s email address.
        /// </summary>
        public readonly string Email;
        /// <summary>
        /// The expiration instant of the user’s account. An expired user is not permitted to login.
        /// </summary>
        public readonly int Expiry;
        /// <summary>
        /// The first name of the user.
        /// </summary>
        public readonly string FirstName;
        /// <summary>
        /// The user’s full name.
        /// </summary>
        public readonly string FullName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The URL that points to an image file that is the user’s profile image.
        /// </summary>
        public readonly string ImageUrl;
        /// <summary>
        /// The user’s last name.
        /// </summary>
        public readonly string LastName;
        /// <summary>
        /// The user’s middle name.
        /// </summary>
        public readonly string MiddleName;
        /// <summary>
        /// The user’s mobile phone number.
        /// </summary>
        public readonly string MobilePhone;
        /// <summary>
        /// The email address of the user’s parent or guardian.
        /// </summary>
        public readonly string ParentEmail;
        /// <summary>
        /// Indicates that the user’s password needs to be changed during their next login attempt.
        /// </summary>
        public readonly bool PasswordChangeRequired;
        /// <summary>
        /// An array of locale strings that give, in order, the user’s preferred languages.
        /// </summary>
        public readonly ImmutableArray<string> PreferredLanguages;
        public readonly string TenantId;
        /// <summary>
        /// The user’s preferred timezone.
        /// </summary>
        public readonly string Timezone;
        public readonly string UserId;
        public readonly string Username;
        /// <summary>
        /// The current status of the username. This is used if you are moderating usernames via CleanSpeak.
        /// </summary>
        public readonly string UsernameStatus;

        [OutputConstructor]
        private GetUserResult(
            bool active,

            string birthDate,

            string data,

            string email,

            int expiry,

            string firstName,

            string fullName,

            string id,

            string imageUrl,

            string lastName,

            string middleName,

            string mobilePhone,

            string parentEmail,

            bool passwordChangeRequired,

            ImmutableArray<string> preferredLanguages,

            string tenantId,

            string timezone,

            string userId,

            string username,

            string usernameStatus)
        {
            Active = active;
            BirthDate = birthDate;
            Data = data;
            Email = email;
            Expiry = expiry;
            FirstName = firstName;
            FullName = fullName;
            Id = id;
            ImageUrl = imageUrl;
            LastName = lastName;
            MiddleName = middleName;
            MobilePhone = mobilePhone;
            ParentEmail = parentEmail;
            PasswordChangeRequired = passwordChangeRequired;
            PreferredLanguages = preferredLanguages;
            TenantId = tenantId;
            Timezone = timezone;
            UserId = userId;
            Username = username;
            UsernameStatus = usernameStatus;
        }
    }
}
