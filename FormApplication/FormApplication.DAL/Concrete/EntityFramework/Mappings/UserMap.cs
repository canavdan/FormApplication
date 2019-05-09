using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.DAL.Concrete.EntityFramework.Mappings
{
   public class UserMap:EntityTypeConfiguration<User>
    {

        public UserMap()
        {
            ToTable(@"Users", @"dbo");
            HasKey(x => x.UserID);

            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.UserMail).HasColumnName("UserMail");
            Property(x => x.UserPassword).HasColumnName("UserPassword");
            Property(x => x.LastName).HasColumnName("LastName");

            
        }
    }
}
