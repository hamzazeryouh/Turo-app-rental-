using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Application.Dtos.Cars;

namespace Turo.Application.Queries.Cars
{
    public record GetAllCarsQuery : IRequest<IEnumerable<CarDto>> { }
}
