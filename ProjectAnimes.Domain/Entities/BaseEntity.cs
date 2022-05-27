namespace ProjectAnimes.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public abstract bool Validate();
    }
}
