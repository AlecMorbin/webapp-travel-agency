using Microsoft.EntityFrameworkCore;
using Test_Tecnico_MVC___Web_API.Models;

namespace Test_Tecnico_MVC___Web_API.Data
{
    public class AgenziaContext : DbContext
    {
        public DbSet<Package> Viaggi { get; set; }
        public DbSet<MessageOb> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=AgenziaViaggi;Integrated Security=True");
        }
    }
}
