using EnterprisePatterns.Api.Movies.Domain.Enum;
using System;

namespace EnterprisePatterns.Api.Proyectos.Domain.Entity
{
    public class Proyecto
    {
        public virtual long Id { get; protected set; }
        public virtual string Name { get; }
        public virtual DateTime ReleaseDate { get; }
        public virtual MpaaRating MpaaRating { get; }
        public virtual string Genre { get; }
        public virtual double Rating { get; }
        public virtual Usuario Usuario { get; }

        protected Proyecto()
        {
        }
    }
   
}

