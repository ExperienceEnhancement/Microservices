using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using IdentityServer3.AccessTokenValidation;

[assembly: OwinStartup(typeof(Api.Startup))]

namespace Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIdentityServerBearerTokenAuthentication(
                new IdentityServerBearerTokenAuthenticationOptions
                {
                    Authority = "https://localhost:44311/identity",
                    RequiredScopes = new[] { "booklover" }
                });

            ConfigureAuth(app);
        }
    }
}
