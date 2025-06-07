using AutoMapper;
using Clean.Architecture.Application.UseCases.ConstTypes.Dtos;
using Clean.Architecture.Application.UseCases.ConstTypes.Queris;
using Clean.Architecture.Domain.Interfaces.Consts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.UseCases.ConstTypes.Handlers.QueryHandlers
{
    public class GetConstTypeByIdQueryHandler : IRequestHandler<GetConstTypeByIdQuery, ConstTypeDto>
    {
        private readonly IConstTypeRepository _constTypeRepository;
        private readonly IMapper _mapper;

        public GetConstTypeByIdQueryHandler(IConstTypeRepository constTypeRepository,IMapper mapper)
        {
            _constTypeRepository = constTypeRepository ?? throw  new ArgumentNullException(nameof(constTypeRepository)) ;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<ConstTypeDto> Handle(GetConstTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = _constTypeRepository.GetConstTypeByIdAsync(request.guid, cancellationToken);
            return _mapper.Map<ConstTypeDto>(entity);
        }
    }
}
