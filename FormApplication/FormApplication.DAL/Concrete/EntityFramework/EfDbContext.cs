using FormApplication.DAL.Concrete.EntityFramework.Mappings;
using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.DAL.Concrete.EntityFramework
{
    public class EfDbContext: DbContext
    {
        public EfDbContext()
        {
            //Veritabanı hazır sen bir şey oluşturma.migration datası verme
            Database.SetInitializer<EfDbContext>(null);
        }

        //Tabloları burada gösteririz
        public DbSet<User> Users { get; set; }
        public DbSet<Form> Forms { get; set; }
       

            //Mapping için OnModelCreating eklememiz gerekir.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new FormMap());
        }
    }
}
