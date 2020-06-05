<a name='assembly'></a>
# AndcultureCode.CSharp.Web

## Contents

- [IApplicationBuilderExtensions](#T-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions 'AndcultureCode.CSharp.Web.Extensions.IApplicationBuilderExtensions')
  - [UseGlobalExceptionHandler()](#M-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions-UseGlobalExceptionHandler-Microsoft-AspNetCore-Builder-IApplicationBuilder- 'AndcultureCode.CSharp.Web.Extensions.IApplicationBuilderExtensions.UseGlobalExceptionHandler(Microsoft.AspNetCore.Builder.IApplicationBuilder)')
- [IExceptionHandlerFeatureExtensions](#T-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions 'AndcultureCode.CSharp.Web.Extensions.IExceptionHandlerFeatureExtensions')
  - [ToResult()](#M-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions-ToResult-Microsoft-AspNetCore-Diagnostics-IExceptionHandlerFeature- 'AndcultureCode.CSharp.Web.Extensions.IExceptionHandlerFeatureExtensions.ToResult(Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature)')

<a name='T-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions'></a>
## IApplicationBuilderExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Extensions for IApplicationBuilder

<a name='M-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions-UseGlobalExceptionHandler-Microsoft-AspNetCore-Builder-IApplicationBuilder-'></a>
### UseGlobalExceptionHandler() `method`

##### Summary

Configure dotnet core API to wrap unhandled exceptions in IResult
and respond with json

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions'></a>
## IExceptionHandlerFeatureExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Extensions for IExceptionHandlerFeature

<a name='M-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions-ToResult-Microsoft-AspNetCore-Diagnostics-IExceptionHandlerFeature-'></a>
### ToResult() `method`

##### Summary

Transform exception context feature to IResult

##### Parameters

This method has no parameters.
