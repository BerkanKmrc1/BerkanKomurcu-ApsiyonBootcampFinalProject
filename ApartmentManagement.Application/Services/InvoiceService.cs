using ApartmentManagement.Domain.Models;
using ApartmentManagement.Infrastructure;
using AutoMapper;
using ApartmentManagement.Application.Dto;
using ApartmentManagement.Application.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IUnitofWork _unitofWork = null;
        private readonly IMapper _mapper;
        public InvoiceService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public async Task<List<UserDto>> Get(Expression<Func<UserDto, bool>> filter)
        {
           var dtoFilter =_mapper.Map<Expression<Func<Invoice, bool>>>(filter);

            var result = await _unitofWork.Invoice.Get(dtoFilter);
           
           return  _mapper.Map<List<UserDto>>(result);
        }

        public async Task<List<UserDto>> GetAll()
        {
            var result = await _unitofWork.Invoice.GetAll();

            return _mapper.Map<List<UserDto>>(result); ;
        }
    }
}
