using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Prenomina
{
    public class HistorialValidacion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("periodoNominaId")]
        public List<string> PeriodoNominaId { get; set; }

        [BsonElement("usuarioValidadorId")]
        public List<string> UsuarioValidadorId { get; set; }

        [BsonElement("resultado")]
        public List<string> Resultado { get; set; }

        [BsonElement("fechaValidacion")]
        public List<DateTime?> FechaValidacion { get; set; }

        [BsonElement("observaciones")]
        public List<string> Observaciones { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}