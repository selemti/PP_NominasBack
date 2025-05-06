using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class ContratoEmpleado
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("tipoContrato")]
        public List<int?> TipoContrato { get; set; }

        [BsonElement("fechaInicioContrato")]
        public List<DateTime?> FechaInicioContrato { get; set; }

        [BsonElement("fechaFinContrato")]
        public List<DateTime?> FechaFinContrato { get; set; }

        [BsonElement("vigente")]
        public List<bool?> vigente { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}