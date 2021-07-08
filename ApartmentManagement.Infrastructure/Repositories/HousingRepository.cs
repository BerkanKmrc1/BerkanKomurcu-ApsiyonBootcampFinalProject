using ApartmentManagement.Domain.Interfaces;
using ApartmentManagement.Domain.Models;
using ApartmentManagement.Infrastructure.Context;
using ApartmentManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Infrastructure.Repositories
{
    public class HousingRepository : Repository<Housing>, IHousingRepository
    {
        public HousingRepository(ApartmentDbContext context): base(context)
        {

        }
    }
}
