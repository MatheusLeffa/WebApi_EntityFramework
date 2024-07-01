namespace WebApi_EntityFramework.DataBase;

using Microsoft.EntityFrameworkCore;
using WebApi_EntityFramework.Models;

public class TarefasContext : DbContext
{
    public DbSet<Tarefa> Tarefas { get; set; } = null!;

    public TarefasContext() { }
    public TarefasContext(DbContextOptions<TarefasContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Tarefa>(entityBuilder =>
        {
            entityBuilder.HasKey(t => t.Id).HasName("PK_Tarefas_Id");
            entityBuilder.Property(t => t.Title).HasMaxLength(30);
            entityBuilder.Property(t => t.Description).HasMaxLength(150);
        });
    }
}