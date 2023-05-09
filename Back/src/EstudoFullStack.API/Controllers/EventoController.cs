using EstudoFullStack.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstudoFullStack.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[] {
        new Evento() {
            EventoId = 1,
            Tema = "Angular e .NET 7",
            Local = "Salvador",
            Lote = "1º Lote",
            QuantdadePessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImageURL = "foto.png"
        },
        new Evento() {
            EventoId = 2,
            Tema = "FullStack",
            Local = "São Paulo",
            Lote = "1º Lote",
            QuantdadePessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImageURL = "foto1.png"
        }
    };

    public EventoController()
    {
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de POST";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete com id = {id}";
    }

}
