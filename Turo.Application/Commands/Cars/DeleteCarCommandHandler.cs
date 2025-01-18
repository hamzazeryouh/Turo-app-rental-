using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Services.CarService;
using Turo.Application.Services;
using MediatR;
using FluentValidation;

namespace Turo.Application.Commands.Cars
{
    internal class DeleteCarCommandHandler:IRequestHandler<DeleteCarCommand,bool>
    {
        private readonly ICarService _carService;
        private readonly ILogger<DeleteCarCommandHandler> _logger;
        private readonly ITranslationService _translationService;

        public DeleteCarCommandHandler(ICarService carService, ILogger<DeleteCarCommandHandler> logger, ITranslationService translationService)
        {
            _carService = carService;
            _logger = logger;
            _translationService = translationService;
        }

        public async Task<bool> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Log the incoming request
                _logger.LogInformation($"Deleting car with ID: {request.Id}");

                // Validate input data
                if (request.Id <= 0)
                {
                    throw new ArgumentException("Invalid car ID");
                }

                // Use the car service to delete the car
                var isDeleted = await _carService.DeleteAsync(request.Id);

                if (!isDeleted)
                {
                    throw new ArgumentException("Car not found or could not be deleted");
                }

                // Log successful deletion
                _logger.LogInformation($"Car with ID: {request.Id} deleted successfully");

                return true;
            }
            catch (ArgumentException ex)
            {
                // Log validation errors
                _logger.LogError($"Error in car deletion: {ex.Message}");
                throw new ValidationException(_translationService.GetTranslation("InvalidCarData"));
            }
            catch (Exception ex)
            {
                // Log unexpected errors
                _logger.LogError($"An unexpected error occurred while deleting the car: {ex.Message}");
                throw new Exception(_translationService.GetTranslation("UnexpectedError"));
            }
        }

    }
}
