using Clean.Architecture.Application.Dtos.Common;
using Clean.Architecture.Domain.ValueObject.Const;
using Clean.Architecture.Domain.ValueObject.Genaric;

using MediatR;

namespace Clean.Architecture.Application.Command.Const
{
    public class UpdateConstCommand : IRequest<ConstDto>
    {

        public Name    Name { get; set; }  
        public Key     Key { get; set; }   
        public Order  Order { get; set; } 
        public Value  Value { get; set; } 
        public Description  Description { get; set; }
        public Guid Id { get; set; } 

        public UpdateConstCommand(Guid Id, Name name, Key key, Order order, Value value , Description description)
        {
            Name = name;
            Key = key;
            Order = order;
            Value = value;
            Description = description;
        }
    }
}
