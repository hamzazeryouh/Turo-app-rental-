namespace Turo.Application.Services.CarService
{
    using AutoMapper;
    using Turo.Application.Dtos.Cars;
    using Turo.Infrastructure.UnitOfWork;
    using Turo.Domain.Entities;
    using Turo.Infrastructure.Repository.Base;

    public class CarService : BaseService<Car, CreateCarDTo, UpdateCarDTo, CarDto>, ICarService
    {
        public CarService(IGenericRepository<Car> repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }
    }
}
