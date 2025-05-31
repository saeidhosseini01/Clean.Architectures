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
    public class UpdateConstCommandHandler:IRequestHandler<UpdateConstCommand,ConstDto>
    {
        private readonly IConstRepository _constRepository;
        private readonly IMapper _mapper;

        public UpdateConstCommandHandler(IConstRepository constRepository,IMapper mapper)
        {
        _constRepository = constRepository;
         _mapper = mapper;
        }

        public async Task<ConstDto> Handle(UpdateConstCommand request, CancellationToken cancellationToken)
        {
            Const res =await  _constRepository.GetConstByIdAsync(request.Id, cancellationToken);
            if(res is null) { }
            res.Order=request.Order;
            res.Name=request.Name;
            res.Description=request.Description;    
            res.Key=request.Key;
            await _constRepository.UpdateConstAsync(res, cancellationToken);
            return _mapper.Map<ConstDto>( _constRepository.GetConstByIdAsync(request.Id, cancellationToken));

        }
    }
}
