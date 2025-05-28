namespace Clean.Architecture.Domain.ValueObject.Genaric
{
    public record IsDeleted(bool value)
    {
        public static implicit operator bool(IsDeleted isDeleted )=>isDeleted.value;
    }
}
