﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Dtos.Cars;
using Turo.Application.Interfaces;
using Turo.Domain.Entities;

namespace Turo.Application.Services.CarService
{
    public interface  ICarService : IBaseService<Car,CreateCarDTo,UpdateCarDTo,CarDto>
    {
    }
}
