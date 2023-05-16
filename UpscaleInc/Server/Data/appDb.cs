using Microsoft.EntityFrameworkCore;
using upscaleInc.Shared;
using UpscaleInc.Shared;

namespace upscaleInc.Server.Data
{
    public class appDb: DbContext
    {

        public appDb(DbContextOptions<appDb> db) : base(db)
        {

        }
        public DbSet<user> users { get; set; }
        public DbSet<customer_reviews> customer_Reviews { get; set; }
        public DbSet<login> logins { get; set; }    
    }
}
