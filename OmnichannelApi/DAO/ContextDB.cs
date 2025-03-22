using Microsoft.EntityFrameworkCore;
using OmnichannelApi.Model;

namespace OmnichannelApi.DAO
{
    public class ContextDB : DbContext
    {
        
       public DbSet<User> Users { get; set; }


        public ContextDB(DbContextOptions<ContextDB> opcoes) : base(opcoes)
        {


        }
    }
}
