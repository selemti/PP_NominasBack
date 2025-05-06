using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    public class Justificante
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("tipoJustificante")]
        public List<int?> TipoJustificante { get; set; }

        [BsonElement("urlDocumento")]
        public List<string> UrlDocumento { get; set; }

        [BsonElement("fechaEmision")]
        public List<DateTime?> FechaEmision { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}