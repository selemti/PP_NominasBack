using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class TablaIsr
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("limiteInferior")]
        public List<decimal?> LimiteInferior { get; set; }

        [BsonElement("limiteSuperior")]
        public List<decimal?> LimiteSuperior { get; set; }

        [BsonElement("cuotaFija")]
        public List<decimal?> CuotaFija { get; set; }

        [BsonElement("porcentajeExcedente")]
        public List<decimal?> PorcentajeExcedente { get; set; }

        [BsonElement("periodo")]
        public List<int?> Periodo { get; set; }

        [BsonElement("ejercicioFiscal")]
        public List<int?> EjercicioFiscal { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}