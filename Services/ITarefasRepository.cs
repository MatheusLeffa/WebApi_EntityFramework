namespace WebApi_EntityFramework.Services;

using WebApi_EntityFramework.Models;

public interface ITarefasRepository
{
    public Task<Tarefa?> GetByIdAsync(long id);
    public Task<IEnumerable<Tarefa>> GetAllAsync();
}