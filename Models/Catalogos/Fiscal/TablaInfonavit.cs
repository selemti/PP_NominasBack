using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class TablaInfonavit
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("tipoDescuento")]
        public List<int?> TipoDescuento { get; set; }

        [BsonElement("valorDescuento")]
        public List<decimal?> ValorDescuento { get; set; }

        [BsonElement("descripcion")]
        public List<string> Descripcion { get; set; }

        [BsonElement("ejercicioFiscal")]
        public List<int?> EjercicioFiscal { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}