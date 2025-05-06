using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class RangoTolerancia
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("codigo")]
        public List<string> Codigo { get; set; }

        [BsonElement("nombre")]
        public List<string> Nombre { get; set; }

        [BsonElement("minutosDesde")]
        public List<int?> MinutosDesde { get; set; }

        [BsonElement("minutosHasta")]
        public List<int?> MinutosHasta { get; set; }

        [BsonElement("penalizacion")]
        public List<bool?> Penalizacion { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}