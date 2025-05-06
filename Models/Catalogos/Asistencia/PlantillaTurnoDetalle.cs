using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class PlantillaTurnoDetalle
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("plantillaId")]
        public List<string> PlantillaId { get; set; }

        [BsonElement("fecha")]
        public List<DateTime?> Fecha { get; set; }

        [BsonElement("turnoId")]
        public List<string> TurnoId { get; set; }

        [BsonElement("plazaId")]
        public List<string> PlazaId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}