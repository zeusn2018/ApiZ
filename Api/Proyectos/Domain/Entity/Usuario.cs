
namespace EnterprisePatterns.Api.Proyectos.Domain.Entity
{
    public class Usuario
    {
        public virtual long Id { get; protected set; }
        public virtual string IdentityDocument { get; }
        public virtual string Name { get; }

    }
}


