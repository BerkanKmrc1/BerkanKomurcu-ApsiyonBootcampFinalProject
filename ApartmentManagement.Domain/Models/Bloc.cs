using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Models
{
    public class Bloc
    {
        public int BlocID { get; set; }
        public int BlockName { get; set; }
        public virtual ICollection<Housing> Housings { get; set; } //Bir blokta birden fazla daire olabilir
    }
}
