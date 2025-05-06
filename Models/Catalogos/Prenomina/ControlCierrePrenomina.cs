using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Prenomina
{
    public class ControlCierrePrenomina
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("periodoNominaId")]
        public List<string> PeriodoNominaId { get; set; }

        [BsonElement("fechaCierre")]
        public List<DateTime?> FechaCierre { get; set; }

        [BsonElement("usuarioCierreId")]
        public List<string> UsuarioCierreId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}