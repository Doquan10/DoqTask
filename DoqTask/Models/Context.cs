using Microsoft.EntityFrameworkCore;

namespace DoqTask.Models
{
    public class Context : DbContext
    {
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DGONCU;Initial Catalog=DoquTask;Integrated Security=True");
        }

        public DbSet<Task> Tasks { get; set; }

    }
}
