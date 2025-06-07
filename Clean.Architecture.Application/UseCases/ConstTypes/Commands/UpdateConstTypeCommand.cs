using Clean.Architecture.Application.UseCases.ConstTypes.Dtos;
using Clean.Architecture.Domain.ValueObject.ConstType;
using Clean.Architecture.Domain.ValueObject.Genaric;
using MediatR;

namespace Clean.Architecture.Application.UseCases.ConstTypes.Commands
{
    public class UpdateConstTypeCommand : IRequest<ConstTypeDto>
    {

        public TypeTitle TypeTitle { get; set; }
        public Description Description { get; set; }
        public Id Id { get; set; }
        public TypeId TypeId { get; set; }
        public UpdateConstTypeCommand (Id id,   TypeTitle typeTitle, Description descripton, TypeId typeId)
        {
            Id= id;
            TypeId = typeId;
            TypeTitle = typeTitle;
            Description = descripton;


        }
    }

}
