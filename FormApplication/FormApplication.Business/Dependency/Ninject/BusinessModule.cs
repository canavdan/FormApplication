using FormApplication.Business.Abstract;
using FormApplication.Business.Concrete;
using FormApplication.DAL.Abstract;
using FormApplication.DAL.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Business.Dependency.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>();
            Bind<IFormService>().To<FormService>().InSingletonScope();
            Bind<IFormDal>().To<EfFormDal>();

            Bind<EfDbContext>().To<EfDbContext>();
         
        }
    }
}
