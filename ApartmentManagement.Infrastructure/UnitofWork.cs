using ApartmentManagement.Domain.Interfaces;
using ApartmentManagement.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Infrastructure
{
    public class UnitofWork : IUnitofWork
    {

        public IUserRepository User { get; }

        public IDuesRepository Dues { get; }

        public IBlocRepository Bloc { get; }

        public IHousingRepository Housing { get; }

        public IHousingTypeRepository HousingType { get; }

        public IInvoiceRepository Invoice { get; }

        public IMessageRepository Message { get; }

     
        private readonly ApartmentDbContext _context;

        public UnitofWork(ApartmentDbContext context, IUserRepository userRepository, IDuesRepository duesRepository, IBlocRepository blocRepository, IHousingRepository housingRepository
            , IHousingTypeRepository housingTypeRepository, IInvoiceRepository invoiceRepository, IMessageRepository messageRepository)
        {
            _context = context;
            User = userRepository;
            Dues = duesRepository;
            Bloc = blocRepository;
            Housing = housingRepository;
            HousingType = housingTypeRepository;
            Invoice = invoiceRepository;
            Message = messageRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
 
            return await _context.SaveChangesAsync();
        }
    }
}
