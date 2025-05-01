using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace PP_NominasBack.Controllers.Catalogos
{
    [ApiController]
    [Route("api/catalogos/[controller]")]
    public abstract class BaseController<TModel, TDto> : ControllerBase
        where TModel : class
        where TDto   : class
    {
        protected readonly IMongoCollection<TModel> _collection;
        protected readonly IMapper _mapper;

        public BaseController(IMongoCollection<TModel> collection, IMapper mapper)
        {
            _collection = db.GetCollection<TModel>(typeof(TModel).Name);
            _mapper    = mapper;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TDto>>> GetAll()
        {
            var docs = await _collection.Find(_ => true).ToListAsync();
            return Ok(_mapper.Map<List<TDto>>(docs));
        }

        [HttpGet("{id:length(24)}", Name = "GetById")]
        public virtual async Task<ActionResult<TDto>> GetById(string id)
        {
            var doc = await _collection.Find(d => EF.Property<string>(d, "Id") == id).FirstOrDefaultAsync();
            if (doc == null) return NotFound();
            return Ok(_mapper.Map<TDto>(doc));
        }

        [HttpPost]
        public virtual async Task<ActionResult<TDto>> Create([FromBody] TDto dto)
        {
            var model = _mapper.Map<TModel>(dto);
            await _collection.InsertOneAsync(model);
            var createdDto = _mapper.Map<TDto>(model);
            return CreatedAtRoute("GetById", new { id = EF.Property<string>(model, "Id") }, createdDto);
        }

        [HttpPut("{id:length(24)}")]
        public virtual async Task<IActionResult> Update(string id, [FromBody] TDto dto)
        {
            var model  = _mapper.Map<TModel>(dto);
            var result = await _collection.ReplaceOneAsync(d => EF.Property<string>(d, "Id") == id, model);
            if (result.MatchedCount == 0) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public virtual async Task<IActionResult> Delete(string id)
        {
            var result = await _collection.DeleteOneAsync(d => EF.Property<string>(d, "Id") == id);
            if (result.DeletedCount == 0) return NotFound();
            return NoContent();
        }
    }
}
