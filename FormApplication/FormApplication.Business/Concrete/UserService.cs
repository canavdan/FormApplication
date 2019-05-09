using FormApplication.Business.Abstract;
using FormApplication.Business.ValidationRules.FluentValidation;
using FormApplication.Common.Aspects.Postsharp.ValidationAspects;
using FormApplication.DAL.Abstract;
using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Business.Concrete
{
   public class UserService : IUserService
    {
        private IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        
        public List<User> GetAll()
        {
            return _userDal.GetList();

        }

        public User GetById(int id)
        {
            return _userDal.Get(p => p.UserID == id);
        }

        [FluentValidationAspect(typeof(UserValidation))]
        public User Add(User user)
        {
            return _userDal.Add(user);
        }

        [FluentValidationAspect(typeof(UserValidation))]
        public User Update(User user)
        {
            return _userDal.Update(user);
        }

       
    }
}
