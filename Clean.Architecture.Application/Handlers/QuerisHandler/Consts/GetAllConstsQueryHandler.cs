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

namespace Clean.Architecture.Application.Handlers.QuerisHandler.Consts
{
    public class GetAllConstsQueryHandler : IRequestHandler<GetAllConstQuery, List<ConstDto>>
    {
        private readonly IConstRepository constRepository;
        private readonly IMapper mapper;

        public GetAllConstsQueryHandler(IConstRepository constRepository,IMapper mapper)
        {
            this.constRepository = constRepository ?? throw new ArgumentNullException(nameof(constRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<ConstDto>> Handle(GetAllConstQuery request, CancellationToken cancellationToken)
        {
            var entities = await constRepository.GetAllConstAsync(cancellationToken);
            return mapper.Map<List<ConstDto>>(entities);
        }
    }
}
