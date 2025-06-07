using AutoMapper;
using Clean.Architecture.Application.Dtos.Common;
using Clean.Architecture.Application.Queries.Const;
using Clean.Architecture.Domain.Interfaces.Consts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.UseCases.Consts.Handlers.QueryHandlers
{
    public class GetConstByIdQueryHandler : IRequestHandler<GetConstByIdQuery, ConstDto>
    {
        private readonly IConstRepository _constRepository;
        private readonly IMapper _mapper;

        public GetConstByIdQueryHandler(IConstRepository constRepository,IMapper mapper)
        {
            _constRepository = constRepository ?? throw new ArgumentNullException(nameof(constRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ConstDto> Handle(GetConstByIdQuery request, CancellationToken cancellationToken)
        {
            var entity =await _constRepository.GetConstByIdAsync(request.id,cancellationToken);
            return _mapper.Map<ConstDto>(entity);
        }
    }
}
