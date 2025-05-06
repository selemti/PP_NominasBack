using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class TablaUma
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("valorUma")]
        public List<decimal?> ValorUma { get; set; }

        [BsonElement("fechaInicioVigencia")]
        public List<DateTime?> FechaInicioVigencia { get; set; }

        [BsonElement("fechaFinVigencia")]
        public List<DateTime?> FechaFinVigencia { get; set; }

        [BsonElement("ejercicioFiscal")]
        public List<int?> EjercicioFiscal { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}