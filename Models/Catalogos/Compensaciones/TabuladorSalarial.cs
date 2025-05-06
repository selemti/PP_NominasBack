using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Compensaciones
{
    public class TabuladorSalarial
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("puestoId")]
        public List<string> PuestoId { get; set; }

        [BsonElement("salarioMinimo")]
        public List<decimal?> SalarioMinimo { get; set; }

        [BsonElement("salarioMaximo")]
        public List<decimal?> SalarioMaximo { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}