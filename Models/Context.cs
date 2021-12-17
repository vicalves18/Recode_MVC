using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace Recode_MVC.Models
{
  public class Context : DbContext
  {
    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(connectionString: "Data Source=DESKTOP-0H94BHG;Initial Catalog=Viagens; Integrated Security=true;");
    }
  }
}