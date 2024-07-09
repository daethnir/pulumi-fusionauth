// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package fusionauth

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/theogravity/pulumi-fusionauth/sdk/v4/go/fusionauth/internal"
)

// ## # Group Resource
//
// A FusionAuth Group is a named object that optionally contains one to many Application Roles.
//
// When a Group does not contain any Application Roles it can still be utilized to logically associate users. Assigning Application Roles to a group allow it to be used to dynamically manage Role assignment to registered Users. In this second scenario as long as a User is registered to an Application the Group membership will allow them to inherit the corresponding Roles from the Group.
//
// [Groups API](https://fusionauth.io/docs/v1/tech/apis/groups)
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
//			_, err := fusionauth.NewFusionAuthGroup(ctx, "myGroup", &fusionauth.FusionAuthGroupArgs{
//				TenantId: pulumi.Any(fusionauth_tenant.My_tenant.Id),
//				RoleIds: pulumi.StringArray{
//					fusionauth_application_role.Admins.Id,
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type FusionAuthGroup struct {
	pulumi.CustomResourceState

	// An object that can hold any information about the Group that should be persisted.
	Data pulumi.MapOutput `pulumi:"data"`
	// The Id to use for the new Group. If not specified a secure random UUID will be generated.
	GroupId pulumi.StringOutput `pulumi:"groupId"`
	// The name of the Group.
	Name pulumi.StringOutput `pulumi:"name"`
	// The Application Roles to assign to this group.
	RoleIds pulumi.StringArrayOutput `pulumi:"roleIds"`
	// The unique Id of the tenant used to scope this API request.
	TenantId pulumi.StringOutput `pulumi:"tenantId"`
}

// NewFusionAuthGroup registers a new resource with the given unique name, arguments, and options.
func NewFusionAuthGroup(ctx *pulumi.Context,
	name string, args *FusionAuthGroupArgs, opts ...pulumi.ResourceOption) (*FusionAuthGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.TenantId == nil {
		return nil, errors.New("invalid value for required argument 'TenantId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource FusionAuthGroup
	err := ctx.RegisterResource("fusionauth:index/fusionAuthGroup:FusionAuthGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFusionAuthGroup gets an existing FusionAuthGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFusionAuthGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FusionAuthGroupState, opts ...pulumi.ResourceOption) (*FusionAuthGroup, error) {
	var resource FusionAuthGroup
	err := ctx.ReadResource("fusionauth:index/fusionAuthGroup:FusionAuthGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FusionAuthGroup resources.
type fusionAuthGroupState struct {
	// An object that can hold any information about the Group that should be persisted.
	Data map[string]interface{} `pulumi:"data"`
	// The Id to use for the new Group. If not specified a secure random UUID will be generated.
	GroupId *string `pulumi:"groupId"`
	// The name of the Group.
	Name *string `pulumi:"name"`
	// The Application Roles to assign to this group.
	RoleIds []string `pulumi:"roleIds"`
	// The unique Id of the tenant used to scope this API request.
	TenantId *string `pulumi:"tenantId"`
}

type FusionAuthGroupState struct {
	// An object that can hold any information about the Group that should be persisted.
	Data pulumi.MapInput
	// The Id to use for the new Group. If not specified a secure random UUID will be generated.
	GroupId pulumi.StringPtrInput
	// The name of the Group.
	Name pulumi.StringPtrInput
	// The Application Roles to assign to this group.
	RoleIds pulumi.StringArrayInput
	// The unique Id of the tenant used to scope this API request.
	TenantId pulumi.StringPtrInput
}

func (FusionAuthGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*fusionAuthGroupState)(nil)).Elem()
}

type fusionAuthGroupArgs struct {
	// An object that can hold any information about the Group that should be persisted.
	Data map[string]interface{} `pulumi:"data"`
	// The Id to use for the new Group. If not specified a secure random UUID will be generated.
	GroupId *string `pulumi:"groupId"`
	// The name of the Group.
	Name *string `pulumi:"name"`
	// The Application Roles to assign to this group.
	RoleIds []string `pulumi:"roleIds"`
	// The unique Id of the tenant used to scope this API request.
	TenantId string `pulumi:"tenantId"`
}

// The set of arguments for constructing a FusionAuthGroup resource.
type FusionAuthGroupArgs struct {
	// An object that can hold any information about the Group that should be persisted.
	Data pulumi.MapInput
	// The Id to use for the new Group. If not specified a secure random UUID will be generated.
	GroupId pulumi.StringPtrInput
	// The name of the Group.
	Name pulumi.StringPtrInput
	// The Application Roles to assign to this group.
	RoleIds pulumi.StringArrayInput
	// The unique Id of the tenant used to scope this API request.
	TenantId pulumi.StringInput
}

func (FusionAuthGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*fusionAuthGroupArgs)(nil)).Elem()
}

type FusionAuthGroupInput interface {
	pulumi.Input

	ToFusionAuthGroupOutput() FusionAuthGroupOutput
	ToFusionAuthGroupOutputWithContext(ctx context.Context) FusionAuthGroupOutput
}

func (*FusionAuthGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**FusionAuthGroup)(nil)).Elem()
}

func (i *FusionAuthGroup) ToFusionAuthGroupOutput() FusionAuthGroupOutput {
	return i.ToFusionAuthGroupOutputWithContext(context.Background())
}

func (i *FusionAuthGroup) ToFusionAuthGroupOutputWithContext(ctx context.Context) FusionAuthGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FusionAuthGroupOutput)
}

