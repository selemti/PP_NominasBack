using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Nomina
{
    public class ConceptoFiniquito
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("finiquitoLiquidacionId")]
        public string FiniquitoLiquidacionId { get; set; }

        [BsonElement("codigo")]
        public string Codigo { get; set; }

        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("esPercepcion")]
        public bool EsPercepcion { get; set; }

        [BsonElement("importe")]
        public decimal Importe { get; set; }

    }
}