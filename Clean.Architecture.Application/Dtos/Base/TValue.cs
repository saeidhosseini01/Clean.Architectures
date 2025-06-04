using Clean.Architecture.Domain.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Dtos.Base
{
    public class TValue<T> : IValueWrapper<T>
    {
        public T? Value { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? IntData { get; set; }
        public string? StringData { get; set; }

        public TValue() { }

        public TValue(T? value, string? title, string? description = null,
            int? intData = null, string? stringData = null)
        {
            Value = value;
            Title = title;
            Description = description;
            IntData = intData;
            StringData = stringData;
        }

        public TValue(T value, string title)
        {
            Value = value;
            Title = title;
        }
    }

}
