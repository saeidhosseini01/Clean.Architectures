namespace Clean.Architecture.Domain.ValueObject.Const
{
    public record ConstTypeId (int value)
    {
         public static implicit operator int (ConstTypeId value) => value.value;
    }
    
}
