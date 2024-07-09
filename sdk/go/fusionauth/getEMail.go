// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package fusionauth

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/theogravity/pulumi-fusionauth/sdk/v4/go/fusionauth/internal"
)

// ## # Email Resource
//
// This data source is used to fetch information about a specific Email Template.
//
// [Emails API](https://fusionauth.io/docs/v1/tech/apis/emails)
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/theogravity/pulumi-fusionauth/sdk/v4/go/fusionauth"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := fusionauth.GetEMail(ctx, &fusionauth.GetEMailArgs{
//				Name: "[FusionAuth Default] Breached Password Notification",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetEMail(ctx *pulumi.Context, args *GetEMailArgs, opts ...pulumi.InvokeOption) (*GetEMailResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetEMailResult
	err := ctx.Invoke("fusionauth:index/getEMail:getEMail", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getEMail.
type GetEMailArgs struct {
	// The email address that this email will be sent from.
	FromEmail *string `pulumi:"fromEmail"`
	// The name of the Email Template.
	Name string `pulumi:"name"`
}

// A collection of values returned by getEMail.
type GetEMailResult struct {
	// The default From Name used when sending emails.
	DefaultFromName string `pulumi:"defaultFromName"`
	// The default HTML Email Template.
	DefaultHtmlTemplate string `pulumi:"defaultHtmlTemplate"`
	// The default Subject used when sending emails.
	DefaultSubject string `pulumi:"defaultSubject"`
	// The default Text Email Template.
	DefaultTextTemplate string `pulumi:"defaultTextTemplate"`
	// The email address that this email will be sent from.
	FromEmail *string `pulumi:"fromEmail"`
	// The Id of the Email Template.
	Id string `pulumi:"id"`
	// The From Name used when sending emails to users who speak other languages.
	LocalizedFromNames map[string]interface{} `pulumi:"localizedFromNames"`
	// The HTML Email Template used when sending emails to users who speak other languages.
	LocalizedHtmlTemplates map[string]interface{} `pulumi:"localizedHtmlTemplates"`
	// The Subject used when sending emails to users who speak other languages.
	LocalizedSubjects map[string]interface{} `pulumi:"localizedSubjects"`
	// The Text Email Template used when sending emails to users who speak other languages.
	LocalizedTextTemplates map[string]interface{} `pulumi:"localizedTextTemplates"`
	Name                   string                 `pulumi:"name"`
}

func GetEMailOutput(ctx *pulumi.Context, args GetEMailOutputArgs, opts ...pulumi.InvokeOption) GetEMailResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetEMailResult, error) {
			args := v.(GetEMailArgs)
			r, err := GetEMail(ctx, &args, opts...)
			var s GetEMailResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetEMailResultOutput)
}

// A collection of arguments for invoking getEMail.
type GetEMailOutputArgs struct {
	// The email address that this email will be sent from.
	FromEmail pulumi.StringPtrInput `pulumi:"fromEmail"`
	// The name of the Email Template.
	Name pulumi.StringInput `pulumi:"name"`
}

func (GetEMailOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEMailArgs)(nil)).Elem()
}

// A collection of values returned by getEMail.
type GetEMailResultOutput struct{ *pulumi.OutputState }

func (GetEMailResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEMailResult)(nil)).Elem()
}

func (o GetEMailResultOutput) ToGetEMailResultOutput() GetEMailResultOutput {
	return o
}

func (o GetEMailResultOutput) ToGetEMailResultOutputWithContext(ctx context.Context) GetEMailResultOutput {
	return o
}

// The default From Name used when sending emails.
func (o GetEMailResultOutput) DefaultFromName() pulumi.StringOutput {
	return o.ApplyT(func(v GetEMailResult) string { return v.DefaultFromName }).(pulumi.StringOutput)
}

// The default HTML Email Template.
func (o GetEMailResultOutput) DefaultHtmlTemplate() pulumi.StringOutput {
	return o.ApplyT(func(v GetEMailResult) string { return v.DefaultHtmlTemplate }).(pulumi.StringOutput)
}

// The default Subject used when sending emails.
func (o GetEMailResultOutput) DefaultSubject() pulumi.StringOutput {
	return o.ApplyT(func(v GetEMailResult) string { return v.DefaultSubject }).(pulumi.StringOutput)
}

// The default Text Email Template.
func (o GetEMailResultOutput) DefaultTextTemplate() pulumi.StringOutput {
	return o.ApplyT(func(v GetEMailResult) string { return v.DefaultTextTemplate }).(pulumi.StringOutput)
}

// The email address that this email will be sent from.
func (o GetEMailResultOutput) FromEmail() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetEMailResult) *string { return v.FromEmail }).(pulumi.StringPtrOutput)
}

// The Id of the Email Template.
func (o GetEMailResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetEMailResult) string { return v.Id }).(pulumi.StringOutput)
}

// The From Name used when sending emails to users who speak other languages.
func (o GetEMailResultOutput) LocalizedFromNames() pulumi.MapOutput {
	return o.ApplyT(func(v GetEMailResult) map[string]interface{} { return v.LocalizedFromNames }).(pulumi.MapOutput)
}

// The HTML Email Template used when sending emails to users who speak other languages.
func (o GetEMailResultOutput) LocalizedHtmlTemplates() pulumi.MapOutput {
	return o.ApplyT(func(v GetEMailResult) map[string]interface{} { return v.LocalizedHtmlTemplates }).(pulumi.MapOutput)
}

// The Subject used when sending emails to users who speak other languages.
func (o GetEMailResultOutput) LocalizedSubjects() pulumi.MapOutput {
	return o.ApplyT(func(v GetEMailResult) map[string]interface{} { return v.LocalizedSubjects }).(pulumi.MapOutput)
}

// The Text Email Template used when sending emails to users who speak other languages.
func (o GetEMailResultOutput) LocalizedTextTemplates() pulumi.MapOutput {
	return o.ApplyT(func(v GetEMailResult) map[string]interface{} { return v.LocalizedTextTemplates }).(pulumi.MapOutput)
}

func (o GetEMailResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetEMailResult) string { return v.Name }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetEMailResultOutput{})
}
