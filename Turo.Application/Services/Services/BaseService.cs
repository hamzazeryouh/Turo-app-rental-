

namespace Turo.Application.Services
{
    using AutoMapper;
    using Turo.Application.Interfaces;
    using Turo.Infrastructure.Repository.Base;
    using Turo.Infrastructure.UnitOfWork;

    public class BaseService<TEntity, TCreate, TUpdate, TViewModel>
  : IBaseService<TCreate, TUpdate, TViewModel>
  where TEntity : class
  where TCreate : IBaseCreateDTO
  where TUpdate : IBaseUpdateDTO
  where TViewModel : IBaseViewModel
    {
        protected readonly IGenericRepository<TEntity> _repository;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public BaseService(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<TViewModel> GetByIdAsync(string id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<TViewModel>(entity);
        }

        public async Task<IEnumerable<TViewModel>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TViewModel>>(entities);
        }

        public async Task<bool> CreateAsync(TCreate dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return  true;
        }

        public async Task<bool> UpdateAsync(TUpdate dto)
        {
            var entity = await _repository.GetByIdAsync((string)dto.GetType().GetProperty("Id").GetValue(dto));
            if (entity == null) return false;

            _mapper.Map(dto, entity);
            _repository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return false;

            _repository.Delete(entity);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
