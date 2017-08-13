using IdentityServer3.Core.Services.InMemory;
using System.Collections.Generic;

namespace IdentityServer.Config
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>()
                {
                    new InMemoryUser
                    {
                        Username = "gaby",
                        Password = "password",
                        Subject = "56711eeb-a447-4851-9642-c3a35d9904e6"
                    },
                    new InMemoryUser
                    {
                        Username = "peter",
                        Password = "password",
                        Subject = "f410b061-c9fd-4af5-857c-7fb0d70e23be"
                    }
                };
        }
    }
}