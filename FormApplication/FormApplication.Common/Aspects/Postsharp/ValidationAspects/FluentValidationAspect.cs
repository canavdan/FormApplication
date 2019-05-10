using FluentValidation;
using FormApplication.Common.CrossCuttingConcerns.Validation.FluentValidation;
using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Common.Aspects.Postsharp.ValidationAspects
{
    [PSerializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }
        //Fonksiyona girer girmez çalışır
        public override void OnEntry(MethodExecutionArgs args)//Args çalıştırılan metodla ilgili bilgi alımını sağlar.
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            //Tüm argumanları gez veri tipini al
            var entities = args.Arguments.Where(t => t.GetType() == entityType);

            //Alınan argumanları foreach ile gez
            foreach (var entity in entities)
            {
                ValidatorTool.FluentValidate(validator, entity);
            }
        }
    }
}