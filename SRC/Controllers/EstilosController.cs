using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

using SRC.Models;
using SRC.Persistence;

namespace SRC.Controllers;

[ApiController]
[Route("[controller]")]
public class EstilosController : ControllerBase
{
    public BeerContext _context {get; set;}
    public EstilosController(BeerContext context)
    {
        this._context = context;
    }

    [HttpGet]
    public ActionResult<List<Estilo>> Get()
    {
        var result = _context.Estilos.ToList();

        try
        {
            if(!result.Any())
            return NoContent();

        return Ok(result);
        }
        catch (System.Exception)
        {
            return BadRequest();
        }
    }

    [HttpPost]
    public ActionResult<Estilo> Post(Estilo estilo)
    {
        try
        {
            _context.Estilos.Add(estilo);
            _context.SaveChanges();
        }
        catch (System.Exception e)
        {
            return BadRequest( new {
                msg = $"Erro ao cadastrar o estilo {estilo.Nome}. Messagem do erro: {e.Message}.",
                status = HttpStatusCode.BadRequest
            });
        }

        return Ok( new {
            msg = $"Estilo {estilo.Nome} registrado.",
            status = HttpStatusCode.Created
        });
    }

    [HttpPut("{id}")]
    public ActionResult<object> Update([FromRoute]int id, [FromBody]Estilo estilo)
    {
        try
        {
            _context.Estilos.Update(estilo);
            _context.SaveChanges();
        }
        catch (System.Exception e)
        {
            return new{
                msg = $"Erro na atualização do estilo {estilo.Nome}. Mensagem de erro: {e.Message}.",
                status = HttpStatusCode.BadRequest
            };
        }

        return new {
            msg = $"Estilo {estilo.Nome} atualizad. ",
            status = HttpStatusCode.OK
        };
    }

    [HttpDelete("{id}")]
    public ActionResult<Object> Delete([FromRoute] int id)
    {
        var result = _context.Estilos.SingleOrDefault(e => e.Id == id);

        if (result is null)
            return new{
                msg = $"Estilo inesistente. Solicitação inválida.",
                status = HttpStatusCode.BadRequest
            };

        _context.Estilos.Remove(result);
        _context.SaveChanges();

        return new{
            msg = $"Estilo {result.Nome} removido com sucesso.",
            status = HttpStatusCode.OK
        };
    }
}