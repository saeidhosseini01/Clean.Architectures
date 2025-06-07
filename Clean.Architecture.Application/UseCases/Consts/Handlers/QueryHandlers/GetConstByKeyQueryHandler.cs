using AutoMapper;
using Clean.Architecture.Application.Dtos.Base;
using Clean.Architecture.Application.Dtos.Common;
using Clean.Architecture.Application.Queries.Const;
using Clean.Architecture.Domain.Interfaces.Consts;
using MediatR;

namespace Clean.Architecture.Application.UseCases.Consts.Handlers.QueryHandlers
{
    public class GetConstByKeyQueryHandler : IRequestHandler<GetConstByKeyQuery, List<TValue<string>>>
    {
        private readonly IConstRepository _constRepository;
        private readonly IMapper _mapper;

        public GetConstByKeyQueryHandler(IConstRepository constRepository, IMapper mapper)
        {
            _constRepository = constRepository ?? throw new ArgumentNullException(nameof(constRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<TValue<string>>> Handle(GetConstByKeyQuery request, CancellationToken cancellationToken)
        {
            var entity = await _constRepository.GetConstByKeyAsync(request.key, cancellationToken);
            return _mapper.Map<List<TValue<string>>>(entity);
        }
    }
}
