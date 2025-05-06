using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Compensaciones
{
    public class EmpleadoCompensacion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("compensacionId")]
        public List<string> CompensacionId { get; set; }

        [BsonElement("valor")]
        public List<decimal?> Valor { get; set; }

        [BsonElement("tipoAsignacion")]
        public List<int?> TipoAsignacion { get; set; }

        [BsonElement("formula")]
        public List<string> Formula { get; set; }

        [BsonElement("periodicidad")]
        public List<int?> Periodicidad { get; set; }

        [BsonElement("fechaInicio")]
        public List<DateTime?> FechaInicio { get; set; }

        [BsonElement("fechaFin")]
        public List<DateTime?> FechaFin { get; set; }

        [BsonElement("vigente")]
        public List<bool?> Vigente { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}