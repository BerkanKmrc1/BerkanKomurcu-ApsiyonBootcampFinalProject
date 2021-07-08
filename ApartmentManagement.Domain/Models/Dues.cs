using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Models
{
    public class Dues
    {
        public int DuesID { get; set; }
        public string DuesAmount { get; set; }
        public string Description { get; set; }
        public virtual Housing Housing { get; set; }//bir aidat bir dairee ait olabilir.
    }
}
