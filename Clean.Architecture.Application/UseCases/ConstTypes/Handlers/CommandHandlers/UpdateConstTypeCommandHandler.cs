using AutoMapper;
using Clean.Architecture.Application.UseCases.ConstTypes.Commands;
using Clean.Architecture.Application.UseCases.ConstTypes.Dtos;
using Clean.Architecture.Domain.Entities.Common;
using Clean.Architecture.Domain.Exeptions.NotFount;
using Clean.Architecture.Domain.Interfaces.Consts;
using FluentResults;
using MediatR;

namespace Clean.Architecture.Application.UseCases.ConstTypes.Handlers.CommandHandlers
{
    public class UpdateConstTypeCommandHandler : IRequestHandler<UpdateConstTypeCommand, ConstTypeDto>
    {
        private readonly IConstTypeRepository _constTypeRepository;
        private readonly IMapper _mapper;

        public UpdateConstTypeCommandHandler(IConstTypeRepository constTypeRepository, IMapper mapper)
        {
            _constTypeRepository = constTypeRepository;
            _mapper = mapper;
        }

        public async Task<ConstTypeDto> Handle(UpdateConstTypeCommand request, CancellationToken cancellationToken)
        {
            ConstType res = await _constTypeRepository.GetConstTypeByIdAsync(request.Id, cancellationToken);
            if (res is null) {
                throw new NotFountEntityExeption();
            }
          
            res.TypeTitle = request.TypeTitle;
            res.Description = request.Description;
            res.TypeId = request.TypeId;
            var rest= _constTypeRepository.UpdateConstTypeAsync(res, cancellationToken);
            return _mapper.Map<ConstTypeDto>(_constTypeRepository.GetConstTypeByIdAsync(request.Id, cancellationToken));

        }
    }

}






