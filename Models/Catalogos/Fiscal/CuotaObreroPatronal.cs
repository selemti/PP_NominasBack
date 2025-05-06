using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class CuotaObreroPatronal
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("concepto")]
        public List<string> Concepto { get; set; }

        [BsonElement("porcentajePatron")]
        public List<decimal?> PorcentajePatron { get; set; }

        [BsonElement("porcentajeEmpleado")]
        public List<decimal?> PorcentajeEmpleado { get; set; }

        [BsonElement("vigenciaInicio")]
        public List<DateTime?> VigenciaInicio { get; set; }

        [BsonElement("vigenciaFin")]
        public List<DateTime?> VigenciaFin { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}