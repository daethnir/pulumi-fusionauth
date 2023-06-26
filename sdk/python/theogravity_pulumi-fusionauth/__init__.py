# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from . import _utilities
import typing
# Export this package's modules as members:
from .fusion_auth_api_key import *
from .fusion_auth_application import *
from .fusion_auth_application_role import *
from .fusion_auth_e_mail import *
from .fusion_auth_entity import *
from .fusion_auth_entity_grant import *
from .fusion_auth_entity_type import *
from .fusion_auth_entity_type_permission import *
from .fusion_auth_form import *
from .fusion_auth_form_field import *
from .fusion_auth_generic_connector import *
from .fusion_auth_group import *
from .fusion_auth_idp_apple import *
from .fusion_auth_idp_external_jwt import *
from .fusion_auth_idp_facebook import *
from .fusion_auth_idp_google import *
from .fusion_auth_idp_linked_in import *
from .fusion_auth_idp_open_id_connect import *
from .fusion_auth_idp_psn import *
from .fusion_auth_idp_saml_v2_idp_initiated import *
from .fusion_auth_idp_samlv2 import *
from .fusion_auth_idp_steam import *
from .fusion_auth_idp_twitch import *
from .fusion_auth_idp_x_box import *
from .fusion_auth_imported_key import *
from .fusion_auth_key import *
from .fusion_auth_lambda import *
from .fusion_auth_reactor import *
from .fusion_auth_registration import *
from .fusion_auth_system_configuration import *
from .fusion_auth_tenant import *
from .fusion_auth_theme import *
from .fusion_auth_user import *
from .fusion_auth_user_action import *
from .fusion_auth_webhook import *
from .get_application import *
from .get_application_role import *
from .get_e_mail import *
from .get_form import *
from .get_form_field import *
from .get_idp import *
from .get_lambda import *
from .get_tenant import *
from .get_user import *
from .provider import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import theogravity_pulumi-fusionauth.config as __config
    config = __config
else:
    config = _utilities.lazy_import('theogravity_pulumi-fusionauth.config')

_utilities.register(
    resource_modules="""
[
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthApiKey",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthApiKey:FusionAuthApiKey": "FusionAuthApiKey"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthApplication",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthApplication:FusionAuthApplication": "FusionAuthApplication"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthApplicationRole",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthApplicationRole:FusionAuthApplicationRole": "FusionAuthApplicationRole"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthEMail",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthEMail:FusionAuthEMail": "FusionAuthEMail"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthEntity",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthEntity:FusionAuthEntity": "FusionAuthEntity"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthEntityGrant",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthEntityGrant:FusionAuthEntityGrant": "FusionAuthEntityGrant"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthEntityType",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthEntityType:FusionAuthEntityType": "FusionAuthEntityType"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthEntityTypePermission",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthEntityTypePermission:FusionAuthEntityTypePermission": "FusionAuthEntityTypePermission"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthForm",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthForm:FusionAuthForm": "FusionAuthForm"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthFormField",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthFormField:FusionAuthFormField": "FusionAuthFormField"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthGenericConnector",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthGenericConnector:FusionAuthGenericConnector": "FusionAuthGenericConnector"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthGroup",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthGroup:FusionAuthGroup": "FusionAuthGroup"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpApple",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpApple:FusionAuthIdpApple": "FusionAuthIdpApple"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpExternalJwt",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpExternalJwt:FusionAuthIdpExternalJwt": "FusionAuthIdpExternalJwt"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpFacebook",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpFacebook:FusionAuthIdpFacebook": "FusionAuthIdpFacebook"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpGoogle",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpGoogle:FusionAuthIdpGoogle": "FusionAuthIdpGoogle"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpLinkedIn",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpLinkedIn:FusionAuthIdpLinkedIn": "FusionAuthIdpLinkedIn"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpOpenIdConnect",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpOpenIdConnect:FusionAuthIdpOpenIdConnect": "FusionAuthIdpOpenIdConnect"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpPsn",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpPsn:FusionAuthIdpPsn": "FusionAuthIdpPsn"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpSamlV2IdpInitiated",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpSamlV2IdpInitiated:FusionAuthIdpSamlV2IdpInitiated": "FusionAuthIdpSamlV2IdpInitiated"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpSamlv2",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpSamlv2:FusionAuthIdpSamlv2": "FusionAuthIdpSamlv2"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpSteam",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpSteam:FusionAuthIdpSteam": "FusionAuthIdpSteam"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpTwitch",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpTwitch:FusionAuthIdpTwitch": "FusionAuthIdpTwitch"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthIdpXBox",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthIdpXBox:FusionAuthIdpXBox": "FusionAuthIdpXBox"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthImportedKey",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthImportedKey:FusionAuthImportedKey": "FusionAuthImportedKey"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthKey",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthKey:FusionAuthKey": "FusionAuthKey"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthLambda",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthLambda:FusionAuthLambda": "FusionAuthLambda"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthReactor",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthReactor:FusionAuthReactor": "FusionAuthReactor"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthRegistration",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthRegistration:FusionAuthRegistration": "FusionAuthRegistration"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthSystemConfiguration",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthSystemConfiguration:FusionAuthSystemConfiguration": "FusionAuthSystemConfiguration"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthTenant",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthTenant:FusionAuthTenant": "FusionAuthTenant"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthTheme",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthTheme:FusionAuthTheme": "FusionAuthTheme"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthUser",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthUser:FusionAuthUser": "FusionAuthUser"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthUserAction",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthUserAction:FusionAuthUserAction": "FusionAuthUserAction"
  }
 },
 {
  "pkg": "fusionauth",
  "mod": "index/fusionAuthWebhook",
  "fqn": "theogravity_pulumi-fusionauth",
  "classes": {
   "fusionauth:index/fusionAuthWebhook:FusionAuthWebhook": "FusionAuthWebhook"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "fusionauth",
  "token": "pulumi:providers:fusionauth",
  "fqn": "theogravity_pulumi-fusionauth",
  "class": "Provider"
 }
]
"""
)
