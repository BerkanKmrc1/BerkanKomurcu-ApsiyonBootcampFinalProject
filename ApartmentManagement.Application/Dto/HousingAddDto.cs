using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Dto
{
    public class HousingAddDto
    {
        public int HousingId { get; set; }
        public int HousingName { get; set; }
    }

    public class HousingUpdateDto
    {
        public int Id { get; set; }
        public int HousingId { get; set; }
        public int Name { get; set; }
    }

}
