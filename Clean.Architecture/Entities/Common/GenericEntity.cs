namespace Clean.Architecture.Domain.Entities.Common
{
    public abstract record GenericEntity
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public bool IsDeleted { get; set; } = false;
        public string Description { get; set; }
    }
    }
