namespace Turo.Infrastructure.Services.CarService
{
    using AutoMapper;
    using Turo.Application.Dtos.Cars;
    using Turo.Infrastructure.UnitOfWork;
    using Turo.Domain.Entities;
    public class CarService : BaseService<Car, CreateCarDTo, UpdateCarDTo, CarDto>, ICarService
    {
        public CarService(Repository.Base.IGenericRepository<Car> repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }
    }
}
