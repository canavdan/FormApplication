using FormApplication.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Entities.Concrete
{
    public class User: IEntity
    {
        //Eğer tablo ismi ile değişken ismi aynı ise bir şey yapmamıza gerek yok
        public int UserID { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string UserPassword { get; set; }
        public string UserMail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
