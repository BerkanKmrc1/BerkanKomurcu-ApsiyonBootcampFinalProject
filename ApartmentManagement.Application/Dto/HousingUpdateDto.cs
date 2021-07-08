using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Dto
{
    public class HousingUpdateDt
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public HousingAddDto User { get; set; }
    }
}
