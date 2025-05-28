namespace Clean.Architecture.Domain.ValueObject.ConstType
{
    public record TypeId(int value)
    {
        public static implicit operator int(TypeId typeId) => typeId.value;
    }

}
