namespace Clean.Architecture.Domain.ValueObject.Const
{
    public record Order(int value)
    {
        public static implicit operator int(Order value) => value.value;
    }
    
}
