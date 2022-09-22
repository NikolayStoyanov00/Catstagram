using System;
using System.Security.Claims;

namespace Catstagram.Infrastructure
{
    public static class IdentityExtensions
    {
        public static string GetId(this ClaimsPrincipal user)
            => user.FindFirstValue(ClaimTypes.Name);
    }
}

