using CCB_Cadastros.Models;
using Microsoft.EntityFrameworkCore;

namespace CCB_Cadastros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Igreja> Cadastros { get; set; }
    }
}
