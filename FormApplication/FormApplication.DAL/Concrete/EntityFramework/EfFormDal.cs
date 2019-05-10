using FormApplication.Common.DataAccess.EntityFramework;
using FormApplication.DAL.Abstract;
using FormApplication.Entities.ComplexTypes;
using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.DAL.Concrete.EntityFramework
{
    public class EfFormDal : EfEntityRepositoryBase<Form, EfDbContext>, IFormDal
    {
        public List<FormDetail> GetFormDetail()
        {
            using (EfDbContext context=new EfDbContext())
            {
                var result = from f in context.Forms
                             join u in context.Users
     on f.UserID equals u.UserID
                             select new FormDetail
                             {
                                 FormId = f.FormID,
                                 Description = f.Description,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 UserName = u.UserName,
                                 Age = f.Age,
                                 FormName = f.FormName
                             };
                return result.ToList();
            } 
        }
    }
}
