using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Nomina
{
    public class FiniquitoLiquidacion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("empleadoId")]
        public string EmpleadoId { get; set; }

        [BsonElement("fechaFiniquito")]
        public DateTime FechaFiniquito { get; set; }

        [BsonElement("isrCalculado")]
        public decimal IsrCalculado { get; set; }

        [BsonElement("totalFiniquito")]
        public decimal TotalFiniquito { get; set; }

        [BsonElement("conceptos")]
        public List<ConceptoFiniquitoDto> Conceptos { get; set; }

    }
}