using Microsoft.EntityFrameworkCore;
using NewProject2022.Models;

namespace NewProject2022.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }
        public DbSet<Command> Commands { get; set; }
    }
}
