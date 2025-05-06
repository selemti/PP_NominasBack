using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Nomina
{
    public class DetalleDeducciones
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("reciboNominaId")]
        public List<string> ReciboNominaId { get; set; }

        [BsonElement("tipoDeduccionId")]
        public List<string> TipoDeduccionId { get; set; }

        [BsonElement("monto")]
        public List<decimal?> Monto { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}