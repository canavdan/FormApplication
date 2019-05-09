using FormApplication.Common.DataAccess.EntityFramework;
using FormApplication.DAL.Abstract;
using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.DAL.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, EfDbContext>, IUserDal
    {

    }
}
