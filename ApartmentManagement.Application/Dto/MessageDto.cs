using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Dto
{
    public class MessageDto
    {
        public int Id { get; set; }
        public  UserDto User { get; set; }
        public string Name { get; set; }

    }
}
