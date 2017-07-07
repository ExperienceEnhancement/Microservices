using IdentityServer.Config;
using IdentityServer3.Core.Configuration;
using Owin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace IdentityServer
{
    public class Startup
    {
        private static readonly string IssuerUri = ConfigurationManager.AppSettings["IssuerUri"];

        public void Configuration(IAppBuilder app)
        {
            app.Map("/identity", idsrvApp =>
                {
                    var idSreverServiceFactory = new IdentityServerServiceFactory()
                        .UseInMemoryClients(Clients.Get())
                        .UseInMemoryScopes(Scopes.Get())
                        .UseInMemoryUsers(Users.Get());

                    var options = new IdentityServerOptions()
                    {
                        Factory = idSreverServiceFactory,
                        SiteName = "Book store",
                        IssuerUri = IssuerUri,
                        PublicOrigin = 
                    };

                    idsrvApp.UseIdentityServer(options);
                });
        }
    }
}