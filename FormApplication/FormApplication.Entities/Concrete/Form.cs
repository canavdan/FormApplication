using FormApplication.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Entities.Concrete
{
    public class Form:IEntity
    {
        public int FormID { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string FormName { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
