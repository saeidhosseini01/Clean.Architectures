namespace Clean.Architecture.Domain.ValueObject.Genaric
{
    public record Description(string value)
    {
        public static implicit operator string(Description descripton)=>descripton.value;
    }
}
