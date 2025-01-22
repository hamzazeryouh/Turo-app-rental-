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
using Turo.Application.Validators;


namespace Turo.Application.Commands.Cars
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, bool>
    {
        private readonly ICarService _carService;
        private readonly ILogger<CreateCarCommandHandler> _logger;
        private readonly ITranslationService _translationService;
        private readonly IValidator<CreateCarCommand> _validator;
        public CreateCarCommandHandler(IValidator<CreateCarCommand> validator, ICarService carService, ILogger<CreateCarCommandHandler> logger, ITranslationService translationService)
        {
            _carService = carService;
            _logger = logger;
            _translationService = translationService;
            _validator = validator;
        }

        public async Task<bool> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);
                if (!validationResult.IsValid)
                {
                    throw new ValidationException(validationResult.Errors);
                }
                // Log the incoming request
                _logger.LogInformation($"Creating a new car: {request.CreateEntity.Make} {request.CreateEntity.Model} ({request.CreateEntity.Year})");

                // Validate input data (this is a simple example, but could be expanded for more robust validation)
                if (string.IsNullOrEmpty(request.CreateEntity.Make) || string.IsNullOrEmpty(request.CreateEntity.Model) || request.CreateEntity.Year <= 0)
                {
                    throw new ArgumentException("Invalid car data");
                }

                // Map request to Car entity


                // Use the car service to create the car
                var createdCar = await _carService.CreateAsync(request.CreateEntity);

                // Log successful creation
                _logger.LogInformation($"Car created successfully: {request.CreateEntity.Make} {request.CreateEntity.Model} ({request.CreateEntity.Year})");

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
