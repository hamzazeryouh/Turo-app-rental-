namespace Turo.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Turo.Application.Helpers;
    using Turo.Application.Services;
    using Turo.Application.Commands;

    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<TEntity, TGetAllQuery, TGetByIdQuery, TCreateCommand, TUpdateCommand, TDeleteCommand>
    : ControllerBase
    where TEntity : class
    where TGetAllQuery : IRequest<IEnumerable<TEntity>>
    where TGetByIdQuery : IRequest<TEntity>
    where TCreateCommand : IRequest<int>
    where TUpdateCommand : IRequest<TEntity>
    where TDeleteCommand : IRequest<bool>
    {
        private readonly ITranslationService _translationService;
        private readonly IMediator _mediator;

        public BaseController(ITranslationService translationService, IMediator mediator)
        {
            _translationService = translationService;
            _mediator = mediator;
        }

        // GET api/[controller]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(Activator.CreateInstance<TGetAllQuery>());
            return Ok(new Response<IEnumerable<TEntity>>(result, 200, _translationService.GetTranslation("Success")));
        }

        // GET api/[controller]/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            // Set the Id dynamically using reflection
            var query = Activator.CreateInstance<TGetByIdQuery>();
            query.GetType().GetProperty("Id")?.SetValue(query, id);

            var result = await _mediator.Send(query);
            if (result == null)
                return NotFound(new Response<object>(_translationService.GetTranslation("NotFound"), 404));

            return Ok(new Response<TEntity>(result, 200, _translationService.GetTranslation("Success")));
        }

        // POST api/[controller]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TEntity entity)
        {
            var command = Activator.CreateInstance<TCreateCommand>();
            if (command is TCreateCommand createCommand)
            {
                // Assuming TCreateCommand has a property for the entity to create
                createCommand.GetType().GetProperty("Entity")?.SetValue(createCommand, entity);
                var result = await _mediator.Send(createCommand);
                return CreatedAtAction(nameof(GetById), new { id = result }, new Response<TEntity>(entity, 201, _translationService.GetTranslation("Created")));
            }

            return BadRequest();
        }

        // PUT api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TEntity entity)
        {
            var command = Activator.CreateInstance<TUpdateCommand>();
            if (command is TUpdateCommand updateCommand)
            {
                // Assuming TUpdateCommand has an Id and Entity property
                updateCommand.GetType().GetProperty("Id")?.SetValue(updateCommand, id);
                updateCommand.GetType().GetProperty("Entity")?.SetValue(updateCommand, entity);

                var result = await _mediator.Send(updateCommand);
                if (result == null)
                    return NotFound(new Response<object>(_translationService.GetTranslation("NotFound"), 404));

                return Ok(new Response<TEntity>(result, 200, _translationService.GetTranslation("Updated")));
            }

            return BadRequest();
        }

        // DELETE api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = Activator.CreateInstance<TDeleteCommand>();
            if (command is TDeleteCommand deleteCommand)
            {
                deleteCommand.GetType().GetProperty("Id")?.SetValue(deleteCommand, id);

                var result = await _mediator.Send(deleteCommand);
                if (!result)
                    return NotFound(new Response<object>(_translationService.GetTranslation("NotFound"), 404));

                return Ok(new Response<object>(result, 200, _translationService.GetTranslation("Deleted")));
            }

            return BadRequest();
        }
    }

}
