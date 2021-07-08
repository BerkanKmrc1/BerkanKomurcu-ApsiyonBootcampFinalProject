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
    public class HousingTypeRepository : Repository<HousingType>, IHousingTypeRepository
    {
        public HousingTypeRepository(ApartmentDbContext context) : base(context)
        {

        }
    }
}
