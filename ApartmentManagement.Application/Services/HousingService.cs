using ApartmentManagement.Application.Dto;
using ApartmentManagement.Application.Interfaces;
using ApartmentManagement.Domain.Models;
using ApartmentManagement.Infrastructure;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Services
{
    public class HousingService : IHousingService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public HousingService(IUnitofWork unitofWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task Add(Housing entity)
        {
            await _unitofWork.Housing.Add(_mapper.Map<Housing>(entity));
            await _unitofWork.Housing.Add(_mapper.Map<Housing>(entity));
            await _unitofWork.Housing.Add(_mapper.Map<Housing>(entity));
            await _unitofWork.Housing.Add(_mapper.Map<Housing>(entity));
            await _unitofWork.Housing.Add(_mapper.Map<Housing>(entity));
            await _unitofWork.Housing.Add(_mapper.Map<Housing>(entity));
            await _unitofWork.Housing.Add(_mapper.Map<Housing>(entity));

            await _unitofWork.SaveChangesAsync();
        }

        public Task Add(HousingAddDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<HousingAddDto>> Get(Expression<Func<HousingAddDto, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<HousingAddDto>> Get(Expression<Func<HousingAddDto, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<HousingAddDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(HousingUpdateDto entity)
        {
            throw new NotImplementedException();
        }

        Task<List<HousingAddDto>> IHousingService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
