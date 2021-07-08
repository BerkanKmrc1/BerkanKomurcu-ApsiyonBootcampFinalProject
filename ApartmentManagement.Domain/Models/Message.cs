using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string Desctiption { get; set; }
        public User User  { get; set; }//bir mesaj bir kullanıcıya ait olabilir
        public int MyProperty { get; set; }
    }
}
