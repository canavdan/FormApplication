using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.DAL.Concrete.EntityFramework.Mappings
{
    public class FormMap:EntityTypeConfiguration<Form>
    {

        public FormMap()
        {
            ToTable(@"Forms", @"dbo");
            HasKey(x => x.FormID);

            Property(x => x.FormName).HasColumnName("FormName");
            Property(x => x.UserID).HasColumnName("UserID");
            Property(x => x.Description).HasColumnName("Description");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Surname).HasColumnName("Surname");
            Property(x => x.Age).HasColumnName("Age");

        }
    
    }
}
