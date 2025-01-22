using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Commands.Cars;
using Turo.Application.Services;

namespace Turo.Application.Validators
{
    public class ValidatorCreateCarCommand : AbstractValidator<CreateCarCommand>
    {
        private readonly ITranslationService _translationService;

        public ValidatorCreateCarCommand(ITranslationService translationService)
        {
            _translationService = translationService;

            RuleFor(car => car.CreateCarDTo!.Make)
                .NotEmpty().WithMessage(_ => _translationService.GetTranslation("MakeRequired"))
                .MaximumLength(50).WithMessage(_ => _translationService.GetTranslation("MakeMaxLength"));

            RuleFor(car => car.CreateCarDTo!.Model)
                .NotEmpty().WithMessage(_ => _translationService.GetTranslation("ModelRequired"))
                .MaximumLength(50).WithMessage(_ => _translationService.GetTranslation("ModelMaxLength"));

            RuleFor(car => car.CreateCarDTo!.VIN)
                .NotEmpty().WithMessage(_ => _translationService.GetTranslation("VINRequired"))
                .Matches(@"^[A-HJ-NPR-Z0-9]{17}$").WithMessage(_ => _translationService.GetTranslation("VINFormat"));

            RuleFor(car => car.CreateCarDTo!.Year)
                .NotNull().WithMessage(_ => _translationService.GetTranslation("YearRequired"))
                .InclusiveBetween(1886, DateTime.UtcNow.Year)
                .WithMessage(_ => _translationService.GetTranslation("YearRange"));

            RuleFor(car => car.CreateCarDTo!.LicensePlate)
                .NotEmpty().WithMessage(_ => _translationService.GetTranslation("LicensePlateRequired"))
                .MaximumLength(10).WithMessage(_ => _translationService.GetTranslation("LicensePlateMaxLength"));

            RuleFor(car => car.CreateCarDTo!.PricePerDay)
                .GreaterThan(0).WithMessage(_ => _translationService.GetTranslation("PricePerDayMin"));

            RuleFor(car => car.CreateCarDTo!.Mileage)
                .GreaterThanOrEqualTo(0).WithMessage(_ => _translationService.GetTranslation("MileageMin"));

            RuleFor(car => car.CreateCarDTo!.Seats)
                .InclusiveBetween(1, 10).WithMessage(_ => _translationService.GetTranslation("SeatsRange"));

            RuleFor(car => car.CreateCarDTo!.Latitude)
                .InclusiveBetween(-90, 90).WithMessage(_ => _translationService.GetTranslation("LatitudeRange"));

            RuleFor(car => car.CreateCarDTo!.Longitude)
                .InclusiveBetween(-180, 180).WithMessage(_ => _translationService.GetTranslation("LongitudeRange"));
        }
    }
}
