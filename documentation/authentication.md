# Authentication

We currently provide features to support three modes of authentication

-   Cookie
-   Google OAuth
-   Microsoft OAuth

Please follow the instructions below to configure the OpenID provider accounts.

**DO NOT** add any Client IDs or Secrets to source control.

---

## Environment Configuration

### Development

For development machines, we leverage [User Secret Manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows)

```shell
dotnet user-secrets set "Authentication:Google:ClientId" "<Client ID>"
dotnet user-secrets set "Authentication:Google:ClientSecret" "<Client Secret>"

dotnet user-secrets set "Authentication:Microsoft:ClientId" "<Client ID>"
dotnet user-secrets set "Authentication:Microsoft:ClientSecret" "<Client Secret>"
```

### Hosting Environments

Environment variables should be considered within each environment's hosting configuration.

Again, **DO NOT** add these details into any of the `appsettings.*.json` files in source control.

---

## Open ID Account Setup

### Google

-   Go to application credentials page
-   Create new project
-   Configure consent screen with details about application
-   User Type: Internal (scopes to andculture/client organization -- like azure ad)
-   Create OAuth Client ID
    -   Type: Web application
    -   Name: Something description (ie. `application api`)
    -   Javascript origin URIs: https://localhost:5001
    -   Redirect URIs: https://localhost:5001/signin-google

### Microsoft

-   Create microsoft account (ie. `developer@my-organization.com`)
-   Create application registration for application
-   Configure redirect-url
    -   Platform type: Web
    -   Redirect URL: https://localhost:5001/signin-microsoft
    -   Logout URL: https://localhost:5001/signout-microsoft
-   Configure as multi-tenant application
    -   Supported account types
        -   Select radio button of “Accounts in any organizational directory (Any Azure AD directory - Multitenant)”
