﻿using System.Threading.Tasks;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;

namespace CleanArch.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
