using FluentValidation;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Services.CarService;
using Turo.Application.Services;
using MediatR;

namespace Turo.Application.Commands.Cars
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand , bool>
    {
        private readonly ICarService _carService;
        private readonly ILogger<UpdateCarCommandHandler> _logger;
        private readonly ITranslationService _translationService;
        private readonly IValidator<UpdateCarCommand> _validator;
        public UpdateCarCommandHandler(IValidator<UpdateCarCommand> validator, ICarService carService, ILogger<UpdateCarCommandHandler> logger, ITranslationService translationService)
        {
            _carService = carService;
            _logger = logger;
            _translationService = translationService;
            _validator = validator;
        }

        public async Task<bool> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);
                if (!validationResult.IsValid)
                {
                    throw new ValidationException(validationResult.Errors);
                }
                // Log the incoming request
                _logger.LogInformation($"update a new car: {request.UpdateCar.Make} {request.UpdateCar.Model} ({request.UpdateCar.Year})");

                // Validate input data (this is a simple example, but could be expanded for more robust validation)
                if (string.IsNullOrEmpty(request.UpdateCar.Make) || string.IsNullOrEmpty(request.UpdateCar.Model) || request.UpdateCar.Year <= 0)
                {
                    throw new ArgumentException("Invalid car data");
                }

                // Map request to Car entity


                // Use the car service to create the car
                var createdCar = await _carService.UpdateAsync(request.UpdateCar);

                // Log successful creation
                _logger.LogInformation($"Car updated successfully: {request.UpdateCar.Make} {request.UpdateCar.Model} ({request.UpdateCar.Year})");

                return createdCar;
            }
            catch (ArgumentException ex)
            {
                // Log validation errors
                _logger.LogError($"Error in car update: {ex.Message}");
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
