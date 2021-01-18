namespace Medex.Database
{
    public interface IRepository<Entity> where Entity : BaseEntity
    {
        public bool AddNew(Entity entity);

        public bool Delete(Entity entity);
    }
}
