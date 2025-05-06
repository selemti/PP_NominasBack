using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Models.Shared
{
    public class DestinatarioAlerta
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("alertaId")]
        public ObjectId AlertaId { get; set; }

        [BsonElement("auditable")]
        public Auditable Auditable { get; set; }

        [BsonElement("tipoDestinatario")]
        public int TipoDestinatario { get; set; }

        [BsonElement("valorDestino")]
        public string ValorDestino { get; set; }
    }
}
