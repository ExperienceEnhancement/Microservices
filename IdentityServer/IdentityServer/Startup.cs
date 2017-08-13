using IdentityServer.Config;
using IdentityServer3.Core.Configuration;
using Owin;
using System;
using System.Security.Cryptography.X509Certificates;

namespace IdentityServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/identity", idsrvApp =>
            {
                var idServerServiceFactory = new IdentityServerServiceFactory()
                .UseInMemoryClients(Clients.Get())
                .UseInMemoryUsers(Users.Get())
                .UseInMemoryScopes(Scopes.Get());


                var options = new IdentityServerOptions
                {
                    Factory = idServerServiceFactory,
                    SiteName = "Identity Server",
                    IssuerUri = "https://identityserversts/identity",
                    PublicOrigin = "https://localhost:44311/",
                    SigningCertificate = LoadCertificate()
                };

                idsrvApp.UseIdentityServer(options);
            });
        }

        X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2($@"{AppDomain.CurrentDomain.BaseDirectory}\Certificates\idsrv3test.pfx", "idsrv3test");
        }
    }
}