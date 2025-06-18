using Clean.Architecture.Domain.ValueObject.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Users.Dtos
{

    public class UserDto(Id id, Name name, Family family, Age age)
    {

        [JsonPropertyName("id")]
        public Guid Id { get; } = id;

        [JsonPropertyName("name")]
        public Name Name { get; } = name;


        [JsonPropertyName("family")]
        public Family Family { get; } = family;


        [JsonPropertyName("age")]
        public Age Age { get; } = age;
    }
}
