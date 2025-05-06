using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class HistorialPlazaEmpleado
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("plazaIdAnterior")]
        public List<string> PlazaIdAnterior { get; set; }

        [BsonElement("plazaIdNueva")]
        public List<string> PlazaIdNueva { get; set; }

        [BsonElement("fechaCambio")]
        public List<DateTime?> FechaCambio { get; set; }

        [BsonElement("motivoCambio")]
        public List<string> MotivoCambio { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}