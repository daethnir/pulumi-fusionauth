# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetApplicationRoleResult',
    'AwaitableGetApplicationRoleResult',
    'get_application_role',
    'get_application_role_output',
]

@pulumi.output_type
class GetApplicationRoleResult:
    """
    A collection of values returned by getApplicationRole.
    """
    def __init__(__self__, application_id=None, id=None, name=None):
        if application_id and not isinstance(application_id, str):
            raise TypeError("Expected argument 'application_id' to be a str")
        pulumi.set(__self__, "application_id", application_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> str:
        return pulumi.get(self, "application_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")


class AwaitableGetApplicationRoleResult(GetApplicationRoleResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetApplicationRoleResult(
            application_id=self.application_id,
            id=self.id,
            name=self.name)


def get_application_role(application_id: Optional[str] = None,
                         name: Optional[str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetApplicationRoleResult:
    """
    ## # Application Role Resource

    This Resource is used to create a role for an Application.

    [Application Roles API](https://fusionauth.io/docs/v1/tech/apis/applications)

    ## Example Usage

    ```python
    import pulumi
    import pulumi_fusionauth as fusionauth

    admin = fusionauth.get_application_role(application_id=data["fusionauth_application"]["FusionAuth"]["id"],
        name="admin")
    ```


    :param str application_id: ID of the application that this role is for.
    :param str name: The name of the Role.
    """
    __args__ = dict()
    __args__['applicationId'] = application_id
    __args__['name'] = name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('fusionauth:index/getApplicationRole:getApplicationRole', __args__, opts=opts, typ=GetApplicationRoleResult).value

    return AwaitableGetApplicationRoleResult(
        application_id=__ret__.application_id,
        id=__ret__.id,
        name=__ret__.name)


@_utilities.lift_output_func(get_application_role)
def get_application_role_output(application_id: Optional[pulumi.Input[str]] = None,
                                name: Optional[pulumi.Input[str]] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetApplicationRoleResult]:
    """
    ## # Application Role Resource

    This Resource is used to create a role for an Application.

    [Application Roles API](https://fusionauth.io/docs/v1/tech/apis/applications)

    ## Example Usage

    ```python
    import pulumi
    import pulumi_fusionauth as fusionauth

    admin = fusionauth.get_application_role(application_id=data["fusionauth_application"]["FusionAuth"]["id"],
        name="admin")
    ```


    :param str application_id: ID of the application that this role is for.
    :param str name: The name of the Role.
    """
    ...