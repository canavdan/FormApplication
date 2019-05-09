using FormApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Business.Abstract
{
    interface IFormService
    {
        List<Form> GetAll();
        Form GetById(int id);
        Form Add(Form form);
        Form Update(Form form);
    }
}
