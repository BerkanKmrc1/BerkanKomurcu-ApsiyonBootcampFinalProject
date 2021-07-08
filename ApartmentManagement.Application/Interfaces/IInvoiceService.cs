using ApartmentManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Interfaces
{
    public interface IInvoiceService
    {
        Task<List<UserDto>> GetAll();
        Task<List<UserDto>> Get(Expression<Func<UserDto, bool>> filter);
    }
}
