// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # Generic Connector Resource
 *
 * A FusionAuth Generic Connector is a named object that provides configuration for allowing authentication against external systems.
 *
 * [Generic Connector API](https://fusionauth.io/docs/v1/tech/apis/connectors/generic/)
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as pulumi_fusionauth from "pulumi-fusionauth";
 *
 * const example = new fusionauth.FusionAuthGenericConnector("example", {
 *     authenticationUrl: "http://mygameserver.local:7001/fusionauth-connector",
 *     connectTimeout: 1000,
 *     data: {
 *         foo: "bar",
 *     },
 *     debug: false,
 *     headers: {
 *         foo: "bar",
 *         bar: "baz",
 *     },
 *     httpAuthenticationPassword: "supersecret",
 *     httpAuthenticationUsername: "me",
 *     readTimeout: 2000,
 *     sslCertificateKeyId: "00000000-0000-0000-0000-000000000678",
 * });
 * ```
 */
export class FusionAuthGenericConnector extends pulumi.CustomResource {
    /**
     * Get an existing FusionAuthGenericConnector resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FusionAuthGenericConnectorState, opts?: pulumi.CustomResourceOptions): FusionAuthGenericConnector {
        return new FusionAuthGenericConnector(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'fusionauth:index/fusionAuthGenericConnector:FusionAuthGenericConnector';

    /**
     * Returns true if the given object is an instance of FusionAuthGenericConnector.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FusionAuthGenericConnector {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FusionAuthGenericConnector.__pulumiType;
    }

    /**
     * The fully qualified URL used to send an HTTP request to authenticate the user.
     */
    public readonly authenticationUrl!: pulumi.Output<string>;
    /**
     * The connect timeout for the HTTP connection, in milliseconds. Value must be greater than 0.
     */
    public readonly connectTimeout!: pulumi.Output<number>;
    /**
     * An object that can hold any information about the Connector that should be persisted.
     */
    public readonly data!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * Determines if debug should be enabled to create an event log to assist in debugging integration errors. Defaults to false.
     */
    public readonly debug!: pulumi.Output<boolean | undefined>;
    /**
     * An object that can hold HTTPHeader key and value pairs.
     */
    public readonly headers!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The HTTP basic authentication password that is sent as part of the HTTP request for the events.
     */
    public readonly httpAuthenticationPassword!: pulumi.Output<string | undefined>;
    /**
     * -(Optional) The HTTP basic authentication username that is sent as part of the HTTP request for the events.
     */
    public readonly httpAuthenticationUsername!: pulumi.Output<string | undefined>;
    /**
     * The unique Connector name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The read timeout in milliseconds used when FusionAuth sends events to the Webhook.
     */
    public readonly readTimeout!: pulumi.Output<number>;
    /**
     * The Id of an existing [Key](https://fusionauth.io/docs/v1/tech/apis/keys/). The X509 certificate is used for client certificate authentication in requests to the Connector.
     */
    public readonly sslCertificateKeyId!: pulumi.Output<string | undefined>;

    /**
     * Create a FusionAuthGenericConnector resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FusionAuthGenericConnectorArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FusionAuthGenericConnectorArgs | FusionAuthGenericConnectorState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FusionAuthGenericConnectorState | undefined;
            resourceInputs["authenticationUrl"] = state ? state.authenticationUrl : undefined;
            resourceInputs["connectTimeout"] = state ? state.connectTimeout : undefined;
            resourceInputs["data"] = state ? state.data : undefined;
            resourceInputs["debug"] = state ? state.debug : undefined;
            resourceInputs["headers"] = state ? state.headers : undefined;
            resourceInputs["httpAuthenticationPassword"] = state ? state.httpAuthenticationPassword : undefined;
            resourceInputs["httpAuthenticationUsername"] = state ? state.httpAuthenticationUsername : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["readTimeout"] = state ? state.readTimeout : undefined;
            resourceInputs["sslCertificateKeyId"] = state ? state.sslCertificateKeyId : undefined;
        } else {
            const args = argsOrState as FusionAuthGenericConnectorArgs | undefined;
            if ((!args || args.authenticationUrl === undefined) && !opts.urn) {
                throw new Error("Missing required property 'authenticationUrl'");
            }
            if ((!args || args.connectTimeout === undefined) && !opts.urn) {
                throw new Error("Missing required property 'connectTimeout'");
            }
            if ((!args || args.readTimeout === undefined) && !opts.urn) {
                throw new Error("Missing required property 'readTimeout'");
            }
            resourceInputs["authenticationUrl"] = args ? args.authenticationUrl : undefined;
            resourceInputs["connectTimeout"] = args ? args.connectTimeout : undefined;
            resourceInputs["data"] = args ? args.data : undefined;
            resourceInputs["debug"] = args ? args.debug : undefined;
            resourceInputs["headers"] = args ? args.headers : undefined;
            resourceInputs["httpAuthenticationPassword"] = args ? args.httpAuthenticationPassword : undefined;
            resourceInputs["httpAuthenticationUsername"] = args ? args.httpAuthenticationUsername : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["readTimeout"] = args ? args.readTimeout : undefined;
            resourceInputs["sslCertificateKeyId"] = args ? args.sslCertificateKeyId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(FusionAuthGenericConnector.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FusionAuthGenericConnector resources.
 */
export interface FusionAuthGenericConnectorState {
    /**
     * The fully qualified URL used to send an HTTP request to authenticate the user.
     */
    authenticationUrl?: pulumi.Input<string>;
    /**
     * The connect timeout for the HTTP connection, in milliseconds. Value must be greater than 0.
     */
    connectTimeout?: pulumi.Input<number>;
    /**
     * An object that can hold any information about the Connector that should be persisted.
     */
    data?: pulumi.Input<{[key: string]: any}>;
    /**
     * Determines if debug should be enabled to create an event log to assist in debugging integration errors. Defaults to false.
     */
    debug?: pulumi.Input<boolean>;
    /**
     * An object that can hold HTTPHeader key and value pairs.
     */
    headers?: pulumi.Input<{[key: string]: any}>;
    /**
     * The HTTP basic authentication password that is sent as part of the HTTP request for the events.
     */
    httpAuthenticationPassword?: pulumi.Input<string>;
    /**
     * -(Optional) The HTTP basic authentication username that is sent as part of the HTTP request for the events.
     */
    httpAuthenticationUsername?: pulumi.Input<string>;
    /**
     * The unique Connector name.
     */
    name?: pulumi.Input<string>;
    /**
     * The read timeout in milliseconds used when FusionAuth sends events to the Webhook.
     */
    readTimeout?: pulumi.Input<number>;
    /**
     * The Id of an existing [Key](https://fusionauth.io/docs/v1/tech/apis/keys/). The X509 certificate is used for client certificate authentication in requests to the Connector.
     */
    sslCertificateKeyId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a FusionAuthGenericConnector resource.
 */
export interface FusionAuthGenericConnectorArgs {
    /**
     * The fully qualified URL used to send an HTTP request to authenticate the user.
     */
    authenticationUrl: pulumi.Input<string>;
    /**
     * The connect timeout for the HTTP connection, in milliseconds. Value must be greater than 0.
     */
    connectTimeout: pulumi.Input<number>;
    /**
     * An object that can hold any information about the Connector that should be persisted.
     */
    data?: pulumi.Input<{[key: string]: any}>;
    /**
     * Determines if debug should be enabled to create an event log to assist in debugging integration errors. Defaults to false.
     */
    debug?: pulumi.Input<boolean>;
    /**
     * An object that can hold HTTPHeader key and value pairs.
     */
    headers?: pulumi.Input<{[key: string]: any}>;
    /**
     * The HTTP basic authentication password that is sent as part of the HTTP request for the events.
     */
    httpAuthenticationPassword?: pulumi.Input<string>;
    /**
     * -(Optional) The HTTP basic authentication username that is sent as part of the HTTP request for the events.
     */
    httpAuthenticationUsername?: pulumi.Input<string>;
    /**
     * The unique Connector name.
     */
    name?: pulumi.Input<string>;
    /**
     * The read timeout in milliseconds used when FusionAuth sends events to the Webhook.
     */
    readTimeout: pulumi.Input<number>;
    /**
     * The Id of an existing [Key](https://fusionauth.io/docs/v1/tech/apis/keys/). The X509 certificate is used for client certificate authentication in requests to the Connector.
     */
    sslCertificateKeyId?: pulumi.Input<string>;
}
