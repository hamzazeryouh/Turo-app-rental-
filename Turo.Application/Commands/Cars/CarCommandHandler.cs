using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Application.Commands.Cars
{
    public class CarCommandHandler : IRequestHandler<CarCommand>
    {
        public Task<Unit> Handle(CarCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
