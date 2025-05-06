using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Vacaciones
{
    public class PeriodoVacacional
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("anio")]
        public List<int?> Anio { get; set; }

        [BsonElement("diasAsignados")]
        public List<int?> DiasAsignados { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}