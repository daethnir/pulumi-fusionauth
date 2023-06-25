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
    public static class GetFormField
    {
        /// <summary>
        /// ## # Form Field Resource
        /// 
        /// A FusionAuth Form Field is an object that can be customized to receive input within a FusionAuth [Form](https://fusionauth.io/docs/v1/tech/apis/forms).
        /// 
        /// [Form Field API](https://fusionauth.io/docs/v1/tech/apis/form-fields)
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
        ///     var @default = Fusionauth.GetFormField.Invoke(new()
        ///     {
        ///         Name = "Email",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetFormFieldResult> InvokeAsync(GetFormFieldArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetFormFieldResult>("fusionauth:index/getFormField:getFormField", args ?? new GetFormFieldArgs(), options.WithDefaults());

        /// <summary>
        /// ## # Form Field Resource
        /// 
        /// A FusionAuth Form Field is an object that can be customized to receive input within a FusionAuth [Form](https://fusionauth.io/docs/v1/tech/apis/forms).
        /// 
        /// [Form Field API](https://fusionauth.io/docs/v1/tech/apis/form-fields)
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
        ///     var @default = Fusionauth.GetFormField.Invoke(new()
        ///     {
        ///         Name = "Email",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetFormFieldResult> Invoke(GetFormFieldInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetFormFieldResult>("fusionauth:index/getFormField:getFormField", args ?? new GetFormFieldInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFormFieldArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Determines if the user input should be confirmed by requiring the value to be entered twice.
        /// - consent_id
        /// - control
        /// </summary>
        [Input("confirm")]
        public bool? Confirm { get; set; }

        [Input("consentId")]
        public string? ConsentId { get; set; }

        [Input("control")]
        public string? Control { get; set; }

        [Input("data")]
        private Dictionary<string, object>? _data;

        /// <summary>
        /// An object that can hold any information about the Form Field that should be persisted.
        /// - description
        /// - key
        /// </summary>
        public Dictionary<string, object> Data
        {
            get => _data ?? (_data = new Dictionary<string, object>());
            set => _data = value;
        }

        [Input("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The unique id of the Form Field. Either `form_field_id` or `name` must be specified.
        /// </summary>
        [Input("formFieldId")]
        public string? FormFieldId { get; set; }

        [Input("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The name of the Form field. Either `form_field_id` or `name` must be specified.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        [Input("options")]
        private List<string>? _options;

        /// <summary>
        /// A list of options that are applied to checkbox, radio, or select controls.
        /// </summary>
        public List<string> Options
        {
            get => _options ?? (_options = new List<string>());
            set => _options = value;
        }

        /// <summary>
        /// Determines if a value is required to complete the form.
        /// </summary>
        [Input("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// The form field type. The possible values are:
        /// </summary>
        [Input("type")]
        public string? Type { get; set; }

        [Input("validator")]
        public Inputs.GetFormFieldValidatorArgs? Validator { get; set; }

        public GetFormFieldArgs()
        {
        }
        public static new GetFormFieldArgs Empty => new GetFormFieldArgs();
    }

    public sealed class GetFormFieldInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Determines if the user input should be confirmed by requiring the value to be entered twice.
        /// - consent_id
        /// - control
        /// </summary>
        [Input("confirm")]
        public Input<bool>? Confirm { get; set; }

        [Input("consentId")]
        public Input<string>? ConsentId { get; set; }

        [Input("control")]
        public Input<string>? Control { get; set; }

        [Input("data")]
        private InputMap<object>? _data;

        /// <summary>
        /// An object that can hold any information about the Form Field that should be persisted.
        /// - description
        /// - key
        /// </summary>
        public InputMap<object> Data
        {
            get => _data ?? (_data = new InputMap<object>());
            set => _data = value;
        }

        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The unique id of the Form Field. Either `form_field_id` or `name` must be specified.
        /// </summary>
        [Input("formFieldId")]
        public Input<string>? FormFieldId { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// The name of the Form field. Either `form_field_id` or `name` must be specified.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("options")]
        private InputList<string>? _options;

        /// <summary>
        /// A list of options that are applied to checkbox, radio, or select controls.
        /// </summary>
        public InputList<string> Options
        {
            get => _options ?? (_options = new InputList<string>());
            set => _options = value;
        }

        /// <summary>
        /// Determines if a value is required to complete the form.
        /// </summary>
        [Input("required")]
        public Input<bool>? Required { get; set; }

        /// <summary>
        /// The form field type. The possible values are:
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("validator")]
        public Input<Inputs.GetFormFieldValidatorInputArgs>? Validator { get; set; }

        public GetFormFieldInvokeArgs()
        {
        }
        public static new GetFormFieldInvokeArgs Empty => new GetFormFieldInvokeArgs();
    }


    [OutputType]
    public sealed class GetFormFieldResult
    {
        /// <summary>
        /// Determines if the user input should be confirmed by requiring the value to be entered twice.
        /// - consent_id
        /// - control
        /// </summary>
        public readonly bool? Confirm;
        public readonly string? ConsentId;
        public readonly string Control;
        /// <summary>
        /// An object that can hold any information about the Form Field that should be persisted.
        /// - description
        /// - key
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Data;
        public readonly string? Description;
        public readonly string FormFieldId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Key;
        /// <summary>
        /// The unique name of the Form Field.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// A list of options that are applied to checkbox, radio, or select controls.
        /// </summary>
        public readonly ImmutableArray<string> Options;
        /// <summary>
        /// Determines if a value is required to complete the form.
        /// </summary>
        public readonly bool? Required;
        /// <summary>
        /// The form field type. The possible values are:
        /// </summary>
        public readonly string? Type;
        public readonly Outputs.GetFormFieldValidatorResult Validator;

        [OutputConstructor]
        private GetFormFieldResult(
            bool? confirm,

            string? consentId,

            string control,

            ImmutableDictionary<string, object>? data,

            string? description,

            string formFieldId,

            string id,

            string? key,

            string? name,

            ImmutableArray<string> options,

            bool? required,

            string? type,

            Outputs.GetFormFieldValidatorResult validator)
        {
            Confirm = confirm;
            ConsentId = consentId;
            Control = control;
            Data = data;
            Description = description;
            FormFieldId = formFieldId;
            Id = id;
            Key = key;
            Name = name;
            Options = options;
            Required = required;
            Type = type;
            Validator = validator;
        }
    }
}
