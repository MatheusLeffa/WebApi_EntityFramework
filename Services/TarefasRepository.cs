using Microsoft.EntityFrameworkCore;
using WebApi_EntityFramework.DataBase;
using WebApi_EntityFramework.Models;

namespace WebApi_EntityFramework.Services;

public class TarefasRepository : ITarefasRepository
{

    private readonly TarefasContext dbContext;

    public TarefasRepository(TarefasContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public Task<Tarefa?> GetByIdAsync(long id)
    {
        return dbContext.Tarefas
            .Where(t => t.Id == id)
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Tarefa>> GetAllAsync()
    {
        return await dbContext.Tarefas
            .OrderBy(t => t.Title)
            .ToListAsync();
    }

}