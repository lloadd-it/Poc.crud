using Poc.Crud.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Crud.Controllers
{
    class FabricaContext :DbContext
    {
        public FabricaContext() : base("name=MySQLConnectionString")
        {            
             this.Configuration.LazyLoadingEnabled = true;
             //this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<MaquinaModel> Maquinas { get; set; }
        public DbSet<TipoModel> Tipos  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<MaquinaModel>().ToTable("Maquinas");
            modelBuilder.Entity<TipoModel>().ToTable("Tipos");
        }
    }
}
