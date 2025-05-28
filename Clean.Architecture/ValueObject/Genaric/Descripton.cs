namespace Clean.Architecture.Domain.ValueObject.Genaric
{
    public record Descripton(string value)
    {
        public static implicit operator string(Descripton descripton)=>descripton.value;
    }
}
