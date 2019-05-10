using FluentValidation;
using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Business.ValidationRules.FluentValidation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(p => p.UserID).NotEmpty();
            RuleFor(p => p.UserName).NotEmpty().WithMessage("Kullanıcı adı boş kalamaz");
            RuleFor(p => p.UserPassword).NotEmpty().WithMessage("Şifre boş kalamaz"); 
            RuleFor(p => p.UserMail).NotEmpty().WithMessage("Mail adresi boş kalamaz");
            RuleFor(p => p.FirstName);
            RuleFor(p => p.LastName);
            
        }

        //Deneme amaçlı
        /*private bool CustomVal(string arg)
        {
            return arg.EndsWith("Z");
        }*/

    }
}
