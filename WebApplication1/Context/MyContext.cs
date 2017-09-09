using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Table> Tables {get;set;}

        //public Context() : base("ExampleContext") { }
        public MyContext(DbContextOptions<MyContext> options) : base (options){}
    }
}
