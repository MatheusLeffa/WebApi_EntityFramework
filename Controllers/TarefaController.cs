using Microsoft.AspNetCore.Mvc;
using WebApi_EntityFramework.Models;
using WebApi_EntityFramework.Services;


namespace WebApi_EntityFramework.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class TarefasController : ControllerBase
{
    private readonly ITarefasRepository repository;

    public TarefasController(ITarefasRepository repository)
    {
        this.repository = repository;
    }

    [HttpGet]
    public Task<IEnumerable<Tarefa>> GetAll()
    {
        return repository.GetAllAsync();
    }

    [HttpGet("{id:long}")]
    public async Task<ActionResult<Tarefa>> GetById(long id)
    {
        var umaTarefa = await repository.GetByIdAsync(id);
        if (umaTarefa == null)
        {
            return NotFound();
        }
        return umaTarefa;
    }

}