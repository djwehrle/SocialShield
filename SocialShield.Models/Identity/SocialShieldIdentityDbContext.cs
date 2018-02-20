using Microsoft.AspNet.Identity.EntityFramework;

namespace SocialShield.Models.Identity
{
    public class SocialShieldIdentityDbContext : IdentityDbContext<UserIdentity>
    {
        public SocialShieldIdentityDbContext()
            : base("SocialShield", throwIfV1Schema: false)
        {
        }

        public static SocialShieldIdentityDbContext Create()
        {
            return new SocialShieldIdentityDbContext();
        }
    }
}