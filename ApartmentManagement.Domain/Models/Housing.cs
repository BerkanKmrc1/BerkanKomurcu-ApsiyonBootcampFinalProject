using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Models
{
    public class Housing
    {
        public int HousingId { get; set; }
        public string HousingName { get; set; }
        public string FloorNumber { get; set; }
        public ICollection<Dues> Dues { get; set; }//bir daireye ait birden fazla aidat olabilir
        public string HousingNo { get; set; }
        public virtual User User { get; set; }//Lazy loading kullanıcaz, Bir daire yalnızca bir kullanıcıya ait olabilir.
        public virtual Bloc Bloc { get; set; }//bir daire  bir blokta olabilir
        public virtual HousingType HousingType { get; set; }
        public string State { get; set; }//dolu, boş durumları 

        public ICollection<Invoice> Invoices { get; set; }//BİR dairede birden fazla fatura olabilir.
    }
}
