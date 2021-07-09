
using ApartmentManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Interfaces
{
    public interface IBlockService
    {
        Task Add(BlockAddDto entity);
        void Delete(int id);
        void Update(HousingUpdateDto entity);
        Task<List<BlockViewDto>> GetAll();
        Task<List<BlockViewDto>> Get(Expression<Func<BlockViewDto, bool>> filter);

    }
}
