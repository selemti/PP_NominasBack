using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PP_NominasBack.Models.Catalogos.Empleados;
using PP_NominasBack.Dtos.Catalogos.Empleados;
using PP_NominasBack.Controllers.Catalogos;


namespace PP_NominasBack.Controllers.Catalogos.Empleados
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : BaseController<Empleado, EmpleadoDto>
    {
        public EmpleadoController(IMongoDatabase db, IMapper mapper)
            : base(db, mapper)
        {
        }
    }
}
