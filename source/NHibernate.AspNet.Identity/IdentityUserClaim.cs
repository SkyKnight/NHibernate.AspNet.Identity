using NHibernate.AspNet.Identity.DomainModel;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace NHibernate.AspNet.Identity
{
    public class IdentityUserClaim<TKey> : EntityWithTypedId<int>
    {
        public virtual string ClaimType { get; set; }

        public virtual string ClaimValue { get; set; }

        public virtual TKey UserId { get; set; }
    }

    public class IdentityUserClaim : IdentityUserClaim<string>
    {

    }

    public class IdentityUserClaimMap : ClassMapping<IdentityUserClaim>
    {
        public IdentityUserClaimMap()
        {
            Table("AspNetUserClaims");
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.ClaimType);
            Property(x => x.ClaimValue);

            Property(x => x.UserId);

            //ManyToOne(x => x.User, m => m.Column("UserId"));
        }
    }

}
