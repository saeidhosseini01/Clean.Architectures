using Clean.Architecture.Application.UseCases.Consts.Dtos;
using Clean.Architecture.Domain.ValueObject.Const;
using Clean.Architecture.Domain.ValueObject.Genaric;
using MediatR;

namespace Clean.Architecture.Application.UseCases.Consts.Commands

{
    public class AddConstCommand : IRequest<ConstDto>
    {
        public Name Name { get; set; }
        public Key Key { get; set; }
        public Order Order { get; set; }
        public Value Value { get; set; }
        public Description Description { get; set; }

        public AddConstCommand(Name name, Key key, Order order, Value value ,Description description)
        {
            Description = description;
            Name = name;
            Key = key;
            Order = order;
            Value = value;
        }
    }

}
