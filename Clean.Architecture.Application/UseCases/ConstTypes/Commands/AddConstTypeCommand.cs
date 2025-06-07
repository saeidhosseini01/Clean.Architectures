using Clean.Architecture.Application.Dtos.Common;
using Clean.Architecture.Domain.ValueObject.ConstType;
using Clean.Architecture.Domain.ValueObject.Genaric;
using MediatR;

namespace Clean.Architecture.Application.Command.Const
{
    public class AddConstTypeCommand : IRequest<ConstTypeDto>
    {

        public TypeTitle TypeTitle { get; set; }
        public Description Description { get; set; }

        public TypeId TypeId { get; set; }
        public AddConstTypeCommand(TypeTitle typeTitle , Description descripton,TypeId typeId)
        {
            TypeId = typeId;
            TypeTitle = typeTitle;
            Description=descripton;
           
                
        }
    }

}
