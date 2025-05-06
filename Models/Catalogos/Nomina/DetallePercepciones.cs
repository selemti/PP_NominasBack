using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Nomina
{
    public class DetallePercepciones
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("reciboNominaId")]
        public List<string> ReciboNominaId { get; set; }

        [BsonElement("tipoCompensacionId")]
        public List<string> TipoCompensacionId { get; set; }

        [BsonElement("monto")]
        public List<decimal?> Monto { get; set; }

        [BsonElement("tipoFiscalizacion")]
        public List<int?> TipoFiscalizacion { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}