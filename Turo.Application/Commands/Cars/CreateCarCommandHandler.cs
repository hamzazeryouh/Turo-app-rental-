using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Services;
using Turo.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Turo.Application.Commands.Cars
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Car>
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

        public async Task<Car> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Log the incoming request
                _logger.LogInformation($"Creating a new car: {request.Make} {request.Model} ({request.Year})");

                // Validate input data (this is a simple example, but could be expanded for more robust validation)
                if (string.IsNullOrEmpty(request.Make) || string.IsNullOrEmpty(request.Model) || request.Year <= 0)
                {
                    throw new ArgumentException("Invalid car data");
                }

                // Map request to Car entity
                var car = new Car
                {
                    Make = request.Make,
                    Model = request.Model,
                    Year = request.Year
                };

                // Use the car service to create the car
                var createdCar = await _carService.CreateCarAsync(car);

                // Log successful creation
                _logger.LogInformation($"Car created successfully: {createdCar.Make} {createdCar.Model} ({createdCar.Year})");

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
