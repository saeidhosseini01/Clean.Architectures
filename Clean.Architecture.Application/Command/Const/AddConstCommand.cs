using Clean.Architecture.Application.Dtos.Common;
using Clean.Architecture.Domain.ValueObject.Const;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Command.Const
{
    public class AddConstCommand(Name name, Key key, Order order, Value value) : IRequest<ConstDtos>
    {
        public Name Name { get; set; } = name;
        public Key Key { get; set; } = key;
        public Order Order { get; set; } = order;
        public Value Value { get; set; } = value;
    }
}
