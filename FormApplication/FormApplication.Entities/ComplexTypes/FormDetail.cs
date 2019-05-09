using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Entities.ComplexTypes
{
    public class FormDetail
    {
        public int FormId { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
