namespace Clean.Architecture.Domain.ValueObject.Const
{
    public record Key (string value)
    {
        public static implicit operator string(Key key) => key.value;
    }
    
}
