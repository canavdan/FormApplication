using FluentValidation;
using FormApplication.Business.ValidationRules.FluentValidation;
using FormApplication.Entities.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Business.Dependency.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<User>>().To<UserValidation>().InSingletonScope();
            Bind<IValidator<Form>>().To<FormValidation>().InSingletonScope();
        }
    }
}
