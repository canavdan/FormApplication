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
using FormApplication.Business.Abstract;
using System.Transactions;
using FormApplication.Common.Aspects.Postsharp.CacheAspects;
using FormApplication.Common.CrossCuttingConcerns.Caching.Memory;
using FormApplication.Entities.ComplexTypes;

namespace FormApplication.Business.Concrete
{
    public class FormService:IFormService
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
       // [CacheRemoveAspect("",typeof(MemoryCacheManager))]
        public Form Add(Form form)
        {
            return _formDal.Add(form);
        }

        [FluentValidationAspect(typeof(FormValidation))]
        public Form Update(Form form)
        {
            return _formDal.Update(form);
        }

        public void TransactionOperation(Form f1,Form f2)
        {
            using (TransactionScope scope=new TransactionScope())
            {
                try
                {
                    _formDal.Add(f1);
                    _formDal.Add(f2);
                    scope.Complete();
                }
                catch(Exception e)
                {
                    scope.Dispose();
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public List<FormDetail> GetFormDetail()
        {
            return _formDal.GetFormDetail();
        }

        public void Delete(Form form)
        {
            _formDal.Delete(form);
        }
    }
}
