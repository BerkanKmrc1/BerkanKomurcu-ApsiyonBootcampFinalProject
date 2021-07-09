using ApartmentManagement.Application.Dto;
using ApartmentManagement.Application.Interfaces;
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
    public class BlockService : IBlockService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public BlockService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        public Task Add(BlockAddDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BlockViewDto>> Get(Expression<Func<BlockViewDto, bool>> filter)
        {
            var dtoFilter = _mapper.Map<Expression<Func<BlockViewDto>, bool>>>(filter);

            var result = await _unitofWork.Bloc.Get(dtoFilter);

            return _mapper.Map<List<BlockViewDto>>(result);
        }

        public Task<List<BlockViewDto>> Get(Expression<Func<BlockViewDto, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BlockViewDto>> GetAll()
        {
            var result = await _unitofWork.Bloc.GetAll();
            return _mapper.Map<List<BlockViewDto>>(result);
        }

        public async Task<BlockViewDto> GetById(int id)
        {
            var result = (await _unitofWork.Bloc.Get(x => x.BlocID == id)).FirstOrDefault();
            if(result != null)
            {
                return _mapper.Map<BlockViewDto>(result);
            }
            return null;
        }

        public void Update(HousingUpdateDto entity)
        {
            throw new NotImplementedException();
        }

        Task<List<BlockViewDto>> IBlockService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
