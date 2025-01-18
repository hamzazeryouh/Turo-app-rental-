using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Services;
using Turo.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using Turo.Application.Services.CarService;
using FluentValidation;


namespace Turo.Application.Commands.Cars
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, int>
{
    private readonly ICarService _carService;
        private readonly ILogger<CreateCarCommandHandler> _logger;
        private readonly ITranslationService _translationService;

        public CreateCarCommandHandler(ICarService carService, ILogger<CreateCarCommandHandler> logger, ITranslationService translationService)
        {
            _carService = carService;
            _logger = logger;
            _translationService = translationService;
        }

        public async Task<int> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Log the incoming request
                _logger.LogInformation($"Creating a new car: {request.CreateCarDTo.Make} {request.CreateCarDTo.Model} ({request.CreateCarDTo.Year})");

                // Validate input data (this is a simple example, but could be expanded for more robust validation)
                if (string.IsNullOrEmpty(request.CreateCarDTo.Make) || string.IsNullOrEmpty(request.CreateCarDTo.Model) || request.CreateCarDTo.Year <= 0)
                {
                    throw new ArgumentException("Invalid car data");
                }

                // Map request to Car entity
               

                // Use the car service to create the car
                var createdCar = await _carService.CreateAsync(request.CreateCarDTo);

                // Log successful creation
                _logger.LogInformation($"Car created successfully: {request.CreateCarDTo.Make} {request.CreateCarDTo.Model} ({request.CreateCarDTo.Year})");

                return createdCar;
            }
            catch (ArgumentException ex)
            {
                // Log validation errors
                _logger.LogError($"Error in car creation: {ex.Message}");
                throw new ValidationException(_translationService.GetTranslation("InvalidCarData"));
            }
            catch (Exception ex)
            {
                // Log unexpected errors
                _logger.LogError($"An unexpected error occurred while creating the car: {ex.Message}");
                throw new Exception(_translationService.GetTranslation("UnexpectedError"));
            }
        }
    }
}
