using FormApplication.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Entities.Concrete
{
    public class Form:IEntity
    {
        public int FormID { get; set; }
        public string FormName { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
