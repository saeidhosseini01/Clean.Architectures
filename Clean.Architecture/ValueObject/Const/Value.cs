namespace Clean.Architecture.Domain.ValueObject.Const
{
    public record Value  (string value) {
     public static implicit operator string (Value value) => value.value;
    }
    
}
