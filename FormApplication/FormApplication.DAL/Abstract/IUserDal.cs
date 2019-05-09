using FormApplication.Common.DataAccess;
using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.DAL.Abstract
{
    public interface IUserDal :IEntityRepository<User>
    {
       
    }
}
