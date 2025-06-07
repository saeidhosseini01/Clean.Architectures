using AutoMapper;

using Clean.Architecture.Application.UseCases.ConstTypes.Dtos;
using Clean.Architecture.Application.UseCases.ConstTypes.Queris;
using Clean.Architecture.Domain.Interfaces.Consts;
using MediatR;

namespace Clean.Architecture.Application.UseCases.ConstTypes.Handlers.QueryHandlers
{
    public class GetAllConstTypeQueryHandler : IRequestHandler<GetAllConstTypeQuery, List<ConstTypeDto>>
    {
        private readonly IConstTypeRepository _constTypeRepository;
        private readonly IMapper _mapper;

        public GetAllConstTypeQueryHandler(IConstTypeRepository constTypeRepository, IMapper mapper)
        {
            _constTypeRepository = constTypeRepository ?? throw new ArgumentNullException(nameof(_constTypeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<ConstTypeDto>> Handle(GetAllConstTypeQuery request, CancellationToken cancellationToken)
        {
            var entities = await _constTypeRepository.GetAllConstTypeAsync(cancellationToken);
            return _mapper.Map<List<ConstTypeDto>>(entities);
        }
    }
}
