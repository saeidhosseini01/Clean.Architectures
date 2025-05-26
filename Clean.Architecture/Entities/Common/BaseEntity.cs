namespace Clean.Architecture.Domain.Entities.Common
{
    public abstract record BaseEntity: GenericEntity
    {
    
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int CreateBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdateBy { get; set; }
    }
    }
