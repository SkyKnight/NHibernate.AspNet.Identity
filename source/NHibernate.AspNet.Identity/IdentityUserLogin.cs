using NHibernate.AspNet.Identity.DomainModel;

namespace NHibernate.AspNet.Identity
{
    public class IdentityUserLogin<TKey> : ValueObject
    {
        public virtual string LoginProvider { get; set; }

        public virtual string ProviderKey { get; set; }

        //public virtual TKey UserId { get; set; }
    }

    public class IdentityUserLogin : IdentityUserLogin<string>
    { }
}
