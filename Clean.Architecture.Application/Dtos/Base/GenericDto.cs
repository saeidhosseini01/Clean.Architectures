using Clean.Architecture.Domain.ValueObject.Genaric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Dtos.Base
{
    public class GenericDto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }
        public GenericDto(Guid id, string description, bool isDeleted)
        {
            Id = id;
            Description = description;
            IsDeleted = isDeleted;
        }
    }
}
