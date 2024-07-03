using Microsoft.AspNetCore.Http;
using ExamenVideojuegos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace ExamenVideojuegos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideojuegoController : Controller
    {
        private readonly ExamenVideojuegosContext _baseDatos;

        public VideojuegoController(ExamenVideojuegosContext baseDatos)
        {
            this._baseDatos = baseDatos;
        }


        //Métodos de GET ListaVideojuegos
        [HttpGet]
        [Route("ListaVideojuegos")]
        public async Task<IActionResult> Lista()
        {
            var listaVideojuegos = await _baseDatos.Videojuegos.ToListAsync();
            return Ok(listaVideojuegos);
        }

        //Métodos de GET ListaVideojuegos
        [HttpGet]
        [Route("ListaVideojuegos/{categoria}")]
        public async Task<IActionResult> ListaFiltrada(string categoria)
        {
            var listaVideojuegos = await _baseDatos.Videojuegos
                                        .Where(v => v.Categoria == categoria)
                                        .ToListAsync();
            return Ok(listaVideojuegos);
        }

    }
}
