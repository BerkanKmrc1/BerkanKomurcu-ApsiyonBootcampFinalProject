using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Models
{
    public class User : IdentityUser
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC{ get; set; }
        public virtual ICollection<Message> Messages { get; set; }// Bir kullanıcının birden fazla mesajı olabilir.
        public string Phone { get; set; }
        //public string Email { get; set; }//Identity User içerisinde mail var
        public string CarInfo { get; set; }

        public virtual ICollection<Housing> Housings { get; set; } //Bir kullanıcının birden fazla dairesi olabilir.
   
    }
}
