using Clean.Architecture.Application.Dtos.Base;
using Clean.Architecture.Domain.ValueObject.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Dtos.Common
{
    public  class ConstDto: GenericDto
    {
        public ConstDto(Name name, Key key, ConstTypeId constTypeId, Order order)
        {
            Id=id;
            Description = description;
            Name = name;
            Key = key;
            ConstTypeId = constTypeId;
            Order = order;
        }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("key")]
        public string Key { get; set; }
        [JsonPropertyName("constTypeId")]
        public int ConstTypeId { get; set; } 
        [JsonPropertyName("order")]
        public int Order { get; set; } 
    }
}
