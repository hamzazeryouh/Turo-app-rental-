using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Dtos.Cars;
using Turo.Application.Interfaces;
using Turo.Domain.Entities;

namespace Turo.Infrastructure.Services.CarService
{
    public interface  ICarService : IBaseService<CreateCarDTo,UpdateCarDTo,CarDto>
    {
    }
}
