using IdentityServer3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityServer.Config
{
    public static class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new List<Scope>()
            {
                new Scope
                {
                    Name = "booklover",
                    DisplayName = "Book Lover",
                    Description = "",
                    Type = ScopeType.Resource
                }
            };
        }
    }
}