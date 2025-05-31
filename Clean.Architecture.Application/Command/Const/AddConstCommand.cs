using Clean.Architecture.Application.Dtos.Common;
using Clean.Architecture.Domain.ValueObject.Const;
using Clean.Architecture.Domain.ValueObject.Genaric;
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
