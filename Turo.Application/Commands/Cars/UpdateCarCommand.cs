﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Dtos.Cars;
using Turo.Domain.Entities;

namespace Turo.Application.Commands.Cars
{
    public class UpdateCarCommand : IRequest<int>
    {
        public string? Id { get; set; }
        public UpdateCarDTo? UpdateCar { get; set; }
    }
}