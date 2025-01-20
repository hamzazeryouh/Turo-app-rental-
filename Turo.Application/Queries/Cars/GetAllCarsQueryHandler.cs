using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Commands;
using Turo.Application.Dtos.Cars;

namespace Turo.Application.Queries.Car
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.Extensions.Logging;
    using FluentValidation;
    using AutoMapper;
    using global::Turo.Application.Queries.Cars;
    using global::Turo.Application.Services.CarService;

    namespace Turo.Application.Handlers.Cars
    {
        public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<CarDto>>
        {
            private readonly ICarService _carService;
            private readonly ILogger<GetAllCarsQueryHandler> _logger;
            private readonly IMapper _mapper;

            public GetAllCarsQueryHandler(ICarService carService, ILogger<GetAllCarsQueryHandler> logger, IMapper mapper)
            {
                _carService = carService;
                _logger = logger;
                _mapper = mapper;
            }

            public async Task<IEnumerable<CarDto>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    
                    _logger.LogInformation("Fetching all cars from the database.");

                    // Fetch cars from the database
                    var cars = await _carService.GetAllAsync();

                    if (cars == null)
                    {
                        _logger.LogWarning("No cars found in the database.");
                        return new List<CarDto>();
                    }

                    // Map to CarDto
                    var carDtos = _mapper.Map<IEnumerable<CarDto>>(cars);

                    _logger.LogInformation($"Successfully retrieved {carDtos.Count()} cars.");

                    return carDtos;
                }
                catch (ValidationException ex)
                {
                    _logger.LogError($"Validation error in fetching cars: {ex.Message}");
                    throw;
                }
                catch (Exception ex)
                {
                    _logger.LogError($"An unexpected error occurred while fetching cars: {ex.Message}");
                    throw new Exception("An error occurred while retrieving the cars.");
                }
            }
        }
    }

}
