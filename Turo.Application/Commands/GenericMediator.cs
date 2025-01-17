using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Application.Commands
{
    using MediatR;
    using System.Collections.Generic;

    public class GetAllQuery<TEntity> : IRequest<IEnumerable<TEntity>> where TEntity : class { }

    public class GetByIdQuery<TEntity> : IRequest<TEntity> where TEntity : class
    {
        public int Id { get; set; }
    }

    public class CreateCommand<TEntity> : IRequest<TEntity> where TEntity : class
    {
        public TEntity Entity { get; set; }
    }

    public class UpdateCommand<TEntity> : IRequest<TEntity> where TEntity : class
    {
        public int Id { get; set; }
        public TEntity Entity { get; set; }
    }

    public class DeleteCommand<TEntity> : IRequest<bool> where TEntity : class
    {
        public int Id { get; set; }
    }

}
