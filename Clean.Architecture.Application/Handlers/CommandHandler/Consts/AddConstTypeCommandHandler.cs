using AutoMapper;
using Clean.Architecture.Application.Command.Const;
using Clean.Architecture.Application.Dtos.Common;
using Clean.Architecture.Domain.Entities.Common;
using Clean.Architecture.Domain.Interfaces.Consts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Handlers.CommandHandler.Consts
{
    public class AddConstTypeCommandHandler : IRequestHandler<AddConstTypeCommand, ConstTypeDto>

    {
        private readonly IConstTypeRepository _constTypeRepository;
        private readonly IMapper _mapper;

        public AddConstTypeCommandHandler(IConstTypeRepository constTypeRepository, IMapper mapper)
        {
            _constTypeRepository = constTypeRepository;
            _mapper = mapper;
        }

        public async Task<ConstTypeDto> Handle(AddConstTypeCommand request, CancellationToken cancellationToken)
        {
            if (request == null) { }

            ConstType entity = new ConstType
            {
                Description = request.Description,
                TypeTitle = request.TypeTitle,
                TypeId = request.TypeId
            };

            await _constTypeRepository.AddConstTypeAsync(entity, cancellationToken);
            return _mapper.Map<ConstTypeDto>(entity);
        }
    }
}
