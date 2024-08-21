using Microsoft.EntityFrameworkCore;
using QuizFast.source.Application.Services;

public class ApplicationDbContext : DbContext
{
    public DbSet<QuizServices> Quiz { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Define a string de conexão para o SQLite
        optionsBuilder.UseSqlite("Data Source=meuBancoDeDados.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Configurações adicionais
    }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}
