using Microsoft.EntityFrameworkCore;

namespace OnlineShoping.API.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }
    }
}
