using Microsoft.AspNet.Identity.EntityFramework;

namespace Template.Api.Contextes
{
    class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() : base("AuthContext")
        {

        }
    }
}
