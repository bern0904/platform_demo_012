namespace PlatformDemo.Core.Data.Repositories
{
    /// <summary>
    /// Main Repository class
    /// </summary>
    public abstract class Repository
    {
        public readonly LocalDbContext Context;

        public Repository(LocalDbContext dbContext)
        {
            Context = dbContext;
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }
    }
}
