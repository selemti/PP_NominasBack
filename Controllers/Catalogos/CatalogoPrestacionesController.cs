using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PP_NominasBack.Common;
using PP_NominasBack.Models.Catalogos.CompensacionesDeducciones;
using PP_NominasBack.Dtos.Catalogos.CompensacionesDeducciones;
using MongoDB.Driver.Linq;
namespace PP_NominasBack.Controllers.Catalogos
{
    [ApiController]
    [Route("api/catalogos/[controller]")]
    public class CatalogoPrestacionesController : BaseController<CatalogoPrestaciones, CatalogoPrestacionesDto>
    {
        public CatalogoPrestacionesController(IMongoDatabase db, IMapper mapper)
            : base(db, mapper)
        {
        }

        [HttpGet("paged")]
        public async Task<ActionResult<PagedResult<CatalogoPrestacionesDto>>> GetPaged(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string? filter = null)
        {
            var query = _collection.AsQueryable();
            if (!string.IsNullOrEmpty(filter))
            {
                query = query.Where(x => EF.Property<string>(x, "Id").Contains(filter));
            }
            var total = await query.CountAsync();
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            var dtoItems = _mapper.Map<List<CatalogoPrestacionesDto>>(items);
            return Ok(new PagedResult<CatalogoPrestacionesDto>(dtoItems, total, pageNumber, pageSize));
        }
    }
}
