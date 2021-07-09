using ApartmentManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Interfaces
{
    public interface IHousingService
    {
        Task Add(HousingAddDto entity);
        void Delete(int id);
        void Update(HousingUpdateDto entity);
        Task<List<HousingAddDto>> GetAll();
        Task<List<HousingAddDto>> Get(Expression<Func<HousingAddDto, bool>> filter);

    }
}
