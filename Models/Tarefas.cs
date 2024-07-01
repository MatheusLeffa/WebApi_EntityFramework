namespace WebApi_EntityFramework.Models;

public class Tarefa
{
    public long Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
}