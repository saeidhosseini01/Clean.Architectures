using Clean.Architecture.Domain.ValueObject.ConstType;
using System.Text.Json.Serialization;





namespace Clean.Architecture.Application.UseCases.ConstTypes.Dtos
{
    public class ConstTypeDto(TypeTitle typeTitle,TypeId typeId)
    {
        [JsonPropertyName("typeTitle")]
        public string TypeTitle{ get; set; }=typeTitle;
        public  int TypeId { get; set; }=typeId;

    }
}
