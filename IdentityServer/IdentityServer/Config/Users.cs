using IdentityServer3.Core.Services.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityServer.Config
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>()
            {
                new InMemoryUser()
                {
                    Username = "gaby",
                    Password = "gaby@identityserver",
                    Subject = "e3d41dcf-836e-412b-84e8-ede4f5a0a47a"
                },
                new InMemoryUser()
                {
                    Username = "ivan",
                    Password = "ivan@identityserver",
                    Subject = "4850bacb-d824-4db5-8b49-284d4823409d"
                }
            };
        }
    }
}