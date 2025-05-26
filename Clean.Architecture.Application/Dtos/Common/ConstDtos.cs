using Clean.Architecture.Domain.ValueObject.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Dtos.Common
{
    public  class ConstDtos(Name name,Key key,ConstTypeId constTypeId,Order order )
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }=name;
        [JsonPropertyName("key")]
        public string Key { get; set; }=key;
        [JsonPropertyName("constTypeId")]
        public int ConstTypeId { get; set; } = constTypeId;
        [JsonPropertyName("order")]
        public int Order { get; set; }  = order;
    }
}
