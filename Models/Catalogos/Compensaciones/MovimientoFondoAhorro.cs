using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Compensaciones
{
    public class MovimientoFondoAhorro
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("fondoAhorroId")]
        public List<string> FondoAhorroId { get; set; }

        [BsonElement("tipoMovimiento")]
        public List<int?> TipoMovimiento { get; set; }

        [BsonElement("monto")]
        public List<decimal?> Monto { get; set; }

        [BsonElement("fechaMovimiento")]
        public List<DateTime?> FechaMovimiento { get; set; }

        [BsonElement("descripcion")]
        public List<string> Descripcion { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}