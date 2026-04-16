using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Core.Commands;
using MediatR;

namespace ClearArchitecture.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command //IRequest
        {
            return _mediator.Send(command);
            
        }
    }
}
