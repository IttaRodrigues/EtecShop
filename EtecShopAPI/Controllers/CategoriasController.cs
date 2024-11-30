using EtecShopAPI.Data;
using EtecShopAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EtecShopAPI.Controllers;
{
    [ApiController]
    [Route("api/categorias")]
    public class CategoriasController(AppDbContext db) : ControllerBase
    {
        private readonly AppDbContext _db = db;

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get(int id) =>
        _db.Categorias.Any(c => c.Id == id) ?
            Ok(await _db.Categorias.FindAsync(id)) : 
            NotFound("Categoria não encontrada!");

            



    }
}