using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Nomina
{
    public class ReciboNomina
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public string Id { get; set; }

        [BsonElement("empleadoId")]
        public string EmpleadoId { get; set; }

        [BsonElement("periodoNominaId")]
        public string PeriodoNominaId { get; set; }

        [BsonElement("horasExtrasTrabajadas")]
        public double HorasExtrasTrabajadas { get; set; }

        [BsonElement("horasExtrasAutorizadas")]
        public double HorasExtrasAutorizadas { get; set; }

        [BsonElement("totalPercepciones")]
        public decimal TotalPercepciones { get; set; }

        [BsonElement("totalDeducciones")]
        public decimal TotalDeducciones { get; set; }

        [BsonElement("totalNeto")]
        public decimal TotalNeto { get; set; }

        [BsonElement("auditable")]
        public Auditable Auditable { get; set; }

    }
}