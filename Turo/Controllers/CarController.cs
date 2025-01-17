﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Turo.Application.Commands.Cars;
using Turo.Application.Dtos.Cars;
using Turo.Application.Queries.Car;
using Turo.Application.Queries.Cars;
using Turo.Application.Services;

namespace Turo.Controllers.cars
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : BaseController<CarDto, GetAllCarsQuery, GetByIdCarQuery, CreateCarCommand, UpdateCarCommand, DeleteCarCommand>
    {
        public CarController(ITranslationService translationService, IMediator mediator) : base(translationService, mediator)
        {
        }
    }
}
