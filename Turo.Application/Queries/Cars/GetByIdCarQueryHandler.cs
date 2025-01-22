using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Dtos.Cars;
using Turo.Application.Services.CarService;

namespace Turo.Application.Queries.Car
{
    internal class GetByIdCarQueryHandler : IRequestHandler<GetByIdCarQuery, CarDto>
    {
        private readonly ICarService _carService;
        private readonly ILogger<GetByIdCarQueryHandler> _logger;
        private readonly IMapper _mapper;

        public GetByIdCarQueryHandler(ICarService carService, ILogger<GetByIdCarQueryHandler> logger, IMapper mapper)
        {
            _carService = carService;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<CarDto> Handle(GetByIdCarQuery request, CancellationToken cancellationToken)
        {
            try
            {

                _logger.LogInformation($"Fetching car details for ID: {request.Id}");

                // Fetch car from the database
                var car = await _carService.GetByIdAsync(request.Id);
                if (car == null)
                {
                    _logger.LogWarning($"Car with ID {request.Id} not found.");
                    throw new KeyNotFoundException($"Car with ID {request.Id} not found.");
                }

                // Map to CarDto
                var carDto = _mapper.Map<CarDto>(car);

                _logger.LogInformation($"Successfully retrieved car: {carDto.Make} {carDto.Model} ({carDto.Year})");

                return carDto;
            }
            catch (ValidationException ex)
            {
                _logger.LogError($"Validation error in fetching car by ID {request.Id}: {ex.Message}");
                throw;
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError($"An unexpected error occurred while fetching car ID {request.Id}: {ex.Message}");
                throw new Exception("An error occurred while retrieving the car.");
            }
        }
    }
}
