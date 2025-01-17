using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Dtos.Cars;

namespace Turo.Application.Commands.Cars
{
    public class CreateCarCommand : IRequest<int>
    {
        public CreateCarDTo? CreateCarDTo { get; set; }
    }
}
