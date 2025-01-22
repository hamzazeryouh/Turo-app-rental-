using FluentValidation;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using Turo.Application.Services.CarService;
using Turo.Application.Services;
using MediatR;

namespace Turo.Application.Commands.Cars
{
    public class UpdateEntityCommandHandler : IRequestHandler<UpdateCarCommand, bool>
    {
        private readonly ICarService _carService;
        private readonly ILogger<UpdateEntityCommandHandler> _logger;
        private readonly ITranslationService _translationService;
        private readonly IValidator<UpdateCarCommand> _validator;

        public UpdateEntityCommandHandler(IValidator<UpdateCarCommand> validator, ICarService carService, ILogger<UpdateEntityCommandHandler> logger, ITranslationService translationService)
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
                // Validate request
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);
                if (!validationResult.IsValid)
                {
                    throw new ValidationException(validationResult.Errors);
                }

                if (string.IsNullOrEmpty(request.UpdateEntity.Make) || string.IsNullOrEmpty(request.UpdateEntity.Model) || request.UpdateEntity.Year <= 0)
                {
                    throw new ArgumentException("Invalid car data");
                }

                // Log the incoming request after validation
                _logger.LogInformation($"Updating car: {request.UpdateEntity.Make} {request.UpdateEntity.Model} ({request.UpdateEntity.Year})");

                // Use the car service to update the car
                var updatedCar = await _carService.UpdateAsync(request.UpdateEntity);

                // Log successful update
                _logger.LogInformation($"Car updated successfully: {request.UpdateEntity.Make} {request.UpdateEntity.Model} ({request.UpdateEntity.Year})");

                return updatedCar;
            }
            catch (ArgumentException ex)
            {
                _logger.LogError($"Validation error while updating car: {ex.Message}");
                throw new ValidationException(_translationService.GetTranslation("InvalidCarData"));
            }
            catch (Exception ex)
            {
                _logger.LogError($"An unexpected error occurred while updating the car: {ex}");
                throw; // Preserve original exception details
            }
        }
    }
}
