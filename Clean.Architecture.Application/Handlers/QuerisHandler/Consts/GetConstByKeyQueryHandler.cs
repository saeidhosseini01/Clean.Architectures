using AutoMapper;
using Clean.Architecture.Application.Dtos.Common;
using Clean.Architecture.Application.Queries.Const;
using Clean.Architecture.Domain.Interfaces.Consts;
using MediatR;

namespace Clean.Architecture.Application.Handlers.QuerisHandler.Consts
{
    public class GetConstByKeyQueryHandler : IRequestHandler<GetConstByKeyQuery, ConstDto>
    {
        private readonly IConstRepository _constRepository;
        private readonly IMapper _mapper;

        public GetConstByKeyQueryHandler(IConstRepository constRepository, IMapper mapper)
        {
            _constRepository = constRepository ?? throw new ArgumentNullException(nameof(constRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ConstDto> Handle(GetConstByKeyQuery request, CancellationToken cancellationToken)
        {
            var entity = await _constRepository.GetConstByKeyAsync(request.key, cancellationToken);
            return _mapper.Map<ConstDto>(entity);
        }
    }
}
