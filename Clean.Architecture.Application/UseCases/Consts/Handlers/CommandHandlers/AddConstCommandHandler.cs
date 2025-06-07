using AutoMapper;

using Clean.Architecture.Application.UseCases.Consts.Commands;
using Clean.Architecture.Application.UseCases.Consts.Dtos;
using Clean.Architecture.Domain.Entities.Common;
using Clean.Architecture.Domain.Interfaces.Consts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.UseCases.Consts.Handlers.CommandHandlers
{
    public class AddConstCommandHandler : IRequestHandler<AddConstCommand, ConstDto>
    {
        private readonly IConstRepository _constRepository;
        private readonly IMapper _mapper;

        public AddConstCommandHandler(IConstRepository constRepository,IMapper mapper)
        {
            _constRepository = constRepository;
            _mapper = mapper;
        }
        public async Task<ConstDto> Handle(AddConstCommand request, CancellationToken cancellationToken)
        {
           if(request is null)
            {

            }
            Const Entity = new Const
            {
                Description = request.Description,
                Key = request.Key,
                Name = request.Name,
                Order = request.Order,

            };
            await _constRepository.AddConstAsync(Entity, cancellationToken);
            return _mapper.Map<ConstDto>(Entity);
        }
    }
}
