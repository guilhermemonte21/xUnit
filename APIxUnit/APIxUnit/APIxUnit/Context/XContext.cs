using APIxUnit.Domains;
using Microsoft.EntityFrameworkCore;

namespace APIxUnit.Context
{
    public class XContext : DbContext
    {
        public XContext()
        {

        }
        public XContext(DbContextOptions<XContext> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se NÃO estiver configurado
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=NOTE09-SALA21\\SQLEXPRESS1; Initial Catalog=APIxUnit; User Id=sa; pwd=Senai@134; TrustServerCertificate = true;");
            
            }
        }


        public virtual DbSet<ProductsDomain> Products { get; set; }
        
    }
}

