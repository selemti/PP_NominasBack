using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class Empleado
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public string Id { get; set; }

        [BsonElement("persona")]
        public PersonaDto Persona { get; set; }

        [BsonElement("curp")]
        public string Curp { get; set; }

        [BsonElement("rfc")]
        public string Rfc { get; set; }

        [BsonElement("fechaIngreso")]
        public DateTime FechaIngreso { get; set; }

        [BsonElement("fechaBaja")]
        public DateTime? FechaBaja { get; set; }

        [BsonElement("tipoContrato")]
        public TipoContrato? TipoContrato { get; set; }

        [BsonElement("vigente")]
        public bool Vigente { get; set; }

        [BsonElement("registroImss")]
        public RegistroImssDto RegistroImss { get; set; }

        [BsonElement("datosPagoEmpleado")]
        public DatosPagoEmpleadoDto DatosPagoEmpleado { get; set; }

        [BsonElement("asignacionesPlaza")]
        public List<AsignacionPlazaEmpleadoDto> AsignacionesPlaza { get; set; }

        [BsonElement("historialPlazas")]
        public List<HistorialPlazaEmpleadoDto> HistorialPlazas { get; set; }

        [BsonElement("contactosEmergencia")]
        public List<EmpleadoContactoDto> ContactosEmergencia { get; set; }

        [BsonElement("documentos")]
        public List<ArchivoEmpleadoDto> Documentos { get; set; }

    }
}