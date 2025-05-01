using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PP_NominasBack.Common;
using PP_NominasBack.Models.Catalogos.Organizacion;
using PP_NominasBack.Dtos.Catalogos.Organizacion;

namespace PP_NominasBack.Controllers.Catalogos
{
    [ApiController]
    [Route("api/catalogos/[controller]")]
    public class UbicacionController : BaseController<Ubicacion, UbicacionDto>
    {
        public UbicacionController(IMongoDatabase db, IMapper mapper)
            : base(db, mapper)
        {
        }

        [HttpGet("paged")]
        public async Task<ActionResult<PagedResult<UbicacionDto>>> GetPaged(
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
            var dtoItems = _mapper.Map<List<UbicacionDto>>(items);
            return Ok(new PagedResult<UbicacionDto>(dtoItems, total, pageNumber, pageSize));
        }
    }
}
