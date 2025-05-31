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
    public class ConstDto : GenericDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("constTypeId")]
        public int ConstTypeId { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }

 
        public ConstDto(Guid id, string description, bool isActive, string name, string key,
            int constTypeId, int order)
            : base(id, description, isActive)
        {
            Name = name;
            Key = key;
            ConstTypeId = constTypeId;
            Order = order;
        }

 
        public ConstDto() : base(Guid.Empty, string.Empty, true)
        {
            Name = string.Empty;
            Key = string.Empty;
        }
    }



}
