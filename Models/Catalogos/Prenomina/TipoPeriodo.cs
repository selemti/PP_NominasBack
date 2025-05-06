using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Prenomina
{
    public class TipoPeriodo
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombreTipoPeriodo")]
        public List<string> NombreTipoPeriodo { get; set; }

        [BsonElement("diasPeriodo")]
        public List<int?> DiasPeriodo { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}