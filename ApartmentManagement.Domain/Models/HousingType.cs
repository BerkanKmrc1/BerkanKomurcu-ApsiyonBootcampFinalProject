using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Models
{
    public class HousingType
    {
        public int HousingTypeId { get; set; }
        public string Description { get; set; }//2 + 1 , 3 + 1 gibi değerler gelicek, burası daha sonra enum da yapılabilir.
    }
}
