using ApartmentManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Infrastructure
{
    public interface IUnitofWork
    {
        IUserRepository User { get; }
        IDuesRepository Dues { get; }
        IBlocRepository Bloc { get; }
        IHousingRepository Housing { get; }
        IHousingTypeRepository HousingType { get; }
        IInvoiceRepository Invoice { get; }
        IMessageRepository Message { get; }

        Task<int> SaveChangesAsync();
    }
}
