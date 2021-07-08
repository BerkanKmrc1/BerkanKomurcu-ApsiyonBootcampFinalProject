using ApartmentManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Interfaces
{
    public interface IMessageService
    {
        Task Add(MessageDto entity);
        void Delete(int id);
        void Update(MessageDto entity);
        Task<List<MessageDto>> GetAll();
        Task<List<MessageDto>> Get(Expression<Func<MessageDto, bool>> filter);

    }
}
