using FormApplication.Business.ValidationRules.FluentValidation;
using FormApplication.DAL.Abstract;
using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormApplication.Common.Aspects.Postsharp;
using FormApplication.Common.Aspects.Postsharp.ValidationAspects;

namespace FormApplication.Business.Concrete
{
    public class FormService
    {

        private IFormDal _formDal;

        public FormService(IFormDal formDal)
        {
            _formDal = formDal;
        }


        public List<Form> GetAll()
        {
            return _formDal.GetList();

        }

        public Form GetById(int id)
        {
            return _formDal.Get(p => p.FormID == id);
        }

        [FluentValidationAspect(typeof(FormValidation))]
        public Form Add(Form form)
        {
            return _formDal.Add(form);
        }

        [FluentValidationAspect(typeof(FormValidation))]
        public Form Update(Form form)
        {
            return _formDal.Update(form);
        }

    }
}
