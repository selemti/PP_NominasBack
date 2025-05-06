using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Deducciones
{
    public class EmpleadoDeduccion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("deduccionId")]
        public List<string> DeduccionId { get; set; }

        [BsonElement("valor")]
        public List<decimal?> Valor { get; set; }

        [BsonElement("periodicidad")]
        public List<int?> Periodicidad { get; set; }

        [BsonElement("fechaInicio")]
        public List<DateTime?> FechaInicio { get; set; }

        [BsonElement("fechaFin")]
        public List<DateTime?> FechaFin { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}