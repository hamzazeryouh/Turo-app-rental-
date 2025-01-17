using MediatR;
using Microsoft.AspNetCore.Mvc;
using Turo.Application.Commands.Cars;
using Turo.Application.Queries.Car;
using Turo.Application.Queries.Cars;
using Turo.Application.Services;
using Turo.Domain.Entities;

namespace Turo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : BaseController<Car, GetAllCarsQuery, GetByIdCarQuery, CreateCarCommand, UpdateCarCommand, DeleteCarCommand>
    {
        public CarController(ITranslationService translationService, IMediator mediator) : base(translationService, mediator)
        {
        }
    }
}
