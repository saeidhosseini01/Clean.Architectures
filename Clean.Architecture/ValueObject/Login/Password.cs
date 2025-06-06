namespace Clean.Architecture.Domain.ValueObject.Login
{
    public record Password(string value)
    {
        public static implicit operator string(Password password)=> password.value;
    }
}
