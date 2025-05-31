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
    public class AddConstCommand : IRequest<ConstDto>
    {
        public Name Name { get; set; }
        public Key Key { get; set; }
        public Order Order { get; set; }
        public Value Value { get; set; }

        public AddConstCommand(Name name, Key key, Order order, Value value)
        {
            Name = name;
            Key = key;
            Order = order;
            Value = value;
        }
    }

}
