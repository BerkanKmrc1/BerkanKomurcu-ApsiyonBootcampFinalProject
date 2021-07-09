using ApartmentManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Interfaces
{
    public interface IBlocRepository : IRepository<Bloc>
    {
        Task Get(bool dtoFilter);
    }
}
