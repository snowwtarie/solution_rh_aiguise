using Microsoft.EntityFrameworkCore;

namespace rh.Models
{
    public class RhContext : DbContext
    {
        public RhContext (DbContextOptions<RhContext> options)
            : base(options)
        {            
        }

        public DbSet<rh.Models.Collaborateur> Collaborateur { get; set; }
        public DbSet<rh.Models.Conge> Conge { get; set; }
        public DbSet<rh.Models.TypeConge> TypeConge { get; set; }
        public DbSet<rh.Models.Contrat> Contrat { get; set; }
        public DbSet<rh.Models.TypeContrat> TypeContrat { get; set; }
        public DbSet<rh.Models.Service> Service { get; set; }
        public DbSet<rh.Models.Depense> Depense { get; set; }
        public DbSet<rh.Models.TypeDepense> TypeDepense { get; set; }
    }
}