using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Application.Commands.Cars
{
    public class DeleteCarCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
