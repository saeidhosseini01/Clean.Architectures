using Clean.Architecture.Application.Dtos.Common;
using Clean.Architecture.Domain.ValueObject.Const;
using MediatR;

namespace Clean.Architecture.Application.Command.Const
{
    public class UpdateConstCommand(Name name, Key key, Order order, Value value) : IRequest<ConstDtos>
    {
        public Name Name { get; set; } = name;
        public Key Key { get; set; } = key;
        public Order Order { get; set; } = order;
        public Value Value { get; set; } = value;
    }
}
