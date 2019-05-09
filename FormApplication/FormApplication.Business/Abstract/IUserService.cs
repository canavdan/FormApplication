using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        User Add(User product);
        User Update(User product);
    }
}
