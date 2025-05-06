using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class TablaImss
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("concepto")]
        public List<string> Concepto { get; set; }

        [BsonElement("porcentajePatronal")]
        public List<decimal?> PorcentajePatronal { get; set; }

        [BsonElement("porcentajeObrero")]
        public List<decimal?> PorcentajeObrero { get; set; }

        [BsonElement("salarioMinimoAplica")]
        public List<bool?> SalarioMinimoAplica { get; set; }

        [BsonElement("ejercicioFiscal")]
        public List<int?> EjercicioFiscal { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}