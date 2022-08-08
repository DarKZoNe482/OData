using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OData.Application;

namespace OData.Controllers;

[ApiController]
[Route("projets")]
public class ProjetController : ControllerBase
{
    private readonly ILogger<ProjetController> _logger;

    public ProjetController(ILogger<ProjetController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [EnableQuery()]
    public ActionResult<IEnumerable<ProjetDto>> Get()
    {
        ProjetDto projet1 = new ProjetDto { DateDebut = 0, Id = Guid.NewGuid(), Nom = "Projet1" };
        ProjetDto projet2 = new ProjetDto { DateDebut = 1234423, Id = Guid.NewGuid(), Nom = "Projet2" };
        ProjetDto projet3 = new ProjetDto { DateDebut = 123, Id = Guid.NewGuid(), Nom = "Projet3" };
        ProjetDto projet4 = new ProjetDto { DateDebut = 213414445, Id = Guid.NewGuid(), Nom = "Projet4" };
        ProjetDto projet5 = new ProjetDto { DateDebut = 2, Id = Guid.NewGuid(), Nom = "Projet5" };
        ProjetDto projet6 = new ProjetDto { DateDebut = 0, Id = Guid.NewGuid(), Nom = "Projet6" };
        List<ProjetDto> projets = new() { projet1, projet2, projet3, projet4, projet5, projet6};

        return Ok(projets.AsEnumerable());
    }
}