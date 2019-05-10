using FluentValidation;
using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Business.ValidationRules.FluentValidation
{
    public class FormValidation : AbstractValidator<Form>
    {
        public FormValidation()
        {
            RuleFor(p => p.FormID).NotEmpty();
            RuleFor(p => p.FormName).NotEmpty().WithMessage("Kullanıcı adı boş kalamaz");
            RuleFor(p => p.Description);
            RuleFor(p => p.UserID).NotEmpty();
            RuleFor(p => p.Name).NotEmpty().WithMessage("İsim boş kalamaz");
            RuleFor(p => p.Surname).NotEmpty().WithMessage("Soyisim boş kalamaz");
            RuleFor(p => p.Age);
            
        }

    }

}