// FusionAuthGroupArrayInput is an input type that accepts FusionAuthGroupArray and FusionAuthGroupArrayOutput values.
// You can construct a concrete instance of `FusionAuthGroupArrayInput` via:
//
//	FusionAuthGroupArray{ FusionAuthGroupArgs{...} }
type FusionAuthGroupArrayInput interface {
	pulumi.Input

	ToFusionAuthGroupArrayOutput() FusionAuthGroupArrayOutput
	ToFusionAuthGroupArrayOutputWithContext(context.Context) FusionAuthGroupArrayOutput
}

type FusionAuthGroupArray []FusionAuthGroupInput

func (FusionAuthGroupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FusionAuthGroup)(nil)).Elem()
}

func (i FusionAuthGroupArray) ToFusionAuthGroupArrayOutput() FusionAuthGroupArrayOutput {
	return i.ToFusionAuthGroupArrayOutputWithContext(context.Background())
}

func (i FusionAuthGroupArray) ToFusionAuthGroupArrayOutputWithContext(ctx context.Context) FusionAuthGroupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FusionAuthGroupArrayOutput)
}

// FusionAuthGroupMapInput is an input type that accepts FusionAuthGroupMap and FusionAuthGroupMapOutput values.
// You can construct a concrete instance of `FusionAuthGroupMapInput` via:
//
//	FusionAuthGroupMap{ "key": FusionAuthGroupArgs{...} }
type FusionAuthGroupMapInput interface {
	pulumi.Input

	ToFusionAuthGroupMapOutput() FusionAuthGroupMapOutput
	ToFusionAuthGroupMapOutputWithContext(context.Context) FusionAuthGroupMapOutput
}

type FusionAuthGroupMap map[string]FusionAuthGroupInput

func (FusionAuthGroupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FusionAuthGroup)(nil)).Elem()
}

func (i FusionAuthGroupMap) ToFusionAuthGroupMapOutput() FusionAuthGroupMapOutput {
	return i.ToFusionAuthGroupMapOutputWithContext(context.Background())
}

func (i FusionAuthGroupMap) ToFusionAuthGroupMapOutputWithContext(ctx context.Context) FusionAuthGroupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FusionAuthGroupMapOutput)
}

type FusionAuthGroupOutput struct{ *pulumi.OutputState }

func (FusionAuthGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**FusionAuthGroup)(nil)).Elem()
}

func (o FusionAuthGroupOutput) ToFusionAuthGroupOutput() FusionAuthGroupOutput {
	return o
}

func (o FusionAuthGroupOutput) ToFusionAuthGroupOutputWithContext(ctx context.Context) FusionAuthGroupOutput {
	return o
}

// An object that can hold any information about the Group that should be persisted.
func (o FusionAuthGroupOutput) Data() pulumi.MapOutput {
	return o.ApplyT(func(v *FusionAuthGroup) pulumi.MapOutput { return v.Data }).(pulumi.MapOutput)
}

// The Id to use for the new Group. If not specified a secure random UUID will be generated.
func (o FusionAuthGroupOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *FusionAuthGroup) pulumi.StringOutput { return v.GroupId }).(pulumi.StringOutput)
}

// The name of the Group.
func (o FusionAuthGroupOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *FusionAuthGroup) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The Application Roles to assign to this group.
func (o FusionAuthGroupOutput) RoleIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *FusionAuthGroup) pulumi.StringArrayOutput { return v.RoleIds }).(pulumi.StringArrayOutput)
}

// The unique Id of the tenant used to scope this API request.
func (o FusionAuthGroupOutput) TenantId() pulumi.StringOutput {
	return o.ApplyT(func(v *FusionAuthGroup) pulumi.StringOutput { return v.TenantId }).(pulumi.StringOutput)
}

type FusionAuthGroupArrayOutput struct{ *pulumi.OutputState }

func (FusionAuthGroupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FusionAuthGroup)(nil)).Elem()
}

func (o FusionAuthGroupArrayOutput) ToFusionAuthGroupArrayOutput() FusionAuthGroupArrayOutput {
	return o
}

func (o FusionAuthGroupArrayOutput) ToFusionAuthGroupArrayOutputWithContext(ctx context.Context) FusionAuthGroupArrayOutput {
	return o
}

func (o FusionAuthGroupArrayOutput) Index(i pulumi.IntInput) FusionAuthGroupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *FusionAuthGroup {
		return vs[0].([]*FusionAuthGroup)[vs[1].(int)]
	}).(FusionAuthGroupOutput)
}

type FusionAuthGroupMapOutput struct{ *pulumi.OutputState }

func (FusionAuthGroupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FusionAuthGroup)(nil)).Elem()
}

func (o FusionAuthGroupMapOutput) ToFusionAuthGroupMapOutput() FusionAuthGroupMapOutput {
	return o
}

func (o FusionAuthGroupMapOutput) ToFusionAuthGroupMapOutputWithContext(ctx context.Context) FusionAuthGroupMapOutput {
	return o
}

func (o FusionAuthGroupMapOutput) MapIndex(k pulumi.StringInput) FusionAuthGroupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *FusionAuthGroup {
		return vs[0].(map[string]*FusionAuthGroup)[vs[1].(string)]
	}).(FusionAuthGroupOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*FusionAuthGroupInput)(nil)).Elem(), &FusionAuthGroup{})
	pulumi.RegisterInputType(reflect.TypeOf((*FusionAuthGroupArrayInput)(nil)).Elem(), FusionAuthGroupArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*FusionAuthGroupMapInput)(nil)).Elem(), FusionAuthGroupMap{})
	pulumi.RegisterOutputType(FusionAuthGroupOutput{})
	pulumi.RegisterOutputType(FusionAuthGroupArrayOutput{})
	pulumi.RegisterOutputType(FusionAuthGroupMapOutput{})
}
